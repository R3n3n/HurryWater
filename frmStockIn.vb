Imports MySql.Data.MySqlClient

Public Class frmStockIn

    Private Const MAX_QTY As Decimal = 1000000D

    Private itemsTable As DataTable
    Private isLoading As Boolean = True

    Private Sub frmStockIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpDate.Value = Date.Today

        LoadItems()
        isLoading = False
        RefreshItemInfo()
    End Sub

    Private Sub LoadItems()
        Try
            connection()
            ' unitCost is a generated column (packCost / packSize); IFNULL guards packSize = 0
            sql = "SELECT itemId, itemName, unit, IFNULL(unitCost, 0) AS unitCost FROM tblinventoryitems ORDER BY itemId"
            cmd = New MySqlCommand(sql, cn)
            itemsTable = New DataTable()
            itemsTable.Load(cmd.ExecuteReader())

            cboItem.DataSource = itemsTable
            cboItem.DisplayMember = "itemName"
            cboItem.ValueMember = "itemId"
            cboItem.SelectedIndex = -1
        Catch ex As Exception
            MsgBox("Error loading items: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    ' ---------- Show the unit in the quantity label ----------

    Private Sub cboItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboItem.SelectedIndexChanged
        If isLoading Then Return
        RefreshItemInfo()
    End Sub

    Private Sub RefreshItemInfo()
        Dim row As DataRowView = TryCast(cboItem.SelectedItem, DataRowView)
        If row Is Nothing Then
            lblQuantity.Text = "Quantity received"
        Else
            lblQuantity.Text = "Quantity received (" & row("unit").ToString() & ")"
        End If
    End Sub

    Private Function TryGetQuantity(ByRef qty As Decimal) As Boolean
        Return Decimal.TryParse(txtQuantity.Text.Trim(), System.Globalization.NumberStyles.Number,
                                System.Globalization.CultureInfo.CurrentCulture, qty)
    End Function

    ' ---------- Save ----------

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If CurrentUserId <= 0 Then
            MsgBox("No logged-in user. Please log in again.", MsgBoxStyle.Exclamation, "Not logged in")
            Return
        End If

        Dim row As DataRowView = TryCast(cboItem.SelectedItem, DataRowView)
        If row Is Nothing Then
            MsgBox("Select an item.", MsgBoxStyle.Exclamation, "Validation error")
            cboItem.Focus()
            Return
        End If

        Dim qty As Decimal
        If Not TryGetQuantity(qty) OrElse qty <= 0 Then
            MsgBox("Enter a valid quantity greater than 0.", MsgBoxStyle.Exclamation, "Validation error")
            txtQuantity.Focus()
            Return
        End If
        If qty > MAX_QTY Then
            MsgBox("That quantity is too large. Please check it.", MsgBoxStyle.Exclamation, "Validation error")
            txtQuantity.Focus()
            Return
        End If

        Dim unit As String = row("unit").ToString()
        If unit.Equals("pcs", StringComparison.OrdinalIgnoreCase) AndAlso qty <> Math.Floor(qty) Then
            MsgBox("Pieces must be a whole number.", MsgBoxStyle.Exclamation, "Validation error")
            txtQuantity.Focus()
            Return
        End If
        qty = Math.Round(qty, 2)

        Dim itemId As Integer = CInt(row("itemId"))
        Dim total As Decimal = Math.Round(qty * CDec(row("unitCost")), 2)   ' automatic: quantity x unit cost
        Dim reference As String = txtReference.Text.Trim()

        Dim txn As MySqlTransaction = Nothing
        Try
            connection()
            txn = cn.BeginTransaction()

            ' Needs the totalCost column (see inventory_update.sql)
            sql = "INSERT INTO tblstocktransactions " &
                  "(itemId, transactionType, quantity, totalCost, transactionDate, referenceNote, recordedBy) " &
                  "VALUES (@itemId, 'Stock-in', @qty, @cost, @date, @note, @user)"
            cmd = New MySqlCommand(sql, cn, txn)
            cmd.Parameters.AddWithValue("@itemId", itemId)
            cmd.Parameters.AddWithValue("@qty", qty)
            cmd.Parameters.AddWithValue("@cost", total)
            cmd.Parameters.AddWithValue("@date", dtpDate.Value.Date)
            cmd.Parameters.AddWithValue("@note", If(reference = "", DBNull.Value, CObj(reference)))
            cmd.Parameters.AddWithValue("@user", CurrentUserId)
            cmd.ExecuteNonQuery()

            sql = "UPDATE tblinventoryitems SET currentStock = currentStock + @qty WHERE itemId = @itemId"
            cmd = New MySqlCommand(sql, cn, txn)
            cmd.Parameters.AddWithValue("@qty", qty)
            cmd.Parameters.AddWithValue("@itemId", itemId)
            cmd.ExecuteNonQuery()

            txn.Commit()
            Me.DialogResult = DialogResult.OK
        Catch ex As Exception
            If txn IsNot Nothing Then
                Try
                    txn.Rollback()
                Catch
                End Try
            End If
            MsgBox("Database error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

End Class