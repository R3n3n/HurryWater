<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuBoard
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
        Me.SplitContainerMain = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDashboard = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnCustomers = New System.Windows.Forms.Button()
        Me.btnSalesDelivery = New System.Windows.Forms.Button()
        Me.btnProduction = New System.Windows.Forms.Button()
        Me.btnInventory = New System.Windows.Forms.Button()
        Me.btnExpenses = New System.Windows.Forms.Button()
        Me.btnDispenserBorrowing = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnUserManagement = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.SplitContainerMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerMain.Panel1.SuspendLayout()
        Me.SplitContainerMain.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainerMain
        '
        Me.SplitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerMain.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerMain.Name = "SplitContainerMain"
        '
        'SplitContainerMain.Panel1
        '
        Me.SplitContainerMain.Panel1.BackColor = System.Drawing.Color.DarkBlue
        Me.SplitContainerMain.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.SplitContainerMain.Panel1.ForeColor = System.Drawing.Color.Black
        Me.SplitContainerMain.Size = New System.Drawing.Size(1358, 871)
        Me.SplitContainerMain.SplitterDistance = 244
        Me.SplitContainerMain.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txtDashboard, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(244, 871)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(56, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Username"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtDashboard
        '
        Me.txtDashboard.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtDashboard.FlatAppearance.BorderSize = 0
        Me.txtDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDashboard.ForeColor = System.Drawing.Color.White
        Me.txtDashboard.Location = New System.Drawing.Point(3, 173)
        Me.txtDashboard.Name = "txtDashboard"
        Me.txtDashboard.Size = New System.Drawing.Size(238, 59)
        Me.txtDashboard.TabIndex = 6
        Me.txtDashboard.Text = "Dashboard"
        Me.txtDashboard.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.txtDashboard.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnUserManagement, 0, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.btnReports, 0, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.btnDispenserBorrowing, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.btnExpenses, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.btnInventory, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.btnProduction, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.btnSalesDelivery, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.btnCustomers, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 238)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 8
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.50328!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(238, 630)
        Me.TableLayoutPanel2.TabIndex = 7
        '
        'btnCustomers
        '
        Me.btnCustomers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCustomers.FlatAppearance.BorderSize = 0
        Me.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomers.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomers.ForeColor = System.Drawing.Color.White
        Me.btnCustomers.Location = New System.Drawing.Point(3, 3)
        Me.btnCustomers.Name = "btnCustomers"
        Me.btnCustomers.Size = New System.Drawing.Size(232, 72)
        Me.btnCustomers.TabIndex = 7
        Me.btnCustomers.Text = "Customers"
        Me.btnCustomers.UseVisualStyleBackColor = True
        '
        'btnSalesDelivery
        '
        Me.btnSalesDelivery.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSalesDelivery.FlatAppearance.BorderSize = 0
        Me.btnSalesDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalesDelivery.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalesDelivery.ForeColor = System.Drawing.Color.White
        Me.btnSalesDelivery.Location = New System.Drawing.Point(3, 81)
        Me.btnSalesDelivery.Name = "btnSalesDelivery"
        Me.btnSalesDelivery.Size = New System.Drawing.Size(232, 72)
        Me.btnSalesDelivery.TabIndex = 8
        Me.btnSalesDelivery.Text = "Sales / Delivery"
        Me.btnSalesDelivery.UseVisualStyleBackColor = True
        '
        'btnProduction
        '
        Me.btnProduction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnProduction.FlatAppearance.BorderSize = 0
        Me.btnProduction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProduction.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProduction.ForeColor = System.Drawing.Color.White
        Me.btnProduction.Location = New System.Drawing.Point(3, 159)
        Me.btnProduction.Name = "btnProduction"
        Me.btnProduction.Size = New System.Drawing.Size(232, 72)
        Me.btnProduction.TabIndex = 9
        Me.btnProduction.Text = "Production"
        Me.btnProduction.UseVisualStyleBackColor = True
        '
        'btnInventory
        '
        Me.btnInventory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnInventory.FlatAppearance.BorderSize = 0
        Me.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventory.ForeColor = System.Drawing.Color.White
        Me.btnInventory.Location = New System.Drawing.Point(3, 237)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(232, 72)
        Me.btnInventory.TabIndex = 10
        Me.btnInventory.Text = "Inventory"
        Me.btnInventory.UseVisualStyleBackColor = True
        '
        'btnExpenses
        '
        Me.btnExpenses.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnExpenses.FlatAppearance.BorderSize = 0
        Me.btnExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExpenses.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpenses.ForeColor = System.Drawing.Color.White
        Me.btnExpenses.Location = New System.Drawing.Point(3, 315)
        Me.btnExpenses.Name = "btnExpenses"
        Me.btnExpenses.Size = New System.Drawing.Size(232, 72)
        Me.btnExpenses.TabIndex = 11
        Me.btnExpenses.Text = "Expenses"
        Me.btnExpenses.UseVisualStyleBackColor = True
        '
        'btnDispenserBorrowing
        '
        Me.btnDispenserBorrowing.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDispenserBorrowing.FlatAppearance.BorderSize = 0
        Me.btnDispenserBorrowing.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDispenserBorrowing.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDispenserBorrowing.ForeColor = System.Drawing.Color.White
        Me.btnDispenserBorrowing.Location = New System.Drawing.Point(3, 393)
        Me.btnDispenserBorrowing.Name = "btnDispenserBorrowing"
        Me.btnDispenserBorrowing.Size = New System.Drawing.Size(232, 72)
        Me.btnDispenserBorrowing.TabIndex = 12
        Me.btnDispenserBorrowing.Text = "Dispenser Borrowing"
        Me.btnDispenserBorrowing.UseVisualStyleBackColor = True
        '
        'btnReports
        '
        Me.btnReports.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnReports.FlatAppearance.BorderSize = 0
        Me.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReports.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReports.ForeColor = System.Drawing.Color.White
        Me.btnReports.Location = New System.Drawing.Point(3, 471)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(232, 72)
        Me.btnReports.TabIndex = 13
        Me.btnReports.Text = "Reports"
        Me.btnReports.UseVisualStyleBackColor = True
        '
        'btnUserManagement
        '
        Me.btnUserManagement.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnUserManagement.FlatAppearance.BorderSize = 0
        Me.btnUserManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUserManagement.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserManagement.ForeColor = System.Drawing.Color.White
        Me.btnUserManagement.Location = New System.Drawing.Point(3, 549)
        Me.btnUserManagement.Name = "btnUserManagement"
        Me.btnUserManagement.Size = New System.Drawing.Size(232, 78)
        Me.btnUserManagement.TabIndex = 14
        Me.btnUserManagement.Text = "User Management"
        Me.btnUserManagement.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox1.Image = Global.HurryWater.My.Resources.Resources.AccountLogo
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(238, 87)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'frmMenuBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1358, 871)
        Me.Controls.Add(Me.SplitContainerMain)
        Me.Name = "frmMenuBoard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMenuBoard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainerMain.Panel1.ResumeLayout(False)
        CType(Me.SplitContainerMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerMain.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainerMain As SplitContainer
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDashboard As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnCustomers As Button
    Friend WithEvents btnSalesDelivery As Button
    Friend WithEvents btnProduction As Button
    Friend WithEvents btnInventory As Button
    Friend WithEvents btnExpenses As Button
    Friend WithEvents btnDispenserBorrowing As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnUserManagement As Button
End Class
