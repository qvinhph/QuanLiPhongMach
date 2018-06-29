Imports QLPMDAL
Imports QLPMDTO
Imports Utility

Public Class ChiTietDanhSachBUS

#Region "Fields"

    Private chiTietDanhSach As ChiTietDanhSachDAL

#End Region

#Region "Constructor"

    Public Sub New()
        chiTietDanhSach = New ChiTietDanhSachDAL()
    End Sub

    Public Sub New(connectionString As String)
        chiTietDanhSach = New ChiTietDanhSachDAL(connectionString)
    End Sub

#End Region

#Region "Methods"

#Region "Insert/Update/Delete on database"

    Public Function Insert(chiTietDS As ChiTietDanhSachDTO) As Result

        '1. verify data here!!

        '2. Insert to DB
        Return chiTietDanhSach.Insert(chiTietDS)

    End Function

    Public Function Update(chiTietDS As ChiTietDanhSachDTO) As Result

        '1. verify data here!!

        '2. Insert to DB
        Return chiTietDanhSach.Update(chiTietDS)

    End Function

    Public Function Delete(maChiTietDS As String) As Result

        '1. verify data here!!

        '2. Insert to DB
        Return chiTietDanhSach.Delete(maChiTietDS)

    End Function

#End Region

    Public Function BuildID(ByRef nextID As String) As Result

        Return chiTietDanhSach.BuildID(nextID)

    End Function

    Public Function SelectAll_MaDanhSach(maDanhSach As String, ByRef listChiTietDS As List(Of ChiTietDanhSachDTO)) As Result
        '1. verify data here!!

        '2. Insert to DB
        Return chiTietDanhSach.SelectAll_MaDanhSach(maDanhSach, listChiTietDS)
    End Function

#End Region

End Class
