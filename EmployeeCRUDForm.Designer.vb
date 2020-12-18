<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeCRUDForm
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
        Me.addButton = New System.Windows.Forms.Button()
        Me.editButton = New System.Windows.Forms.Button()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.backButton = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.addressTextbox = New System.Windows.Forms.TextBox()
        Me.addressLabel = New System.Windows.Forms.Label()
        Me.ageTextbox = New System.Windows.Forms.TextBox()
        Me.employeeNameTextbox = New System.Windows.Forms.TextBox()
        Me.contactNoTextbox = New System.Windows.Forms.TextBox()
        Me.contactNoLabel = New System.Windows.Forms.Label()
        Me.ageLabel = New System.Windows.Forms.Label()
        Me.employeeNameLabel = New System.Windows.Forms.Label()
        Me.employeeIDTextbox = New System.Windows.Forms.TextBox()
        Me.employeeIDLabel = New System.Windows.Forms.Label()
        Me.employeeDgv = New System.Windows.Forms.DataGridView()
        Me.EmployeeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeetblBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CSystemDataSet = New Cashiering_System01.CSystemDataSet()
        Me.EmployeetblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeetblTableAdapter = New Cashiering_System01.CSystemDataSetTableAdapters.EmployeetblTableAdapter()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.employeeDgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeetblBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CSystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeetblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'backButton
        '
        Me.backButton.BackColor = System.Drawing.Color.Black
        Me.backButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backButton.ForeColor = System.Drawing.Color.White
        Me.backButton.Location = New System.Drawing.Point(15, 329)
        Me.backButton.Margin = New System.Windows.Forms.Padding(2)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(82, 42)
        Me.backButton.TabIndex = 10
        Me.backButton.Text = "BACK"
        Me.backButton.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = Global.Cashiering_System01.My.Resources.Resources.plain_
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.backButton)
        Me.GroupBox2.Controls.Add(Me.deleteButton)
        Me.GroupBox2.Controls.Add(Me.editButton)
        Me.GroupBox2.Controls.Add(Me.addButton)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 10)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(112, 394)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(15, 212)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 79)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "CREATE EMPLOYEE LOGIN"
        Me.Button1.UseVisualStyleBackColor = False
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
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.Cashiering_System01.My.Resources.Resources.plain_
        Me.GroupBox1.Controls.Add(Me.addressTextbox)
        Me.GroupBox1.Controls.Add(Me.addressLabel)
        Me.GroupBox1.Controls.Add(Me.ageTextbox)
        Me.GroupBox1.Controls.Add(Me.employeeNameTextbox)
        Me.GroupBox1.Controls.Add(Me.contactNoTextbox)
        Me.GroupBox1.Controls.Add(Me.contactNoLabel)
        Me.GroupBox1.Controls.Add(Me.ageLabel)
        Me.GroupBox1.Controls.Add(Me.employeeNameLabel)
        Me.GroupBox1.Controls.Add(Me.employeeIDTextbox)
        Me.GroupBox1.Controls.Add(Me.employeeIDLabel)
        Me.GroupBox1.Controls.Add(Me.employeeDgv)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(134, 10)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(710, 394)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'addressTextbox
        '
        Me.addressTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addressTextbox.Location = New System.Drawing.Point(155, 105)
        Me.addressTextbox.Margin = New System.Windows.Forms.Padding(2)
        Me.addressTextbox.Name = "addressTextbox"
        Me.addressTextbox.Size = New System.Drawing.Size(503, 23)
        Me.addressTextbox.TabIndex = 4
        '
        'addressLabel
        '
        Me.addressLabel.AutoSize = True
        Me.addressLabel.BackColor = System.Drawing.Color.Tan
        Me.addressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addressLabel.ForeColor = System.Drawing.Color.Black
        Me.addressLabel.Location = New System.Drawing.Point(70, 111)
        Me.addressLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.addressLabel.Name = "addressLabel"
        Me.addressLabel.Size = New System.Drawing.Size(72, 17)
        Me.addressLabel.TabIndex = 46
        Me.addressLabel.Text = "Address:"
        '
        'ageTextbox
        '
        Me.ageTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ageTextbox.Location = New System.Drawing.Point(472, 26)
        Me.ageTextbox.Margin = New System.Windows.Forms.Padding(2)
        Me.ageTextbox.Name = "ageTextbox"
        Me.ageTextbox.Size = New System.Drawing.Size(84, 23)
        Me.ageTextbox.TabIndex = 2
        '
        'employeeNameTextbox
        '
        Me.employeeNameTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeNameTextbox.Location = New System.Drawing.Point(155, 65)
        Me.employeeNameTextbox.Margin = New System.Windows.Forms.Padding(2)
        Me.employeeNameTextbox.Name = "employeeNameTextbox"
        Me.employeeNameTextbox.Size = New System.Drawing.Size(186, 23)
        Me.employeeNameTextbox.TabIndex = 1
        '
        'contactNoTextbox
        '
        Me.contactNoTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contactNoTextbox.Location = New System.Drawing.Point(472, 66)
        Me.contactNoTextbox.Margin = New System.Windows.Forms.Padding(2)
        Me.contactNoTextbox.Name = "contactNoTextbox"
        Me.contactNoTextbox.Size = New System.Drawing.Size(186, 23)
        Me.contactNoTextbox.TabIndex = 3
        '
        'contactNoLabel
        '
        Me.contactNoLabel.AutoSize = True
        Me.contactNoLabel.BackColor = System.Drawing.Color.Tan
        Me.contactNoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contactNoLabel.ForeColor = System.Drawing.Color.Black
        Me.contactNoLabel.Location = New System.Drawing.Point(377, 71)
        Me.contactNoLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.contactNoLabel.Name = "contactNoLabel"
        Me.contactNoLabel.Size = New System.Drawing.Size(82, 17)
        Me.contactNoLabel.TabIndex = 42
        Me.contactNoLabel.Text = "Contact #:"
        '
        'ageLabel
        '
        Me.ageLabel.AutoSize = True
        Me.ageLabel.BackColor = System.Drawing.Color.Tan
        Me.ageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ageLabel.ForeColor = System.Drawing.Color.Black
        Me.ageLabel.Location = New System.Drawing.Point(418, 31)
        Me.ageLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ageLabel.Name = "ageLabel"
        Me.ageLabel.Size = New System.Drawing.Size(41, 17)
        Me.ageLabel.TabIndex = 40
        Me.ageLabel.Text = "Age:"
        '
        'employeeNameLabel
        '
        Me.employeeNameLabel.AutoSize = True
        Me.employeeNameLabel.BackColor = System.Drawing.Color.Tan
        Me.employeeNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeNameLabel.ForeColor = System.Drawing.Color.Black
        Me.employeeNameLabel.Location = New System.Drawing.Point(13, 71)
        Me.employeeNameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.employeeNameLabel.Name = "employeeNameLabel"
        Me.employeeNameLabel.Size = New System.Drawing.Size(129, 17)
        Me.employeeNameLabel.TabIndex = 38
        Me.employeeNameLabel.Text = "Employee Name:"
        '
        'employeeIDTextbox
        '
        Me.employeeIDTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeIDTextbox.Location = New System.Drawing.Point(155, 25)
        Me.employeeIDTextbox.Margin = New System.Windows.Forms.Padding(2)
        Me.employeeIDTextbox.Name = "employeeIDTextbox"
        Me.employeeIDTextbox.ReadOnly = True
        Me.employeeIDTextbox.Size = New System.Drawing.Size(84, 23)
        Me.employeeIDTextbox.TabIndex = 37
        '
        'employeeIDLabel
        '
        Me.employeeIDLabel.AutoSize = True
        Me.employeeIDLabel.BackColor = System.Drawing.Color.Tan
        Me.employeeIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeIDLabel.ForeColor = System.Drawing.Color.Black
        Me.employeeIDLabel.Location = New System.Drawing.Point(39, 31)
        Me.employeeIDLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.employeeIDLabel.Name = "employeeIDLabel"
        Me.employeeIDLabel.Size = New System.Drawing.Size(103, 17)
        Me.employeeIDLabel.TabIndex = 36
        Me.employeeIDLabel.Text = "Employee ID:"
        '
        'employeeDgv
        '
        Me.employeeDgv.AutoGenerateColumns = False
        Me.employeeDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.employeeDgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmployeeIDDataGridViewTextBoxColumn, Me.EmployeeNameDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.employeeDgv.DataSource = Me.EmployeetblBindingSource1
        Me.employeeDgv.Location = New System.Drawing.Point(7, 146)
        Me.employeeDgv.Name = "employeeDgv"
        Me.employeeDgv.Size = New System.Drawing.Size(694, 233)
        Me.employeeDgv.TabIndex = 5
        '
        'EmployeeIDDataGridViewTextBoxColumn
        '
        Me.EmployeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID"
        Me.EmployeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID"
        Me.EmployeeIDDataGridViewTextBoxColumn.Name = "EmployeeIDDataGridViewTextBoxColumn"
        '
        'EmployeeNameDataGridViewTextBoxColumn
        '
        Me.EmployeeNameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeName"
        Me.EmployeeNameDataGridViewTextBoxColumn.HeaderText = "EmployeeName"
        Me.EmployeeNameDataGridViewTextBoxColumn.Name = "EmployeeNameDataGridViewTextBoxColumn"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Age"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Age"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ContactNo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ContactNo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 250
        '
        'EmployeetblBindingSource1
        '
        Me.EmployeetblBindingSource1.DataMember = "Employeetbl"
        Me.EmployeetblBindingSource1.DataSource = Me.CSystemDataSet
        '
        'CSystemDataSet
        '
        Me.CSystemDataSet.DataSetName = "CSystemDataSet"
        Me.CSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeetblTableAdapter
        '
        Me.EmployeetblTableAdapter.ClearBeforeFill = True
        '
        'EmployeeCRUDForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.BackgroundImage = Global.Cashiering_System01.My.Resources.Resources.plain_
        Me.ClientSize = New System.Drawing.Size(855, 414)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "EmployeeCRUDForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EMPLOYEE INFO"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.employeeDgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeetblBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CSystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeetblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents addButton As Button
    Friend WithEvents editButton As Button
    Friend WithEvents deleteButton As Button
    Friend WithEvents backButton As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents employeeDgv As DataGridView
    Friend WithEvents EmployeetblBindingSource As BindingSource
    Friend WithEvents EmployeeNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BranchLocationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CSystemDataSet As CSystemDataSet
    Friend WithEvents EmployeetblBindingSource1 As BindingSource
    Friend WithEvents EmployeetblTableAdapter As CSystemDataSetTableAdapters.EmployeetblTableAdapter
    Friend WithEvents EmployeeIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents addressTextbox As TextBox
    Friend WithEvents addressLabel As Label
    Friend WithEvents ageTextbox As TextBox
    Friend WithEvents employeeNameTextbox As TextBox
    Friend WithEvents contactNoTextbox As TextBox
    Friend WithEvents contactNoLabel As Label
    Friend WithEvents ageLabel As Label
    Friend WithEvents employeeNameLabel As Label
    Friend WithEvents employeeIDTextbox As TextBox
    Friend WithEvents employeeIDLabel As Label
    Friend WithEvents Button1 As Button
End Class
