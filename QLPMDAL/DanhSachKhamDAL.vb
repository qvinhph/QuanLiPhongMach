Imports System.Configuration
Imports System.Data.SqlClient
Imports QLPMDTO
Imports Utility


Public Class DanhSachKhamDAL

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

    Public Function Insert(danhSachKham As DanhSachKhamDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tbldanh_sach_kham] ([ma_danh_sach], [ngay_kham]) "
        query &= "VALUES (@ma_danh_sach, @ngay_kham) "

        Dim nextID = Nothing
        nextID = BuildID(nextID)
        danhSachKham.MaDanhSach = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ma_danh_sach", danhSachKham.MaDanhSach)
                    .Parameters.AddWithValue("@ngay_kham", danhSachKham.NgayKham)
                End With

                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    'Failure
                    conn.Close()
                    Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm danh sách khám mới không thành công", ex.StackTrace)
                End Try
            End Using
        End Using

        'Success
        Return New Result(True)

    End Function

    Public Function Update(danhSachKham As DanhSachKhamDTO) As Result

        Dim query As String = Nothing
        query &= "UPDATE [tbldanh_sach_kham] SET "
        query &= "[ma_danh_sach] = @ma_danh_sach "
        query &= "[ngay_kham] = @ngay_kham "
        query &= "WHERE [ma_danh_sach] = @ma_danh_sach "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ma_danh_sach", danhSachKham.MaDanhSach)
                    .Parameters.AddWithValue("@ngay_kham", danhSachKham.NgayKham)
                End With

                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    'Failure
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Cập nhật danh sách khám không thành công", ex.StackTrace)
                End Try

            End Using
        End Using

        'Success
        Return New Result(True)

    End Function

    Public Function Delete(maDanhSach As String) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tbldanh_sach_kham] "
        query &= " WHERE "
        query &= " [ma_danh_sach] = @ma_danh_sach "

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
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    'Failure
                    conn.Close()
                    Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa danh sách khám không thành công", ex.StackTrace)
                End Try

            End Using
        End Using

        'Success
        Return New Result(True)

    End Function

#End Region

    Public Function BuildID(ByRef nextID As String) As Result 'ex: DS000001

        nextID = String.Empty

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [ma_danh_sach] "
        query &= "FROM [tbldanh_sach_kham] "
        query &= "ORDER BY [ma_danh_sach] DESC "

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
                            idOnDB = reader("ma_danh_sach")
                        End While
                    Else
                        idOnDB = "DS000000"
                    End If

                    If (idOnDB <> Nothing And idOnDB.Length >= 8) Then
                        Dim currentNumberID = Integer.Parse(idOnDB.Substring(2, 6))
                        Dim nextNumberID = currentNumberID + 1
                        Dim strNextNumberID = nextNumberID.ToString().PadLeft(6, "0")
                        nextID = "DS" + strNextNumberID
                        'For debugging
                        Console.WriteLine(nextID)
                    End If

                Catch ex As Exception
                    'Failure
                    conn.Close()
                    Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy mã tự động của danh sách khám mới không thành công", ex.StackTrace)

                End Try
            End Using
        End Using

        'Success
        Return New Result(True)

    End Function

    Public Function SelectAll(ByRef listDanhSachKham As List(Of DanhSachKhamDTO)) As Result

        Dim query As String = Nothing
        query &= "SELECT * "
        query &= "FROM [tbldanh_sach_kham] "

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
                        listDanhSachKham.Clear()
                        While reader.Read()
                            listDanhSachKham.Add(New DanhSachKhamDTO(reader("ma_danh_sach"), reader("ngay_kham")))
                        End While
                    End If

                Catch ex As Exception
                    'Failure
                    conn.Close()
                    Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả danh sách khám không thành công", ex.StackTrace)
                End Try

            End Using
        End Using

        'Success
        Return New Result(True)

    End Function

#End Region

End Class
