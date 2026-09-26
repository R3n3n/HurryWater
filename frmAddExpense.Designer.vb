<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddExpense
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblCustomers = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpExpenseDate = New System.Windows.Forms.DateTimePicker()
        Me.cboCategory = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.errorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.errorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(151, 406)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(95, 29)
        Me.btnCancel.TabIndex = 52
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
        Me.btnSave.Location = New System.Drawing.Point(262, 406)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(121, 29)
        Me.btnSave.TabIndex = 51
        Me.btnSave.Text = "Save Expense"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lblCustomers
        '
        Me.lblCustomers.AutoSize = True
        Me.lblCustomers.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomers.Location = New System.Drawing.Point(12, 18)
        Me.lblCustomers.Name = "lblCustomers"
        Me.lblCustomers.Size = New System.Drawing.Size(185, 31)
        Me.lblCustomers.TabIndex = 50
        Me.lblCustomers.Text = "Add Expense"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 20)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Date"
        '
        'dtpExpenseDate
        '
        Me.dtpExpenseDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpExpenseDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpExpenseDate.Location = New System.Drawing.Point(18, 118)
        Me.dtpExpenseDate.Name = "dtpExpenseDate"
        Me.dtpExpenseDate.Size = New System.Drawing.Size(365, 29)
        Me.dtpExpenseDate.TabIndex = 53
        '
        'cboCategory
        '
        Me.cboCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Items.AddRange(New Object() {"Cash", "Card"})
        Me.cboCategory.Location = New System.Drawing.Point(18, 192)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(365, 32)
        Me.cboCategory.TabIndex = 56
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Category"
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(18, 265)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(365, 29)
        Me.txtAmount.TabIndex = 58
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.Location = New System.Drawing.Point(14, 242)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(65, 20)
        Me.lblQuantity.TabIndex = 57
        Me.lblQuantity.Text = "Amount"
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(18, 341)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(365, 29)
        Me.txtDescription.TabIndex = 60
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 318)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 20)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Description"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(246, 20)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Record a new bussiness expense"
        '
        'errorProvider1
        '
        Me.errorProvider1.ContainerControl = Me
        '
        'frmAddExpense
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 461)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.cboCategory)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpExpenseDate)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblCustomers)
        Me.Name = "frmAddExpense"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmAddExpense"
        CType(Me.errorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents lblCustomers As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpExpenseDate As DateTimePicker
    Friend WithEvents cboCategory As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents lblQuantity As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents errorProvider1 As ErrorProvider
End Class
