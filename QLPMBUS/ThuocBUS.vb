Imports QLPMDAL
Imports QLPMDTO
Imports Utility

Public Class ThuocBUS

#Region "Fields"

    Private thuocDAL As ThuocDAL

#End Region

#Region "Constructor"

    Public Sub New()
        thuocDAL = New ThuocDAL()
    End Sub

    Public Sub New(connectionString As String)
        thuocDAL = New ThuocDAL(connectionString)
    End Sub

#End Region

#Region "Methods"

#Region "Insert/Update/Delete on database"

    Public Function Insert(thuoc As ThuocDTO) As Result

        '1. verify data here!!

        '2. Insert to DB
        Return thuocDAL.Insert(thuoc)

    End Function

    Public Function Update(thuoc As ThuocDTO) As Result

        '1. verify data here!!

        '2. Insert to DB
        Return thuocDAL.Update(thuoc)

    End Function

    Public Function Delete(maThuoc As String) As Result

        '1. verify data here!!

        '2. Insert to DB
        Return thuocDAL.Delete(maThuoc)

    End Function

#End Region

    Public Function BuildID(ByRef nextID As String) As Result

        Return thuocDAL.BuildID(nextID)

    End Function

    Public Function SelectAll(ByRef listThuoc As List(Of ThuocDTO)) As Result
        '1. verify data here!!

        '2. Insert to DB
        Return thuocDAL.SelectAll(listThuoc)
    End Function

    Public Function Select_ByMaThuoc(maThuoc As String, ByRef thuoc As ThuocDTO) As Result
        '1. verify data here!!

        '2. Insert to DB
        Return thuocDAL.Select_ByMaThuoc(maThuoc, thuoc)
    End Function

    Public Function IsValidName(thuoc As ThuocDTO) As Boolean

        If (thuoc.TenThuoc.Length < 1) Then
            Return False
        End If

        Return True
    End Function
#End Region

End Class
