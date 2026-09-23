Imports MySql.Data.MySqlClient

Public Class frmAddSalesOrder
    Private Sub frmAddSalesOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each nud As NumericUpDown In {nudQuantity1, nudQuantity2, nudQuantity3}
            nud.Minimum = 0
            nud.Value = 0
        Next
        For Each nud As NumericUpDown In {nudUnitPrice1, nudUnitPrice2, nudUnitPrice3}
            nud.Minimum = 0
            nud.DecimalPlaces = 2
        Next

        LoadCustomers()
        LoadProductsIntoAllRows()

        RecalculateGrandTotal()
    End Sub

    Private Sub LoadCustomers()
        connection()
        sql = "SELECT customerId, customerName FROM tblCustomers WHERE status = 'Active' ORDER BY customerName"
        cmd = New MySqlCommand(sql, cn)
        Dim dt As New DataTable()
        dt.Load(cmd.ExecuteReader())
        cn.Close()

        cboCustomer.DataSource = dt
        cboCustomer.DisplayMember = "customerName"
        cboCustomer.ValueMember = "customerId"
        cboCustomer.SelectedIndex = -1
    End Sub

    Private Sub LoadProductsIntoAllRows()
        connection()
        sql = "SELECT productId, CONCAT(containerType, ' - ', waterType) AS displayName, unitPrice " &
              "FROM tblProducts WHERE status = 'Active' ORDER BY category, containerType"
        cmd = New MySqlCommand(sql, cn)
        Dim dt As New DataTable()
        dt.Load(cmd.ExecuteReader())
        cn.Close()

        For Each cbo As ComboBox In {cboProduct1, cboProduct2, cboProduct3}
            cbo.DataSource = dt.Copy()
            cbo.DisplayMember = "displayName"
            cbo.ValueMember = "productId"
            cbo.SelectedIndex = -1
        Next
    End Sub

    Private Sub cboProduct1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProduct1.SelectedIndexChanged
        AutoFillPrice(cboProduct1, nudUnitPrice1)
        RecalculateLine(nudQuantity1, nudUnitPrice1, lblLineTotal1)
    End Sub
    Private Sub cboProduct2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProduct2.SelectedIndexChanged
        AutoFillPrice(cboProduct2, nudUnitPrice2)
        RecalculateLine(nudQuantity2, nudUnitPrice2, lblLineTotal2)
    End Sub
    Private Sub cboProduct3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProduct3.SelectedIndexChanged
        AutoFillPrice(cboProduct3, nudUnitPrice3)
        RecalculateLine(nudQuantity3, nudUnitPrice3, lblLineTotal3)
    End Sub

    Private Sub nudQuantity1_ValueChanged(sender As Object, e As EventArgs) Handles nudQuantity1.ValueChanged, nudUnitPrice1.ValueChanged
        RecalculateLine(nudQuantity1, nudUnitPrice1, lblLineTotal1)
    End Sub
    Private Sub nudQuantity2_ValueChanged(sender As Object, e As EventArgs) Handles nudQuantity2.ValueChanged, nudUnitPrice2.ValueChanged
        RecalculateLine(nudQuantity2, nudUnitPrice2, lblLineTotal2)
    End Sub
    Private Sub nudQuantity3_ValueChanged(sender As Object, e As EventArgs) Handles nudQuantity3.ValueChanged, nudUnitPrice3.ValueChanged
        RecalculateLine(nudQuantity3, nudUnitPrice3, lblLineTotal3)
    End Sub

    Private Sub AutoFillPrice(cbo As ComboBox, nudPrice As NumericUpDown)
        If cbo.SelectedIndex = -1 Then
            nudPrice.Value = 0
        Else
            nudPrice.Value = CDec(DirectCast(cbo.SelectedItem, DataRowView)("unitPrice"))
        End If
    End Sub

    Private Sub RecalculateLine(nudQty As NumericUpDown, nudPrice As NumericUpDown, lblLineTotal As Label)
        Dim lineTotal As Decimal = nudQty.Value * nudPrice.Value
        lblLineTotal.Text = "₱" & lineTotal.ToString("N2")
        RecalculateGrandTotal()
    End Sub

    Private Sub RecalculateGrandTotal()
        Dim total As Decimal = (nudQuantity1.Value * nudUnitPrice1.Value) + (nudQuantity2.Value * nudUnitPrice2.Value) + (nudQuantity3.Value * nudUnitPrice3.Value)
        lblTotal.Text = "₱" & total.ToString("N2")
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        errorProvider1.Clear()

        If Not ValidateOrder() Then
            MsgBox("Please fix the highlighted fields before saving.", MsgBoxStyle.Exclamation, "Validation error")
            Return
        End If

        Try
            SaveOrder()
            Me.DialogResult = DialogResult.OK
        Catch ex As MySqlException
            MsgBox("Database error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Function ValidateOrder() As Boolean
        Dim isValid As Boolean = True

        If cboCustomer.SelectedIndex = -1 Then
            errorProvider1.SetError(cboCustomer, "Select a customer.")
            isValid = False
        End If

        Dim hasAtLeastOneLine As Boolean =
            (cboProduct1.SelectedIndex <> -1 AndAlso nudQuantity1.Value > 0) OrElse
            (cboProduct2.SelectedIndex <> -1 AndAlso nudQuantity2.Value > 0) OrElse
            (cboProduct3.SelectedIndex <> -1 AndAlso nudQuantity3.Value > 0)

        If Not hasAtLeastOneLine Then
            errorProvider1.SetError(cboProduct1, "Add at least one product with a quantity greater than 0.")
            isValid = False
        End If

        ' Catch the mismatched case: a product picked but qty left at 0,
        ' or a quantity entered but no product picked. Both are half-filled
        ' rows that would silently insert nothing — better to flag them.
        For Each pair In New List(Of (Product As ComboBox, Qty As NumericUpDown)) From {
            (cboProduct1, nudQuantity1), (cboProduct2, nudQuantity2), (cboProduct3, nudQuantity3)}

            Dim productChosen As Boolean = pair.Product.SelectedIndex <> -1
            Dim qtyEntered As Boolean = pair.Qty.Value > 0

            If productChosen Xor qtyEntered Then
                errorProvider1.SetError(pair.Product, "Select a product AND enter a quantity, or leave this row fully empty.")
                isValid = False
            End If
        Next

        Return isValid
    End Function

    ''' <summary>
    ''' Inserts the order header AND up to 3 line items as ONE transaction.
    ''' Empty rows (no product/qty) are simply skipped, not inserted.
    ''' </summary>
    Private Sub SaveOrder()
        connection()
        Dim txn As MySqlTransaction = cn.BeginTransaction()

        Try
            sql = "INSERT INTO tblSalesOrders " &
                  "(customerId, userId, orderDate, pickupStatus, paymentMode, paymentStatus, totalAmount) " &
                  "VALUES (@customerId, @userId, @orderDate, @pickupStatus, @paymentMode, @paymentStatus, @total)"

            cmd = New MySqlCommand(sql, cn, txn)
            cmd.Parameters.AddWithValue("@customerId", CInt(cboCustomer.SelectedValue))
            cmd.Parameters.AddWithValue("@userId", CurrentUserId)
            cmd.Parameters.AddWithValue("@orderDate", dtpOrderDate.Value.Date)
            cmd.Parameters.AddWithValue("@pickupStatus", cboPickupStatus.Text)
            cmd.Parameters.AddWithValue("@paymentMode", cboPaymentMode.Text)
            cmd.Parameters.AddWithValue("@paymentStatus", cboPaymentStatus.Text)
            cmd.Parameters.AddWithValue("@total", GetGrandTotalValue())
            cmd.ExecuteNonQuery()

            Dim newOrderId As Long = cmd.LastInsertedId

            InsertLineIfUsed(txn, newOrderId, cboProduct1, nudQuantity1, nudUnitPrice1)
            InsertLineIfUsed(txn, newOrderId, cboProduct2, nudQuantity2, nudUnitPrice2)
            InsertLineIfUsed(txn, newOrderId, cboProduct3, nudQuantity3, nudUnitPrice3)

            txn.Commit()
        Catch ex As Exception
            txn.Rollback()
            Throw
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    Private Sub InsertLineIfUsed(txn As MySqlTransaction, orderId As Long, cboProduct As ComboBox, nudQty As NumericUpDown, nudPrice As NumericUpDown)
        ' Skip rows the user left empty
        If cboProduct.SelectedIndex = -1 OrElse nudQty.Value = 0 Then Return

        sql = "INSERT INTO tblSalesOrderDetails (orderId, productId, quantity, unitPrice) " &
              "VALUES (@orderId, @productId, @qty, @price)"

        cmd = New MySqlCommand(sql, cn, txn)
        cmd.Parameters.AddWithValue("@orderId", orderId)
        cmd.Parameters.AddWithValue("@productId", CInt(cboProduct.SelectedValue))
        cmd.Parameters.AddWithValue("@qty", CInt(nudQty.Value))
        cmd.Parameters.AddWithValue("@price", nudPrice.Value)
        cmd.ExecuteNonQuery()
    End Sub

    Private Function GetGrandTotalValue() As Decimal
        Return (nudQuantity1.Value * nudUnitPrice1.Value) +
               (nudQuantity2.Value * nudUnitPrice2.Value) +
               (nudQuantity3.Value * nudUnitPrice3.Value)
    End Function
End Class