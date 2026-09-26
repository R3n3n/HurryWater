<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDispenserBorrowing
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
        Me.btnAddBorrow = New System.Windows.Forms.Button()
        Me.lblCustomers = New System.Windows.Forms.Label()
        Me.lsvBorrowing = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnMarkReturned = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAddBorrow
        '
        Me.btnAddBorrow.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnAddBorrow.FlatAppearance.BorderSize = 0
        Me.btnAddBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddBorrow.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddBorrow.ForeColor = System.Drawing.Color.White
        Me.btnAddBorrow.Location = New System.Drawing.Point(770, 29)
        Me.btnAddBorrow.Name = "btnAddBorrow"
        Me.btnAddBorrow.Size = New System.Drawing.Size(276, 58)
        Me.btnAddBorrow.TabIndex = 13
        Me.btnAddBorrow.Text = "+ New Borrow Record"
        Me.btnAddBorrow.UseVisualStyleBackColor = False
        '
        'lblCustomers
        '
        Me.lblCustomers.AutoSize = True
        Me.lblCustomers.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomers.Location = New System.Drawing.Point(15, 26)
        Me.lblCustomers.Name = "lblCustomers"
        Me.lblCustomers.Size = New System.Drawing.Size(533, 61)
        Me.lblCustomers.TabIndex = 12
        Me.lblCustomers.Text = "Dispenser Borrowing"
        '
        'lsvBorrowing
        '
        Me.lsvBorrowing.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.lsvBorrowing.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvBorrowing.HideSelection = False
        Me.lsvBorrowing.Location = New System.Drawing.Point(26, 114)
        Me.lsvBorrowing.Name = "lsvBorrowing"
        Me.lsvBorrowing.Size = New System.Drawing.Size(1020, 548)
        Me.lsvBorrowing.TabIndex = 14
        Me.lsvBorrowing.UseCompatibleStateImageBehavior = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Customer"
        '
        'btnMarkReturned
        '
        Me.btnMarkReturned.BackColor = System.Drawing.Color.White
        Me.btnMarkReturned.FlatAppearance.BorderSize = 0
        Me.btnMarkReturned.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMarkReturned.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMarkReturned.ForeColor = System.Drawing.Color.Black
        Me.btnMarkReturned.Location = New System.Drawing.Point(573, 29)
        Me.btnMarkReturned.Name = "btnMarkReturned"
        Me.btnMarkReturned.Size = New System.Drawing.Size(182, 58)
        Me.btnMarkReturned.TabIndex = 15
        Me.btnMarkReturned.Text = "Mark Returned"
        Me.btnMarkReturned.UseVisualStyleBackColor = False
        '
        'frmDispenserBorrowing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1072, 694)
        Me.Controls.Add(Me.btnMarkReturned)
        Me.Controls.Add(Me.lsvBorrowing)
        Me.Controls.Add(Me.btnAddBorrow)
        Me.Controls.Add(Me.lblCustomers)
        Me.Name = "frmDispenserBorrowing"
        Me.Text = "frmDispenserBorrowing"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAddBorrow As Button
    Friend WithEvents lblCustomers As Label
    Friend WithEvents lsvBorrowing As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents btnMarkReturned As Button
End Class
