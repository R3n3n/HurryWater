<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesDelivery
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
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboFilterPayment = New System.Windows.Forms.ComboBox()
        Me.btnAddOrder = New System.Windows.Forms.Button()
        Me.lsvOrders = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cboFilterPickup = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblCustomers
        '
        Me.lblCustomers.AutoSize = True
        Me.lblCustomers.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomers.Location = New System.Drawing.Point(12, 22)
        Me.lblCustomers.Name = "lblCustomers"
        Me.lblCustomers.Size = New System.Drawing.Size(407, 61)
        Me.lblCustomers.TabIndex = 1
        Me.lblCustomers.Text = "Sales / Delivery"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(26, 137)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(480, 38)
        Me.txtSearch.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(234, 31)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "# orders this week"
        '
        'cboFilterPayment
        '
        Me.cboFilterPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFilterPayment.FormattingEnabled = True
        Me.cboFilterPayment.Items.AddRange(New Object() {"Unpaid", "Paid"})
        Me.cboFilterPayment.Location = New System.Drawing.Point(798, 137)
        Me.cboFilterPayment.Name = "cboFilterPayment"
        Me.cboFilterPayment.Size = New System.Drawing.Size(243, 39)
        Me.cboFilterPayment.TabIndex = 10
        '
        'btnAddOrder
        '
        Me.btnAddOrder.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnAddOrder.FlatAppearance.BorderSize = 0
        Me.btnAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddOrder.ForeColor = System.Drawing.Color.White
        Me.btnAddOrder.Location = New System.Drawing.Point(798, 46)
        Me.btnAddOrder.Name = "btnAddOrder"
        Me.btnAddOrder.Size = New System.Drawing.Size(243, 58)
        Me.btnAddOrder.TabIndex = 24
        Me.btnAddOrder.Text = "+ Add Order"
        Me.btnAddOrder.UseVisualStyleBackColor = False
        '
        'lsvOrders
        '
        Me.lsvOrders.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.lsvOrders.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvOrders.HideSelection = False
        Me.lsvOrders.Location = New System.Drawing.Point(26, 197)
        Me.lsvOrders.Name = "lsvOrders"
        Me.lsvOrders.Size = New System.Drawing.Size(1015, 461)
        Me.lsvOrders.TabIndex = 25
        Me.lsvOrders.UseCompatibleStateImageBehavior = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Customer"
        '
        'cboFilterPickup
        '
        Me.cboFilterPickup.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFilterPickup.FormattingEnabled = True
        Me.cboFilterPickup.Items.AddRange(New Object() {"Pending", "Picked-up", "Delivered"})
        Me.cboFilterPickup.Location = New System.Drawing.Point(525, 137)
        Me.cboFilterPickup.Name = "cboFilterPickup"
        Me.cboFilterPickup.Size = New System.Drawing.Size(256, 39)
        Me.cboFilterPickup.TabIndex = 26
        '
        'frmSalesDelivery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1072, 694)
        Me.Controls.Add(Me.cboFilterPickup)
        Me.Controls.Add(Me.lsvOrders)
        Me.Controls.Add(Me.btnAddOrder)
        Me.Controls.Add(Me.cboFilterPayment)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lblCustomers)
        Me.Name = "frmSalesDelivery"
        Me.Text = "frmSalesDelivery"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCustomers As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboFilterPayment As ComboBox
    Friend WithEvents btnAddOrder As Button
    Friend WithEvents lsvOrders As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents cboFilterPickup As ComboBox
End Class
