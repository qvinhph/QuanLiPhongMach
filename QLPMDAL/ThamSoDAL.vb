Imports System.Configuration
Imports System.Data.SqlClient
Imports QLPMDTO
Imports Utility

Public Class ThamSoDAL

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

    'Public Function Insert(thamSo As ThamSoDTO) As Result

    '    Dim query As String = String.Empty
    '    query &= "INSERT INTO [tbltham_so] ([so_benh_nhan_toi_da], [tien_kham]) "
    '    query &= "VALUES (@so_benh_nhan_toi_da, @tien_kham) "

    '    Using conn As New SqlConnection(connectionString)
    '        Using comm As New SqlCommand()
    '            With comm
    '                .Connection = conn
    '                .CommandType = CommandType.Text
    '                .CommandText = query
    '                .Parameters.AddWithValue("@so_benh_nhan_toi_da", thamSo.SoBenhNhanToiDa)
    '                .Parameters.AddWithValue("@tien_kham", thamSo.TienKham)
    '            End With

    '            Try
    '                conn.Open()
    '                comm.ExecuteNonQuery()
    '            Catch ex As Exception
    '                'Failure
    '                conn.Close()
    '                Console.WriteLine(ex.StackTrace)
    '                Return New Result(False, "Thêm tham số không thành công", ex.StackTrace)
    '            End Try
    '        End Using
    '    End Using

    '    'Success
    '    Return New Result(True)

    'End Function

    Public Function Update(thamSo As ThamSoDTO) As Result

        Dim query As String = Nothing
        query &= "UPDATE [tbltham_so] SET "
        query &= "[so_benh_nhan_toi_da] = @so_benh_nhan_toi_da "
        query &= "[tien_kham] = @tien_kham "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@so_benh_nhan_toi_da", thamSo.SoBenhNhanToiDa)
                    .Parameters.AddWithValue("@tien_kham", thamSo.TienKham)
                End With

                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    'Failure
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Cập nhật tham số không thành công", ex.StackTrace)
                End Try

            End Using
        End Using

        'Success
        Return New Result(True)

    End Function

    'Public Function Delete(thamSo As ThamSoDTO) As Result
    'End Function

#End Region

    ''' <summary>
    ''' Get the current 'Tham So' on the database base.
    ''' </summary>
    ''' <param name="thamSo">The specified instance of ThamSoDTO will receive the data.</param>
    ''' <returns></returns>
    Public Function GetThamSoOnDB(ByRef thamSo As ThamSoDTO) As Result

        Dim query As String = Nothing
        query &= "SELECT TOP 1 * "
        query &= "FROM [tbltham_so] "

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
                        While reader.Read()
                            thamSo = New ThamSoDTO(reader("so_benh_nhan_toi_da"), reader("tien_kham"))
                        End While
                    End If

                Catch ex As Exception
                    'Failure
                    conn.Close()
                    Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tham số không thành công", ex.StackTrace)
                End Try

            End Using
        End Using

        'Success
        Return New Result(True)

    End Function

#End Region

End Class
