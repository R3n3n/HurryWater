<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventory
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
        Me.lsvInventory = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnStockOut = New System.Windows.Forms.Button()
        Me.btnStockIn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCustomers
        '
        Me.lblCustomers.AutoSize = True
        Me.lblCustomers.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomers.Location = New System.Drawing.Point(23, 23)
        Me.lblCustomers.Name = "lblCustomers"
        Me.lblCustomers.Size = New System.Drawing.Size(254, 61)
        Me.lblCustomers.TabIndex = 7
        Me.lblCustomers.Text = "Inventory"
        '
        'lsvInventory
        '
        Me.lsvInventory.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.lsvInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvInventory.HideSelection = False
        Me.lsvInventory.Location = New System.Drawing.Point(34, 113)
        Me.lsvInventory.Name = "lsvInventory"
        Me.lsvInventory.Size = New System.Drawing.Size(998, 504)
        Me.lsvInventory.TabIndex = 9
        Me.lsvInventory.UseCompatibleStateImageBehavior = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Customer"
        '
        'btnStockOut
        '
        Me.btnStockOut.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnStockOut.FlatAppearance.BorderSize = 0
        Me.btnStockOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStockOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStockOut.ForeColor = System.Drawing.Color.White
        Me.btnStockOut.Location = New System.Drawing.Point(883, 33)
        Me.btnStockOut.Name = "btnStockOut"
        Me.btnStockOut.Size = New System.Drawing.Size(149, 42)
        Me.btnStockOut.TabIndex = 51
        Me.btnStockOut.Text = "↑ Stock Out"
        Me.btnStockOut.UseVisualStyleBackColor = False
        '
        'btnStockIn
        '
        Me.btnStockIn.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnStockIn.FlatAppearance.BorderSize = 0
        Me.btnStockIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStockIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStockIn.ForeColor = System.Drawing.Color.White
        Me.btnStockIn.Location = New System.Drawing.Point(716, 33)
        Me.btnStockIn.Name = "btnStockIn"
        Me.btnStockIn.Size = New System.Drawing.Size(149, 42)
        Me.btnStockIn.TabIndex = 52
        Me.btnStockIn.Text = "↓ Stock In"
        Me.btnStockIn.UseVisualStyleBackColor = False
        '
        'frmInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1072, 694)
        Me.Controls.Add(Me.btnStockIn)
        Me.Controls.Add(Me.btnStockOut)
        Me.Controls.Add(Me.lsvInventory)
        Me.Controls.Add(Me.lblCustomers)
        Me.Name = "frmInventory"
        Me.Text = "frmInventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCustomers As Label
    Friend WithEvents lsvInventory As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents btnStockOut As Button
    Friend WithEvents btnStockIn As Button
End Class
