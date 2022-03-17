Imports HashKoduUret
Public Class Form1
    Private Sub KodUretBtn_Click(sender As Object, e As EventArgs) Handles KodUretBtn.Click
        HashKoduTBox.Clear()
        If AlgoritmaCBox.SelectedIndex > -1 Then
            Dim Metin, Kod, Algotirma As String
            Metin = MetinTBox.Text
            Algotirma = AlgoritmaCBox.SelectedItem
            Dim KodUret As New HashKodu
            Kod = KodUret.HashKodUret(Metin, Algotirma)
            'Kod = KodUret.HashKodUret(Metin, "SHA256")
            HashKoduTBox.Text = Kod
        End If
    End Sub
End Class
