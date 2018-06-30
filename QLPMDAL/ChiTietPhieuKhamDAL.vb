Imports System.Configuration
Imports System.Data.SqlClient
Imports QLPMDTO
Imports Utility

Public Class ChiTietPhieuKhamDAL

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

    Public Function Insert(chiTietPhieuKham As ChiTietPhieuKhamDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblchi_tiet_phieu_kham] ([ma_chi_tiet_phieu_kham], [ma_phieu_kham], [ma_thuoc], [so_luong]) "
        query &= "VALUES (@ma_chi_tiet_phieu_kham, @ma_phieu_kham, @ma_thuoc, @so_luong) "

        Dim nextID = Nothing
        BuildID(nextID)
        chiTietPhieuKham.MaChiTietPhieuKham = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ma_chi_tiet_phieu_kham", chiTietPhieuKham.MaChiTietPhieuKham)
                    .Parameters.AddWithValue("@ma_phieu_kham", chiTietPhieuKham.MaPhieuKham)
                    .Parameters.AddWithValue("@ma_thuoc", chiTietPhieuKham.MaThuoc)
                    .Parameters.AddWithValue("@so_luong", chiTietPhieuKham.SoLuong)
                End With

                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    'Failure
                    conn.Close()
                    Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm chi tiết phiếu khám mới không thành công", ex.StackTrace)
                End Try
            End Using
        End Using

        'Success
        Return New Result(True)

    End Function

    Public Function Update(chiTietPhieuKham As ChiTietPhieuKhamDTO) As Result

        Dim query As String = Nothing
        query &= "UPDATE [tblchi_tiet_phieu_kham] SET "
        query &= "[ma_chi_tiet_phieu_kham] = @ma_chi_tiet_phieu_kham "
        query &= "[ma_phieu_kham] = @ma_phieu_kham "
        query &= "[ma_thuoc] = @ma_thuoc "
        query &= "[so_luong] = @so_luong "
        query &= "WHERE [ma_chi_tiet_phieu_kham] = @ma_chi_tiet_phieu_kham "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ma_chi_tiet_phieu_kham", chiTietPhieuKham.MaChiTietPhieuKham)
                    .Parameters.AddWithValue("@ma_phieu_kham", chiTietPhieuKham.MaPhieuKham)
                    .Parameters.AddWithValue("@ma_thuoc", chiTietPhieuKham.MaThuoc)
                    .Parameters.AddWithValue("@so_luong", chiTietPhieuKham.SoLuong)
                End With

                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    'Failure
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Cập nhật chi tiết phiếu khám không thành công", ex.StackTrace)
                End Try

            End Using
        End Using

        'Success
        Return New Result(True)

    End Function

    Public Function Delete(maChiTietPhieuKham As String) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblchi_tiet_phieu_kham] "
        query &= " WHERE "
        query &= " [ma_chi_tiet_phieu_kham] = @ma_chi_tiet_phieu_kham "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ma_chi_tiet_phieu_kham", maChiTietPhieuKham)
                End With

                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    'Failure
                    conn.Close()
                    Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa chi tiết phiếu khám không thành công", ex.StackTrace)
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
        query &= "SELECT TOP 1 [ma_chi_tiet_phieu_kham] "
        query &= "FROM [tblchi_tiet_phieu_kham] "
        query &= "ORDER BY [ma_chi_tiet_phieu_kham] DESC "

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
                            idOnDB = reader("ma_chi_tiet_phieu_kham")
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
                    Return New Result(False, "Lấy mã tự động của chi tiết phiếu khám mới không thành công", ex.StackTrace)

                End Try
            End Using
        End Using

        'Success
        Return New Result(True)

    End Function

    Public Function SelectAll_ByMaPhieuKham(maPhieuKham As String, ByRef listChiTietPK As List(Of ChiTietPhieuKhamDTO)) As Result

        Dim query As String = Nothing
        query &= "SELECT * "
        query &= "FROM [tblchi_tiet_phieu_kham] "
        query &= "WHERE [tblchi_tiet_phieu_kham].[ma_phieu_kham] = @ma_phieu_kham "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ma_phieu_kham", maPhieuKham)
                End With

                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listChiTietPK.Clear()
                        While reader.Read()
                            listChiTietPK.Add(New ChiTietPhieuKhamDTO(reader("ma_chi_tiet_phieu_kham"), reader("ma_phieu_kham"),
                                                                      reader("ma_thuoc"), reader("so_luong")))
                        End While
                    End If

                Catch ex As Exception
                    'Failure
                    conn.Close()
                    Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy chi tiết phiếu khám theo mã phiếu khám không thành công", ex.StackTrace)
                End Try

            End Using
        End Using

        'Success
        Return New Result(True)

    End Function

#End Region

End Class
