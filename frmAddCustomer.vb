Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class frmAddCustomer
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        errorProvider1.Clear()

        If Not ValidateInputs() Then
            MsgBox("Please fix the highlighted fields before saving.", MsgBoxStyle.Exclamation, "Validation error")
            Return
        End If

        Try
            SaveCustomer()
            Me.DialogResult = DialogResult.OK
        Catch ex As MySqlException
            MsgBox("Database error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Function ValidateInputs() As Boolean
        Dim isValid As Boolean = True

        Dim name As String = txtName.Text.Trim()
        If String.IsNullOrEmpty(name) Then
            errorProvider1.SetError(txtName, "Customer name is required.")
            isValid = False
        ElseIf Not Regex.IsMatch(name, "^[a-zA-Z\u00C0-\u017F.,'\-\s]+$") Then
            errorProvider1.SetError(txtName, "Name contains invalid characters.")
            isValid = False
        End If

        Dim contact As String = txtContactNo.Text.Trim()
        If String.IsNullOrEmpty(contact) Then
            errorProvider1.SetError(txtContactNo, "Contact number is required.")
            isValid = False
        ElseIf Not Regex.IsMatch(contact, "^(09\d{9}|\+639\d{9})$") Then
            errorProvider1.SetError(txtContactNo, "Enter a valid PH mobile number (e.g. 09171234567).")
            isValid = False
        End If

        Dim address As String = txtAddress.Text.Trim()
        If String.IsNullOrEmpty(address) Then
            errorProvider1.SetError(txtAddress, "Address is required.")
            isValid = False
        End If

        If cboCustomerType.SelectedIndex = -1 Then
            errorProvider1.SetError(cboCustomerType, "Select a customer type.")
            isValid = False
        End If

        Dim cycleText As String = txtDeliveryCycle.Text.Trim()
        Dim cycleValue As Integer
        If String.IsNullOrEmpty(cycleText) Then
            errorProvider1.SetError(txtDeliveryCycle, "Delivery cycle is required.")
            isValid = False
        ElseIf Not Integer.TryParse(cycleText, cycleValue) Then
            errorProvider1.SetError(txtDeliveryCycle, "Enter a whole number (e.g. 2).")
            isValid = False
        ElseIf cycleValue < 1 OrElse cycleValue > 30 Then
            errorProvider1.SetError(txtDeliveryCycle, "Cycle must be between 1 and 30 days.")
            isValid = False
        End If

        Return isValid
    End Function

    Private Sub SaveCustomer()
        Call connection()

        sql = "INSERT INTO tblCustomers (customerName, contactNo, address, customerType, deliveryFrequencyDays, preferredPaymentMode, status) " &
              "VALUES (@name, @contact, @address, @type, @cycle, @payment, 'Active')"

        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@name", txtName.Text.Trim())
        cmd.Parameters.AddWithValue("@contact", txtContactNo.Text.Trim())
        cmd.Parameters.AddWithValue("@address", txtAddress.Text.Trim())
        cmd.Parameters.AddWithValue("@type", cboCustomerType.SelectedItem.ToString())
        cmd.Parameters.AddWithValue("@cycle", Integer.Parse(txtDeliveryCycle.Text.Trim()))
        cmd.Parameters.AddWithValue("@payment", If(cboPaymentMode.SelectedItem Is Nothing, "Cash", cboPaymentMode.SelectedItem.ToString()))
        cmd.ExecuteNonQuery()
    End Sub
End Class