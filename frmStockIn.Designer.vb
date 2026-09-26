<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockIn
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
        Me.lblCustomers = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboItem = New System.Windows.Forms.ComboBox()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtReference = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCustomers
        '
        Me.lblCustomers.AutoSize = True
        Me.lblCustomers.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomers.Location = New System.Drawing.Point(12, 9)
        Me.lblCustomers.Name = "lblCustomers"
        Me.lblCustomers.Size = New System.Drawing.Size(121, 31)
        Me.lblCustomers.TabIndex = 8
        Me.lblCustomers.Text = "Stock In"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(151, 420)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(95, 29)
        Me.btnCancel.TabIndex = 24
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
        Me.btnSave.Location = New System.Drawing.Point(262, 420)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(121, 29)
        Me.btnSave.TabIndex = 23
        Me.btnSave.Text = "Confirm Stock-In"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 20)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Record newly received stock"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 20)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Item"
        '
        'cboItem
        '
        Me.cboItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboItem.FormattingEnabled = True
        Me.cboItem.Items.AddRange(New Object() {"Cash", "Card"})
        Me.cboItem.Location = New System.Drawing.Point(18, 109)
        Me.cboItem.Name = "cboItem"
        Me.cboItem.Size = New System.Drawing.Size(365, 32)
        Me.cboItem.TabIndex = 27
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.Location = New System.Drawing.Point(14, 166)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(138, 20)
        Me.lblQuantity.TabIndex = 28
        Me.lblQuantity.Text = "Quantity Received"
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(18, 189)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(365, 29)
        Me.txtQuantity.TabIndex = 29
        '
        'dtpDate
        '
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(18, 267)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(365, 29)
        Me.dtpDate.TabIndex = 43
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 244)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 20)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Date"
        '
        'txtReference
        '
        Me.txtReference.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReference.Location = New System.Drawing.Point(18, 347)
        Me.txtReference.Name = "txtReference"
        Me.txtReference.Size = New System.Drawing.Size(365, 29)
        Me.txtReference.TabIndex = 46
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 324)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(202, 20)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Reference No. / Invoice No."
        '
        'frmStockIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 461)
        Me.Controls.Add(Me.txtReference)
        Me.Controls.Add(Me.Label5)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmStockIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmStockIn"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCustomers As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cboItem As ComboBox
    Friend WithEvents lblQuantity As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents txtReference As TextBox
    Friend WithEvents Label5 As Label
End Class
