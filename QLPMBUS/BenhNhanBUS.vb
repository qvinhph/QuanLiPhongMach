Imports QLPMDAL
Imports QLPMDTO
Imports Utility

Public Class BenhNhanBUS
    Private bnDAL As BenhNhanDAL
    Public Sub New()
        bnDAL = New BenhNhanDAL()
    End Sub
    Public Sub New(connectionString As String)
        bnDAL = New BenhNhanDAL(connectionString)
    End Sub
    Public Function isValidName(hs As BenhnhanDTO) As Boolean

        If (hs.HoTen.Length < 1) Then
            Return False
        End If

        Return True
    End Function
    Public Function insert(bn As BenhnhanDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return bnDAL.Insert(bn)
    End Function


    Public Function buildMSBN(ByRef nextMsbn As String) As Result
        Return bnDAL.BuildID(nextMsbn)
    End Function
End Class
