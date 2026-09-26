Imports MySql.Data.MySqlClient

Public Class frmUserManagement

    Private Sub frmUserManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupListView()
        LoadUserList()
    End Sub

    Private Sub SetupListView()
        lsvUsers.View = View.Details
        lsvUsers.FullRowSelect = True
        lsvUsers.GridLines = True

        lsvUsers.Columns.Clear()
        lsvUsers.Columns.Add("Name", 260)
        lsvUsers.Columns.Add("Username", 260)
        lsvUsers.Columns.Add("Role", 150)
        lsvUsers.Columns.Add("Status", 350)
    End Sub

    Private Sub LoadUserList()
        lsvUsers.Items.Clear()

        sql = "SELECT userId, fullName, username, role, status FROM tblUsers ORDER BY fullName"

        Try
            connection()
            cmd = New MySqlCommand(sql, cn)
            dr = cmd.ExecuteReader()

            While dr.Read()
                Dim item As New ListViewItem(dr("fullName").ToString())
                item.SubItems.Add(dr("username").ToString())
                item.SubItems.Add(dr("role").ToString())
                item.SubItems.Add(dr("status").ToString())
                item.Tag = dr("userId")

                If dr("status").ToString() = "Deactivated" Then
                    item.ForeColor = Color.Gray   ' visually de-emphasize disabled accounts
                End If

                lsvUsers.Items.Add(item)
            End While

            dr.Close()
        Catch ex As Exception
            MsgBox("Error loading users: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        Dim addForm As New frmAddStaffAccount()

        If addForm.ShowDialog() = DialogResult.OK Then
            LoadUserList()
        End If

        addForm.Dispose()
    End Sub

    ''' <summary>
    ''' Toggles the selected user between Active and Deactivated.
    ''' Deactivate rather than delete — this preserves every sales
    ''' order, expense, and log entry that user ever recorded, so
    ''' historical data never gets orphaned by removing a user.
    ''' </summary>
    Private Sub btnToggleStatus_Click(sender As Object, e As EventArgs) Handles btnToggleStatus.Click
        If lsvUsers.SelectedItems.Count = 0 Then
            MsgBox("Select a user first.", MsgBoxStyle.Exclamation, "No selection")
            Return
        End If

        Dim selectedItem As ListViewItem = lsvUsers.SelectedItems(0)
        Dim selectedUserId As Integer = CInt(selectedItem.Tag)
        Dim currentStatus As String = selectedItem.SubItems(3).Text

        ' Guard: don't let someone lock themselves out mid-session
        If selectedUserId = CurrentUserId Then
            MsgBox("You cannot deactivate your own account while logged in.", MsgBoxStyle.Exclamation, "Not allowed")
            Return
        End If

        Dim newStatus As String = If(currentStatus = "Active", "Deactivated", "Active")
        Dim actionWord As String = If(newStatus = "Deactivated", "deactivate", "reactivate")

        Dim confirm As MsgBoxResult = MsgBox(
            "Are you sure you want to " & actionWord & " " & selectedItem.Text & "'s account?",
            MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm")

        If confirm <> MsgBoxResult.Yes Then Return

        Try
            connection()
            sql = "UPDATE tblUsers SET status = @status WHERE userId = @id"
            cmd = New MySqlCommand(sql, cn)
            cmd.Parameters.AddWithValue("@status", newStatus)
            cmd.Parameters.AddWithValue("@id", selectedUserId)
            cmd.ExecuteNonQuery()

            LoadUserList()
        Catch ex As Exception
            MsgBox("Database error: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Sub

End Class