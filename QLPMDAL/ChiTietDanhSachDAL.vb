Imports System.Configuration
Imports System.Data.SqlClient
Imports QLPMDTO
Imports Utility

Public Class ChiTietDanhSachDAL

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

    Public Function Insert(chiTietDS As ChiTietDanhSachDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblchi_tiet_danh_sach] ([ma_chi_tiet_danh_sach], [ma_danh_sach], [ma_benh_nhan]) "
        query &= "VALUES (@ma_chi_tiet_danh_sach, @ma_danh_sach, @ma_benh_nhan) "

        Dim nextID = Nothing
        BuildID(nextID)
        chiTietDS.MaChiTietDanhSach = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ma_chi_tiet_danh_sach", chiTietDS.MaChiTietDanhSach)
                    .Parameters.AddWithValue("@ma_danh_sach", chiTietDS.MaDanhSach)
                    .Parameters.AddWithValue("@ma_benh_nhan", chiTietDS.MaBenhNhan)
                End With

                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    'Failure
                    conn.Close()
                    Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm chi tiết danh sách mới không thành công", ex.StackTrace)
                End Try
            End Using
        End Using

        'Success
        Return New Result(True)

    End Function

    Public Function Update(chiTietDS As ChiTietDanhSachDTO) As Result

        Dim query As String = Nothing
        query &= "UPDATE [tblchi_tiet_danh_sach] SET "
        query &= "[ma_chi_tiet_danh_sach] = @ma_chi_tiet_danh_sach "
        query &= "[ma_danh_sach] = @ma_danh_sach "
        query &= "[ma_benh_nhan] = @ma_benh_nhan "
        query &= "WHERE [ma_chi_tiet_danh_sach] = @ma_chi_tiet_danh_sach "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ma_chi_tiet_danh_sach", chiTietDS.MaChiTietDanhSach)
                    .Parameters.AddWithValue("@ma_danh_sach", chiTietDS.MaDanhSach)
                    .Parameters.AddWithValue("@ma_benh_nhan", chiTietDS.MaBenhNhan)
                End With

                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    'Failure
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Cập nhật chi tiết danh sách không thành công", ex.StackTrace)
                End Try

            End Using
        End Using

        'Success
        Return New Result(True)

    End Function

    Public Function Delete(maChiTietDanhSach As String) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblchi_tiet_danh_sach] "
        query &= " WHERE "
        query &= " [ma_chi_tiet_danh_sach] = @ma_chi_tiet_danh_sach "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ma_chi_tiet_danh_sach", maChiTietDanhSach)
                End With

                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    'Failure
                    conn.Close()
                    Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa chi tiết báo cáo doanh thu không thành công", ex.StackTrace)
                End Try

            End Using
        End Using

        'Success
        Return New Result(True)

    End Function

#End Region

    Public Function BuildID(ByRef nextID As String) As Result 'ex: CT000001

        nextID = String.Empty

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [ma_chi_tiet_danh_sach] "
        query &= "FROM [tblchi_tiet_danh_sach] "
        query &= "ORDER BY [ma_chi_tiet_danh_sach] DESC "

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
                            idOnDB = reader("ma_chi_tiet_danh_sach")
                        End While
                    Else
                        idOnDB = "CT000000"
                    End If

                    If (idOnDB <> Nothing And idOnDB.Length >= 8) Then
                        Dim currentNumberID = Integer.Parse(idOnDB.Substring(2, 6))
                        Dim nextNumberID = currentNumberID + 1
                        Dim strNextNumberID = nextNumberID.ToString().PadLeft(6, "0")
                        nextID = "CT" + strNextNumberID
                        'For debugging
                        Console.WriteLine(nextID)
                    End If

                Catch ex As Exception
                    'Failure
                    conn.Close()
                    Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy mã tự động của chi tiết danh sách mới không thành công", ex.StackTrace)

                End Try
            End Using
        End Using

        'Success
        Return New Result(True)

    End Function
    Public Function SelectAll(ByRef listChiTietDS As List(Of ChiTietDanhSachDTO)) As Result

        Dim query As String = Nothing
        query &= "SELECT * "
        query &= "FROM [tblchi_tiet_danh_sach] "

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
                        listChiTietDS.Clear()
                        While reader.Read()
                            listChiTietDS.Add(New ChiTietDanhSachDTO(reader("ma_chi_tiet_danh_sach"), reader("ma_danh_sach"),
                                                                      reader("ma_benh_nhan")))
                        End While
                    End If

                Catch ex As Exception
                    'Failure
                    conn.Close()
                    Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả chi tiết danh sách không thành công", ex.StackTrace)
                End Try

            End Using
        End Using

        'Success
        Return New Result(True)

    End Function
    Public Function SelectAll_MaDanhSach(maDanhSach As String, ByRef listChiTietDS As List(Of ChiTietDanhSachDTO)) As Result

        Dim query As String = Nothing
        query &= "SELECT * "
        query &= "FROM [tblchi_tiet_danh_sach] "
        query &= "WHERE [ma_danh_sach] = @ma_danh_sach "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ma_danh_sach", maDanhSach)
                End With

                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listChiTietDS.Clear()
                        While reader.Read()
                            listChiTietDS.Add(New ChiTietDanhSachDTO(reader("ma_chi_tiet_danh_sach"), reader("ma_danh_sach"),
                                                                      reader("ma_benh_nhan")))
                        End While
                    End If

                Catch ex As Exception
                    'Failure
                    conn.Close()
                    Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả chi tiết danh sách theo mã danh sách không thành công", ex.StackTrace)
                End Try

            End Using
        End Using

        'Success
        Return New Result(True)

    End Function

#End Region

End Class
