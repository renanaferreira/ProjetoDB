Imports System.Data.SqlClient

Public Class DBConnection

    Private _conn As SqlConnection
    Private _url As String
    Private _cmd As SqlCommand
    Private _reader As SqlDataReader

    Shared Sub Connect(ByRef conn As DBConnection, ByVal dbserver As String, ByVal dbname As String, ByVal username As String, ByVal password As String)
        Dim url As String = "Data Source = " + dbserver + ";" +
                            "Initial Catalog = " + dbname + ";" +
                            "uid = " + username + ";" +
                            "password = " + password
        Dim db As New SqlConnection(url)
        Try
            db.Open()
            If db.State = ConnectionState.Open Then
                conn = New DBConnection(url, db)
                db.Close()
            End If
        Catch ex As Exception
            conn = Nothing
        End Try

    End Sub


    Private Sub New(ByVal url As String, ByRef conn As SqlConnection)
        _url = url
        _conn = conn
        _cmd = New SqlCommand
        _cmd.Connection = _conn
    End Sub

    Public Sub read_all_arm(ByRef lista As List(Of Armazem))
        _cmd.CommandText = "SELECT * FROM FranquiaLojas.read_all_arm();"
        Try
            open()
            _reader = _cmd.ExecuteReader
            While _reader.Read
                Dim item As New Armazem
                item.Cod_int = _reader.Item("codigo_interno")
                item.Morada = _reader.Item("morada")
                item.Email = _reader.Item("email")
                item.Tel = _reader.Item("telefone")
                item.Nome = Convert.ToString(IIf(_reader.IsDBNull(_reader.GetOrdinal("nome")), "", _reader.Item("nome")))
                lista.Add(item)
            End While
            close()
        Catch ex As Exception
            MsgBox(ex.Message)
            close()
        End Try

    End Sub

    Public Sub get_arm(ByVal cod_int As Integer, ByRef arm As Armazem)
        _cmd.CommandText = "SELECT * FROM FranquiaLojas.get_arm(@cod_int);"
        _cmd.Parameters.Add("@cod_int", SqlDbType.Int).Value = cod_int

        Try
            open()
            _reader = _cmd.ExecuteReader
            While _reader.Read
                arm.Cod_int = cod_int
                arm.Morada = _reader.Item("morada")
                arm.Email = _reader.Item("email")
                arm.Tel = _reader.Item("telefone")
                arm.Nome = _reader.Item("nome")
            End While
            close()
        Catch ex As Exception
            MsgBox(ex.Message)
            close()
        End Try

    End Sub

    Public Sub create_arm(ByVal email As String, ByVal morada As String, ByVal tel As String, ByVal nome As String, ByRef cod_int As Int64)
        _cmd.CommandText = "FranquiaLojas.create_armazem"
        _cmd.CommandType = CommandType.StoredProcedure

        _cmd.Parameters.Add("@email", SqlDbType.VarChar, 128).Value = email
        _cmd.Parameters.Add("@tel", SqlDbType.Char, 9).Value = tel
        _cmd.Parameters.Add("@morada", SqlDbType.VarChar, 256).Value = morada
        If nome <> "" Then
            _cmd.Parameters.Add("@nome", SqlDbType.VarChar, 128).Value = nome
        End If
        _cmd.Parameters.Add("@cod_int", SqlDbType.Int).Direction = ParameterDirection.Output

        executeNonQuery()
        cod_int = Convert.ToInt64(_cmd.Parameters("@cod_int").Value)
    End Sub

    Public Sub delete_arm(ByVal cod_int As Int64, ByRef status As Boolean)

        _cmd.CommandText = "FranquiaLojas.inactivate_arm"
        _cmd.CommandType = CommandType.StoredProcedure

        _cmd.Parameters.Add("@cod_int", SqlDbType.Int).Value = cod_int
        _cmd.Parameters("@cod_int").Direction = ParameterDirection.Input
        _cmd.Parameters.Add("@fator", SqlDbType.Int).Direction = ParameterDirection.ReturnValue

        executeNonQuery()
        status = Convert.ToBoolean(_cmd.Parameters("@fator").Value)

    End Sub

    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function

    Private Sub open()
        If _conn.State = ConnectionState.Closed Then
            _conn.Open()
        End If
    End Sub

    Private Sub close()
        If _conn.State = ConnectionState.Open Then
            _conn.Close()
        End If
    End Sub

    Private Sub executeNonQuery()
        Try
            open()
            _cmd.ExecuteNonQuery()
            close()
        Catch ex As Exception
            MsgBox(ex.Message)
            close()
        End Try
    End Sub
End Class
