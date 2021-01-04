<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesReportForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SalesReportForm))
        Me.btnDailyReportsCompilation = New System.Windows.Forms.Button()
        Me.btnTodaysReport = New System.Windows.Forms.Button()
        Me.btnWeeklyReport = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDailyReportsCompilation
        '
        Me.btnDailyReportsCompilation.AccessibleDescription = "inventbutton"
        Me.btnDailyReportsCompilation.AccessibleName = "inventbutton"
        Me.btnDailyReportsCompilation.BackColor = System.Drawing.Color.Black
        Me.btnDailyReportsCompilation.ForeColor = System.Drawing.Color.White
        Me.btnDailyReportsCompilation.Location = New System.Drawing.Point(227, 439)
        Me.btnDailyReportsCompilation.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDailyReportsCompilation.Name = "btnDailyReportsCompilation"
        Me.btnDailyReportsCompilation.Size = New System.Drawing.Size(170, 45)
        Me.btnDailyReportsCompilation.TabIndex = 9
        Me.btnDailyReportsCompilation.Text = "DailyReports"
        Me.btnDailyReportsCompilation.UseVisualStyleBackColor = False
        '
        'btnTodaysReport
        '
        Me.btnTodaysReport.AccessibleDescription = "inventbutton"
        Me.btnTodaysReport.AccessibleName = "inventbutton"
        Me.btnTodaysReport.BackColor = System.Drawing.Color.Black
        Me.btnTodaysReport.ForeColor = System.Drawing.Color.White
        Me.btnTodaysReport.Location = New System.Drawing.Point(43, 439)
        Me.btnTodaysReport.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTodaysReport.Name = "btnTodaysReport"
        Me.btnTodaysReport.Size = New System.Drawing.Size(170, 45)
        Me.btnTodaysReport.TabIndex = 10
        Me.btnTodaysReport.Text = "Today's Report"
        Me.btnTodaysReport.UseVisualStyleBackColor = False
        '
        'btnWeeklyReport
        '
        Me.btnWeeklyReport.AccessibleDescription = "inventbutton"
        Me.btnWeeklyReport.AccessibleName = "inventbutton"
        Me.btnWeeklyReport.BackColor = System.Drawing.Color.Black
        Me.btnWeeklyReport.ForeColor = System.Drawing.Color.White
        Me.btnWeeklyReport.Location = New System.Drawing.Point(412, 439)
        Me.btnWeeklyReport.Margin = New System.Windows.Forms.Padding(2)
        Me.btnWeeklyReport.Name = "btnWeeklyReport"
        Me.btnWeeklyReport.Size = New System.Drawing.Size(170, 45)
        Me.btnWeeklyReport.TabIndex = 11
        Me.btnWeeklyReport.Text = "Weekly Report"
        Me.btnWeeklyReport.UseVisualStyleBackColor = False
        '
        'SalesReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(623, 536)
        Me.Controls.Add(Me.btnWeeklyReport)
        Me.Controls.Add(Me.btnTodaysReport)
        Me.Controls.Add(Me.btnDailyReportsCompilation)
        Me.Name = "SalesReportForm"
        Me.Text = "SalesReportForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDailyReportsCompilation As Button
    Friend WithEvents btnTodaysReport As Button
    Friend WithEvents btnWeeklyReport As Button
End Class
