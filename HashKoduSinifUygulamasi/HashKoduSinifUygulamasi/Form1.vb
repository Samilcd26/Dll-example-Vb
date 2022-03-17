Public Class Form1
    Private Sub KodUretBtn_Click(sender As Object, e As EventArgs) Handles KodUretBtn.Click
        If AlgoritmaCBox.SelectedIndex > -1 Then
            Dim Mtn As String = MetinTBox.Text
            Dim Sonuc As String
            Dim KodUret As New HashKodu
            Dim Algotirma As String = AlgoritmaCBox.SelectedItem
            Sonuc = KodUret.HashKoduUret(Mtn, Algotirma)
            HashKoduTbox.Text = Sonuc
        End If
    End Sub
End Class
