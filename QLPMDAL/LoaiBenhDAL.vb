Imports System.Configuration
Imports System.Data.SqlClient
Imports QLPMDTO
Imports Utility

Public Class LoaiBenhDAL

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

    Public Function Insert(loaiBenh As LoaiBenhDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblloai_benh] ([ma_loai_benh], [loai_benh]) "
        query &= "VALUES (@ma_loai_benh, @loai_benh) "

        Dim nextID = Nothing
        nextID = BuildID(nextID)
        loaiBenh.MaLoaiBenh = nextID

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ma_loai_benh", loaiBenh.MaLoaiBenh)
                    .Parameters.AddWithValue("@loai_benh", loaiBenh.LoaiBenh)
                End With

                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    'Failure
                    conn.Close()
                    Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm loại bệnh mới không thành công", ex.StackTrace)
                End Try
            End Using
        End Using

        'Success
        Return New Result(True)

    End Function

    Public Function Update(loaiBenh As LoaiBenhDTO) As Result

        Dim query As String = Nothing
        query &= "UPDATE [tblloai_benh] SET "
        query &= "[ma_loai_benh] = @ma_loai_benh "
        query &= "[loai_benh] = @loai_benh "
        query &= "WHERE [ma_loai_benh] = @ma_loai_benh "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ma_don_vi", loaiBenh.MaLoaiBenh)
                    .Parameters.AddWithValue("@don_vi", loaiBenh.LoaiBenh)
                End With

                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    'Failure
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Cập nhật loại bệnh không thành công", ex.StackTrace)
                End Try

            End Using
        End Using

        'Success
        Return New Result(True)

    End Function

    Public Function Delete(maLoaiBenh As String) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblloai_benh] "
        query &= " WHERE "
        query &= " [ma_loai_benh] = @ma_loai_benh "

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
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    'Failure
                    conn.Close()
                    Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa loại bệnh không thành công", ex.StackTrace)
                End Try

            End Using
        End Using

        'Success
        Return New Result(True)

    End Function

#End Region

    Public Function BuildID(ByRef nextID As String) As Result 'ex: LB000001

        nextID = String.Empty

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [ma_loai_benh] "
        query &= "FROM [tblloai_benh] "
        query &= "ORDER BY [ma_loai_benh] DESC "

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
                            idOnDB = reader("ma_loai_benh")
                        End While
                    End If

                    If (idOnDB <> Nothing And idOnDB.Length >= 8) Then
                        Dim currentNumberID = Integer.Parse(idOnDB.Substring(2, 6))
                        Dim nextNumberID = currentNumberID + 1
                        Dim strNextNumberID = nextNumberID.ToString().PadLeft(6, "0")
                        nextID = "LB" + strNextNumberID
                        'For debugging
                        Console.WriteLine(nextID)
                    End If

                Catch ex As Exception
                    'Failure
                    conn.Close()
                    Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy mã tự động của loại bệnh mới không thành công", ex.StackTrace)

                End Try
            End Using
        End Using

        'Success
        Return New Result(True)

    End Function

#End Region

End Class
