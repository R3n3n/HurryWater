Imports MySql.Data.MySqlClient

Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Call connection()

        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Please enter information for username and password.")
            Exit Sub
        End If

        sql = "SELECT * FROM tblusers WHERE username = @username AND passwordHash = @password"
        cmd = New MySqlCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("@username", txtUsername.Text)
            .Parameters.AddWithValue("@password", txtPassword.Text)
            .ExecuteNonQuery()
        End With

        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            dr.Read()
            MsgBox("Welcome " & dr("role").ToString() & "!", MsgBoxStyle.Information)
            frmDashboard.Show()
            Me.Hide()
        Else
            MsgBox("Invalid username or password!", MsgBoxStyle.Critical)
            Exit Sub
        End If

        dr.Close()
        txtUsername.Clear()
        txtPassword.Clear()
        txtUsername.Focus()
        cn.Close()
        Me.Hide()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUsername.Clear()
        txtPassword.Clear()
    End Sub
End Class