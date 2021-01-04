<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WeeklyReportForms
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WeeklyReportForms))
        Me.dgvWeeklyReport = New System.Windows.Forms.DataGridView()
        Me.CSystemDataSet1 = New Cashiering_System01.CSystemDataSet1()
        Me.DailyReporttblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DailyReporttblTableAdapter = New Cashiering_System01.CSystemDataSet1TableAdapters.DailyReporttblTableAdapter()
        Me.WeekNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DailyEarningDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblWeeklyEarning = New System.Windows.Forms.Label()
        Me.lblWeekNumber = New System.Windows.Forms.Label()
        Me.tbxWeekNumber = New System.Windows.Forms.TextBox()
        Me.btnGetReport = New System.Windows.Forms.Button()
        CType(Me.dgvWeeklyReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CSystemDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DailyReporttblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvWeeklyReport
        '
        Me.dgvWeeklyReport.AutoGenerateColumns = False
        Me.dgvWeeklyReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvWeeklyReport.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.WeekNumberDataGridViewTextBoxColumn, Me.DailyEarningDataGridViewTextBoxColumn})
        Me.dgvWeeklyReport.DataSource = Me.DailyReporttblBindingSource
        Me.dgvWeeklyReport.Location = New System.Drawing.Point(328, 28)
        Me.dgvWeeklyReport.Name = "dgvWeeklyReport"
        Me.dgvWeeklyReport.Size = New System.Drawing.Size(242, 396)
        Me.dgvWeeklyReport.TabIndex = 0
        '
        'CSystemDataSet1
        '
        Me.CSystemDataSet1.DataSetName = "CSystemDataSet1"
        Me.CSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DailyReporttblBindingSource
        '
        Me.DailyReporttblBindingSource.DataMember = "DailyReporttbl"
        Me.DailyReporttblBindingSource.DataSource = Me.CSystemDataSet1
        '
        'DailyReporttblTableAdapter
        '
        Me.DailyReporttblTableAdapter.ClearBeforeFill = True
        '
        'WeekNumberDataGridViewTextBoxColumn
        '
        Me.WeekNumberDataGridViewTextBoxColumn.DataPropertyName = "WeekNumber"
        Me.WeekNumberDataGridViewTextBoxColumn.HeaderText = "WeekNumber"
        Me.WeekNumberDataGridViewTextBoxColumn.Name = "WeekNumberDataGridViewTextBoxColumn"
        '
        'DailyEarningDataGridViewTextBoxColumn
        '
        Me.DailyEarningDataGridViewTextBoxColumn.DataPropertyName = "DailyEarning"
        Me.DailyEarningDataGridViewTextBoxColumn.HeaderText = "DailyEarning"
        Me.DailyEarningDataGridViewTextBoxColumn.Name = "DailyEarningDataGridViewTextBoxColumn"
        '
        'lblWeeklyEarning
        '
        Me.lblWeeklyEarning.AutoSize = True
        Me.lblWeeklyEarning.BackColor = System.Drawing.Color.Tan
        Me.lblWeeklyEarning.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblWeeklyEarning.Location = New System.Drawing.Point(11, 78)
        Me.lblWeeklyEarning.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblWeeklyEarning.Name = "lblWeeklyEarning"
        Me.lblWeeklyEarning.Size = New System.Drawing.Size(205, 24)
        Me.lblWeeklyEarning.TabIndex = 4
        Me.lblWeeklyEarning.Text = "Weekly Earning : P 0"
        '
        'lblWeekNumber
        '
        Me.lblWeekNumber.AutoSize = True
        Me.lblWeekNumber.BackColor = System.Drawing.Color.Tan
        Me.lblWeekNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblWeekNumber.Location = New System.Drawing.Point(11, 145)
        Me.lblWeekNumber.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblWeekNumber.Name = "lblWeekNumber"
        Me.lblWeekNumber.Size = New System.Drawing.Size(95, 24)
        Me.lblWeekNumber.TabIndex = 5
        Me.lblWeekNumber.Text = "Weekly #"
        '
        'tbxWeekNumber
        '
        Me.tbxWeekNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.tbxWeekNumber.Location = New System.Drawing.Point(120, 139)
        Me.tbxWeekNumber.MinimumSize = New System.Drawing.Size(60, 30)
        Me.tbxWeekNumber.Name = "tbxWeekNumber"
        Me.tbxWeekNumber.Size = New System.Drawing.Size(87, 30)
        Me.tbxWeekNumber.TabIndex = 10
        '
        'btnGetReport
        '
        Me.btnGetReport.BackColor = System.Drawing.Color.Green
        Me.btnGetReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnGetReport.ForeColor = System.Drawing.Color.White
        Me.btnGetReport.Location = New System.Drawing.Point(10, 205)
        Me.btnGetReport.Name = "btnGetReport"
        Me.btnGetReport.Size = New System.Drawing.Size(141, 45)
        Me.btnGetReport.TabIndex = 11
        Me.btnGetReport.Text = "Get Report"
        Me.btnGetReport.UseVisualStyleBackColor = False
        '
        'WeeklyReportForms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(582, 450)
        Me.Controls.Add(Me.btnGetReport)
        Me.Controls.Add(Me.tbxWeekNumber)
        Me.Controls.Add(Me.lblWeekNumber)
        Me.Controls.Add(Me.lblWeeklyEarning)
        Me.Controls.Add(Me.dgvWeeklyReport)
        Me.Name = "WeeklyReportForms"
        Me.Text = "WeeklyReportForms"
        CType(Me.dgvWeeklyReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CSystemDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DailyReporttblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvWeeklyReport As DataGridView
    Friend WithEvents CSystemDataSet1 As CSystemDataSet1
    Friend WithEvents DailyReporttblBindingSource As BindingSource
    Friend WithEvents DailyReporttblTableAdapter As CSystemDataSet1TableAdapters.DailyReporttblTableAdapter
    Friend WithEvents WeekNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DailyEarningDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents lblWeeklyEarning As Label
    Friend WithEvents lblWeekNumber As Label
    Friend WithEvents tbxWeekNumber As TextBox
    Friend WithEvents btnGetReport As Button
End Class
