Imports AlanHesapla 'Referans olarak eklediğimiz Dll dosyamızı import ediyoruz
Public Class Form1
    Private Sub HesaplaBtn_Click(sender As Object, e As EventArgs) Handles HesaplaBtn.Click
        If IsNumeric(TabanTBox.Text) And IsNumeric(YukseklikTBox.Text) Then
            Dim Taban, Yukseklik, Alan As Decimal
            Dim AlanBul As New Alanlar 'Dll dosyamızdaki Class'ın adı Alanlar
            Taban = TabanTBox.Text
            Yukseklik = YukseklikTBox.Text
            Alan = AlanBul.Ucgen(Taban, Yukseklik)
            AlanTBox.Text = Alan
        End If
    End Sub
End Class
