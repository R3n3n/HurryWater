<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddBorrowRecord
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
        Me.components = New System.ComponentModel.Container()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblCustomers = New System.Windows.Forms.Label()
        Me.cboCustomer = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDispenserRef = New System.Windows.Forms.TextBox()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpDateBorrowed = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpExpectedReturn = New System.Windows.Forms.DateTimePicker()
        Me.errorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.errorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(296, 20)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Log a dispenser being lent to a customer"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(151, 389)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(95, 29)
        Me.btnCancel.TabIndex = 64
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
        Me.btnSave.Location = New System.Drawing.Point(262, 389)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(121, 29)
        Me.btnSave.TabIndex = 63
        Me.btnSave.Text = "Save Record"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lblCustomers
        '
        Me.lblCustomers.AutoSize = True
        Me.lblCustomers.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomers.Location = New System.Drawing.Point(12, 21)
        Me.lblCustomers.Name = "lblCustomers"
        Me.lblCustomers.Size = New System.Drawing.Size(274, 31)
        Me.lblCustomers.TabIndex = 62
        Me.lblCustomers.Text = "New Borrow Record"
        '
        'cboCustomer
        '
        Me.cboCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCustomer.FormattingEnabled = True
        Me.cboCustomer.Items.AddRange(New Object() {"Cash", "Card"})
        Me.cboCustomer.Location = New System.Drawing.Point(18, 153)
        Me.cboCustomer.Name = "cboCustomer"
        Me.cboCustomer.Size = New System.Drawing.Size(365, 32)
        Me.cboCustomer.TabIndex = 67
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Customer"
        '
        'txtDispenserRef
        '
        Me.txtDispenserRef.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDispenserRef.Location = New System.Drawing.Point(18, 229)
        Me.txtDispenserRef.Name = "txtDispenserRef"
        Me.txtDispenserRef.Size = New System.Drawing.Size(365, 29)
        Me.txtDispenserRef.TabIndex = 69
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.Location = New System.Drawing.Point(14, 206)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(115, 20)
        Me.lblQuantity.TabIndex = 68
        Me.lblQuantity.Text = "Dispenser Ref."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 283)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 20)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Date Borrowed"
        '
        'dtpDateBorrowed
        '
        Me.dtpDateBorrowed.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateBorrowed.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateBorrowed.Location = New System.Drawing.Point(18, 306)
        Me.dtpDateBorrowed.Name = "dtpDateBorrowed"
        Me.dtpDateBorrowed.Size = New System.Drawing.Size(171, 29)
        Me.dtpDateBorrowed.TabIndex = 70
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(208, 283)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 20)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Expected Return"
        '
        'dtpExpectedReturn
        '
        Me.dtpExpectedReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpExpectedReturn.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpExpectedReturn.Location = New System.Drawing.Point(212, 306)
        Me.dtpExpectedReturn.Name = "dtpExpectedReturn"
        Me.dtpExpectedReturn.Size = New System.Drawing.Size(171, 29)
        Me.dtpExpectedReturn.TabIndex = 72
        '
        'errorProvider1
        '
        Me.errorProvider1.ContainerControl = Me
        '
        'frmAddBorrowRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 461)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpExpectedReturn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpDateBorrowed)
        Me.Controls.Add(Me.txtDispenserRef)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.cboCustomer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblCustomers)
        Me.Name = "frmAddBorrowRecord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmAddBorrowRecord"
        CType(Me.errorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents lblCustomers As Label
    Friend WithEvents cboCustomer As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDispenserRef As TextBox
    Friend WithEvents lblQuantity As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpDateBorrowed As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpExpectedReturn As DateTimePicker
    Friend WithEvents errorProvider1 As ErrorProvider
End Class
