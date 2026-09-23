<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProduction
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblCustomers = New System.Windows.Forms.Label()
        Me.dtpLogDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboTank = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nudLiters = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblBottles500 = New System.Windows.Forms.Label()
        Me.lblBottles350 = New System.Windows.Forms.Label()
        Me.lblGallons = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        CType(Me.nudLiters, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(321, 31)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Enter today's tank output "
        '
        'lblCustomers
        '
        Me.lblCustomers.AutoSize = True
        Me.lblCustomers.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomers.Location = New System.Drawing.Point(21, 19)
        Me.lblCustomers.Name = "lblCustomers"
        Me.lblCustomers.Size = New System.Drawing.Size(393, 61)
        Me.lblCustomers.TabIndex = 6
        Me.lblCustomers.Text = "Log Production"
        '
        'dtpLogDate
        '
        Me.dtpLogDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpLogDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpLogDate.Location = New System.Drawing.Point(35, 180)
        Me.dtpLogDate.Name = "dtpLogDate"
        Me.dtpLogDate.Size = New System.Drawing.Size(255, 38)
        Me.dtpLogDate.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 29)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Date"
        '
        'cboTank
        '
        Me.cboTank.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTank.FormattingEnabled = True
        Me.cboTank.Items.AddRange(New Object() {"Pending", "Picked-up", "Delivered"})
        Me.cboTank.Location = New System.Drawing.Point(327, 179)
        Me.cboTank.Name = "cboTank"
        Me.cboTank.Size = New System.Drawing.Size(323, 39)
        Me.cboTank.TabIndex = 46
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(322, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 29)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Tank"
        '
        'nudLiters
        '
        Me.nudLiters.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudLiters.Location = New System.Drawing.Point(35, 288)
        Me.nudLiters.Name = "nudLiters"
        Me.nudLiters.Size = New System.Drawing.Size(615, 38)
        Me.nudLiters.TabIndex = 47
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 256)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 29)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Liters Produced"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.lblBottles500)
        Me.Panel1.Controls.Add(Me.lblBottles350)
        Me.Panel1.Controls.Add(Me.lblGallons)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Location = New System.Drawing.Point(35, 362)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(615, 164)
        Me.Panel1.TabIndex = 49
        '
        'lblBottles500
        '
        Me.lblBottles500.AutoSize = True
        Me.lblBottles500.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBottles500.Location = New System.Drawing.Point(434, 107)
        Me.lblBottles500.Name = "lblBottles500"
        Me.lblBottles500.Size = New System.Drawing.Size(29, 31)
        Me.lblBottles500.TabIndex = 56
        Me.lblBottles500.Text = "0"
        '
        'lblBottles350
        '
        Me.lblBottles350.AutoSize = True
        Me.lblBottles350.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBottles350.Location = New System.Drawing.Point(212, 107)
        Me.lblBottles350.Name = "lblBottles350"
        Me.lblBottles350.Size = New System.Drawing.Size(29, 31)
        Me.lblBottles350.TabIndex = 55
        Me.lblBottles350.Text = "0"
        '
        'lblGallons
        '
        Me.lblGallons.AutoSize = True
        Me.lblGallons.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGallons.Location = New System.Drawing.Point(15, 107)
        Me.lblGallons.Name = "lblGallons"
        Me.lblGallons.Size = New System.Drawing.Size(29, 31)
        Me.lblGallons.TabIndex = 54
        Me.lblGallons.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(436, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 24)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "500mL bottles"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(214, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 24)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "350mL bottles"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 24)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Gallons"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(245, 24)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Auto-Calculated Equivalents"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(737, 17)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 24)
        Me.Label12.TabIndex = 27
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(501, 562)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(149, 42)
        Me.btnSave.TabIndex = 50
        Me.btnSave.Text = "Save Log"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'frmProduction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1072, 694)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nudLiters)
        Me.Controls.Add(Me.cboTank)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpLogDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblCustomers)
        Me.Name = "frmProduction"
        Me.Text = "frmProduction"
        CType(Me.nudLiters, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents lblCustomers As Label
    Friend WithEvents dtpLogDate As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents cboTank As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents nudLiters As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblBottles500 As Label
    Friend WithEvents lblBottles350 As Label
    Friend WithEvents lblGallons As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnSave As Button
End Class
