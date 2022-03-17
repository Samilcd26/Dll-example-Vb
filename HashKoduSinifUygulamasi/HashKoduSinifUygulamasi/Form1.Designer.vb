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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MetinTBox = New System.Windows.Forms.TextBox()
        Me.AlgoritmaCBox = New System.Windows.Forms.ComboBox()
        Me.KodUretBtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.HashKoduTbox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Metin:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Algoritma:"
        '
        'MetinTBox
        '
        Me.MetinTBox.Location = New System.Drawing.Point(16, 50)
        Me.MetinTBox.Multiline = True
        Me.MetinTBox.Name = "MetinTBox"
        Me.MetinTBox.Size = New System.Drawing.Size(310, 55)
        Me.MetinTBox.TabIndex = 2
        '
        'AlgoritmaCBox
        '
        Me.AlgoritmaCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AlgoritmaCBox.FormattingEnabled = True
        Me.AlgoritmaCBox.Items.AddRange(New Object() {"MD5", "SHA1", "SHA256", "SHA384", "SHA512"})
        Me.AlgoritmaCBox.Location = New System.Drawing.Point(205, 122)
        Me.AlgoritmaCBox.Name = "AlgoritmaCBox"
        Me.AlgoritmaCBox.Size = New System.Drawing.Size(121, 23)
        Me.AlgoritmaCBox.TabIndex = 3
        '
        'KodUretBtn
        '
        Me.KodUretBtn.Location = New System.Drawing.Point(12, 151)
        Me.KodUretBtn.Name = "KodUretBtn"
        Me.KodUretBtn.Size = New System.Drawing.Size(314, 45)
        Me.KodUretBtn.TabIndex = 4
        Me.KodUretBtn.Text = "Kod Üret"
        Me.KodUretBtn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 212)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Hash Kodu:"
        '
        'HashKoduTbox
        '
        Me.HashKoduTbox.Location = New System.Drawing.Point(12, 230)
        Me.HashKoduTbox.Multiline = True
        Me.HashKoduTbox.Name = "HashKoduTbox"
        Me.HashKoduTbox.Size = New System.Drawing.Size(314, 92)
        Me.HashKoduTbox.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 348)
        Me.Controls.Add(Me.HashKoduTbox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.KodUretBtn)
        Me.Controls.Add(Me.AlgoritmaCBox)
        Me.Controls.Add(Me.MetinTBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MetinTBox As TextBox
    Friend WithEvents AlgoritmaCBox As ComboBox
    Friend WithEvents KodUretBtn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents HashKoduTbox As TextBox
End Class
