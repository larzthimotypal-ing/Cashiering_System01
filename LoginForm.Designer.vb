<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.loginButton = New System.Windows.Forms.Button()
        Me.passwordLabel = New System.Windows.Forms.Label()
        Me.empLabel = New System.Windows.Forms.Label()
        Me.empLoginTxtbox = New System.Windows.Forms.TextBox()
        Me.passwordLoginTxtbox = New System.Windows.Forms.TextBox()
        Me.UserTypeLabel = New System.Windows.Forms.Label()
        Me.usertypeCheckbox = New System.Windows.Forms.ComboBox()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'exitButton
        '
        Me.exitButton.AccessibleName = "firstexit"
        Me.exitButton.BackgroundImage = Global.Cashiering_System01.My.Resources.Resources._57993231_exit_icon_red_circle_flat_design_internet_button_web_and_mobile_app_illustration
        Me.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.exitButton.Location = New System.Drawing.Point(586, 528)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(56, 39)
        Me.exitButton.TabIndex = 5
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'loginButton
        '
        Me.loginButton.AccessibleDescription = ""
        Me.loginButton.AccessibleName = "loginuser"
        Me.loginButton.BackColor = System.Drawing.Color.Tan
        Me.loginButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginButton.ForeColor = System.Drawing.Color.Black
        Me.loginButton.Location = New System.Drawing.Point(445, 427)
        Me.loginButton.Margin = New System.Windows.Forms.Padding(2)
        Me.loginButton.Name = "loginButton"
        Me.loginButton.Size = New System.Drawing.Size(137, 49)
        Me.loginButton.TabIndex = 4
        Me.loginButton.Text = "LOGIN"
        Me.loginButton.UseVisualStyleBackColor = False
        '
        'passwordLabel
        '
        Me.passwordLabel.AccessibleName = "passwordlbl"
        Me.passwordLabel.AutoSize = True
        Me.passwordLabel.BackColor = System.Drawing.Color.Tan
        Me.passwordLabel.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordLabel.ForeColor = System.Drawing.Color.Black
        Me.passwordLabel.Location = New System.Drawing.Point(78, 440)
        Me.passwordLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.passwordLabel.Name = "passwordLabel"
        Me.passwordLabel.Size = New System.Drawing.Size(127, 22)
        Me.passwordLabel.TabIndex = 10
        Me.passwordLabel.Text = "PASSWORD:"
        '
        'empLabel
        '
        Me.empLabel.AccessibleName = "emplbl"
        Me.empLabel.AutoSize = True
        Me.empLabel.BackColor = System.Drawing.Color.Tan
        Me.empLabel.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empLabel.ForeColor = System.Drawing.Color.Black
        Me.empLabel.Location = New System.Drawing.Point(53, 396)
        Me.empLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.empLabel.Name = "empLabel"
        Me.empLabel.Size = New System.Drawing.Size(152, 26)
        Me.empLabel.TabIndex = 9
        Me.empLabel.Text = "EMPLOYEE NO:"
        Me.empLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.empLabel.UseCompatibleTextRendering = True
        '
        'empLoginTxtbox
        '
        Me.empLoginTxtbox.AccessibleName = "empinput"
        Me.empLoginTxtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empLoginTxtbox.Location = New System.Drawing.Point(221, 387)
        Me.empLoginTxtbox.Margin = New System.Windows.Forms.Padding(2)
        Me.empLoginTxtbox.Name = "empLoginTxtbox"
        Me.empLoginTxtbox.Size = New System.Drawing.Size(194, 35)
        Me.empLoginTxtbox.TabIndex = 1
        '
        'passwordLoginTxtbox
        '
        Me.passwordLoginTxtbox.AccessibleName = "passwordtxt"
        Me.passwordLoginTxtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordLoginTxtbox.Location = New System.Drawing.Point(221, 431)
        Me.passwordLoginTxtbox.Margin = New System.Windows.Forms.Padding(2)
        Me.passwordLoginTxtbox.Name = "passwordLoginTxtbox"
        Me.passwordLoginTxtbox.Size = New System.Drawing.Size(194, 35)
        Me.passwordLoginTxtbox.TabIndex = 2
        Me.passwordLoginTxtbox.UseSystemPasswordChar = True
        '
        'UserTypeLabel
        '
        Me.UserTypeLabel.AccessibleName = "passwordlbl"
        Me.UserTypeLabel.AutoSize = True
        Me.UserTypeLabel.BackColor = System.Drawing.Color.Tan
        Me.UserTypeLabel.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserTypeLabel.ForeColor = System.Drawing.Color.Black
        Me.UserTypeLabel.Location = New System.Drawing.Point(78, 486)
        Me.UserTypeLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UserTypeLabel.Name = "UserTypeLabel"
        Me.UserTypeLabel.Size = New System.Drawing.Size(126, 22)
        Me.UserTypeLabel.TabIndex = 13
        Me.UserTypeLabel.Text = "USER TYPE:"
        '
        'usertypeCheckbox
        '
        Me.usertypeCheckbox.FormattingEnabled = True
        Me.usertypeCheckbox.Items.AddRange(New Object() {"Admin", "Employee"})
        Me.usertypeCheckbox.Location = New System.Drawing.Point(221, 488)
        Me.usertypeCheckbox.Name = "usertypeCheckbox"
        Me.usertypeCheckbox.Size = New System.Drawing.Size(194, 21)
        Me.usertypeCheckbox.TabIndex = 3
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = Global.Cashiering_System01.My.Resources.Resources.option2_2
        Me.ClientSize = New System.Drawing.Size(653, 578)
        Me.Controls.Add(Me.usertypeCheckbox)
        Me.Controls.Add(Me.UserTypeLabel)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.loginButton)
        Me.Controls.Add(Me.passwordLabel)
        Me.Controls.Add(Me.empLabel)
        Me.Controls.Add(Me.empLoginTxtbox)
        Me.Controls.Add(Me.passwordLoginTxtbox)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "USER LOGIN"
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents usertypeCheckbox As ComboBox
    Friend WithEvents UserTypeLabel As Label
    Friend WithEvents exitButton As Button
    Friend WithEvents loginButton As Button
    Friend WithEvents passwordLabel As Label
    Friend WithEvents empLabel As Label
    Friend WithEvents empLoginTxtbox As TextBox
    Friend WithEvents passwordLoginTxtbox As TextBox
End Class
