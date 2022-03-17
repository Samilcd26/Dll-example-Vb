Public Class Form1
    Private Sub HesaplaBtn_Click(sender As Object, e As EventArgs) Handles HesaplaBtn.Click
        If IsNumeric(YCapTBox.Text) Then
            Dim YCap As Decimal = YCapTBox.Text
            Dim Alan As Decimal

            Dim AlanHesap As New Alanlar 'Alanlar Class'ımızın ismi

            Alan = AlanHesap.Daire(YCap)
            AlanTBox.Text = Alan
        End If
    End Sub
End Class
