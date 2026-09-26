<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockOut
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.cboItem = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblCustomers = New System.Windows.Forms.Label()
        Me.txtAvailable = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboReason = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtReference = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 252)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 20)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Date"
        '
        'dtpDate
        '
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(23, 275)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(365, 26)
        Me.dtpDate.TabIndex = 55
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(23, 215)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(365, 26)
        Me.txtQuantity.TabIndex = 54
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.Location = New System.Drawing.Point(19, 192)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(110, 20)
        Me.lblQuantity.TabIndex = 53
        Me.lblQuantity.Text = "Quantity Used"
        '
        'cboItem
        '
        Me.cboItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboItem.FormattingEnabled = True
        Me.cboItem.Items.AddRange(New Object() {"Cash", "Card"})
        Me.cboItem.Location = New System.Drawing.Point(23, 91)
        Me.cboItem.Name = "cboItem"
        Me.cboItem.Size = New System.Drawing.Size(365, 28)
        Me.cboItem.TabIndex = 52
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 20)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Item"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 20)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Record consumable items used up"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(156, 421)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(95, 29)
        Me.btnCancel.TabIndex = 49
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(267, 421)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(121, 29)
        Me.btnSave.TabIndex = 48
        Me.btnSave.Text = "Confirm Stock Out"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lblCustomers
        '
        Me.lblCustomers.AutoSize = True
        Me.lblCustomers.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomers.Location = New System.Drawing.Point(17, 10)
        Me.lblCustomers.Name = "lblCustomers"
        Me.lblCustomers.Size = New System.Drawing.Size(143, 31)
        Me.lblCustomers.TabIndex = 47
        Me.lblCustomers.Text = "Stock Out"
        '
        'txtAvailable
        '
        Me.txtAvailable.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvailable.Location = New System.Drawing.Point(23, 154)
        Me.txtAvailable.Name = "txtAvailable"
        Me.txtAvailable.Size = New System.Drawing.Size(365, 26)
        Me.txtAvailable.TabIndex = 60
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 20)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Current Stock"
        '
        'cboReason
        '
        Me.cboReason.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboReason.FormattingEnabled = True
        Me.cboReason.Items.AddRange(New Object() {"Cash", "Card"})
        Me.cboReason.Location = New System.Drawing.Point(23, 333)
        Me.cboReason.Name = "cboReason"
        Me.cboReason.Size = New System.Drawing.Size(365, 28)
        Me.cboReason.TabIndex = 62
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 310)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 20)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Reason"
        '
        'txtReference
        '
        Me.txtReference.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReference.Location = New System.Drawing.Point(23, 389)
        Me.txtReference.Name = "txtReference"
        Me.txtReference.Size = New System.Drawing.Size(365, 26)
        Me.txtReference.TabIndex = 64
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 366)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(199, 20)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Additional details (optional)"
        '
        'frmStockOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 461)
        Me.Controls.Add(Me.txtReference)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboReason)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtAvailable)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.cboItem)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblCustomers)
        Me.Name = "frmStockOut"
        Me.Text = "frmStockOut"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents lblQuantity As Label
    Friend WithEvents cboItem As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents lblCustomers As Label
    Friend WithEvents txtAvailable As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboReason As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtReference As TextBox
    Friend WithEvents Label6 As Label
End Class
