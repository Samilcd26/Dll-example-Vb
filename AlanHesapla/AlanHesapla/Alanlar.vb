Public Class Alanlar
    Public Function Daire(r As Decimal, Optional Pi As Decimal = Math.PI) As Decimal
        Dim Alan As Decimal
        Alan = Pi * Math.Pow(r, 2)
        Return Alan
    End Function
    Public Function Ucgen(Taban As Decimal, Yukseklik As Decimal) As Decimal
        Dim Alan As Decimal
        Alan = Taban * Yukseklik / 2
        Return Alan
    End Function
End Class
