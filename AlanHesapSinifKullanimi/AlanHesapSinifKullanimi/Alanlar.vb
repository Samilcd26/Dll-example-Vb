Public Class Alanlar
    Public Function Daire(r As Decimal, Optional Pi As Decimal = Math.PI) As Decimal
        Dim Sonuc As Decimal
        Sonuc = Pi * r ^ 2 'Sonuc = Pi * Math.Pow(r , 2)
        Return Sonuc
    End Function
End Class
