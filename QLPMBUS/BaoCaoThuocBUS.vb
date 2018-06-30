Imports QLPMDAL
Imports QLPMDTO
Imports Utility

Public Class BaoCaoThuocBUS

#Region "Fields"

    Private baoCaoDAL As BaoCaoThuocDAL

#End Region

#Region "Constructor"

    Public Sub New()
        baoCaoDAL = New BaoCaoThuocDAL()
    End Sub

    Public Sub New(connectionString As String)
        baoCaoDAL = New BaoCaoThuocDAL(connectionString)
    End Sub

#End Region

#Region "Methods"

#Region "Insert/Update/Delete on database"

    Public Function Insert(baoCao As BaoCaoThuocDTO) As Result

        '1. verify data here!!

        '2. Insert to DB
        Return baoCaoDAL.Insert(baoCao)

    End Function

    Public Function Update(baoCao As BaoCaoThuocDTO) As Result

        '1. verify data here!!

        '2. Insert to DB
        Return baoCaoDAL.Update(baoCao)

    End Function

    Public Function Delete(maBaoCao As String) As Result

        '1. verify data here!!

        '2. Insert to DB
        Return baoCaoDAL.Delete(maBaoCao)

    End Function

#End Region

    Public Function BuildID(ByRef nextID As String) As Result

        Return baoCaoDAL.BuildID(nextID)

    End Function

    Public Function SelectAll(ByRef listBaoCao As List(Of BaoCaoThuocDTO)) As Result
        '1. verify data here!!

        '2. Insert to DB
        Return baoCaoDAL.SelectAll(listBaoCao)
    End Function

#End Region

End Class
