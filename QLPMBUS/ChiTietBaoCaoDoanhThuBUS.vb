Imports QLPMDAL
Imports QLPMDTO
Imports Utility

Public Class ChiTietBaoCaoDoanhThuBUS

#Region "Fields"

    Private chiTietDAL As ChiTietBaoCaoDoanhThuDAL

#End Region

#Region "Constructor"

    Public Sub New()
        chiTietDAL = New ChiTietBaoCaoDoanhThuDAL()
    End Sub

    Public Sub New(connectionString As String)
        chiTietDAL = New ChiTietBaoCaoDoanhThuDAL(connectionString)
    End Sub

#End Region

#Region "Methods"

#Region "Insert/Update/Delete on database"

    Public Function Insert(chiTietBaoCao As ChiTietBaoCaoDoanhThuDTO) As Result

        '1. verify data here!!

        '2. Insert to DB
        Return chiTietDAL.Insert(chiTietBaoCao)

    End Function

    Public Function Update(chiTietBaoCao As ChiTietBaoCaoDoanhThuDTO) As Result

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

    Public Function SelectAll_ByMaBaoCaoDoanhThu(maBaoCaoDT As String, ByRef listChiTietBCDT As List(Of ChiTietBaoCaoDoanhThuDTO)) As Result
        '1. verify data here!!

        '2. Insert to DB
        Return chiTietDAL.SelectAll_ByMaBaoCaoDoanhThu(maBaoCaoDT, listChiTietBCDT)
    End Function

#End Region

End Class
