Imports MySql.Data.MySqlClient

Public Class frmAddBorrowRecord

    Private Sub frmAddBorrowRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomers()

        dtpDateBorrowed.Value = Date.Today
        dtpExpectedReturn.Value = Date.Today.AddDays(14)   ' reasonable default, adjust as needed
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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        errorProvider1.Clear()

        If Not ValidateInputs() Then
            MsgBox("Please fix the highlighted fields before saving.", MsgBoxStyle.Exclamation, "Validation error")
            Return
        End If

        Try
            SaveBorrowRecord()
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

        If cboCustomer.SelectedIndex = -1 Then
            errorProvider1.SetError(cboCustomer, "Select a customer.")
            isValid = False
        End If

        Dim dispenserRef As String = txtDispenserRef.Text.Trim()
        If String.IsNullOrEmpty(dispenserRef) Then
            errorProvider1.SetError(txtDispenserRef, "Enter a dispenser reference (e.g. DSP-015).")
            isValid = False
        End If

        ' Expected return can't be before the borrow date itself —
        ' catches an easy date-picker mistake before it hits the database
        If dtpExpectedReturn.Value.Date < dtpDateBorrowed.Value.Date Then
            errorProvider1.SetError(dtpExpectedReturn, "Expected return date can't be before the borrow date.")
            isValid = False
        End If

        Return isValid
    End Function

    Private Sub SaveBorrowRecord()
        connection()

        sql = "INSERT INTO tblDispenserBorrowing " &
              "(customerId, dispenserRef, dateBorrowed, expectedReturnDate, status) " &
              "VALUES (@customerId, @dispenserRef, @dateBorrowed, @expectedReturn, 'Borrowed')"

        cmd = New MySqlCommand(sql, cn)
        cmd.Parameters.AddWithValue("@customerId", CInt(cboCustomer.SelectedValue))
        cmd.Parameters.AddWithValue("@dispenserRef", txtDispenserRef.Text.Trim())
        cmd.Parameters.AddWithValue("@dateBorrowed", dtpDateBorrowed.Value.Date)
        cmd.Parameters.AddWithValue("@expectedReturn", dtpExpectedReturn.Value.Date)
        cmd.ExecuteNonQuery()

        If cn.State = ConnectionState.Open Then cn.Close()
    End Sub

End Class