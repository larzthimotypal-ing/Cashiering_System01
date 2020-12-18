<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuAdminForm
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
        Me.logoutButton = New System.Windows.Forms.Button()
        Me.salesReportButton = New System.Windows.Forms.Button()
        Me.productButton = New System.Windows.Forms.Button()
        Me.inventoryButton = New System.Windows.Forms.Button()
        Me.modifyEmpButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'logoutButton
        '
        Me.logoutButton.AccessibleDescription = "inventbutton"
        Me.logoutButton.AccessibleName = "inventbutton"
        Me.logoutButton.BackColor = System.Drawing.Color.Black
        Me.logoutButton.ForeColor = System.Drawing.Color.White
        Me.logoutButton.Location = New System.Drawing.Point(437, 408)
        Me.logoutButton.Margin = New System.Windows.Forms.Padding(2)
        Me.logoutButton.Name = "logoutButton"
        Me.logoutButton.Size = New System.Drawing.Size(170, 45)
        Me.logoutButton.TabIndex = 15
        Me.logoutButton.Text = "LOGOUT"
        Me.logoutButton.UseVisualStyleBackColor = False
        '
        'salesReportButton
        '
        Me.salesReportButton.AccessibleDescription = "inventbutton"
        Me.salesReportButton.AccessibleName = "inventbutton"
        Me.salesReportButton.BackColor = System.Drawing.Color.Black
        Me.salesReportButton.ForeColor = System.Drawing.Color.White
        Me.salesReportButton.Location = New System.Drawing.Point(238, 382)
        Me.salesReportButton.Margin = New System.Windows.Forms.Padding(2)
        Me.salesReportButton.Name = "salesReportButton"
        Me.salesReportButton.Size = New System.Drawing.Size(170, 45)
        Me.salesReportButton.TabIndex = 14
        Me.salesReportButton.Text = "SALES REPORT"
        Me.salesReportButton.UseVisualStyleBackColor = False
        '
        'productButton
        '
        Me.productButton.AccessibleDescription = "inventbutton"
        Me.productButton.AccessibleName = "inventbutton"
        Me.productButton.BackColor = System.Drawing.Color.Black
        Me.productButton.ForeColor = System.Drawing.Color.White
        Me.productButton.Location = New System.Drawing.Point(27, 441)
        Me.productButton.Margin = New System.Windows.Forms.Padding(2)
        Me.productButton.Name = "productButton"
        Me.productButton.Size = New System.Drawing.Size(170, 45)
        Me.productButton.TabIndex = 13
        Me.productButton.Text = "PRODUCT"
        Me.productButton.UseVisualStyleBackColor = False
        '
        'inventoryButton
        '
        Me.inventoryButton.AccessibleDescription = "inventbutton"
        Me.inventoryButton.AccessibleName = "inventbutton"
        Me.inventoryButton.BackColor = System.Drawing.Color.Black
        Me.inventoryButton.ForeColor = System.Drawing.Color.White
        Me.inventoryButton.Location = New System.Drawing.Point(27, 382)
        Me.inventoryButton.Margin = New System.Windows.Forms.Padding(2)
        Me.inventoryButton.Name = "inventoryButton"
        Me.inventoryButton.Size = New System.Drawing.Size(170, 45)
        Me.inventoryButton.TabIndex = 12
        Me.inventoryButton.Text = "INVENTORY"
        Me.inventoryButton.UseVisualStyleBackColor = False
        '
        'modifyEmpButton
        '
        Me.modifyEmpButton.AccessibleDescription = "inventbutton"
        Me.modifyEmpButton.AccessibleName = "inventbutton"
        Me.modifyEmpButton.BackColor = System.Drawing.Color.Black
        Me.modifyEmpButton.ForeColor = System.Drawing.Color.White
        Me.modifyEmpButton.Location = New System.Drawing.Point(238, 441)
        Me.modifyEmpButton.Margin = New System.Windows.Forms.Padding(2)
        Me.modifyEmpButton.Name = "modifyEmpButton"
        Me.modifyEmpButton.Size = New System.Drawing.Size(170, 45)
        Me.modifyEmpButton.TabIndex = 16
        Me.modifyEmpButton.Text = "MODIFY EMPLOYEE"
        Me.modifyEmpButton.UseVisualStyleBackColor = False
        '
        'MenuAdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Cashiering_System01.My.Resources.Resources.option2_2
        Me.ClientSize = New System.Drawing.Size(644, 521)
        Me.Controls.Add(Me.modifyEmpButton)
        Me.Controls.Add(Me.logoutButton)
        Me.Controls.Add(Me.salesReportButton)
        Me.Controls.Add(Me.productButton)
        Me.Controls.Add(Me.inventoryButton)
        Me.Name = "MenuAdminForm"
        Me.Text = "MENU - ADMIN"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents logoutButton As Button
    Friend WithEvents salesReportButton As Button
    Friend WithEvents productButton As Button
    Friend WithEvents inventoryButton As Button
    Friend WithEvents modifyEmpButton As Button
End Class
