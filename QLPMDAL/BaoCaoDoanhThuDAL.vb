﻿Imports System.Configuration
Imports System.Data.SqlClient
Imports QLPMDTO
Imports Utility

Public Class BaoCaoDoanhThuDAL

#Region "Fields"

    Private connectionString As String

#End Region

#Region "Constructor"

    ''' <summary>
    ''' Read ConnectionString value from App.config file
    ''' </summary>
    Public Sub New()
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

#End Region

#Region "Methods"

#Region "Insert/Update/Delete on database"

    Public Function Insert(baoCaoDoanhThu As BaoCaoDoanhThuDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblbao_cao_doanh_thu] ([ma_bao_cao_doanh_thu], [thang_bao_cao]) "
        query &= "VALUES (@ma_bao_cao_doanh_thu, @thang_bao_cao) "

        Dim nextID = Nothing
        nextID = BuildID(nextID)
        baoCaoDoanhThu.MaBaoCaoDoanhThu = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ma_bao_cao_doanh_thu", baoCaoDoanhThu.MaBaoCaoDoanhThu)
                    .Parameters.AddWithValue("@thang_bao_cao", baoCaoDoanhThu.ThangBaoCao)
                End With

                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    'Failure
                    conn.Close()
                    Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm bảng báo cáo doanh thu mới không thành công", ex.StackTrace)
                End Try
            End Using
        End Using

        'Success
        Return New Result(True)

    End Function

    Public Function Update(baoCaoDoanhThu As BaoCaoDoanhThuDTO) As Result

        Dim query As String = Nothing
        query &= "UPDATE [tblbao_cao_doanh_thu] SET "
        query &= "[ma_bao_cao_doanh_thu] = @ma_bao_cao_doanh_thu "
        query &= "[thang_bao_cao] = @thang_bao_cao "
        query &= "WHERE [ma_bao_cao_doanh_thu] = @ma_bao_cao_doanh_thu "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ma_bao_cao_doanh_thu", baoCaoDoanhThu.MaBaoCaoDoanhThu)
                    .Parameters.AddWithValue("@thang_bao_cao", baoCaoDoanhThu.ThangBaoCao)
                End With

                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    'Failure
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Cập nhật bảng báo cáo doanh thu không thành công", ex.StackTrace)
                End Try

            End Using
        End Using

        'Success
        Return New Result(True)

    End Function

    Public Function Delete(maBaoCaoDoanhThu As String) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblbao_cao_doanh_thu] "
        query &= " WHERE "
        query &= " [ma_bao_cao_doanh_thu] = @ma_bao_cao_doanh_thu "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ma_bao_cao_doanh_thu", maBaoCaoDoanhThu)
                End With

                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    'Failure
                    conn.Close()
                    Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa bảng báo cáo doanh thu không thành công", ex.StackTrace)
                End Try

            End Using
        End Using

        'Success
        Return New Result(True)

    End Function

#End Region

    Public Function BuildID(ByRef nextID As String) As Result 'ex: BC000001

        nextID = String.Empty

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [ma_bao_cao_doanh_thu] "
        query &= "FROM [tblbao_cao_doanh_thu] "
        query &= "ORDER BY [ma_bao_cao_doanh_thu] DESC "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With

                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    Dim idOnDB As String = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            idOnDB = reader("ma_bao_cao_doanh_thu")
                        End While
                    Else
                        idOnDB = "BC000000"
                    End If

                    If (idOnDB <> Nothing And idOnDB.Length >= 8) Then
                        Dim currentNumberID = Integer.Parse(idOnDB.Substring(2, 6))
                        Dim nextNumberID = currentNumberID + 1
                        Dim strNextNumberID = nextNumberID.ToString().PadLeft(6, "0")
                        nextID = "BC" + strNextNumberID
                        'For debugging
                        Console.WriteLine(nextID)
                    End If

                Catch ex As Exception
                    'Failure
                    conn.Close()
                    Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy mã tự động của bảng báo cáo doanh thu mới không thành công", ex.StackTrace)

                End Try
            End Using
        End Using

        'Success
        Return New Result(True)

    End Function

    Public Function SelectAll(ByRef listBaoCaoDoanhThu As List(Of BaoCaoDoanhThuDTO)) As Result

        Dim query As String = Nothing
        query &= "SELECT * "
        query &= "FROM [tblbao_cao_doanh_thu] "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With

                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listBaoCaoDoanhThu.Clear()
                        While reader.Read()
                            listBaoCaoDoanhThu.Add(New BaoCaoDoanhThuDTO(reader("ma_bao_cao_doanh_thu"), reader("thang_bao_cao")))
                        End While
                    End If

                Catch ex As Exception
                    'Failure
                    conn.Close()
                    Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả bảng báo cáo doanh thu không thành công", ex.StackTrace)
                End Try

            End Using
        End Using

        'Success
        Return New Result(True)

    End Function

#End Region

End Class
