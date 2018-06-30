Imports QLPMDAL
Imports QLPMDTO
Imports Utility

Public Class PhieuKhamBUS

#Region "Fields"

    Private phieuKhamDAL As PhieuKhamDAL

#End Region

#Region "Constructor"

    Public Sub New()
        phieuKhamDAL = New PhieuKhamDAL()
    End Sub

    Public Sub New(connectionString As String)
        phieuKhamDAL=New PhieuKhamDAL(connectionString)
    End Sub

#End Region

#Region "Methods"

#Region "Insert/Update/Delete on database"

    Public Function Insert(phieuKham As PhieuKhamDTO) As Result

        '1. verify data here!!

        '2. Insert to DB
        Return phieuKhamDAL.Insert(phieuKham)

    End Function

    Public Function Update(phieuKham As PhieuKhamDTO) As Result

        '1. verify data here!!

        '2. Insert to DB
        Return phieuKhamDAL.Update(phieuKham)

    End Function

    Public Function Delete(maPhieuKham As String) As Result

        '1. verify data here!!

        '2. Insert to DB
        Return phieuKhamDAL.Delete(maPhieuKham)

    End Function

#End Region

    Public Function BuildID(ByRef nextID As String) As Result

        Return phieuKhamDAL.BuildID(nextID)

    End Function

    Public Function SelectAll(ByRef listPhieuKham As List(Of PhieuKhamDTO)) As Result
        '1. verify data here!!

        '2. Insert to DB
        Return phieuKhamDAL.SelectAll(listPhieuKham)
    End Function

#End Region

End Class
