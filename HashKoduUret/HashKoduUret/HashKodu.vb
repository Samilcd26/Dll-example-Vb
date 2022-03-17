Imports System.Security.Cryptography
Imports System.Text
Public Class HashKodu
    Private Function AlgotirmaSec(AlgoritmaAdi As String) As HashAlgorithm
        Dim SecilenAlgoritma As HashAlgorithm
        AlgoritmaAdi = AlgoritmaAdi.ToUpper
        Select Case AlgoritmaAdi
            Case "MD5"
                SecilenAlgoritma = MD5.Create
            Case "SHA1"
                SecilenAlgoritma = SHA1.Create
            Case "SHA256"
                SecilenAlgoritma = SHA256.Create
            Case "SHA384"
                SecilenAlgoritma = SHA384.Create
            Case "SHA512"
                SecilenAlgoritma = SHA512.Create
            Case Else
                SecilenAlgoritma = Nothing
        End Select
        Return SecilenAlgoritma
    End Function
    Public Function HashKodUret(Metin As String, Optional AlgoritmaAdi As String = "MD5") As String
        Dim Sonuc As String = Nothing
        Dim Algortima As HashAlgorithm = AlgotirmaSec(AlgoritmaAdi)
        If Not IsNothing(Algortima) Then
            Dim ByteMetin() As Byte = Encoding.UTF8.GetBytes(Metin)
            Dim ByteSonuc() As Byte = Algortima.ComputeHash(ByteMetin)
            For Each Eleman As Byte In ByteSonuc
                Sonuc &= Eleman.ToString("x2")
            Next
        End If
        Return Sonuc
    End Function
End Class
