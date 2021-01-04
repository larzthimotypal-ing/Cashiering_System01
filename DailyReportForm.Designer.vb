<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DailyReportForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblTodaysReport = New System.Windows.Forms.Label()
        Me.WeektblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WeeklyReporttblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvTodaysTransaction = New System.Windows.Forms.DataGridView()
        Me.CSystemDataSet = New Cashiering_System01.CSystemDataSet()
        Me.CSystemDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransactiontblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransactiontblTableAdapter = New Cashiering_System01.CSystemDataSetTableAdapters.TransactiontblTableAdapter()
        Me.CSystemDataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemPurchasetblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemPurchasetblTableAdapter = New Cashiering_System01.CSystemDataSetTableAdapters.ItemPurchasetblTableAdapter()
        Me.TransactiontblBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CSystemDataSetBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransactiontblBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblDailyEarning = New System.Windows.Forms.Label()
        Me.btnRecord = New System.Windows.Forms.Button()
        Me.lblWeekNumber = New System.Windows.Forms.Label()
        Me.tbxWeekNumber = New System.Windows.Forms.TextBox()
        CType(Me.WeektblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WeeklyReporttblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTodaysTransaction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CSystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CSystemDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransactiontblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CSystemDataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemPurchasetblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransactiontblBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CSystemDataSetBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransactiontblBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTodaysReport
        '
        Me.lblTodaysReport.AutoSize = True
        Me.lblTodaysReport.BackColor = System.Drawing.Color.Tan
        Me.lblTodaysReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTodaysReport.Location = New System.Drawing.Point(11, 26)
        Me.lblTodaysReport.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTodaysReport.Name = "lblTodaysReport"
        Me.lblTodaysReport.Size = New System.Drawing.Size(198, 24)
        Me.lblTodaysReport.TabIndex = 1
        Me.lblTodaysReport.Text = "Today's Transaction"
        '
        'dgvTodaysTransaction
        '
        Me.dgvTodaysTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTodaysTransaction.Location = New System.Drawing.Point(12, 68)
        Me.dgvTodaysTransaction.Name = "dgvTodaysTransaction"
        Me.dgvTodaysTransaction.Size = New System.Drawing.Size(435, 347)
        Me.dgvTodaysTransaction.TabIndex = 2
        '
        'CSystemDataSet
        '
        Me.CSystemDataSet.DataSetName = "CSystemDataSet"
        Me.CSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CSystemDataSetBindingSource
        '
        Me.CSystemDataSetBindingSource.DataSource = Me.CSystemDataSet
        Me.CSystemDataSetBindingSource.Position = 0
        '
        'TransactiontblBindingSource
        '
        Me.TransactiontblBindingSource.DataMember = "Transactiontbl"
        Me.TransactiontblBindingSource.DataSource = Me.CSystemDataSetBindingSource
        '
        'TransactiontblTableAdapter
        '
        Me.TransactiontblTableAdapter.ClearBeforeFill = True
        '
        'CSystemDataSetBindingSource1
        '
        Me.CSystemDataSetBindingSource1.DataSource = Me.CSystemDataSet
        Me.CSystemDataSetBindingSource1.Position = 0
        '
        'ItemPurchasetblBindingSource
        '
        Me.ItemPurchasetblBindingSource.DataMember = "ItemPurchasetbl"
        Me.ItemPurchasetblBindingSource.DataSource = Me.CSystemDataSetBindingSource1
        '
        'ItemPurchasetblTableAdapter
        '
        Me.ItemPurchasetblTableAdapter.ClearBeforeFill = True
        '
        'TransactiontblBindingSource1
        '
        Me.TransactiontblBindingSource1.DataMember = "Transactiontbl"
        Me.TransactiontblBindingSource1.DataSource = Me.CSystemDataSet
        '
        'CSystemDataSetBindingSource2
        '
        Me.CSystemDataSetBindingSource2.DataSource = Me.CSystemDataSet
        Me.CSystemDataSetBindingSource2.Position = 0
        '
        'TransactiontblBindingSource2
        '
        Me.TransactiontblBindingSource2.DataMember = "Transactiontbl"
        Me.TransactiontblBindingSource2.DataSource = Me.CSystemDataSetBindingSource2
        '
        'lblDailyEarning
        '
        Me.lblDailyEarning.AutoSize = True
        Me.lblDailyEarning.BackColor = System.Drawing.Color.Tan
        Me.lblDailyEarning.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblDailyEarning.Location = New System.Drawing.Point(27, 451)
        Me.lblDailyEarning.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDailyEarning.Name = "lblDailyEarning"
        Me.lblDailyEarning.Size = New System.Drawing.Size(182, 24)
        Me.lblDailyEarning.TabIndex = 3
        Me.lblDailyEarning.Text = "Daily Earning : P 0"
        '
        'btnRecord
        '
        Me.btnRecord.BackColor = System.Drawing.Color.Green
        Me.btnRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnRecord.ForeColor = System.Drawing.Color.White
        Me.btnRecord.Location = New System.Drawing.Point(350, 497)
        Me.btnRecord.Name = "btnRecord"
        Me.btnRecord.Size = New System.Drawing.Size(96, 45)
        Me.btnRecord.TabIndex = 6
        Me.btnRecord.Text = "Record"
        Me.btnRecord.UseVisualStyleBackColor = False
        '
        'lblWeekNumber
        '
        Me.lblWeekNumber.AutoSize = True
        Me.lblWeekNumber.BackColor = System.Drawing.Color.Tan
        Me.lblWeekNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblWeekNumber.Location = New System.Drawing.Point(158, 506)
        Me.lblWeekNumber.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblWeekNumber.Name = "lblWeekNumber"
        Me.lblWeekNumber.Size = New System.Drawing.Size(80, 24)
        Me.lblWeekNumber.TabIndex = 10
        Me.lblWeekNumber.Text = "Week #"
        '
        'tbxWeekNumber
        '
        Me.tbxWeekNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.tbxWeekNumber.Location = New System.Drawing.Point(243, 503)
        Me.tbxWeekNumber.MinimumSize = New System.Drawing.Size(60, 30)
        Me.tbxWeekNumber.Name = "tbxWeekNumber"
        Me.tbxWeekNumber.Size = New System.Drawing.Size(87, 30)
        Me.tbxWeekNumber.TabIndex = 9
        '
        'SalesReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.Cashiering_System01.My.Resources.Resources.plain_
        Me.ClientSize = New System.Drawing.Size(458, 554)
        Me.Controls.Add(Me.lblWeekNumber)
        Me.Controls.Add(Me.tbxWeekNumber)
        Me.Controls.Add(Me.btnRecord)
        Me.Controls.Add(Me.lblDailyEarning)
        Me.Controls.Add(Me.dgvTodaysTransaction)
        Me.Controls.Add(Me.lblTodaysReport)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "SalesReportForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SALES REPORT"
        CType(Me.WeektblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WeeklyReporttblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTodaysTransaction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CSystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CSystemDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransactiontblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CSystemDataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemPurchasetblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransactiontblBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CSystemDataSetBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransactiontblBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTodaysReport As Label
    Friend WithEvents WeektblBindingSource As BindingSource
    Friend WithEvents WeekNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MonNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TuesNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WedNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ThursNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FriNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WeeklyReporttblBindingSource As BindingSource
    Friend WithEvents WeeklyNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WeekNoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TotalOfSoldItemsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalEarningsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents dgvTodaysTransaction As DataGridView
    Friend WithEvents CSystemDataSetBindingSource As BindingSource
    Friend WithEvents CSystemDataSet As CSystemDataSet
    Friend WithEvents TransactiontblBindingSource As BindingSource
    Friend WithEvents TransactiontblTableAdapter As CSystemDataSetTableAdapters.TransactiontblTableAdapter
    Friend WithEvents CSystemDataSetBindingSource1 As BindingSource
    Friend WithEvents ItemPurchasetblBindingSource As BindingSource
    Friend WithEvents ItemPurchasetblTableAdapter As CSystemDataSetTableAdapters.ItemPurchasetblTableAdapter
    Friend WithEvents TransactiontblBindingSource1 As BindingSource
    Friend WithEvents CSystemDataSetBindingSource2 As BindingSource
    Friend WithEvents TransactiontblBindingSource2 As BindingSource
    Friend WithEvents lblDailyEarning As Label
    Friend WithEvents btnRecord As Button
    Friend WithEvents lblWeekNumber As Label
    Friend WithEvents tbxWeekNumber As TextBox
End Class
