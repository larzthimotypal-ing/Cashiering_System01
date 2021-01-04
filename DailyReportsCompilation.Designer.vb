<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DailyReportsCompilation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DailyReportsCompilation))
        Me.dgvDailyReportsCompilation = New System.Windows.Forms.DataGridView()
        Me.DailyReportIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WeekNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DailyEarningDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DailyReporttblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CSystemDataSet1 = New Cashiering_System01.CSystemDataSet1()
        Me.DailyReporttblTableAdapter = New Cashiering_System01.CSystemDataSet1TableAdapters.DailyReporttblTableAdapter()
        CType(Me.dgvDailyReportsCompilation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DailyReporttblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CSystemDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDailyReportsCompilation
        '
        Me.dgvDailyReportsCompilation.AutoGenerateColumns = False
        Me.dgvDailyReportsCompilation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDailyReportsCompilation.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DailyReportIDDataGridViewTextBoxColumn, Me.WeekNumberDataGridViewTextBoxColumn, Me.DailyEarningDataGridViewTextBoxColumn})
        Me.dgvDailyReportsCompilation.DataSource = Me.DailyReporttblBindingSource
        Me.dgvDailyReportsCompilation.Location = New System.Drawing.Point(12, 48)
        Me.dgvDailyReportsCompilation.Name = "dgvDailyReportsCompilation"
        Me.dgvDailyReportsCompilation.Size = New System.Drawing.Size(344, 390)
        Me.dgvDailyReportsCompilation.TabIndex = 0
        '
        'DailyReportIDDataGridViewTextBoxColumn
        '
        Me.DailyReportIDDataGridViewTextBoxColumn.DataPropertyName = "DailyReportID"
        Me.DailyReportIDDataGridViewTextBoxColumn.HeaderText = "DailyReportID"
        Me.DailyReportIDDataGridViewTextBoxColumn.Name = "DailyReportIDDataGridViewTextBoxColumn"
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
        'DailyReporttblBindingSource
        '
        Me.DailyReporttblBindingSource.DataMember = "DailyReporttbl"
        Me.DailyReporttblBindingSource.DataSource = Me.CSystemDataSet1
        '
        'CSystemDataSet1
        '
        Me.CSystemDataSet1.DataSetName = "CSystemDataSet1"
        Me.CSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DailyReporttblTableAdapter
        '
        Me.DailyReporttblTableAdapter.ClearBeforeFill = True
        '
        'DailyReportsCompilation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(367, 450)
        Me.Controls.Add(Me.dgvDailyReportsCompilation)
        Me.Name = "DailyReportsCompilation"
        Me.Text = "DailyReportsCompilation"
        CType(Me.dgvDailyReportsCompilation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DailyReporttblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CSystemDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvDailyReportsCompilation As DataGridView
    Friend WithEvents CSystemDataSet1 As CSystemDataSet1
    Friend WithEvents DailyReporttblBindingSource As BindingSource
    Friend WithEvents DailyReporttblTableAdapter As CSystemDataSet1TableAdapters.DailyReporttblTableAdapter
    Friend WithEvents DailyReportIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WeekNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DailyEarningDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
