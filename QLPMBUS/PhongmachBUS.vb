Imports QLPMDAL
Imports QLPMDTO
Imports Utility

Public Class PhongmachBUS
    Private tvDAL As PhongmachDAL
    Public Sub New()
        tvDAL = New PhongmachDAL()
    End Sub
    Public Sub New(connectionString As String)
        tvDAL = New PhongmachDAL(connectionString)
    End Sub
    Public Function isValidName(hs As PhongMachDTO) As Boolean

        If (hs.HoTen.Length < 1) Then
            Return False
        End If

        Return True
    End Function
    Public Function insert(dg As PhongMachDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return tvDAL.insert(dg)
    End Function


    Public Function buildMSDG(ByRef nextMsdg As Integer) As Result
        Return tvDAL.buildMSDG(nextMsdg)
    End Function
End Class
