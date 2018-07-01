Imports System.Configuration
Imports System.Data.SqlClient
Imports QLPMDTO
Imports Utility

Public Class HoaDonDAL

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

    Public Function Insert(hoaDon As HoaDonDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblhoa_don] ([ma_hoa_don], [ma_phieu_kham], [tien_thuoc], [tien_kham]) "
        query &= "VALUES (@ma_hoa_don, @ma_phieu_kham, @tien_thuoc, @tien_kham) "

        Dim nextID = Nothing
        BuildID(nextID)
        hoaDon.MaHoaDon = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ma_hoa_don", hoaDon.MaHoaDon)
                    .Parameters.AddWithValue("@ma_phieu_kham", hoaDon.MaPhieuKham)
                    .Parameters.AddWithValue("@tien_thuoc", hoaDon.TienThuoc)
                    .Parameters.AddWithValue("@tien_kham", hoaDon.TienKham)
                End With

                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    'Failure
                    conn.Close()
                    Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm hóa đơn mới không thành công", ex.StackTrace)
                End Try
            End Using
        End Using

        'Success
        Return New Result(True)

    End Function

    Public Function Update(hoaDon As HoaDonDTO) As Result

        Dim query As String = Nothing
        query &= "UPDATE [tblhoa_don] SET "
        query &= "[ma_hoa_don] = @ma_hoa_don "
        query &= "[ma_phieu_kham] = @ma_phieu_kham "
        query &= "[tien_thuoc] = @tien_thuoc "
        query &= "[tien_kham] = @tien_kham"
        query &= "WHERE [ma_hoa_don] = @ma_hoa_don "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ma_hoa_don", hoaDon.MaHoaDon)
                    .Parameters.AddWithValue("@ma_phieu_kham", hoaDon.MaPhieuKham)
                    .Parameters.AddWithValue("@tien_thuoc", hoaDon.TienThuoc)
                    .Parameters.AddWithValue("@tien_kham", hoaDon.TienKham)
                End With

                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    'Failure
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Cập nhật hóa đơn không thành công", ex.StackTrace)
                End Try

            End Using
        End Using

        'Success
        Return New Result(True)

    End Function

    Public Function Delete(maHoaDon As String) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblhoa_don] "
        query &= " WHERE "
        query &= " [ma_hoa_don] = @ma_hoa_don"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ma_hoa_don", maHoaDon)
                End With

                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    'Failure
                    conn.Close()
                    Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa hóa đơn không thành công", ex.StackTrace)
                End Try

            End Using
        End Using

        'Success
        Return New Result(True)

    End Function

#End Region

    Public Function BuildID(ByRef nextID As String) As Result 'ex: HD000001

        nextID = String.Empty

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [ma_hoa_don] "
        query &= "FROM [tblhoa_don] "
        query &= "ORDER BY [ma_hoa_don] DESC "

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
                            idOnDB = reader("ma_hoa_don")
                        End While
                    Else
                        idOnDB = "HD000000"
                    End If

                    If (idOnDB <> Nothing And idOnDB.Length >= 8) Then
                        Dim currentNumberID = Integer.Parse(idOnDB.Substring(2, 6))
                        Dim nextNumberID = currentNumberID + 1
                        Dim strNextNumberID = nextNumberID.ToString().PadLeft(6, "0")
                        nextID = "HD" + strNextNumberID
                        'For debugging
                        Console.WriteLine(nextID)
                    End If

                Catch ex As Exception
                    'Failure
                    conn.Close()
                    Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy mã tự động của hóa đơn mới không thành công", ex.StackTrace)

                End Try
            End Using
        End Using

        'Success
        Return New Result(True)

    End Function

    Public Function SelectAll(ByRef listHoaDon As List(Of HoaDonDTO)) As Result

        Dim query As String = Nothing
        query &= "SELECT * "
        query &= "FROM [tblhoa_don] "

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
                        listHoaDon.Clear()
                        While reader.Read()
                            listHoaDon.Add(New HoaDonDTO(reader("ma_hoa_don"), reader("ma_phieu_kham"),
                                                         reader("tien_thuoc"), reader("tien_kham")))
                        End While
                    End If

                Catch ex As Exception
                    'Failure
                    conn.Close()
                    Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả hóa đơn không thành công", ex.StackTrace)
                End Try

            End Using
        End Using

        'Success
        Return New Result(True)

    End Function

#End Region

End Class
