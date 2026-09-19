Public Class frmStaffDashboard
    Private Sub LoadFormInPanel(ByVal childForm As Form)
        ' Clear existing forms/controls from the right panel
        SplitContainer1.Panel2.Controls.Clear()

        ' Embed the child form as a control
        With childForm
            .TopLevel = False
            .FormBorderStyle = FormBorderStyle.None
            .Dock = DockStyle.Fill
        End With

        ' Add and render the child form inside Panel2
        SplitContainer1.Panel2.Controls.Add(childForm)
        SplitContainer1.Panel2.Tag = childForm
        childForm.Show()
    End Sub

    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        LoadFormInPanel(New frmCustomers())
    End Sub

    Private Sub btnSalesDelivery_Click(sender As Object, e As EventArgs) Handles btnSalesDelivery.Click
        LoadFormInPanel(New frmSalesDelivery())
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        'LoadFormInPanel(New frmDashboard())
    End Sub

    Private Sub btnProduction_Click(sender As Object, e As EventArgs) Handles btnProduction.Click
        LoadFormInPanel(New frmProduction())
    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        LoadFormInPanel(New frmInventory())
    End Sub

    Private Sub btnExpenses_Click(sender As Object, e As EventArgs) Handles btnExpenses.Click
        LoadFormInPanel(New frmExpenses())
    End Sub

    Private Sub btnDispenserBorrowing_Click(sender As Object, e As EventArgs) Handles btnDispenserBorrowing.Click
        LoadFormInPanel(New frmDispenserBorrowing())
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        LoadFormInPanel(New frmReports())
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As MsgBoxResult
        result = MsgBox("Do you want to logout?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm Logout")

        If result = MsgBoxResult.Yes Then
            Dim loginForm As New frmLogin()
            loginForm.Show()
            Me.Close()
        End If
    End Sub
End Class