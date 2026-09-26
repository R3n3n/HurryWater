<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExpenses
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
        Me.btnAddExpense = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblGasTotal = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblSuppliesTotal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblSalaryTotal = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblGrandTotal = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lsvExpenses = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCustomers
        '
        Me.lblCustomers.AutoSize = True
        Me.lblCustomers.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomers.Location = New System.Drawing.Point(21, 30)
        Me.lblCustomers.Name = "lblCustomers"
        Me.lblCustomers.Size = New System.Drawing.Size(267, 61)
        Me.lblCustomers.TabIndex = 8
        Me.lblCustomers.Text = "Expenses"
        '
        'btnAddExpense
        '
        Me.btnAddExpense.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnAddExpense.FlatAppearance.BorderSize = 0
        Me.btnAddExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddExpense.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddExpense.ForeColor = System.Drawing.Color.White
        Me.btnAddExpense.Location = New System.Drawing.Point(806, 33)
        Me.btnAddExpense.Name = "btnAddExpense"
        Me.btnAddExpense.Size = New System.Drawing.Size(233, 58)
        Me.btnAddExpense.TabIndex = 11
        Me.btnAddExpense.Text = "+ Add Expense"
        Me.btnAddExpense.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.lblGasTotal)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Location = New System.Drawing.Point(32, 138)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(238, 126)
        Me.Panel1.TabIndex = 50
        '
        'lblGasTotal
        '
        Me.lblGasTotal.AutoSize = True
        Me.lblGasTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGasTotal.Location = New System.Drawing.Point(15, 72)
        Me.lblGasTotal.Name = "lblGasTotal"
        Me.lblGasTotal.Size = New System.Drawing.Size(31, 33)
        Me.lblGasTotal.TabIndex = 54
        Me.lblGasTotal.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(169, 25)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Gas - this month"
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel2.Controls.Add(Me.lblSuppliesTotal)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(287, 138)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(238, 126)
        Me.Panel2.TabIndex = 55
        '
        'lblSuppliesTotal
        '
        Me.lblSuppliesTotal.AutoSize = True
        Me.lblSuppliesTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuppliesTotal.Location = New System.Drawing.Point(15, 72)
        Me.lblSuppliesTotal.Name = "lblSuppliesTotal"
        Me.lblSuppliesTotal.Size = New System.Drawing.Size(31, 33)
        Me.lblSuppliesTotal.TabIndex = 54
        Me.lblSuppliesTotal.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(213, 25)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Supplies - this month"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(737, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 24)
        Me.Label3.TabIndex = 27
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel3.Controls.Add(Me.lblSalaryTotal)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Location = New System.Drawing.Point(545, 138)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(238, 126)
        Me.Panel3.TabIndex = 55
        '
        'lblSalaryTotal
        '
        Me.lblSalaryTotal.AutoSize = True
        Me.lblSalaryTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalaryTotal.Location = New System.Drawing.Point(15, 72)
        Me.lblSalaryTotal.Name = "lblSalaryTotal"
        Me.lblSalaryTotal.Size = New System.Drawing.Size(31, 33)
        Me.lblSalaryTotal.TabIndex = 54
        Me.lblSalaryTotal.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(191, 25)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Salary - this month"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(737, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 24)
        Me.Label7.TabIndex = 27
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel4.Controls.Add(Me.lblGrandTotal)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Location = New System.Drawing.Point(801, 138)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(238, 126)
        Me.Panel4.TabIndex = 55
        '
        'lblGrandTotal
        '
        Me.lblGrandTotal.AutoSize = True
        Me.lblGrandTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrandTotal.Location = New System.Drawing.Point(15, 72)
        Me.lblGrandTotal.Name = "lblGrandTotal"
        Me.lblGrandTotal.Size = New System.Drawing.Size(31, 33)
        Me.lblGrandTotal.TabIndex = 54
        Me.lblGrandTotal.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(17, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(178, 25)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "Total - this month"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(737, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 24)
        Me.Label11.TabIndex = 27
        '
        'lsvExpenses
        '
        Me.lsvExpenses.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.lsvExpenses.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvExpenses.HideSelection = False
        Me.lsvExpenses.Location = New System.Drawing.Point(32, 295)
        Me.lsvExpenses.Name = "lsvExpenses"
        Me.lsvExpenses.Size = New System.Drawing.Size(1007, 355)
        Me.lsvExpenses.TabIndex = 56
        Me.lsvExpenses.UseCompatibleStateImageBehavior = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Customer"
        '
        'frmExpenses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1072, 694)
        Me.Controls.Add(Me.lsvExpenses)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnAddExpense)
        Me.Controls.Add(Me.lblCustomers)
        Me.Name = "frmExpenses"
        Me.Text = "frmExpenses"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCustomers As Label
    Friend WithEvents btnAddExpense As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblGasTotal As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblSuppliesTotal As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblGrandTotal As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblSalaryTotal As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lsvExpenses As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
End Class
