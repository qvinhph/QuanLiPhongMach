﻿Imports System.Configuration
Imports System.Data.SqlClient
Imports QLPMDTO
Imports Utility

Public Class BenhNhanDAL

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

    Public Function Insert(benhNhan As BenhNhanDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblbenh_nhan] ([ma_benh_nhan], [ho_ten], [gioi_tinh], [nam_sinh], [dia_chi])"
        query &= "VALUES (@ma_benh_nhan, @ho_ten, @gioi_tinh, @nam_sinh, @dia_chi) "

        'Dim nextID = Nothing
        'benhNhan.MaBenhNhan = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ma_benh_nhan", benhNhan.MaBenhNhan)
                    .Parameters.AddWithValue("@ho_ten", benhNhan.HoTen)
                    .Parameters.AddWithValue("@gioi_tinh", benhNhan.GioiTinh)
                    .Parameters.AddWithValue("@nam_sinh", benhNhan.NgaySinh)
                    .Parameters.AddWithValue("@dia_chi", benhNhan.DiaChi)
                End With

                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    'Failure
                    conn.Close()
                    Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm bệnh nhân mới không thành công", ex.StackTrace)
                End Try
            End Using
        End Using

        'Success
        Return New Result(True)

    End Function

    Public Function Update(benhNhan As BenhNhanDTO) As Result

        Dim query As String = Nothing
        query &= "UPDATE [tblbenh_nhan] SET "
        query &= "[ma_benh_nhan] = @ma_benh_nhan "
        query &= "[ho_ten] = @ho_ten "
        query &= "[gioi_tinh] = @gioi_tinh "
        query &= "[nam_sinh] = @nam_sinh "
        query &= "[dia_chi] = @dia_chi "
        query &= "WHERE [ma_benh_nhan] = @ma_benh_nhan "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ma_benh_nhan", benhNhan.MaBenhNhan)
                    .Parameters.AddWithValue("@ho_ten", benhNhan.HoTen)
                    .Parameters.AddWithValue("@gioi_tinh", benhNhan.GioiTinh)
                    .Parameters.AddWithValue("@nam_sinh", benhNhan.NgaySinh)
                    .Parameters.AddWithValue("@dia_chi", benhNhan.DiaChi)
                End With

                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    'Failure
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Cập nhật bệnh nhân không thành công", ex.StackTrace)
                End Try

            End Using
        End Using

        'Success
        Return New Result(True)

    End Function

    Public Function Delete(maBenhNhan As String) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblbenh_nhan] "
        query &= " WHERE "
        query &= " [ma_benh_nhan] = @ma_benh_nhan "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ma_benh_nhan", maBenhNhan)
                End With

                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    'Failure
                    conn.Close()
                    Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa bệnh nhân không thành công", ex.StackTrace)
                End Try

            End Using
        End Using

        'Success
        Return New Result(True)

    End Function

#End Region

    Public Function BuildID(ByRef nextID As String) As Result 'ex: DV000001

        nextID = String.Empty

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [ma_benh_nhan] "
        query &= "FROM [tblbenh_nhan] "
        query &= "ORDER BY [ma_benh_nhan] DESC "

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
                            idOnDB = reader("ma_benh_nhan")
                        End While
                    Else
                        idOnDB = "BN000000"
                    End If

                    If (idOnDB <> Nothing And idOnDB.Length >= 8) Then
                        Dim currentNumberID = Integer.Parse(idOnDB.Substring(2, 6))
                        Dim nextNumberID = currentNumberID + 1
                        Dim strNextNumberID = nextNumberID.ToString().PadLeft(6, "0")
                        nextID = "BN" + strNextNumberID
                        'For debugging
                        Console.WriteLine(nextID)
                    End If

                Catch ex As Exception
                    'Failure
                    conn.Close()
                    Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy mã tự động của bệnh nhân mới không thành công", ex.StackTrace)

                End Try
            End Using
        End Using

        'Success
        Return New Result(True)

    End Function

    Public Function SelectAll(ByRef listBenhNhan As List(Of BenhNhanDTO)) As Result

        Dim query As String = Nothing
        query &= "SELECT * "
        query &= "FROM [tblbenh_nhan] "

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
                        listBenhNhan.Clear()
                        While reader.Read()
                            listBenhNhan.Add(New BenhNhanDTO(reader("ma_benh_nhan"), reader("ho_ten"), reader("dia_chi"), reader("nam_sinh"), reader("gioi_tinh")))
                        End While
                    End If

                Catch ex As Exception
                    'Failure
                    conn.Close()
                    Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả bệnh nhân không thành công", ex.StackTrace)
                End Try

            End Using
        End Using

        'Success
        Return New Result(True)

    End Function
    Public Function SelectAll_ByLoaiBenh(maLoaiBenh As String, ByRef listBenhNhan As List(Of BenhNhanDTO)) As Result
        Dim query As String = String.Empty
        query &= "SELECT [tblbenh_nhan].[ma_benh_nhan], [ho_ten], [gioi_tinh], [nam_sinh], [dia_chi]"
        query &= " FROM [tblbenh_nhan] "
        query &= "     ,[tblphieu_kham]"
        query &= "     ,[tblchi_tiet_danh_sach]"
        query &= " WHERE "
        query &= "      [tblbenh_nhan].[ma_benh_nhan] = [tblchi_tiet_danh_sach].[ma_benh_nhan]"
        query &= "     AND [tblphieu_kham].[ma_chi_tiet_danh_sach] = [tblchi_tiet_danh_sach].[ma_chi_tiet_danh_sach]"
        query &= "     AND [tblphieu_kham].[ma_loai_benh] = @ma_loai_benh"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ma_loai_benh", maLoaiBenh)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listBenhNhan.Clear()
                        While reader.Read()
                            listBenhNhan.Add(New BenhNhanDTO(reader("ma_benh_nhan"), reader("ho_ten"), reader("dia_chi"), reader("nam_sinh"), reader("gioi_tinh")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả Bệnh nhân theo Loại bệnh không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function SelectAll_ByNgayKham(ngayKham As Date, ByRef listBenhNhan As List(Of BenhNhanDTO)) As Result
        Dim query As String = String.Empty
        query &= "SELECT [tblbenh_nhan].[ma_benh_nhan], [ho_ten], [gioi_tinh], [nam_sinh], [dia_chi]"
        query &= " FROM [tblbenh_nhan] "
        query &= "     ,[tbldanh_sach_kham]"
        query &= "     ,[tblchi_tiet_danh_sach]"
        query &= " WHERE "
        query &= "      [tblbenh_nhan].[ma_benh_nhan] = [tblchi_tiet_danh_sach].[ma_benh_nhan]"
        query &= "     AND [tbldanh_sach_kham].[ma_danh_sach] = [tblchi_tiet_danh_sach].[ma_danh_sach]"
        query &= "     AND [tbldanh_sach_kham].[ngay_kham] = @ngaykham"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ngaykham", ngayKham)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listBenhNhan.Clear()
                        While reader.Read()
                            listBenhNhan.Add(New BenhNhanDTO(reader("ma_benh_nhan"), reader("ho_ten"), reader("dia_chi"), reader("nam_sinh"), reader("gioi_tinh")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả Bệnh nhân theo Ngày khám không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function SelectAll_ByName(HoTen As String, ByRef listBenhNhan As List(Of BenhNhanDTO)) As Result

        Dim query As String = Nothing
        query &= "SELECT * "
        query &= "FROM [tblbenh_nhan] "
        query &= " WHERE [tblbenh_nhan].[ho_ten]=@hoten"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@hoten", HoTen)
                End With

                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listBenhNhan.Clear()
                        While reader.Read()
                            listBenhNhan.Add(New BenhNhanDTO(reader("ma_benh_nhan"), reader("ho_ten"), reader("dia_chi"), reader("nam_sinh"), reader("gioi_tinh")))
                        End While
                    End If

                Catch ex As Exception
                    'Failure
                    conn.Close()
                    Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả bệnh nhân theo tên không thành công", ex.StackTrace)
                End Try

            End Using
        End Using

        'Success
        Return New Result(True)

    End Function

    Public Function SelectAll_ByID(MaSo As String, ByRef listBenhNhan As List(Of BenhNhanDTO)) As Result

        Dim query As String = Nothing
        query &= "SELECT * "
        query &= "FROM [tblbenh_nhan] "
        query &= " WHERE [tblbenh_nhan].[ma_benh_nhan] = @maso"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maso", MaSo)
                End With

                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listBenhNhan.Clear()
                        While reader.Read()
                            listBenhNhan.Add(New BenhNhanDTO(reader("ma_benh_nhan"), reader("ho_ten"), reader("dia_chi"), reader("nam_sinh"), reader("gioi_tinh")))
                        End While
                    End If

                Catch ex As Exception
                    'Failure
                    conn.Close()
                    Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả bệnh nhân theo mã số không thành công", ex.StackTrace)
                End Try

            End Using
        End Using

        'Success
        Return New Result(True)

    End Function
#End Region

End Class
