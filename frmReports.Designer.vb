<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReports
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
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.lblCustomers = New System.Windows.Forms.Label()
        Me.cboDateRange = New System.Windows.Forms.ComboBox()
        Me.btnExportCsv = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblNet = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblTotalExpenses = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblUnpaidBalance = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTotalSales = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lsvCustomerSummary = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label13 = New System.Windows.Forms.Label()
        Me.chtSalesTrend = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lsvLowStock = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.chtSalesTrend, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCustomers
        '
        Me.lblCustomers.AutoSize = True
        Me.lblCustomers.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomers.Location = New System.Drawing.Point(13, 24)
        Me.lblCustomers.Name = "lblCustomers"
        Me.lblCustomers.Size = New System.Drawing.Size(219, 61)
        Me.lblCustomers.TabIndex = 13
        Me.lblCustomers.Text = "Reports"
        '
        'cboDateRange
        '
        Me.cboDateRange.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDateRange.FormattingEnabled = True
        Me.cboDateRange.Items.AddRange(New Object() {"Pending", "Picked-up", "Delivered"})
        Me.cboDateRange.Location = New System.Drawing.Point(624, 39)
        Me.cboDateRange.Name = "cboDateRange"
        Me.cboDateRange.Size = New System.Drawing.Size(243, 39)
        Me.cboDateRange.TabIndex = 47
        '
        'btnExportCsv
        '
        Me.btnExportCsv.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnExportCsv.FlatAppearance.BorderSize = 0
        Me.btnExportCsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportCsv.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportCsv.ForeColor = System.Drawing.Color.White
        Me.btnExportCsv.Location = New System.Drawing.Point(891, 39)
        Me.btnExportCsv.Name = "btnExportCsv"
        Me.btnExportCsv.Size = New System.Drawing.Size(152, 39)
        Me.btnExportCsv.TabIndex = 48
        Me.btnExportCsv.Text = "Export"
        Me.btnExportCsv.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel4.Controls.Add(Me.lblNet)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Location = New System.Drawing.Point(805, 107)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(238, 105)
        Me.Panel4.TabIndex = 57
        '
        'lblNet
        '
        Me.lblNet.AutoSize = True
        Me.lblNet.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNet.Location = New System.Drawing.Point(16, 55)
        Me.lblNet.Name = "lblNet"
        Me.lblNet.Size = New System.Drawing.Size(31, 33)
        Me.lblNet.TabIndex = 54
        Me.lblNet.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(17, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 25)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "Net"
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel3.Controls.Add(Me.lblTotalExpenses)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Location = New System.Drawing.Point(543, 107)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(238, 105)
        Me.Panel3.TabIndex = 58
        '
        'lblTotalExpenses
        '
        Me.lblTotalExpenses.AutoSize = True
        Me.lblTotalExpenses.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalExpenses.Location = New System.Drawing.Point(16, 55)
        Me.lblTotalExpenses.Name = "lblTotalExpenses"
        Me.lblTotalExpenses.Size = New System.Drawing.Size(31, 33)
        Me.lblTotalExpenses.TabIndex = 54
        Me.lblTotalExpenses.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 25)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Total Expenses"
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel2.Controls.Add(Me.lblUnpaidBalance)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(281, 107)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(238, 105)
        Me.Panel2.TabIndex = 59
        '
        'lblUnpaidBalance
        '
        Me.lblUnpaidBalance.AutoSize = True
        Me.lblUnpaidBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnpaidBalance.Location = New System.Drawing.Point(15, 55)
        Me.lblUnpaidBalance.Name = "lblUnpaidBalance"
        Me.lblUnpaidBalance.Size = New System.Drawing.Size(31, 33)
        Me.lblUnpaidBalance.TabIndex = 54
        Me.lblUnpaidBalance.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 25)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Unpaid Balance"
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.lblTotalSales)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Location = New System.Drawing.Point(23, 107)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(238, 105)
        Me.Panel1.TabIndex = 56
        '
        'lblTotalSales
        '
        Me.lblTotalSales.AutoSize = True
        Me.lblTotalSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSales.Location = New System.Drawing.Point(16, 55)
        Me.lblTotalSales.Name = "lblTotalSales"
        Me.lblTotalSales.Size = New System.Drawing.Size(31, 33)
        Me.lblTotalSales.TabIndex = 54
        Me.lblTotalSales.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 25)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Total Sales"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 25)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Sales Trend"
        '
        'lsvCustomerSummary
        '
        Me.lsvCustomerSummary.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.lsvCustomerSummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvCustomerSummary.HideSelection = False
        Me.lsvCustomerSummary.Location = New System.Drawing.Point(23, 492)
        Me.lsvCustomerSummary.Name = "lsvCustomerSummary"
        Me.lsvCustomerSummary.Size = New System.Drawing.Size(1020, 164)
        Me.lsvCustomerSummary.TabIndex = 62
        Me.lsvCustomerSummary.UseCompatibleStateImageBehavior = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Customer"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(17, 448)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(270, 31)
        Me.Label13.TabIndex = 63
        Me.Label13.Text = "Customer Summary"
        '
        'chtSalesTrend
        '
        ChartArea3.Name = "ChartArea1"
        Me.chtSalesTrend.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.chtSalesTrend.Legends.Add(Legend3)
        Me.chtSalesTrend.Location = New System.Drawing.Point(22, 49)
        Me.chtSalesTrend.Name = "chtSalesTrend"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Sales"
        Me.chtSalesTrend.Series.Add(Series3)
        Me.chtSalesTrend.Size = New System.Drawing.Size(446, 130)
        Me.chtSalesTrend.TabIndex = 64
        Me.chtSalesTrend.Text = "Chart1"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.chtSalesTrend)
        Me.Panel5.Location = New System.Drawing.Point(23, 240)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(496, 195)
        Me.Panel5.TabIndex = 57
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(737, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 24)
        Me.Label9.TabIndex = 27
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel6.Controls.Add(Me.lsvLowStock)
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Controls.Add(Me.Label8)
        Me.Panel6.Location = New System.Drawing.Point(547, 240)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(496, 195)
        Me.Panel6.TabIndex = 65
        '
        'lsvLowStock
        '
        Me.lsvLowStock.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2})
        Me.lsvLowStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvLowStock.HideSelection = False
        Me.lsvLowStock.Location = New System.Drawing.Point(18, 52)
        Me.lsvLowStock.Name = "lsvLowStock"
        Me.lsvLowStock.Size = New System.Drawing.Size(463, 127)
        Me.lsvLowStock.TabIndex = 66
        Me.lsvLowStock.UseCompatibleStateImageBehavior = False
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Customer"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(737, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 24)
        Me.Label4.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(17, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(169, 25)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Low-Stock Items"
        '
        'frmReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1072, 694)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lsvCustomerSummary)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnExportCsv)
        Me.Controls.Add(Me.cboDateRange)
        Me.Controls.Add(Me.lblCustomers)
        Me.Name = "frmReports"
        Me.Text = "frmReports"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.chtSalesTrend, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCustomers As Label
    Friend WithEvents cboDateRange As ComboBox
    Friend WithEvents btnExportCsv As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblNet As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblTotalExpenses As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblUnpaidBalance As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTotalSales As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lsvCustomerSummary As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents Label13 As Label
    Friend WithEvents chtSalesTrend As DataVisualization.Charting.Chart
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lsvLowStock As ListView
    Friend WithEvents ColumnHeader2 As ColumnHeader
End Class
