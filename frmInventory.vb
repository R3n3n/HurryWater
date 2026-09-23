Imports MySql.Data.MySqlClient

Public Class frmInventory
    Private Sub btnStockIn_Click(sender As Object, e As EventArgs) Handles btnStockIn.Click
        Dim addForm As New frmStockIn()

        If addForm.ShowDialog() = DialogResult.OK Then
            LoadCustomerList()
        End If

        addForm.Dispose()
    End Sub

    Private Sub LoadCustomerList()
        lsvInventory.Items.Clear()

        sql = "SELECT itemId, itemName, unit, currentStock, reorderPoint, safetyStock, supplierId, createdAt FROM tblinventoryitems"

        Try
            connection()
            cmd = New MySqlCommand(sql, cn)
            dr = cmd.ExecuteReader()

            While dr.Read()
                Dim item As New ListViewItem(dr("itemName").ToString())

                item.SubItems.Add(dr("unit").ToString())
                item.SubItems.Add(dr("currenStock").ToString())
                item.SubItems.Add(dr("reorderPoint").ToString())
                item.SubItems.Add(dr("safetyStock").ToString())

                item.Tag = dr("itemId")

                lsvInventory.Items.Add(item)
            End While

            dr.Close()
        Catch ex As Exception
            MsgBox("Error loading inventory: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub
End Class