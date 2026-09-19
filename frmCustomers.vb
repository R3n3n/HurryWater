Imports MySql.Data.MySqlClient

Public Class frmCustomers

    Private Sub frmCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()

        SetupListView()
        LoadDocumentData()
    End Sub
    Private Sub SetupListView()
        lsvCustomers.View = View.Details
        lsvCustomers.FullRowSelect = True
        lsvCustomers.GridLines = True

        lsvCustomers.Columns.Clear()
        lsvCustomers.Columns.Add("Customer Name", 280)
        lsvCustomers.Columns.Add("Contact", 255)
        lsvCustomers.Columns.Add("Type", 230)
        lsvCustomers.Columns.Add("Frequency", 225)
    End Sub

    Private Sub LoadDocumentData()
        lsvCustomers.Items.Clear()

        sql = "SELECT customerId, customerName, contactNo, customerType, deliveryFrequencyDays FROM tblcustomers"

        Try
            connection()
            cmd = New MySqlCommand(sql, cn)
            dr = cmd.ExecuteReader()

            While dr.Read()
                Dim item As New ListViewItem(dr("customerName").ToString())

                item.SubItems.Add(dr("contactNo").ToString())
                item.SubItems.Add(dr("customerType").ToString())
                item.SubItems.Add(dr("deliveryFrequencyDays").ToString())

                item.Tag = dr("customerId")

                lsvCustomers.Items.Add(item)
            End While

            dr.Close()
        Catch ex As Exception
            MsgBox("Error loading customers: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        Dim addForm As New frmAddCustomer()

        If addForm.ShowDialog() = DialogResult.OK Then
            LoadCustomerList()
        End If

        addForm.Dispose()
    End Sub

    Private Sub LoadCustomerList()
        lsvCustomers.Items.Clear()

        sql = "SELECT customerId, customerName, contactNo, customerType, deliveryFrequencyDays FROM tblcustomers"

        Try
            connection()
            cmd = New MySqlCommand(sql, cn)
            dr = cmd.ExecuteReader()

            While dr.Read()
                Dim item As New ListViewItem(dr("customerName").ToString())

                item.SubItems.Add(dr("contactNo").ToString())
                item.SubItems.Add(dr("customerType").ToString())
                item.SubItems.Add(dr("deliveryFrequencyDays").ToString())

                item.Tag = dr("customerId")

                lsvCustomers.Items.Add(item)
            End While

            dr.Close()
        Catch ex As Exception
            MsgBox("Error loading customers: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub
End Class