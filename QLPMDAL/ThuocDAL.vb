Imports System.Configuration
Imports System.Data.SqlClient
Imports QLPMDTO
Imports Utility

Public Class ThuocDAL

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

    Public Function Insert(thuoc As ThuocDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblthuoc] ([ma_thuoc], [ten_thuoc], [ma_don_vi], [so_luong], [ma_cach_dung], [don_gia]) "
        query &= "VALUES (@ma_thuoc, @ten_thuoc, @ma_don_vi, @so_luong, @ma_cach_dung, @don_gia) "

        Dim nextID = Nothing
        nextID = BuildID(nextID)
        thuoc.MaThuoc = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ma_thuoc", thuoc.MaThuoc)
                    .Parameters.AddWithValue("@ten_thuoc", thuoc.TenThuoc)
                    .Parameters.AddWithValue("@ma_don_vi", thuoc.MaDonVi)
                    .Parameters.AddWithValue("@so_luong", thuoc.SoLuong)
                    .Parameters.AddWithValue("@ma_cach_dung", thuoc.MaCachDung)
                    .Parameters.AddWithValue("@don_gia", thuoc.DonGia)
                End With

                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    'Failure
                    conn.Close()
                    Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm thuốc mới không thành công", ex.StackTrace)
                End Try
            End Using
        End Using

        'Success
        Return New Result(True)

    End Function

    Public Function Update(thuoc As ThuocDTO) As Result

        Dim query As String = Nothing
        query &= "UPDATE [tblthuoc] SET "
        query &= "[ma_thuoc] = @ma_thuoc "
        query &= "[ten_thuoc] = @ten_thuoc "
        query &= "[ma_don_vi] = @ma_don_vi "
        query &= "[so_luong] = @so_luong "
        query &= "[ma_cach_dung] = @ma_cach_dung "
        query &= "[don_gia] = @don_gia "
        query &= "WHERE [ma_thuoc] = @ma_thuoc "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ma_thuoc", thuoc.MaThuoc)
                    .Parameters.AddWithValue("@ten_thuoc", thuoc.TenThuoc)
                    .Parameters.AddWithValue("@ma_don_vi", thuoc.MaDonVi)
                    .Parameters.AddWithValue("@so_luong", thuoc.SoLuong)
                    .Parameters.AddWithValue("@ma_cach_dung", thuoc.MaCachDung)
                    .Parameters.AddWithValue("@don_gia", thuoc.DonGia)
                End With

                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    'Failure
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Cập nhật thuốc không thành công", ex.StackTrace)
                End Try

            End Using
        End Using

        'Success
        Return New Result(True)

    End Function

    Public Function Delete(maThuoc As String) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblthuoc] "
        query &= " WHERE "
        query &= " [ma_thuoc] = @ma_thuoc"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ma_thuoc", maThuoc)
                End With

                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    'Failure
                    conn.Close()
                    Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa thuốc không thành công", ex.StackTrace)
                End Try

            End Using
        End Using

        'Success
        Return New Result(True)

    End Function

#End Region

    Public Function BuildID(ByRef nextID As String) As Result 'ex: TH000001

        nextID = String.Empty

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [ma_thuoc] "
        query &= "FROM [tblthuoc] "
        query &= "ORDER BY [ma_thuoc] DESC "

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
                            idOnDB = reader("ma_thuoc")
                        End While
                    Else
                        idOnDB = "TH000000"
                    End If

                    If (idOnDB <> Nothing And idOnDB.Length >= 8) Then
                        Dim currentNumberID = Integer.Parse(idOnDB.Substring(2, 6))
                        Dim nextNumberID = currentNumberID + 1
                        Dim strNextNumberID = nextNumberID.ToString().PadLeft(6, "0")
                        nextID = "TH" + strNextNumberID
                        'For debugging
                        Console.WriteLine(nextID)
                    End If

                Catch ex As Exception
                    'Failure
                    conn.Close()
                    Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy mã tự động của thuốc mới không thành công", ex.StackTrace)

                End Try
            End Using
        End Using

        'Success
        Return New Result(True)

    End Function

    Public Function SelectAll(ByRef listThuoc As List(Of ThuocDTO)) As Result

        Dim query As String = Nothing
        query &= "SELECT * "
        query &= "FROM [tblthuoc] "

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
                        listThuoc.Clear()
                        While reader.Read()
                            listThuoc.Add(New ThuocDTO(reader("ma_thuoc"), reader("ten_thuoc"), reader("ma_don_vi"),
                                                    reader("ma_cach_dung"), reader("so_luong"), reader("don_gia")))
                        End While
                    End If

                Catch ex As Exception
                    'Failure
                    conn.Close()
                    Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả thuốc không thành công", ex.StackTrace)
                End Try

            End Using
        End Using

        'Success
        Return New Result(True)

    End Function

#End Region

End Class
