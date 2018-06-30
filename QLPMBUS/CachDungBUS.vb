Imports QLPMDAL
Imports QLPMDTO
Imports Utility

Public Class CachDungBUS

#Region "Fields"

    Private cachDungDAL As CachDungDAL

#End Region

#Region "Constructor"

    Public Sub New()
        cachDungDAL = New CachDungDAL()
    End Sub

    Public Sub New(connectionString As String)
        cachDungDAL = New CachDungDAL(connectionString)
    End Sub

#End Region

#Region "Methods"

#Region "Insert/Update/Delete on database"

    Public Function Insert(cachDung As CachDungDTO) As Result

        '1. verify data here!!

        '2. Insert to DB
        Return cachDungDAL.Insert(cachDung)

    End Function

    Public Function Update(cachDung As CachDungDTO) As Result

        '1. verify data here!!

        '2. Insert to DB
        Return cachDungDAL.Update(cachDung)

    End Function

    Public Function Delete(maCachDung As String) As Result

        '1. verify data here!!

        '2. Insert to DB
        Return cachDungDAL.Delete(maCachDung)

    End Function

#End Region

    Public Function BuildID(ByRef nextID As String) As Result

        Return cachDungDAL.BuildID(nextID)

    End Function

    Public Function SelectAll(ByRef listCachDung As List(Of CachDungDTO)) As Result
        '1. verify data here!!

        '2. Insert to DB
        Return cachDungDAL.SelectAll(listCachDung)
    End Function

#End Region

End Class
