Imports QLPMDAL
Imports QLPMDTO
Imports Utility

Public Class HoaDonBUS

#Region "Fields"

    Private hoaDonDAL As HoaDonDAL

#End Region

#Region "Constructor"

    Public Sub New()
        hoaDonDAL = New HoaDonDAL()
    End Sub

    Public Sub New(connectionString As String)
        hoaDonDAL = New HoaDonDAL(connectionString)
    End Sub

#End Region

#Region "Methods"

#Region "Insert/Update/Delete on database"

    Public Function Insert(hoaDon As HoaDonDTO) As Result

        '1. verify data here!!

        '2. Insert to DB
        Return hoaDonDAL.Insert(hoaDon)

    End Function

    Public Function Update(hoaDon As HoaDonDTO) As Result

        '1. verify data here!!

        '2. Insert to DB
        Return hoaDonDAL.Update(hoaDon)

    End Function

    Public Function Delete(maHoaDon As String) As Result

        '1. verify data here!!

        '2. Insert to DB
        Return hoaDonDAL.Delete(maHoaDon)

    End Function

#End Region

    Public Function BuildID(ByRef nextID As String) As Result

        Return hoaDonDAL.BuildID(nextID)

    End Function

    Public Function SelectAll(ByRef listHoaDon As List(Of HoaDonDTO)) As Result
        '1. verify data here!!

        '2. Insert to DB
        Return hoaDonDAL.SelectAll(listHoaDon)
    End Function

#End Region

End Class
