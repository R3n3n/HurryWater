Imports MySql.Data.MySqlClient

Public Class frmSalesDelivery

    Private Sub SetupListView()
        lsvOrders.View = View.Details
        lsvOrders.FullRowSelect = True
        lsvOrders.GridLines = True

        lsvOrders.Columns.Clear()
        lsvOrders.Columns.Add("Order Date", 110)
        lsvOrders.Columns.Add("Customer", 230)
        lsvOrders.Columns.Add("Pickup Status", 120)
        lsvOrders.Columns.Add("Payment", 100)
        lsvOrders.Columns.Add("Total", 110)
    End Sub
    Private Sub LoadOrderList()
        lsvOrders.Items.Clear()

        sql = "SELECT o.orderId, o.orderDate, c.customerName, o.pickupStatus, o.paymentStatus, o.totalAmount " &
              "FROM tblSalesOrders o INNER JOIN tblCustomers c ON o.customerId = c.customerId " &
              "WHERE c.customerName LIKE @search"

        If cboFilterPickup.Text <> "All pickup statuses" AndAlso cboFilterPickup.Text <> "" Then
            sql &= " AND o.pickupStatus = @pickupStatus"
        End If
        If cboFilterPayment.Text <> "All payment statuses" AndAlso cboFilterPayment.Text <> "" Then
            sql &= " AND o.paymentStatus = @paymentStatus"
        End If

        sql &= " ORDER BY o.orderDate DESC, o.orderId DESC"

        Try
            connection()
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@search", "%" & txtSearch.Text.Trim() & "%")

            If cboFilterPickup.Text <> "All pickup statuses" AndAlso cboFilterPickup.Text <> "" Then
                cmd.Parameters.AddWithValue("@pickupStatus", cboFilterPickup.Text)
            End If
            If cboFilterPayment.Text <> "All payment statuses" AndAlso cboFilterPayment.Text <> "" Then
                cmd.Parameters.AddWithValue("@paymentStatus", cboFilterPayment.Text)
            End If

            dr = cmd.ExecuteReader()

            While dr.Read()
                Dim item As New ListViewItem(CDate(dr("orderDate")).ToString("MMM d, yyyy"))
                item.SubItems.Add(dr("customerName").ToString())
                item.SubItems.Add(dr("pickupStatus").ToString())
                item.SubItems.Add(dr("paymentStatus").ToString())
                item.SubItems.Add("₱" & CDec(dr("totalAmount")).ToString("N2"))

                item.Tag = dr("orderId")

                If dr("paymentStatus").ToString() = "Unpaid" Then
                    item.BackColor = Color.MistyRose
                End If

                lsvOrders.Items.Add(item)
            End While

            dr.Close()
        Catch ex As Exception
            MsgBox("Error loading orders: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadOrderList()
    End Sub

    Private Sub cboFilterPickup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFilterPickup.SelectedIndexChanged
        LoadOrderList()
    End Sub

    Private Sub cboFilterPayment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFilterPayment.SelectedIndexChanged
        LoadOrderList()
    End Sub

    Private Sub btnAddOrder_Click(sender As Object, e As EventArgs) Handles btnAddOrder.Click
        Dim addForm As New frmAddSalesOrder()

        If addForm.ShowDialog() = DialogResult.OK Then
            LoadOrderList()
        End If

        addForm.Dispose()
    End Sub
End Class