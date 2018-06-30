Imports QLPMDAL
Imports QLPMDTO
Imports Utility

Public Class ChiTietPhieuKhamBUS

#Region "Fields"

    Private chiTietPhieuKhamDAL As ChiTietPhieuKhamDAL

#End Region

#Region "Constructor"

    Public Sub New()
        chiTietPhieuKhamDAL = New ChiTietPhieuKhamDAL()
    End Sub

    Public Sub New(connectionString As String)
        chiTietPhieuKhamDAL = New ChiTietPhieuKhamDAL(connectionString)
    End Sub

#End Region

#Region "Methods"

#Region "Insert/Update/Delete on database"

    Public Function Insert(chiTietPhieuKham As ChiTietPhieuKhamDTO) As Result

        '1. verify data here!!

        '2. Insert to DB
        Return chiTietPhieuKhamDAL.Insert(chiTietPhieuKham)

    End Function

    Public Function Update(chiTietPhieuKham As ChiTietPhieuKhamDTO) As Result

        '1. verify data here!!

        '2. Insert to DB
        Return chiTietPhieuKhamDAL.Update(chiTietPhieuKham)

    End Function

    Public Function Delete(maCTPK As String) As Result

        '1. verify data here!!

        '2. Insert to DB
        Return chiTietPhieuKhamDAL.Delete(maCTPK)

    End Function

#End Region

    Public Function BuildID(ByRef nextID As String) As Result

        Return chiTietPhieuKhamDAL.BuildID(nextID)

    End Function

    Public Function SelectAll_ByMaPhieuKham(maPhieuKham As String, ByRef listChiTietPK As List(Of ChiTietPhieuKhamDTO)) As Result
        '1. verify data here!!

        '2. Insert to DB
        Return chiTietPhieuKhamDAL.SelectAll_ByMaPhieuKham(maPhieuKham, listChiTietPK)
    End Function

#End Region

End Class
