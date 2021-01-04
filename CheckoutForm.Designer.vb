<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckoutForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CheckoutForm))
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblPayment = New System.Windows.Forms.Label()
        Me.tbxPayment = New System.Windows.Forms.TextBox()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Tan
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblTotal.ForeColor = System.Drawing.Color.Black
        Me.lblTotal.Location = New System.Drawing.Point(12, 51)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(61, 24)
        Me.lblTotal.TabIndex = 0
        Me.lblTotal.Text = "Total :"
        '
        'lblPayment
        '
        Me.lblPayment.AutoSize = True
        Me.lblPayment.BackColor = System.Drawing.Color.Tan
        Me.lblPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblPayment.ForeColor = System.Drawing.Color.Black
        Me.lblPayment.Location = New System.Drawing.Point(12, 85)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(98, 24)
        Me.lblPayment.TabIndex = 1
        Me.lblPayment.Text = "Payment : "
        '
        'tbxPayment
        '
        Me.tbxPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tbxPayment.Location = New System.Drawing.Point(126, 83)
        Me.tbxPayment.Name = "tbxPayment"
        Me.tbxPayment.Size = New System.Drawing.Size(146, 26)
        Me.tbxPayment.TabIndex = 2
        '
        'lblChange
        '
        Me.lblChange.AutoSize = True
        Me.lblChange.BackColor = System.Drawing.Color.Tan
        Me.lblChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblChange.ForeColor = System.Drawing.Color.Black
        Me.lblChange.Location = New System.Drawing.Point(12, 118)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(119, 24)
        Me.lblChange.TabIndex = 3
        Me.lblChange.Text = "Change : P 0"
        '
        'CheckoutForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(284, 192)
        Me.Controls.Add(Me.lblChange)
        Me.Controls.Add(Me.tbxPayment)
        Me.Controls.Add(Me.lblPayment)
        Me.Controls.Add(Me.lblTotal)
        Me.ForeColor = System.Drawing.Color.Cornsilk
        Me.Name = "CheckoutForm"
        Me.Text = "CheckoutForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTotal As Label
    Friend WithEvents lblPayment As Label
    Friend WithEvents tbxPayment As TextBox
    Friend WithEvents lblChange As Label
End Class
