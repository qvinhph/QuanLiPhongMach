Imports QLPMDAL
Imports QLPMDTO
Imports Utility

Public Class ChiTietBaoCaoThuocBUS

#Region "Fields"

    Private chiTietDAL As ChiTietBaoCaoThuocDAL

#End Region

#Region "Constructor"

    Public Sub New()
        chiTietDAL = New ChiTietBaoCaoThuocDAL()
    End Sub

    Public Sub New(connectionString As String)
        chiTietDAL = New ChiTietBaoCaoThuocDAL(connectionString)
    End Sub

#End Region

#Region "Methods"

#Region "Insert/Update/Delete on database"

    Public Function Insert(chiTietBaoCao As ChiTietBaoCaoThuocDTO) As Result

        '1. verify data here!!

        '2. Insert to DB
        Return chiTietDAL.Insert(chiTietBaoCao)

    End Function

    Public Function Update(chiTietBaoCao As ChiTietBaoCaoThuocDTO) As Result

        '1. verify data here!!

        '2. Insert to DB
        Return chiTietDAL.Update(chiTietBaoCao)

    End Function

    Public Function Delete(maChiTietBaoCao As String) As Result

        '1. verify data here!!

        '2. Insert to DB
        Return chiTietDAL.Delete(maChiTietBaoCao)

    End Function

#End Region

    Public Function BuildID(ByRef nextID As String) As Result

        Return chiTietDAL.BuildID(nextID)

    End Function

    Public Function SelectAll_ByMaBaoCaoDoanhThu(maBaoCao As String, ByRef listChiTietBaoCaoThuoc As List(Of ChiTietBaoCaoThuocDTO)) As Result
        '1. verify data here!!

        '2. Insert to DB
        Return chiTietDAL.SelectAll_ByMaBaoCaoThuoc(maBaoCao, listChiTietBaoCaoThuoc)
    End Function

#End Region

End Class
