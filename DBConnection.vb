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

    Public Sub read_all_arm(ByRef lista As List(Of Object))
        read("read_all_arm", lista)
    End Sub

    Public Sub create_arm(ByRef arm As Armazem)
        executeNonQuery("create_arm", arm)
        arm.Cod_int = Convert.ToInt64(_cmd.Parameters("@cod_int").Value)
    End Sub
    Public Sub update_arm(ByRef status As Boolean, ByRef arm As Armazem)
        executeNonQuery("update_arm", arm)
        status = Convert.ToBoolean(_cmd.Parameters("@fator").Value)
    End Sub
    Public Sub inactivate_arm(ByRef arm As Armazem, ByRef status As Boolean)
        executeNonQuery("inactivate_arm", arm)
        status = Convert.ToBoolean(_cmd.Parameters("@fator").Value)
    End Sub

    Public Sub read_all_forn(ByRef lista As List(Of Object))
        read("read_all_forn", lista)
    End Sub

    Public Sub create_forn(ByRef forn As Fornecedor, ByRef status As Boolean)
        executeNonQuery("create_forn", forn)
        status = Convert.ToBoolean(_cmd.Parameters("@fator").Value)
    End Sub

    Public Sub update_forn(ByRef status As Boolean, ByRef forn As Fornecedor)
        executeNonQuery("update_forn", forn)
        status = Convert.ToBoolean(_cmd.Parameters("@fator").Value)
    End Sub

    Public Sub read_all_item(ByRef lista As List(Of Object))
        read("read_all_item", lista)
    End Sub

    Public Sub create_item(ByRef item As Item, ByRef status As Boolean)
        executeNonQuery("create_item", item)
        item.Cod_int = Convert.ToBoolean(_cmd.Parameters("@cod_int").Value)
    End Sub

    Public Sub update_item(ByRef status As Boolean, ByRef item As Item)
        executeNonQuery("update_item", item)
        status = Convert.ToBoolean(_cmd.Parameters("@fator").Value)
    End Sub
    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function

    Private Sub executeNonQuery(ByVal tipo As String, ByRef entity As Object)
        set_command(tipo, entity)
        Try
            If _conn.State = ConnectionState.Closed Then
                _conn.Open()
            End If
            _cmd.ExecuteNonQuery()
            If _conn.State = ConnectionState.Open Then
                _conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            If _conn.State = ConnectionState.Open Then
                _conn.Close()
            End If
        End Try
    End Sub

    Private Sub read(ByVal tipo As String, ByRef lista As List(Of Object))
        set_command(tipo, Nothing)
        Try
            If _conn.State = ConnectionState.Closed Then
                _conn.Open()
            End If
            _reader = _cmd.ExecuteReader
            While _reader.Read
                Dim item As Object
                read_item(tipo, item)
                lista.Add(item)
            End While
            If _conn.State = ConnectionState.Open Then
                _conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            If _conn.State = ConnectionState.Open Then
                _conn.Close()
            End If
        End Try
    End Sub

    Private Sub set_command(ByVal tipo As String, ByRef entity As Object)
        _cmd.Parameters.Clear()

        If tipo = "read_all_arm" Then
            _cmd.CommandText = "SELECT * FROM FranquiaLojas.read_all_arm();"
            _cmd.CommandType = CommandType.Text
        ElseIf tipo = "create_arm" Then
            _cmd.CommandText = "FranquiaLojas.create_armazem"
            _cmd.CommandType = CommandType.StoredProcedure
            _cmd.Parameters.Add("@email", SqlDbType.VarChar, 128).Value = entity.Email
            _cmd.Parameters.Add("@tel", SqlDbType.Char, 9).Value = entity.Tel
            _cmd.Parameters.Add("@morada", SqlDbType.VarChar, 256).Value = entity.Morada
            If entity.Morada <> "" Then
                _cmd.Parameters.Add("@nome", SqlDbType.VarChar, 128).Value = entity.Morada
            End If
            _cmd.Parameters.Add("@cod_int", SqlDbType.Int).Direction = ParameterDirection.Output
        ElseIf tipo = "update_arm" Then
            _cmd.CommandText = "FranquiaLojas.update_arm"
            _cmd.CommandType = CommandType.StoredProcedure
            _cmd.Parameters.Add("@cod_int", SqlDbType.Int).Value = entity.Cod_int
            _cmd.Parameters("@cod_int").Direction = ParameterDirection.Input

            _cmd.Parameters.Add("@fator", SqlDbType.Int).Direction = ParameterDirection.ReturnValue

            _cmd.Parameters.Add("@email", SqlDbType.VarChar, 128).Value = entity.Email
            _cmd.Parameters("@email").Direction = ParameterDirection.Input

            _cmd.Parameters.Add("@morada", SqlDbType.VarChar, 512).Value = entity.Morada
            _cmd.Parameters("@morada").Direction = ParameterDirection.Input

            _cmd.Parameters.Add("@tel", SqlDbType.Char, 9).Value = entity.Tel
            _cmd.Parameters("@tel").Direction = ParameterDirection.Input

            _cmd.Parameters.Add("@nome", SqlDbType.VarChar, 128).Value = entity.Nome
            _cmd.Parameters("@nome").Direction = ParameterDirection.Input
        ElseIf tipo = "inactivate_arm" Then
            _cmd.CommandText = "FranquiaLojas.inactivate_arm"
            _cmd.CommandType = CommandType.StoredProcedure
            _cmd.Parameters.Add("@cod_int", SqlDbType.Int).Value = entity.Cod_int
            _cmd.Parameters("@cod_int").Direction = ParameterDirection.Input
            _cmd.Parameters.Add("@fator", SqlDbType.Int).Direction = ParameterDirection.ReturnValue
        ElseIf tipo = "read_all_forn" Then
            _cmd.CommandText = "SELECT * FROM FranquiaLojas.read_all_forn();"
            _cmd.CommandType = CommandType.Text

        ElseIf tipo = "create_forn" Then
            _cmd.CommandText = "FranquiaLojas.create_fornecedor"
            _cmd.CommandType = CommandType.StoredProcedure
            _cmd.Parameters.Add("@nif", SqlDbType.Char, 9).Value = entity.Nif
            _cmd.Parameters.Add("@email", SqlDbType.VarChar, 128).Value = entity.Email
            _cmd.Parameters.Add("@tel", SqlDbType.Char, 9).Value = entity.Tel
            _cmd.Parameters.Add("@morada", SqlDbType.VarChar, 256).Value = entity.Morada
            If entity.Nome <> "" Then
                _cmd.Parameters.Add("@nome", SqlDbType.VarChar, 128).Value = entity.Nome
            End If
            _cmd.Parameters.Add("@fator", SqlDbType.Int).Direction = ParameterDirection.ReturnValue
        ElseIf tipo = "update_forn" Then
            _cmd.CommandText = "FranquiaLojas.update_forn"
            _cmd.CommandType = CommandType.StoredProcedure
            _cmd.Parameters.Add("@nif", SqlDbType.Char, 9).Value = entity.Nif
            _cmd.Parameters("@nif").Direction = ParameterDirection.Input

            _cmd.Parameters.Add("@fator", SqlDbType.Int).Direction = ParameterDirection.ReturnValue

            _cmd.Parameters.Add("@email", SqlDbType.VarChar, 128).Value = entity.Email
            _cmd.Parameters("@email").Direction = ParameterDirection.Input

            _cmd.Parameters.Add("@morada", SqlDbType.VarChar, 512).Value = entity.Morada
            _cmd.Parameters("@morada").Direction = ParameterDirection.Input

            _cmd.Parameters.Add("@tel", SqlDbType.Char, 9).Value = entity.Tel
            _cmd.Parameters("@tel").Direction = ParameterDirection.Input

            _cmd.Parameters.Add("@nome", SqlDbType.VarChar, 128).Value = entity.Nome
            _cmd.Parameters("@nome").Direction = ParameterDirection.Input
        ElseIf tipo = "read_all_item" Then
            _cmd.CommandText = "SELECT * FROM FranquiaLojas.read_all_item();"
            _cmd.CommandType = CommandType.Text
        ElseIf tipo = "create_item" Then
            _cmd.CommandText = "FranquiaLojas.create_item"
            _cmd.CommandType = CommandType.StoredProcedure

            _cmd.Parameters.Add("@nome", SqlDbType.VarChar, 128).Value = entity.Nome
            _cmd.Parameters.Add("@desc", SqlDbType.VarChar, 512).Value = entity.Desc
            _cmd.Parameters.Add("@preco", SqlDbType.Float).Value = entity.Preço
            _cmd.Parameters.Add("@cod_int", SqlDbType.Int).Direction = ParameterDirection.Output
        ElseIf tipo = "update_item" Then
            _cmd.CommandText = "FranquiaLojas.update_item"
            _cmd.CommandType = CommandType.StoredProcedure
            _cmd.Parameters.Add("@nome", SqlDbType.VarChar, 128).Value = entity.Nome
            _cmd.Parameters.Add("@desc", SqlDbType.VarChar, 512).Value = entity.Desc
            _cmd.Parameters.Add("@preco", SqlDbType.Float).Value = entity.Preço
            _cmd.Parameters.Add("@fator", SqlDbType.Int).Direction = ParameterDirection.ReturnValue

        End If
    End Sub

    Private Sub read_item(ByVal tipo As String, ByRef entity As Object)
        If tipo = "read_all_arm" Then
            entity = New Armazem
            entity.Cod_int = _reader.Item("codigo_interno")
            entity.Morada = _reader.Item("morada")
            entity.Email = _reader.Item("email")
            entity.Tel = _reader.Item("telefone")
            entity.Nome = Convert.ToString(IIf(_reader.IsDBNull(_reader.GetOrdinal("nome")), "", _reader.Item("nome")))
        ElseIf tipo = "read_all_item" Then
            entity = New Item
            entity.Cod_int = _reader.Item("codigo_interno")
            entity.Desc = _reader.Item("descricao")
            entity.Nome = _reader.Item("nome")
            entity.Preço = _reader.Item("preco")
        ElseIf tipo = "read_all_forn" Then
            entity = New Fornecedor
            entity.Nif = _reader.Item("nif")
            entity.Morada = _reader.Item("morada")
            entity.Email = _reader.Item("email")
            entity.Tel = _reader.Item("telefone")
            entity.Nome = Convert.ToString(IIf(_reader.IsDBNull(_reader.GetOrdinal("nome")), "", _reader.Item("nome")))
        End If
    End Sub

End Class
