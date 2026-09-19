<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddSalesOrder
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
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboPaymentStatus = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboPaymentMode = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblLineTotal3 = New System.Windows.Forms.Label()
        Me.lblLineTotal2 = New System.Windows.Forms.Label()
        Me.nudUnitPrice3 = New System.Windows.Forms.NumericUpDown()
        Me.nudUnitPrice2 = New System.Windows.Forms.NumericUpDown()
        Me.nudQuantity3 = New System.Windows.Forms.NumericUpDown()
        Me.cboProduct3 = New System.Windows.Forms.ComboBox()
        Me.nudQuantity2 = New System.Windows.Forms.NumericUpDown()
        Me.cboProduct2 = New System.Windows.Forms.ComboBox()
        Me.lblLineTotal1 = New System.Windows.Forms.Label()
        Me.nudUnitPrice1 = New System.Windows.Forms.NumericUpDown()
        Me.nudQuantity1 = New System.Windows.Forms.NumericUpDown()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboProduct1 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboPickupStatus = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblCustomers = New System.Windows.Forms.Label()
        Me.cboCustomer = New System.Windows.Forms.ComboBox()
        Me.dtpOrderDate = New System.Windows.Forms.DateTimePicker()
        Me.errorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.nudUnitPrice3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudUnitPrice2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudQuantity3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudQuantity2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudUnitPrice1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudQuantity1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(764, 608)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(109, 42)
        Me.btnCancel.TabIndex = 40
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(889, 608)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(149, 42)
        Me.btnSave.TabIndex = 39
        Me.btnSave.Text = "Save Order"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(996, 549)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(42, 29)
        Me.lblTotal.TabIndex = 38
        Me.lblTotal.Text = "₱0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(987, 517)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 24)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Total"
        '
        'cboPaymentStatus
        '
        Me.cboPaymentStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPaymentStatus.FormattingEnabled = True
        Me.cboPaymentStatus.Items.AddRange(New Object() {"Unpaid", "Paid"})
        Me.cboPaymentStatus.Location = New System.Drawing.Point(326, 545)
        Me.cboPaymentStatus.Name = "cboPaymentStatus"
        Me.cboPaymentStatus.Size = New System.Drawing.Size(254, 39)
        Me.cboPaymentStatus.TabIndex = 36
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(321, 513)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(178, 29)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Payment Status"
        '
        'cboPaymentMode
        '
        Me.cboPaymentMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPaymentMode.FormattingEnabled = True
        Me.cboPaymentMode.Items.AddRange(New Object() {"Cash", "Card"})
        Me.cboPaymentMode.Location = New System.Drawing.Point(23, 545)
        Me.cboPaymentMode.Name = "cboPaymentMode"
        Me.cboPaymentMode.Size = New System.Drawing.Size(254, 39)
        Me.cboPaymentMode.TabIndex = 34
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 513)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(174, 29)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Payment Mode"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.lblLineTotal3)
        Me.Panel1.Controls.Add(Me.lblLineTotal2)
        Me.Panel1.Controls.Add(Me.nudUnitPrice3)
        Me.Panel1.Controls.Add(Me.nudUnitPrice2)
        Me.Panel1.Controls.Add(Me.nudQuantity3)
        Me.Panel1.Controls.Add(Me.cboProduct3)
        Me.Panel1.Controls.Add(Me.nudQuantity2)
        Me.Panel1.Controls.Add(Me.cboProduct2)
        Me.Panel1.Controls.Add(Me.lblLineTotal1)
        Me.Panel1.Controls.Add(Me.nudUnitPrice1)
        Me.Panel1.Controls.Add(Me.nudQuantity1)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.cboProduct1)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Location = New System.Drawing.Point(23, 227)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1015, 257)
        Me.Panel1.TabIndex = 32
        '
        'lblLineTotal3
        '
        Me.lblLineTotal3.AutoSize = True
        Me.lblLineTotal3.BackColor = System.Drawing.Color.Transparent
        Me.lblLineTotal3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLineTotal3.Location = New System.Drawing.Point(737, 166)
        Me.lblLineTotal3.Name = "lblLineTotal3"
        Me.lblLineTotal3.Size = New System.Drawing.Size(33, 24)
        Me.lblLineTotal3.TabIndex = 34
        Me.lblLineTotal3.Text = "₱0"
        '
        'lblLineTotal2
        '
        Me.lblLineTotal2.AutoSize = True
        Me.lblLineTotal2.BackColor = System.Drawing.Color.Transparent
        Me.lblLineTotal2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLineTotal2.Location = New System.Drawing.Point(737, 110)
        Me.lblLineTotal2.Name = "lblLineTotal2"
        Me.lblLineTotal2.Size = New System.Drawing.Size(33, 24)
        Me.lblLineTotal2.TabIndex = 34
        Me.lblLineTotal2.Text = "₱0"
        '
        'nudUnitPrice3
        '
        Me.nudUnitPrice3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudUnitPrice3.Location = New System.Drawing.Point(529, 160)
        Me.nudUnitPrice3.Name = "nudUnitPrice3"
        Me.nudUnitPrice3.Size = New System.Drawing.Size(172, 38)
        Me.nudUnitPrice3.TabIndex = 33
        '
        'nudUnitPrice2
        '
        Me.nudUnitPrice2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudUnitPrice2.Location = New System.Drawing.Point(529, 104)
        Me.nudUnitPrice2.Name = "nudUnitPrice2"
        Me.nudUnitPrice2.Size = New System.Drawing.Size(172, 38)
        Me.nudUnitPrice2.TabIndex = 33
        '
        'nudQuantity3
        '
        Me.nudQuantity3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudQuantity3.Location = New System.Drawing.Point(340, 160)
        Me.nudQuantity3.Name = "nudQuantity3"
        Me.nudQuantity3.Size = New System.Drawing.Size(172, 38)
        Me.nudQuantity3.TabIndex = 32
        '
        'cboProduct3
        '
        Me.cboProduct3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProduct3.FormattingEnabled = True
        Me.cboProduct3.Location = New System.Drawing.Point(18, 160)
        Me.cboProduct3.Name = "cboProduct3"
        Me.cboProduct3.Size = New System.Drawing.Size(307, 39)
        Me.cboProduct3.TabIndex = 31
        '
        'nudQuantity2
        '
        Me.nudQuantity2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudQuantity2.Location = New System.Drawing.Point(340, 104)
        Me.nudQuantity2.Name = "nudQuantity2"
        Me.nudQuantity2.Size = New System.Drawing.Size(172, 38)
        Me.nudQuantity2.TabIndex = 32
        '
        'cboProduct2
        '
        Me.cboProduct2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProduct2.FormattingEnabled = True
        Me.cboProduct2.Location = New System.Drawing.Point(18, 104)
        Me.cboProduct2.Name = "cboProduct2"
        Me.cboProduct2.Size = New System.Drawing.Size(307, 39)
        Me.cboProduct2.TabIndex = 31
        '
        'lblLineTotal1
        '
        Me.lblLineTotal1.AutoSize = True
        Me.lblLineTotal1.BackColor = System.Drawing.Color.Transparent
        Me.lblLineTotal1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLineTotal1.Location = New System.Drawing.Point(737, 57)
        Me.lblLineTotal1.Name = "lblLineTotal1"
        Me.lblLineTotal1.Size = New System.Drawing.Size(33, 24)
        Me.lblLineTotal1.TabIndex = 30
        Me.lblLineTotal1.Text = "₱0"
        '
        'nudUnitPrice1
        '
        Me.nudUnitPrice1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudUnitPrice1.Location = New System.Drawing.Point(529, 51)
        Me.nudUnitPrice1.Name = "nudUnitPrice1"
        Me.nudUnitPrice1.Size = New System.Drawing.Size(172, 38)
        Me.nudUnitPrice1.TabIndex = 29
        '
        'nudQuantity1
        '
        Me.nudQuantity1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudQuantity1.Location = New System.Drawing.Point(340, 51)
        Me.nudQuantity1.Name = "nudQuantity1"
        Me.nudQuantity1.Size = New System.Drawing.Size(172, 38)
        Me.nudQuantity1.TabIndex = 28
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(737, 17)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 24)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Line Total"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(525, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 24)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Unit Price"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(336, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 24)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Qty"
        '
        'cboProduct1
        '
        Me.cboProduct1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProduct1.FormattingEnabled = True
        Me.cboProduct1.Location = New System.Drawing.Point(18, 51)
        Me.cboProduct1.Name = "cboProduct1"
        Me.cboProduct1.Size = New System.Drawing.Size(307, 39)
        Me.cboProduct1.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(14, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 24)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Product"
        '
        'cboPickupStatus
        '
        Me.cboPickupStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPickupStatus.FormattingEnabled = True
        Me.cboPickupStatus.Items.AddRange(New Object() {"Pending", "Picked-up", "Delivered"})
        Me.cboPickupStatus.Location = New System.Drawing.Point(784, 163)
        Me.cboPickupStatus.Name = "cboPickupStatus"
        Me.cboPickupStatus.Size = New System.Drawing.Size(254, 39)
        Me.cboPickupStatus.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(779, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 29)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Pickup Status"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(512, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 29)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Order Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 29)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Customer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(483, 31)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Record a pickup or delivery transaction"
        '
        'lblCustomers
        '
        Me.lblCustomers.AutoSize = True
        Me.lblCustomers.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomers.Location = New System.Drawing.Point(9, 18)
        Me.lblCustomers.Name = "lblCustomers"
        Me.lblCustomers.Size = New System.Drawing.Size(656, 61)
        Me.lblCustomers.TabIndex = 24
        Me.lblCustomers.Text = "New sales / delivery order"
        '
        'cboCustomer
        '
        Me.cboCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCustomer.FormattingEnabled = True
        Me.cboCustomer.Location = New System.Drawing.Point(23, 163)
        Me.cboCustomer.Name = "cboCustomer"
        Me.cboCustomer.Size = New System.Drawing.Size(451, 39)
        Me.cboCustomer.TabIndex = 41
        '
        'dtpOrderDate
        '
        Me.dtpOrderDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpOrderDate.Location = New System.Drawing.Point(517, 163)
        Me.dtpOrderDate.Name = "dtpOrderDate"
        Me.dtpOrderDate.Size = New System.Drawing.Size(225, 38)
        Me.dtpOrderDate.TabIndex = 42
        '
        'errorProvider1
        '
        Me.errorProvider1.ContainerControl = Me
        '
        'frmAddSalesOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1072, 694)
        Me.Controls.Add(Me.dtpOrderDate)
        Me.Controls.Add(Me.cboCustomer)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboPaymentStatus)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboPaymentMode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cboPickupStatus)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblCustomers)
        Me.Name = "frmAddSalesOrder"
        Me.Text = "frmAddSalesOrder"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.nudUnitPrice3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudUnitPrice2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudQuantity3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudQuantity2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudUnitPrice1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudQuantity1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cboPaymentStatus As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cboPaymentMode As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblLineTotal3 As Label
    Friend WithEvents lblLineTotal2 As Label
    Friend WithEvents nudUnitPrice3 As NumericUpDown
    Friend WithEvents nudUnitPrice2 As NumericUpDown
    Friend WithEvents nudQuantity3 As NumericUpDown
    Friend WithEvents cboProduct3 As ComboBox
    Friend WithEvents nudQuantity2 As NumericUpDown
    Friend WithEvents cboProduct2 As ComboBox
    Friend WithEvents lblLineTotal1 As Label
    Friend WithEvents nudUnitPrice1 As NumericUpDown
    Friend WithEvents nudQuantity1 As NumericUpDown
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cboProduct1 As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cboPickupStatus As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblCustomers As Label
    Friend WithEvents cboCustomer As ComboBox
    Friend WithEvents dtpOrderDate As DateTimePicker
    Friend WithEvents errorProvider1 As ErrorProvider
End Class
