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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MetinTBox = New System.Windows.Forms.TextBox()
        Me.AlgoritmaCBox = New System.Windows.Forms.ComboBox()
        Me.KodUretBtn = New System.Windows.Forms.Button()
        Me.HashKoduTBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Metin:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Algoritma:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hash Kodu:"
        '
        'MetinTBox
        '
        Me.MetinTBox.Location = New System.Drawing.Point(15, 38)
        Me.MetinTBox.Multiline = True
        Me.MetinTBox.Name = "MetinTBox"
        Me.MetinTBox.Size = New System.Drawing.Size(369, 65)
        Me.MetinTBox.TabIndex = 3
        '
        'AlgoritmaCBox
        '
        Me.AlgoritmaCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AlgoritmaCBox.FormattingEnabled = True
        Me.AlgoritmaCBox.Items.AddRange(New Object() {"MD5", "SHA1", "SHA256", "SHA384", "SHA512"})
        Me.AlgoritmaCBox.Location = New System.Drawing.Point(166, 114)
        Me.AlgoritmaCBox.Name = "AlgoritmaCBox"
        Me.AlgoritmaCBox.Size = New System.Drawing.Size(121, 21)
        Me.AlgoritmaCBox.TabIndex = 4
        '
        'KodUretBtn
        '
        Me.KodUretBtn.Location = New System.Drawing.Point(12, 146)
        Me.KodUretBtn.Name = "KodUretBtn"
        Me.KodUretBtn.Size = New System.Drawing.Size(372, 33)
        Me.KodUretBtn.TabIndex = 5
        Me.KodUretBtn.Text = "Kod Üret"
        Me.KodUretBtn.UseVisualStyleBackColor = True
        '
        'HashKoduTBox
        '
        Me.HashKoduTBox.Location = New System.Drawing.Point(12, 207)
        Me.HashKoduTBox.Multiline = True
        Me.HashKoduTBox.Name = "HashKoduTBox"
        Me.HashKoduTBox.ReadOnly = True
        Me.HashKoduTBox.Size = New System.Drawing.Size(372, 75)
        Me.HashKoduTBox.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 303)
        Me.Controls.Add(Me.HashKoduTBox)
        Me.Controls.Add(Me.KodUretBtn)
        Me.Controls.Add(Me.AlgoritmaCBox)
        Me.Controls.Add(Me.MetinTBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents MetinTBox As TextBox
    Friend WithEvents AlgoritmaCBox As ComboBox
    Friend WithEvents KodUretBtn As Button
    Friend WithEvents HashKoduTBox As TextBox
End Class
