Imports QLPMDAL
Imports QLPMDTO
Imports Utility

Public Class BenhNhanBUS
    Private tvDAL As BenhNhanDAL
    Public Sub New()
        tvDAL = New BenhNhanDAL()
    End Sub
    Public Sub New(connectionString As String)
        tvDAL = New BenhNhanDAL(connectionString)
    End Sub
    Public Function isValidName(hs As BenhnhanDTO) As Boolean

        If (hs.HoTen.Length < 1) Then
            Return False
        End If

        Return True
    End Function
    Public Function insert(dg As BenhnhanDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return tvDAL.insert(dg)
    End Function


    Public Function buildMSBN(ByRef nextMsbn As String) As Result
        Return tvDAL.BuildID(nextMsbn)
    End Function
End Class
