<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserManagement
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.lblCustomers = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lsvUsers = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnToggleStatus = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAddUser
        '
        Me.btnAddUser.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnAddUser.FlatAppearance.BorderSize = 0
        Me.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddUser.ForeColor = System.Drawing.Color.White
        Me.btnAddUser.Location = New System.Drawing.Point(808, 44)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(233, 58)
        Me.btnAddUser.TabIndex = 13
        Me.btnAddUser.Text = "+ Add Staff Account"
        Me.btnAddUser.UseVisualStyleBackColor = False
        '
        'lblCustomers
        '
        Me.lblCustomers.AutoSize = True
        Me.lblCustomers.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomers.Location = New System.Drawing.Point(22, 24)
        Me.lblCustomers.Name = "lblCustomers"
        Me.lblCustomers.Size = New System.Drawing.Size(474, 61)
        Me.lblCustomers.TabIndex = 12
        Me.lblCustomers.Text = "User Management"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(259, 31)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Owner's only screen"
        '
        'lsvUsers
        '
        Me.lsvUsers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.lsvUsers.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvUsers.HideSelection = False
        Me.lsvUsers.Location = New System.Drawing.Point(33, 137)
        Me.lsvUsers.Name = "lsvUsers"
        Me.lsvUsers.Size = New System.Drawing.Size(1008, 518)
        Me.lsvUsers.TabIndex = 15
        Me.lsvUsers.UseCompatibleStateImageBehavior = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Customer"
        '
        'btnToggleStatus
        '
        Me.btnToggleStatus.BackColor = System.Drawing.Color.White
        Me.btnToggleStatus.FlatAppearance.BorderSize = 0
        Me.btnToggleStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnToggleStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnToggleStatus.ForeColor = System.Drawing.Color.Black
        Me.btnToggleStatus.Location = New System.Drawing.Point(572, 44)
        Me.btnToggleStatus.Name = "btnToggleStatus"
        Me.btnToggleStatus.Size = New System.Drawing.Size(218, 58)
        Me.btnToggleStatus.TabIndex = 16
        Me.btnToggleStatus.Text = "Deactivate / Activate"
        Me.btnToggleStatus.UseVisualStyleBackColor = False
        '
        'frmUserManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1072, 694)
        Me.Controls.Add(Me.btnToggleStatus)
        Me.Controls.Add(Me.lsvUsers)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAddUser)
        Me.Controls.Add(Me.lblCustomers)
        Me.Name = "frmUserManagement"
        Me.Text = "frmUserManagement"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAddUser As Button
    Friend WithEvents lblCustomers As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lsvUsers As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents btnToggleStatus As Button
End Class
