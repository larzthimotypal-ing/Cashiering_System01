<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form2
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
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.reportsbutton = New System.Windows.Forms.Button()
        Me.inventbutton = New System.Windows.Forms.Button()
        Me.Logoutbutton = New System.Windows.Forms.Button()
        Me.settingbutton = New System.Windows.Forms.Button()
        Me.voidbutton = New System.Windows.Forms.Button()
        Me.totalbutton = New System.Windows.Forms.Button()
        Me.additembutton = New System.Windows.Forms.Button()
        Me.listviewsearch = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.totaltextbox = New System.Windows.Forms.TextBox()
        Me.searchtextbox = New System.Windows.Forms.TextBox()
        Me.minusbutton = New System.Windows.Forms.Button()
        Me.plusbutton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.searchbuttonone = New System.Windows.Forms.Button()
        Me.searchbuttontwo = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(61, 4)
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.Cashiering_System01.My.Resources.Resources.form1
        Me.GroupBox1.Controls.Add(Me.reportsbutton)
        Me.GroupBox1.Controls.Add(Me.inventbutton)
        Me.GroupBox1.Controls.Add(Me.Logoutbutton)
        Me.GroupBox1.Controls.Add(Me.settingbutton)
        Me.GroupBox1.Location = New System.Drawing.Point(-4, -1)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(140, 539)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'reportsbutton
        '
        Me.reportsbutton.AccessibleDescription = "reportsbutton"
        Me.reportsbutton.AccessibleName = "reportsbutton"
        Me.reportsbutton.BackColor = System.Drawing.Color.Black
        Me.reportsbutton.ForeColor = System.Drawing.Color.White
        Me.reportsbutton.Location = New System.Drawing.Point(26, 221)
        Me.reportsbutton.Margin = New System.Windows.Forms.Padding(2)
        Me.reportsbutton.Name = "reportsbutton"
        Me.reportsbutton.Size = New System.Drawing.Size(95, 46)
        Me.reportsbutton.TabIndex = 8
        Me.reportsbutton.Text = "REPORTS"
        Me.reportsbutton.UseVisualStyleBackColor = False
        '
        'inventbutton
        '
        Me.inventbutton.AccessibleDescription = "inventbutton"
        Me.inventbutton.AccessibleName = "inventbutton"
        Me.inventbutton.BackColor = System.Drawing.Color.Black
        Me.inventbutton.ForeColor = System.Drawing.Color.White
        Me.inventbutton.Location = New System.Drawing.Point(26, 150)
        Me.inventbutton.Margin = New System.Windows.Forms.Padding(2)
        Me.inventbutton.Name = "inventbutton"
        Me.inventbutton.Size = New System.Drawing.Size(95, 46)
        Me.inventbutton.TabIndex = 7
        Me.inventbutton.Text = "INVENTORY"
        Me.inventbutton.UseVisualStyleBackColor = False
        '
        'Logoutbutton
        '
        Me.Logoutbutton.AccessibleDescription = "Logoutbutton"
        Me.Logoutbutton.AccessibleName = "Logoutbutton"
        Me.Logoutbutton.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Logoutbutton.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Logoutbutton.Location = New System.Drawing.Point(26, 466)
        Me.Logoutbutton.Margin = New System.Windows.Forms.Padding(2)
        Me.Logoutbutton.Name = "Logoutbutton"
        Me.Logoutbutton.Size = New System.Drawing.Size(95, 44)
        Me.Logoutbutton.TabIndex = 6
        Me.Logoutbutton.Text = "LOGOUT"
        Me.Logoutbutton.UseVisualStyleBackColor = False
        '
        'settingbutton
        '
        Me.settingbutton.AccessibleDescription = "settingbutton"
        Me.settingbutton.AccessibleName = "settingbutton"
        Me.settingbutton.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.settingbutton.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.settingbutton.Location = New System.Drawing.Point(26, 294)
        Me.settingbutton.Margin = New System.Windows.Forms.Padding(2)
        Me.settingbutton.Name = "settingbutton"
        Me.settingbutton.Size = New System.Drawing.Size(95, 48)
        Me.settingbutton.TabIndex = 4
        Me.settingbutton.Text = "SETTINGS"
        Me.settingbutton.UseVisualStyleBackColor = False
        '
        'voidbutton
        '
        Me.voidbutton.AccessibleDescription = "voidbutton"
        Me.voidbutton.AccessibleName = "voidbutton"
        Me.voidbutton.BackColor = System.Drawing.Color.Tan
        Me.voidbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.voidbutton.ForeColor = System.Drawing.Color.Black
        Me.voidbutton.Location = New System.Drawing.Point(464, 245)
        Me.voidbutton.Margin = New System.Windows.Forms.Padding(2)
        Me.voidbutton.Name = "voidbutton"
        Me.voidbutton.Size = New System.Drawing.Size(152, 46)
        Me.voidbutton.TabIndex = 2
        Me.voidbutton.Text = "VOID ITEMS"
        Me.voidbutton.UseVisualStyleBackColor = False
        '
        'totalbutton
        '
        Me.totalbutton.AccessibleDescription = "totalbutton"
        Me.totalbutton.AccessibleName = "totalbutton"
        Me.totalbutton.BackColor = System.Drawing.Color.Tan
        Me.totalbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalbutton.ForeColor = System.Drawing.Color.Black
        Me.totalbutton.Location = New System.Drawing.Point(464, 316)
        Me.totalbutton.Margin = New System.Windows.Forms.Padding(2)
        Me.totalbutton.Name = "totalbutton"
        Me.totalbutton.Size = New System.Drawing.Size(152, 46)
        Me.totalbutton.TabIndex = 3
        Me.totalbutton.Text = "TOTAL"
        Me.totalbutton.UseVisualStyleBackColor = False
        '
        'additembutton
        '
        Me.additembutton.AccessibleDescription = "additembutton"
        Me.additembutton.AccessibleName = "additembutton"
        Me.additembutton.BackColor = System.Drawing.Color.Tan
        Me.additembutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.additembutton.ForeColor = System.Drawing.Color.Black
        Me.additembutton.Location = New System.Drawing.Point(464, 106)
        Me.additembutton.Margin = New System.Windows.Forms.Padding(2)
        Me.additembutton.Name = "additembutton"
        Me.additembutton.Size = New System.Drawing.Size(152, 46)
        Me.additembutton.TabIndex = 1
        Me.additembutton.Text = "ADD ITEM"
        Me.additembutton.UseVisualStyleBackColor = False
        '
        'listviewsearch
        '
        Me.listviewsearch.AccessibleDescription = "listviewsearch"
        Me.listviewsearch.AccessibleName = "listviewsearch"
        Me.listviewsearch.BackColor = System.Drawing.Color.White
        Me.listviewsearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listviewsearch.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.listviewsearch.HideSelection = False
        Me.listviewsearch.Location = New System.Drawing.Point(28, 106)
        Me.listviewsearch.Margin = New System.Windows.Forms.Padding(2)
        Me.listviewsearch.Name = "listviewsearch"
        Me.listviewsearch.Size = New System.Drawing.Size(385, 366)
        Me.listviewsearch.TabIndex = 5
        Me.listviewsearch.UseCompatibleStateImageBehavior = False
        Me.listviewsearch.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ITEM_NO"
        Me.ColumnHeader1.Width = 85
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "ITEM_NAME"
        Me.ColumnHeader2.Width = 188
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "ITEM_PRICE"
        Me.ColumnHeader3.Width = 128
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "QUANTITY"
        Me.ColumnHeader4.Width = 113
        '
        'totaltextbox
        '
        Me.totaltextbox.AcceptsReturn = True
        Me.totaltextbox.AccessibleDescription = "totaltextbox"
        Me.totaltextbox.AccessibleName = "totaltextbox"
        Me.totaltextbox.BackColor = System.Drawing.Color.White
        Me.totaltextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totaltextbox.Location = New System.Drawing.Point(467, 401)
        Me.totaltextbox.Margin = New System.Windows.Forms.Padding(2)
        Me.totaltextbox.Name = "totaltextbox"
        Me.totaltextbox.Size = New System.Drawing.Size(150, 62)
        Me.totaltextbox.TabIndex = 8
        '
        'searchtextbox
        '
        Me.searchtextbox.AccessibleDescription = "searchtextbox"
        Me.searchtextbox.AccessibleName = "searchtextbox"
        Me.searchtextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchtextbox.Location = New System.Drawing.Point(175, 34)
        Me.searchtextbox.Margin = New System.Windows.Forms.Padding(2)
        Me.searchtextbox.Name = "searchtextbox"
        Me.searchtextbox.Size = New System.Drawing.Size(252, 41)
        Me.searchtextbox.TabIndex = 11
        '
        'minusbutton
        '
        Me.minusbutton.AccessibleDescription = "minusbutton"
        Me.minusbutton.AccessibleName = "minusbutton"
        Me.minusbutton.BackColor = System.Drawing.Color.Tan
        Me.minusbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minusbutton.ForeColor = System.Drawing.Color.Black
        Me.minusbutton.Location = New System.Drawing.Point(553, 168)
        Me.minusbutton.Margin = New System.Windows.Forms.Padding(2)
        Me.minusbutton.Name = "minusbutton"
        Me.minusbutton.Size = New System.Drawing.Size(63, 41)
        Me.minusbutton.TabIndex = 13
        Me.minusbutton.Text = "-"
        Me.minusbutton.UseVisualStyleBackColor = False
        '
        'plusbutton
        '
        Me.plusbutton.AccessibleDescription = "plusbutton"
        Me.plusbutton.AccessibleName = "plusbutton"
        Me.plusbutton.BackColor = System.Drawing.Color.Tan
        Me.plusbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.plusbutton.ForeColor = System.Drawing.Color.Black
        Me.plusbutton.Location = New System.Drawing.Point(464, 168)
        Me.plusbutton.Margin = New System.Windows.Forms.Padding(2)
        Me.plusbutton.Name = "plusbutton"
        Me.plusbutton.Size = New System.Drawing.Size(64, 41)
        Me.plusbutton.TabIndex = 14
        Me.plusbutton.Text = "+"
        Me.plusbutton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Tan
        Me.Label1.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(449, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 38)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "CASHIERING"
        '
        'searchbuttonone
        '
        Me.searchbuttonone.AccessibleDescription = "searchbuttonone"
        Me.searchbuttonone.AccessibleName = "searchbuttonone"
        Me.searchbuttonone.BackColor = System.Drawing.Color.Tan
        Me.searchbuttonone.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchbuttonone.ForeColor = System.Drawing.Color.Black
        Me.searchbuttonone.Location = New System.Drawing.Point(28, 34)
        Me.searchbuttonone.Margin = New System.Windows.Forms.Padding(2)
        Me.searchbuttonone.Name = "searchbuttonone"
        Me.searchbuttonone.Size = New System.Drawing.Size(130, 40)
        Me.searchbuttonone.TabIndex = 15
        Me.searchbuttonone.Text = "SEARCH"
        Me.searchbuttonone.UseVisualStyleBackColor = False
        '
        'searchbuttontwo
        '
        Me.searchbuttontwo.AccessibleDescription = "searchbuttontwo"
        Me.searchbuttontwo.AccessibleName = "searchbuttontwo"
        Me.searchbuttontwo.BackgroundImage = Global.Cashiering_System01.My.Resources.Resources.search_button_icon_png_6
        Me.searchbuttontwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.searchbuttontwo.Location = New System.Drawing.Point(369, 34)
        Me.searchbuttontwo.Margin = New System.Windows.Forms.Padding(2)
        Me.searchbuttontwo.Name = "searchbuttontwo"
        Me.searchbuttontwo.Size = New System.Drawing.Size(56, 41)
        Me.searchbuttontwo.TabIndex = 2
        Me.searchbuttontwo.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.OldLace
        Me.GroupBox2.BackgroundImage = Global.Cashiering_System01.My.Resources.Resources.plain_
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox2.Controls.Add(Me.totalbutton)
        Me.GroupBox2.Controls.Add(Me.minusbutton)
        Me.GroupBox2.Controls.Add(Me.plusbutton)
        Me.GroupBox2.Controls.Add(Me.voidbutton)
        Me.GroupBox2.Controls.Add(Me.additembutton)
        Me.GroupBox2.Controls.Add(Me.listviewsearch)
        Me.GroupBox2.Controls.Add(Me.totaltextbox)
        Me.GroupBox2.Controls.Add(Me.searchbuttontwo)
        Me.GroupBox2.Controls.Add(Me.searchbuttonone)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.searchtextbox)
        Me.GroupBox2.Location = New System.Drawing.Point(134, -1)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(686, 539)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(819, 531)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MAININTERFACE"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents settingbutton As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Logoutbutton As Button
    Friend WithEvents inventbutton As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents reportsbutton As Button
    Friend WithEvents voidbutton As Button
    Friend WithEvents searchtextbox As TextBox
    Friend WithEvents listviewsearch As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents totalbutton As Button
    Friend WithEvents additembutton As Button
    Friend WithEvents totaltextbox As TextBox
    Friend WithEvents minusbutton As Button
    Friend WithEvents plusbutton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents searchbuttonone As Button
    Friend WithEvents searchbuttontwo As Button
    Friend WithEvents GroupBox2 As GroupBox
End Class
