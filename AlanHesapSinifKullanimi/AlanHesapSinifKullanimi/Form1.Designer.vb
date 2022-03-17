<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.YCapTBox = New System.Windows.Forms.TextBox()
        Me.HesaplaBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AlanTBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Yarıçap:"
        '
        'YCapTBox
        '
        Me.YCapTBox.Location = New System.Drawing.Point(108, 24)
        Me.YCapTBox.Name = "YCapTBox"
        Me.YCapTBox.Size = New System.Drawing.Size(100, 23)
        Me.YCapTBox.TabIndex = 1
        '
        'HesaplaBtn
        '
        Me.HesaplaBtn.Location = New System.Drawing.Point(16, 63)
        Me.HesaplaBtn.Name = "HesaplaBtn"
        Me.HesaplaBtn.Size = New System.Drawing.Size(192, 46)
        Me.HesaplaBtn.TabIndex = 2
        Me.HesaplaBtn.Text = "Alan Hesapla"
        Me.HesaplaBtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Alan:"
        '
        'AlanTBox
        '
        Me.AlanTBox.Location = New System.Drawing.Point(108, 125)
        Me.AlanTBox.Name = "AlanTBox"
        Me.AlanTBox.Size = New System.Drawing.Size(100, 23)
        Me.AlanTBox.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(233, 181)
        Me.Controls.Add(Me.AlanTBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.HesaplaBtn)
        Me.Controls.Add(Me.YCapTBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents YCapTBox As TextBox
    Friend WithEvents HesaplaBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents AlanTBox As TextBox
End Class
