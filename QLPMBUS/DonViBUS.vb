Imports QLPMDAL
Imports QLPMDTO
Imports Utility

Public Class DonViBUS

#Region "Fields"

    Private donViDAL As DonViDAL

#End Region

#Region "Constructor"

    Public Sub New()
        donViDAL = New DonViDAL()
    End Sub

    Public Sub New(connectionString As String)
        donViDAL = New DonViDAL(connectionString)
    End Sub

#End Region

#Region "Methods"

#Region "Insert/Update/Delete on database"

    Public Function Insert(donVi As DonViDTO) As Result

        '1. verify data here!!

        '2. Insert to DB
        Return donViDAL.Insert(donVi)

    End Function

    Public Function Update(donVi As DonViDTO) As Result

        '1. verify data here!!

        '2. Insert to DB
        Return donViDAL.Update(donVi)

    End Function

    Public Function Delete(maDonVi As String) As Result

        '1. verify data here!!

        '2. Insert to DB
        Return donViDAL.Delete(maDonVi)

    End Function

#End Region

    Public Function BuildID(ByRef nextID As String) As Result

        Return donViDAL.BuildID(nextID)

    End Function

    Public Function SelectAll(ByRef listDonVi As List(Of DonViDTO)) As Result
        '1. verify data here!!

        '2. Insert to DB
        Return donViDAL.SelectAll(listDonVi)
    End Function

#End Region

End Class
