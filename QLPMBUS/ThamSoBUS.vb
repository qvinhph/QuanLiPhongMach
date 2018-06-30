Imports QLPMDAL
Imports QLPMDTO
Imports Utility


Public Class ThamSoBUS

#Region "Fields"

    Private thamSoDAL As ThamSoDAL

#End Region

#Region "Constructor"

    Public Sub New()
        thamSoDAL = New ThamSoDAL()
    End Sub

    Public Sub New(connectionString As String)
        thamSoDAL = New ThamSoDAL(connectionString)
    End Sub

#End Region

#Region "Methods"

#Region "Insert/Update/Delete on database"

    Public Function Update(thamSo As ThamSoDTO) As Result

        '1. verify data here!!

        '2. Insert to DB
        Return thamSoDAL.Update(thamSo)

    End Function

#End Region

    Public Function GetThamSoOnDB(ByRef thamSo As ThamSoDTO) As Result
        '1. verify data here!!

        '2. Insert to DB
        Return thamSoDAL.GetThamSoOnDB(thamSo)
    End Function

#End Region

End Class
