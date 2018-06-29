Imports QLPMDAL
Imports QLPMDTO
Imports Utility

Public Class BenhNhanBUS
    'Private bnDAL As BenhNhanDAL
    'Public Sub New()
    '    bnDAL = New BenhNhanDAL()
    'End Sub
    'Public Sub New(connectionString As String)
    '    bnDAL = New BenhNhanDAL(connectionString)
    'End Sub

    'Public Function Insert(bn As BenhNhanDTO) As Result
    '    '1. verify data here!!

    '    '2. Insert to DB
    '    Return bnDAL.Insert(bn)
    'End Function


    'Public Function BuildID(ByRef nextMsbn As String) As Result
    '    Return bnDAL.BuildID(nextMsbn)
    'End Function


#Region "Fields"

    Private benhNhanDAL As BenhNhanDAL

#End Region

#Region "Constructor"

    Public Sub New()
        benhNhanDAL = New BenhNhanDAL()
    End Sub

    Public Sub New(connectionString As String)
        benhNhanDAL = New BenhNhanDAL(connectionString)
    End Sub

#End Region

#Region "Methods"

#Region "Insert/Update/Delete on database"

    Public Function Insert(benhNhan As BenhNhanDTO) As Result

        '1. verify data here!!

        '2. Insert to DB
        Return benhNhanDAL.Insert(benhNhan)

    End Function

    Public Function Update(benhNhan As BenhNhanDTO) As Result

        '1. verify data here!!

        '2. Insert to DB
        Return benhNhanDAL.Update(benhNhan)

    End Function

    Public Function Delete(maLoaiBenh As String) As Result

        '1. verify data here!!

        '2. Insert to DB
        Return benhNhanDAL.Delete(maLoaiBenh)

    End Function

#End Region

    Public Function BuildID(ByRef nextID As String) As Result

        Return benhNhanDAL.BuildID(nextID)

    End Function

    Public Function SelectAll(ByRef listBenhNhan As List(Of BenhNhanDTO)) As Result
        '1. verify data here!!

        '2. Insert to DB
        Return benhNhanDAL.SelectAll(listBenhNhan)
    End Function

    Public Function IsValidName(benhNhan As BenhNhanDTO) As Boolean

        If (benhNhan.HoTen.Length < 1) Then
            Return False
        End If

        Return True
    End Function

#End Region


End Class
