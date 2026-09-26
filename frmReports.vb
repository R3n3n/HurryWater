Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmReports

    Private Sub frmReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupListViews()

        cboDateRange.Items.Clear()
        cboDateRange.Items.AddRange({"This Month", "Last 7 Days"})
        cboDateRange.SelectedIndex = 0   ' defaults to This Month

        LoadLowStockList()   ' not date-dependent — load once, no refresh needed on filter change
        RefreshDateFilteredReports()
    End Sub

    Private Sub SetupListViews()
        lsvLowStock.View = View.Details
        lsvLowStock.FullRowSelect = True
        lsvLowStock.GridLines = True
        lsvLowStock.Columns.Clear()
        lsvLowStock.Columns.Add("Item", 220)
        lsvLowStock.Columns.Add("Current Stock", 110)
        lsvLowStock.Columns.Add("Reorder Point", 110)

        lsvCustomerSummary.View = View.Details
        lsvCustomerSummary.FullRowSelect = True
        lsvCustomerSummary.GridLines = True
        lsvCustomerSummary.Columns.Clear()
        lsvCustomerSummary.Columns.Add("Customer", 220)
        lsvCustomerSummary.Columns.Add("Orders", 90)
        lsvCustomerSummary.Columns.Add("Outstanding", 120)
    End Sub

    ' --- Date range selection -----------------------------------------

    Private Sub cboDateRange_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDateRange.SelectedIndexChanged
        RefreshDateFilteredReports()
    End Sub

    ''' <summary>
    ''' Translates the dropdown's current selection into an actual
    ''' start/end date pair every query below can use.
    ''' </summary>
    Private Function GetSelectedDateRange() As (StartDate As Date, EndDate As Date)
        Select Case cboDateRange.Text
            Case "Last 7 Days"
                Return (Date.Today.AddDays(-6), Date.Today)
            Case Else ' "This Month"
                Dim firstOfMonth As New Date(Date.Today.Year, Date.Today.Month, 1)
                Return (firstOfMonth, Date.Today)
        End Select
    End Function

    Private Sub RefreshDateFilteredReports()
        Dim range = GetSelectedDateRange()
        LoadSummary(range.StartDate, range.EndDate)
        LoadSalesTrendChart(range.StartDate, range.EndDate)
        LoadCustomerOutstandingList(range.StartDate, range.EndDate)
    End Sub

    ' --- Summary cards --------------------------------------------------

    Private Sub LoadSummary(startDate As Date, endDate As Date)
        Try
            connection()

            sql = "SELECT COALESCE(SUM(totalAmount), 0) FROM tblSalesOrders " &
                  "WHERE orderDate BETWEEN @start AND @end"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@start", startDate)
            cmd.Parameters.AddWithValue("@end", endDate)
            Dim totalSales As Decimal = CDec(cmd.ExecuteScalar())

            ' Deliberately NOT filtered by date — see notes at the top of this file
            sql = "SELECT COALESCE(SUM(totalAmount), 0) FROM tblSalesOrders WHERE paymentStatus = 'Unpaid'"
            cmd = New MySqlCommand(sql, cn)
            Dim unpaidBalance As Decimal = CDec(cmd.ExecuteScalar())

            sql = "SELECT COALESCE(SUM(amount), 0) FROM tblExpenses " &
                  "WHERE expenseDate BETWEEN @start AND @end"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@start", startDate)
            cmd.Parameters.AddWithValue("@end", endDate)
            Dim totalExpenses As Decimal = CDec(cmd.ExecuteScalar())

            Dim net As Decimal = totalSales - totalExpenses

            lblTotalSales.Text = "₱" & totalSales.ToString("N2")
            lblUnpaidBalance.Text = "₱" & unpaidBalance.ToString("N2")
            lblTotalExpenses.Text = "₱" & totalExpenses.ToString("N2")
            lblNet.Text = "₱" & net.ToString("N2")
            lblNet.ForeColor = If(net < 0, Color.Firebrick, Color.DarkGreen)
        Catch ex As Exception
            MsgBox("Error loading report summary: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    ' --- Sales trend: one point per day across the selected range --------

    Private Sub LoadSalesTrendChart(startDate As Date, endDate As Date)
        Dim dailyTotals As New Dictionary(Of Date, Decimal)

        Try
            connection()
            sql = "SELECT orderDate, SUM(totalAmount) AS dailyTotal FROM tblSalesOrders " &
                  "WHERE orderDate BETWEEN @start AND @end GROUP BY orderDate"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@start", startDate)
            cmd.Parameters.AddWithValue("@end", endDate)
            dr = cmd.ExecuteReader()

            While dr.Read()
                dailyTotals(CDate(dr("orderDate")).Date) = CDec(dr("dailyTotal"))
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox("Error loading sales trend: " & ex.Message, MsgBoxStyle.Critical)
            Return
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try

        chtSalesTrend.Series("Sales").Points.Clear()

        ' "This Month" can run up to ~31 days, "Last 7 Days" is always 7 —
        ' both stay as one point per day, no bucketing needed at this scale
        Dim totalDays As Integer = CInt((endDate - startDate).TotalDays)
        Dim d As Date = startDate
        While d <= endDate
            Dim total As Decimal = If(dailyTotals.ContainsKey(d), dailyTotals(d), 0D)
            Dim label As String = If(totalDays <= 7, d.ToString("ddd"), d.ToString("MMM d"))
            chtSalesTrend.Series("Sales").Points.AddXY(label, total)
            d = d.AddDays(1)
        End While
    End Sub

    ' --- Low-stock items — NOT date-filtered, loaded once at Form_Load ----

    Private Sub LoadLowStockList()
        lsvLowStock.Items.Clear()

        sql = "SELECT itemName, currentStock, reorderPoint FROM tblInventoryItems " &
              "WHERE currentStock <= reorderPoint ORDER BY itemName"

        Try
            connection()
            cmd = New MySqlCommand(sql, cn)
            dr = cmd.ExecuteReader()

            While dr.Read()
                Dim item As New ListViewItem(dr("itemName").ToString())
                item.SubItems.Add(dr("currentStock").ToString())
                item.SubItems.Add(dr("reorderPoint").ToString())
                item.BackColor = Color.MistyRose

                lsvLowStock.Items.Add(item)
            End While
            dr.Close()

            If lsvLowStock.Items.Count = 0 Then
                Dim noneItem As New ListViewItem("No items below reorder point")
                noneItem.SubItems.Add("")
                noneItem.SubItems.Add("")
                noneItem.ForeColor = Color.Gray
                lsvLowStock.Items.Add(noneItem)
            End If
        Catch ex As Exception
            MsgBox("Error loading low-stock items: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    ' --- Per-customer summary, scoped to the selected range --------------

    Private Sub LoadCustomerOutstandingList(startDate As Date, endDate As Date)
        lsvCustomerSummary.Items.Clear()

        sql = "SELECT c.customerName, " &
              "       COUNT(o.orderId) AS orderCount, " &
              "       COALESCE(SUM(CASE WHEN o.paymentStatus = 'Unpaid' THEN o.totalAmount ELSE 0 END), 0) AS outstanding " &
              "FROM tblCustomers c " &
              "INNER JOIN tblSalesOrders o ON c.customerId = o.customerId " &
              "  AND o.orderDate BETWEEN @start AND @end " &
              "GROUP BY c.customerId, c.customerName " &
              "ORDER BY outstanding DESC, c.customerName ASC"

        Try
            connection()
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@start", startDate)
            cmd.Parameters.AddWithValue("@end", endDate)
            dr = cmd.ExecuteReader()

            While dr.Read()
                Dim outstanding As Decimal = CDec(dr("outstanding"))

                Dim item As New ListViewItem(dr("customerName").ToString())
                item.SubItems.Add(dr("orderCount").ToString())
                item.SubItems.Add("₱" & outstanding.ToString("N2"))

                If outstanding > 0 Then
                    item.SubItems(2).ForeColor = Color.Firebrick
                    item.SubItems(2).Font = New Font(lsvCustomerSummary.Font, FontStyle.Bold)
                End If

                lsvCustomerSummary.Items.Add(item)
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox("Error loading customer summary: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    ' --- Export (exports whatever is CURRENTLY shown, filter included) ----

    Private Sub btnExportCsv_Click(sender As Object, e As EventArgs) Handles btnExportCsv.Click
        Using sfd As New SaveFileDialog()
            sfd.Filter = "CSV files (*.csv)|*.csv"
            sfd.FileName = "customer_summary_" & Date.Today.ToString("yyyy-MM-dd") & ".csv"

            If sfd.ShowDialog() <> DialogResult.OK Then Return

            Try
                Using writer As New StreamWriter(sfd.FileName, False)
                    writer.WriteLine("Report range: " & cboDateRange.Text)
                    writer.WriteLine("Customer,Orders,Outstanding")
                    For Each item As ListViewItem In lsvCustomerSummary.Items
                        Dim line As String = String.Join(",",
                            item.SubItems(0).Text.Replace(",", " "),
                            item.SubItems(1).Text,
                            item.SubItems(2).Text.Replace("₱", "").Replace(",", ""))
                        writer.WriteLine(line)
                    Next
                End Using

                MsgBox("Report exported successfully.", MsgBoxStyle.Information, "Export complete")
            Catch ex As Exception
                MsgBox("Export failed: " & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End Using
    End Sub

End Class