Imports QLPMDAL
Imports QLPMDTO
Imports Utility

Public Class DanhSachKhamBUS


#Region "Fields"

    Private danhSachKhamDAL As DanhSachKhamDAL

#End Region

#Region "Constructor"

    Public Sub New()
        danhSachKhamDAL = New DanhSachKhamDAL()
    End Sub

    Public Sub New(connectionString As String)
        danhSachKhamDAL = New DanhSachKhamDAL(connectionString)
    End Sub

#End Region

#Region "Methods"

#Region "Insert/Update/Delete on database"

    Public Function Insert(danhSachKham As DanhSachKhamDTO) As Result

        '1. verify data here!!

        '2. Insert to DB
        Return danhSachKhamDAL.Insert(danhSachKham)

    End Function

    Public Function Update(danhSachKham As DanhSachKhamDTO) As Result

        '1. verify data here!!

        '2. Insert to DB
        Return danhSachKhamDAL.Update(danhSachKham)

    End Function

    Public Function Delete(maDanhSachKham As String) As Result

        '1. verify data here!!

        '2. Insert to DB
        Return danhSachKhamDAL.Delete(maDanhSachKham)

    End Function

#End Region

    Public Function BuildID(ByRef nextID As String) As Result

        Return danhSachKhamDAL.BuildID(nextID)

    End Function

    Public Function SelectAll(ByRef listDSKham As List(Of DanhSachKhamDTO)) As Result
        '1. verify data here!!

        '2. Insert to DB
        Return danhSachKhamDAL.SelectAll(listDSKham)
    End Function

#End Region


End Class
