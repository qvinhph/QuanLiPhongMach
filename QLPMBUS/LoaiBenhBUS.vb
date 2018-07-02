Imports QLPMDAL
Imports QLPMDTO
Imports Utility

Public Class LoaiBenhBUS

#Region "Fields"

    Private loaiBenhDAL As LoaiBenhDAL

#End Region

#Region "Constructor"

    Public Sub New()
        loaiBenhDAL = New LoaiBenhDAL()
    End Sub

    Public Sub New(connectionString As String)
        loaiBenhDAL = New LoaiBenhDAL(connectionString)
    End Sub

#End Region

#Region "Methods"

#Region "Insert/Update/Delete on database"

    Public Function Insert(loaiBenh As LoaiBenhDTO) As Result

        '1. verify data here!!

        '2. Insert to DB
        Return loaiBenhDAL.Insert(loaiBenh)

    End Function

    Public Function Update(loaiBenh As LoaiBenhDTO) As Result

        '1. verify data here!!

        '2. Insert to DB
        Return loaiBenhDAL.Update(loaiBenh)

    End Function

    Public Function Delete(maLoaiBenh As String) As Result

        '1. verify data here!!

        '2. Insert to DB
        Return loaiBenhDAL.Delete(maLoaiBenh)

    End Function

#End Region

    Public Function BuildID(ByRef nextID As String) As Result

        Return loaiBenhDAL.BuildID(nextID)

    End Function

    Public Function SelectAll(ByRef listLoaiBenh As List(Of LoaiBenhDTO)) As Result
        '1. verify data here!!

        '2. Insert to DB
        Return loaiBenhDAL.SelectAll(listLoaiBenh)
    End Function

    Public Function IsValidName(loaiBenh As LoaiBenhDTO) As Boolean

        If (loaiBenh.LoaiBenh.Length < 1) Then
            Return False
        End If

        Return True
    End Function
#End Region

End Class
