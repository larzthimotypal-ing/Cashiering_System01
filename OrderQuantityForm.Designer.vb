<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderQuantityForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrderQuantityForm))
        Me.lblOrderQuantityMessage = New System.Windows.Forms.Label()
        Me.tbxOrderQuantity = New System.Windows.Forms.TextBox()
        Me.btnOrderQuantitySubmit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblOrderQuantityMessage
        '
        Me.lblOrderQuantityMessage.AutoSize = True
        Me.lblOrderQuantityMessage.BackColor = System.Drawing.Color.Tan
        Me.lblOrderQuantityMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblOrderQuantityMessage.Location = New System.Drawing.Point(29, 59)
        Me.lblOrderQuantityMessage.Name = "lblOrderQuantityMessage"
        Me.lblOrderQuantityMessage.Size = New System.Drawing.Size(159, 24)
        Me.lblOrderQuantityMessage.TabIndex = 0
        Me.lblOrderQuantityMessage.Text = "How Many Items?"
        '
        'tbxOrderQuantity
        '
        Me.tbxOrderQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.tbxOrderQuantity.Location = New System.Drawing.Point(201, 43)
        Me.tbxOrderQuantity.MinimumSize = New System.Drawing.Size(60, 40)
        Me.tbxOrderQuantity.Name = "tbxOrderQuantity"
        Me.tbxOrderQuantity.Size = New System.Drawing.Size(87, 40)
        Me.tbxOrderQuantity.TabIndex = 1
        '
        'btnOrderQuantitySubmit
        '
        Me.btnOrderQuantitySubmit.BackColor = System.Drawing.Color.Green
        Me.btnOrderQuantitySubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrderQuantitySubmit.ForeColor = System.Drawing.Color.White
        Me.btnOrderQuantitySubmit.Location = New System.Drawing.Point(131, 96)
        Me.btnOrderQuantitySubmit.Name = "btnOrderQuantitySubmit"
        Me.btnOrderQuantitySubmit.Size = New System.Drawing.Size(75, 38)
        Me.btnOrderQuantitySubmit.TabIndex = 2
        Me.btnOrderQuantitySubmit.Text = "Submit"
        Me.btnOrderQuantitySubmit.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Firebrick
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(33, 96)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 38)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'OrderQuantityForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(300, 146)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOrderQuantitySubmit)
        Me.Controls.Add(Me.tbxOrderQuantity)
        Me.Controls.Add(Me.lblOrderQuantityMessage)
        Me.Name = "OrderQuantityForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "OrderQuantityForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblOrderQuantityMessage As Label
    Friend WithEvents tbxOrderQuantity As TextBox
    Friend WithEvents btnOrderQuantitySubmit As Button
    Friend WithEvents btnCancel As Button
End Class
