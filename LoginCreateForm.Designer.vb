<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginCreateForm
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.backButton = New System.Windows.Forms.Button()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.editButton = New System.Windows.Forms.Button()
        Me.addButton = New System.Windows.Forms.Button()
        Me.CSystemDataSet = New Cashiering_System01.CSystemDataSet()
        Me.LogintblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LogintblTableAdapter = New Cashiering_System01.CSystemDataSetTableAdapters.LogintblTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.loginDgv = New System.Windows.Forms.DataGridView()
        Me.LoginIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employeeIDLabel = New System.Windows.Forms.Label()
        Me.employeeIDTextbox = New System.Windows.Forms.TextBox()
        Me.passwordLabel = New System.Windows.Forms.Label()
        Me.passwordTextbox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.usertypeCheckbox = New System.Windows.Forms.ComboBox()
        Me.usertypeLabel = New System.Windows.Forms.Label()
        Me.loginIDTextbox = New System.Windows.Forms.TextBox()
        Me.loginIDLabel = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.CSystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogintblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.loginDgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = Global.Cashiering_System01.My.Resources.Resources.plain_
        Me.GroupBox2.Controls.Add(Me.backButton)
        Me.GroupBox2.Controls.Add(Me.deleteButton)
        Me.GroupBox2.Controls.Add(Me.editButton)
        Me.GroupBox2.Controls.Add(Me.addButton)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 11)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(112, 336)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'backButton
        '
        Me.backButton.BackColor = System.Drawing.Color.Black
        Me.backButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backButton.ForeColor = System.Drawing.Color.White
        Me.backButton.Location = New System.Drawing.Point(15, 281)
        Me.backButton.Margin = New System.Windows.Forms.Padding(2)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(82, 42)
        Me.backButton.TabIndex = 10
        Me.backButton.Text = "BACK"
        Me.backButton.UseVisualStyleBackColor = False
        '
        'deleteButton
        '
        Me.deleteButton.BackColor = System.Drawing.Color.Black
        Me.deleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteButton.ForeColor = System.Drawing.Color.White
        Me.deleteButton.Location = New System.Drawing.Point(15, 132)
        Me.deleteButton.Margin = New System.Windows.Forms.Padding(2)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(82, 42)
        Me.deleteButton.TabIndex = 8
        Me.deleteButton.Text = "DELETE"
        Me.deleteButton.UseVisualStyleBackColor = False
        '
        'editButton
        '
        Me.editButton.BackColor = System.Drawing.Color.Black
        Me.editButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editButton.ForeColor = System.Drawing.Color.White
        Me.editButton.Location = New System.Drawing.Point(15, 77)
        Me.editButton.Margin = New System.Windows.Forms.Padding(2)
        Me.editButton.Name = "editButton"
        Me.editButton.Size = New System.Drawing.Size(82, 41)
        Me.editButton.TabIndex = 7
        Me.editButton.Text = "EDIT"
        Me.editButton.UseVisualStyleBackColor = False
        '
        'addButton
        '
        Me.addButton.BackColor = System.Drawing.Color.Black
        Me.addButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addButton.ForeColor = System.Drawing.Color.White
        Me.addButton.Location = New System.Drawing.Point(15, 31)
        Me.addButton.Margin = New System.Windows.Forms.Padding(2)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(82, 38)
        Me.addButton.TabIndex = 6
        Me.addButton.Text = "ADD"
        Me.addButton.UseVisualStyleBackColor = False
        '
        'CSystemDataSet
        '
        Me.CSystemDataSet.DataSetName = "CSystemDataSet"
        Me.CSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LogintblBindingSource
        '
        Me.LogintblBindingSource.DataMember = "Logintbl"
        Me.LogintblBindingSource.DataSource = Me.CSystemDataSet
        '
        'LogintblTableAdapter
        '
        Me.LogintblTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 60)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 60)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 14
        '
        'loginDgv
        '
        Me.loginDgv.AutoGenerateColumns = False
        Me.loginDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.loginDgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LoginIDDataGridViewTextBoxColumn, Me.EmployeeIDDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn, Me.UserTypeDataGridViewTextBoxColumn})
        Me.loginDgv.DataSource = Me.LogintblBindingSource
        Me.loginDgv.Location = New System.Drawing.Point(7, 90)
        Me.loginDgv.Name = "loginDgv"
        Me.loginDgv.Size = New System.Drawing.Size(443, 233)
        Me.loginDgv.TabIndex = 5
        '
        'LoginIDDataGridViewTextBoxColumn
        '
        Me.LoginIDDataGridViewTextBoxColumn.DataPropertyName = "LoginID"
        Me.LoginIDDataGridViewTextBoxColumn.HeaderText = "LoginID"
        Me.LoginIDDataGridViewTextBoxColumn.Name = "LoginIDDataGridViewTextBoxColumn"
        '
        'EmployeeIDDataGridViewTextBoxColumn
        '
        Me.EmployeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID"
        Me.EmployeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID"
        Me.EmployeeIDDataGridViewTextBoxColumn.Name = "EmployeeIDDataGridViewTextBoxColumn"
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "Password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "Password"
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        '
        'UserTypeDataGridViewTextBoxColumn
        '
        Me.UserTypeDataGridViewTextBoxColumn.DataPropertyName = "UserType"
        Me.UserTypeDataGridViewTextBoxColumn.HeaderText = "UserType"
        Me.UserTypeDataGridViewTextBoxColumn.Name = "UserTypeDataGridViewTextBoxColumn"
        '
        'employeeIDLabel
        '
        Me.employeeIDLabel.AutoSize = True
        Me.employeeIDLabel.BackColor = System.Drawing.Color.Tan
        Me.employeeIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeIDLabel.ForeColor = System.Drawing.Color.Black
        Me.employeeIDLabel.Location = New System.Drawing.Point(8, 57)
        Me.employeeIDLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.employeeIDLabel.Name = "employeeIDLabel"
        Me.employeeIDLabel.Size = New System.Drawing.Size(103, 17)
        Me.employeeIDLabel.TabIndex = 36
        Me.employeeIDLabel.Text = "Employee ID:"
        '
        'employeeIDTextbox
        '
        Me.employeeIDTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeIDTextbox.Location = New System.Drawing.Point(125, 51)
        Me.employeeIDTextbox.Margin = New System.Windows.Forms.Padding(2)
        Me.employeeIDTextbox.Name = "employeeIDTextbox"
        Me.employeeIDTextbox.Size = New System.Drawing.Size(84, 23)
        Me.employeeIDTextbox.TabIndex = 37
        '
        'passwordLabel
        '
        Me.passwordLabel.AutoSize = True
        Me.passwordLabel.BackColor = System.Drawing.Color.Tan
        Me.passwordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordLabel.ForeColor = System.Drawing.Color.Black
        Me.passwordLabel.Location = New System.Drawing.Point(228, 19)
        Me.passwordLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.passwordLabel.Name = "passwordLabel"
        Me.passwordLabel.Size = New System.Drawing.Size(82, 17)
        Me.passwordLabel.TabIndex = 38
        Me.passwordLabel.Text = "Password:"
        '
        'passwordTextbox
        '
        Me.passwordTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordTextbox.Location = New System.Drawing.Point(325, 13)
        Me.passwordTextbox.Margin = New System.Windows.Forms.Padding(2)
        Me.passwordTextbox.Name = "passwordTextbox"
        Me.passwordTextbox.Size = New System.Drawing.Size(125, 23)
        Me.passwordTextbox.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.Cashiering_System01.My.Resources.Resources.plain_
        Me.GroupBox1.Controls.Add(Me.usertypeCheckbox)
        Me.GroupBox1.Controls.Add(Me.usertypeLabel)
        Me.GroupBox1.Controls.Add(Me.loginIDTextbox)
        Me.GroupBox1.Controls.Add(Me.loginIDLabel)
        Me.GroupBox1.Controls.Add(Me.passwordTextbox)
        Me.GroupBox1.Controls.Add(Me.passwordLabel)
        Me.GroupBox1.Controls.Add(Me.employeeIDTextbox)
        Me.GroupBox1.Controls.Add(Me.employeeIDLabel)
        Me.GroupBox1.Controls.Add(Me.loginDgv)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(134, 11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(461, 336)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'usertypeCheckbox
        '
        Me.usertypeCheckbox.FormattingEnabled = True
        Me.usertypeCheckbox.Items.AddRange(New Object() {"Admin", "Employee"})
        Me.usertypeCheckbox.Location = New System.Drawing.Point(325, 54)
        Me.usertypeCheckbox.Name = "usertypeCheckbox"
        Me.usertypeCheckbox.Size = New System.Drawing.Size(125, 21)
        Me.usertypeCheckbox.TabIndex = 42
        '
        'usertypeLabel
        '
        Me.usertypeLabel.AutoSize = True
        Me.usertypeLabel.BackColor = System.Drawing.Color.Tan
        Me.usertypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usertypeLabel.ForeColor = System.Drawing.Color.Black
        Me.usertypeLabel.Location = New System.Drawing.Point(222, 57)
        Me.usertypeLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.usertypeLabel.Name = "usertypeLabel"
        Me.usertypeLabel.Size = New System.Drawing.Size(88, 17)
        Me.usertypeLabel.TabIndex = 41
        Me.usertypeLabel.Text = "User Type:"
        '
        'loginIDTextbox
        '
        Me.loginIDTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginIDTextbox.Location = New System.Drawing.Point(125, 16)
        Me.loginIDTextbox.Margin = New System.Windows.Forms.Padding(2)
        Me.loginIDTextbox.Name = "loginIDTextbox"
        Me.loginIDTextbox.ReadOnly = True
        Me.loginIDTextbox.Size = New System.Drawing.Size(84, 23)
        Me.loginIDTextbox.TabIndex = 40
        '
        'loginIDLabel
        '
        Me.loginIDLabel.AutoSize = True
        Me.loginIDLabel.BackColor = System.Drawing.Color.Tan
        Me.loginIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginIDLabel.ForeColor = System.Drawing.Color.Black
        Me.loginIDLabel.Location = New System.Drawing.Point(38, 22)
        Me.loginIDLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.loginIDLabel.Name = "loginIDLabel"
        Me.loginIDLabel.Size = New System.Drawing.Size(73, 17)
        Me.loginIDLabel.TabIndex = 39
        Me.loginIDLabel.Text = "Login ID:"
        '
        'LoginCreateForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Cashiering_System01.My.Resources.Resources.plain_
        Me.ClientSize = New System.Drawing.Size(606, 360)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "LoginCreateForm"
        Me.Text = "CREATE LOGIN INFO"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.CSystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogintblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.loginDgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents backButton As Button
    Friend WithEvents deleteButton As Button
    Friend WithEvents editButton As Button
    Friend WithEvents addButton As Button
    Friend WithEvents CSystemDataSet As CSystemDataSet
    Friend WithEvents LogintblBindingSource As BindingSource
    Friend WithEvents LogintblTableAdapter As CSystemDataSetTableAdapters.LogintblTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents loginDgv As DataGridView
    Friend WithEvents LoginIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents employeeIDLabel As Label
    Friend WithEvents employeeIDTextbox As TextBox
    Friend WithEvents passwordLabel As Label
    Friend WithEvents passwordTextbox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents usertypeLabel As Label
    Friend WithEvents loginIDTextbox As TextBox
    Friend WithEvents loginIDLabel As Label
    Friend WithEvents usertypeCheckbox As ComboBox
End Class
