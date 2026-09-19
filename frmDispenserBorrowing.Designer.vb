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
        Me.btnBorrowRecord = New System.Windows.Forms.Button()
        Me.lblCustomers = New System.Windows.Forms.Label()
        Me.lsvDispenserBorrowing = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'btnBorrowRecord
        '
        Me.btnBorrowRecord.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnBorrowRecord.FlatAppearance.BorderSize = 0
        Me.btnBorrowRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrowRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrowRecord.ForeColor = System.Drawing.Color.White
        Me.btnBorrowRecord.Location = New System.Drawing.Point(770, 29)
        Me.btnBorrowRecord.Name = "btnBorrowRecord"
        Me.btnBorrowRecord.Size = New System.Drawing.Size(276, 58)
        Me.btnBorrowRecord.TabIndex = 13
        Me.btnBorrowRecord.Text = "+ New Borrow Record"
        Me.btnBorrowRecord.UseVisualStyleBackColor = False
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
        'lsvDispenserBorrowing
        '
        Me.lsvDispenserBorrowing.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.lsvDispenserBorrowing.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvDispenserBorrowing.HideSelection = False
        Me.lsvDispenserBorrowing.Location = New System.Drawing.Point(26, 114)
        Me.lsvDispenserBorrowing.Name = "lsvDispenserBorrowing"
        Me.lsvDispenserBorrowing.Size = New System.Drawing.Size(1020, 548)
        Me.lsvDispenserBorrowing.TabIndex = 14
        Me.lsvDispenserBorrowing.UseCompatibleStateImageBehavior = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Customer"
        '
        'frmDispenserBorrowing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1072, 694)
        Me.Controls.Add(Me.lsvDispenserBorrowing)
        Me.Controls.Add(Me.btnBorrowRecord)
        Me.Controls.Add(Me.lblCustomers)
        Me.Name = "frmDispenserBorrowing"
        Me.Text = "frmDispenserBorrowing"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBorrowRecord As Button
    Friend WithEvents lblCustomers As Label
    Friend WithEvents lsvDispenserBorrowing As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
End Class
