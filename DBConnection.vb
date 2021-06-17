Imports System.Data.SqlClient

Public Class DBConnection

    Private _conn As SqlConnection
    Private _url As String
    Private _cmd As SqlCommand
    Private _reader As SqlDataReader


    Public Shared ReadOnly tel_attr = "telefone"
    Public Shared ReadOnly email_attr = "email"
    Public Shared ReadOnly morada_attr = "morada"
    Public Shared ReadOnly cod_int_attr = "codigo_interno"

    Shared Function Connect(ByRef conn As DBConnection, dbserver As String, dbname As String, username As String, password As String)
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
    End Function

    Private Sub New(url As String, ByRef conn As SqlConnection)
        _url = url
        _conn = conn
        _cmd = New SqlCommand
        _cmd.Connection = _conn
    End Sub

    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function

    Public Function execute(tipo As String, ByRef entity As Object) As Boolean
        _cmd.Parameters.Clear()
        _cmd.CommandType = CommandType.StoredProcedure
        _cmd.Parameters.Add("@status", SqlDbType.Int).Direction = ParameterDirection.ReturnValue
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
        set_output(tipo, entity)
        Return Convert.ToBoolean(_cmd.Parameters("@status").Value)
    End Function

    Public Function read(tipo As String) As List(Of Object)
        _cmd.Parameters.Clear()
        _cmd.CommandType = CommandType.Text
        _cmd.CommandText = set_read(tipo)
        Try
            If _conn.State = ConnectionState.Closed Then
                _conn.Open()
            End If
            _reader = _cmd.ExecuteReader
            Dim lista As List(Of Object) = New List(Of Object)
            While _reader.Read
                lista.Add(read_item(tipo))
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
    End Function

    Private Sub set_command(tipo As String, ByRef entity As Object)
        If tipo = "create_arm" Then
            _cmd.CommandText = "FranquiaLojas.create_armazem"
            _cmd.Parameters.Add("@codigo_interno", SqlDbType.Int).Direction = ParameterDirection.Output

            _cmd.Parameters.Add("@email", SqlDbType.VarChar, 128).Value = entity.Email
            _cmd.Parameters("@email").Direction = ParameterDirection.Input

            _cmd.Parameters.Add("@telefone", SqlDbType.Char, 9).Value = entity.Tel
            _cmd.Parameters("@telefone").Direction = ParameterDirection.Input

            _cmd.Parameters.Add("@morada", SqlDbType.VarChar, 256).Value = entity.Morada
            _cmd.Parameters("@morada").Direction = ParameterDirection.Input

            If entity.Nome <> "" Then
                _cmd.Parameters.Add("@nome", SqlDbType.VarChar, 128).Value = entity.Morada
                _cmd.Parameters("@nome").Direction = ParameterDirection.Input
            End If

        ElseIf tipo = "update_arm" Then
            _cmd.CommandText = "FranquiaLojas.update_arm"

            _cmd.Parameters.Add("@codigo_interno", SqlDbType.Int).Value = entity.Cod_int
            _cmd.Parameters("@codigo_interno").Direction = ParameterDirection.Input

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

            _cmd.Parameters.Add("@cod_int", SqlDbType.Int).Value = entity.Cod_int
            _cmd.Parameters("@cod_int").Direction = ParameterDirection.Input

        ElseIf tipo = "create_forn" Then
            _cmd.CommandText = "FranquiaLojas.create_fornecedor"

            _cmd.Parameters.Add("@nif", SqlDbType.Char, 9).Value = entity.Nif
            _cmd.Parameters("@nif").Direction = ParameterDirection.Input

            _cmd.Parameters.Add("@email", SqlDbType.VarChar, 128).Value = entity.Email
            _cmd.Parameters("@email").Direction = ParameterDirection.Input

            _cmd.Parameters.Add("@telefone", SqlDbType.Char, 9).Value = entity.Tel
            _cmd.Parameters("@telefone").Direction = ParameterDirection.Input

            _cmd.Parameters.Add("@morada", SqlDbType.VarChar, 256).Value = entity.Morada
            _cmd.Parameters("@morada").Direction = ParameterDirection.Input

            If entity.Nome <> "" Then
                _cmd.Parameters.Add("@nome", SqlDbType.VarChar, 128).Value = entity.Nome
                _cmd.Parameters("@nome").Direction = ParameterDirection.Input
            End If

        ElseIf tipo = "update_forn" Then
            _cmd.CommandText = "FranquiaLojas.update_forn"

            _cmd.Parameters.Add("@nif", SqlDbType.Char, 9).Value = entity.Nif
            _cmd.Parameters("@nif").Direction = ParameterDirection.Input


            _cmd.Parameters.Add("@email", SqlDbType.VarChar, 128).Value = entity.Email
            _cmd.Parameters("@email").Direction = ParameterDirection.Input

            _cmd.Parameters.Add("@morada", SqlDbType.VarChar, 512).Value = entity.Morada
            _cmd.Parameters("@morada").Direction = ParameterDirection.Input

            _cmd.Parameters.Add("@tel", SqlDbType.Char, 9).Value = entity.Tel
            _cmd.Parameters("@tel").Direction = ParameterDirection.Input

            _cmd.Parameters.Add("@nome", SqlDbType.VarChar, 128).Value = entity.Nome
            _cmd.Parameters("@nome").Direction = ParameterDirection.Input

        ElseIf tipo = "create_item" Then

            _cmd.CommandText = "FranquiaLojas.create_item"
            _cmd.Parameters.Add("@codigo_interno", SqlDbType.Int).Direction = ParameterDirection.Output

            _cmd.Parameters.Add("@nome", SqlDbType.VarChar, 128).Value = entity.Nome
            _cmd.Parameters("@nome").Direction = ParameterDirection.Input

            _cmd.Parameters.Add("@preco", SqlDbType.Float).Value = entity.Preço
            _cmd.Parameters("@preco").Direction = ParameterDirection.Input

            If entity.Desc <> "" Then
                _cmd.Parameters.Add("@descricao", SqlDbType.VarChar, 512).Value = entity.Descricao
                _cmd.Parameters("@descricao").Direction = ParameterDirection.Input
            End If

        ElseIf tipo = "create_loja" Then
            Dim ent As Loja = CType(entity, Loja)
            _cmd.CommandText = "FranquiaLojas.create_loja"
            _cmd.Parameters.Add("@codigo_interno", SqlDbType.Int).Direction = ParameterDirection.Output

            If ent.Nome <> "" Then
                _cmd.Parameters.Add("@nome", SqlDbType.VarChar, 128).Value = ent.Nome
                _cmd.Parameters("@nome").Direction = ParameterDirection.Input
            End If

            _cmd.Parameters.Add("@email", SqlDbType.VarChar, 128).Value = ent.Email
            _cmd.Parameters("@email").Direction = ParameterDirection.Input

            _cmd.Parameters.Add("@morada", SqlDbType.VarChar, 512).Value = ent.Morada
            _cmd.Parameters("@morada").Direction = ParameterDirection.Input

            _cmd.Parameters.Add("@telefone", SqlDbType.Char, 9).Value = ent.Tel
            _cmd.Parameters("@telefone").Direction = ParameterDirection.Input

            _cmd.Parameters.Add("@codigo_interno_armazem", SqlDbType.Char, 9).Value = ent.Cod_int_arm
            _cmd.Parameters("@codigo_interno_armazem").Direction = ParameterDirection.Input

            If ent.Cod_int_ger <> -1 Then
                _cmd.Parameters.Add("@codigo_interno_gerente", SqlDbType.VarChar, 128).Value = ent.Cod_int_ger
                _cmd.Parameters("@codigo_interno_gerente").Direction = ParameterDirection.Input
            End If

        ElseIf tipo = "update_item" Then
            _cmd.CommandText = "FranquiaLojas.update_item"
            _cmd.Parameters.Add("@cod_int", SqlDbType.Int).Value = entity.Cod_int
            _cmd.Parameters.Add("@nome", SqlDbType.VarChar, 128).Value = entity.Nome
            _cmd.Parameters.Add("@desc", SqlDbType.VarChar, 512).Value = entity.Desc
            _cmd.Parameters.Add("@preco", SqlDbType.Float).Value = entity.Preço
            _cmd.Parameters.Add("@fator", SqlDbType.Int).Direction = ParameterDirection.ReturnValue
        ElseIf tipo = "create_pessoa" Then
            _cmd.CommandText = "FranquiaLojas.create_pessoa"

            _cmd.Parameters.Add("@nif", SqlDbType.Char, 9).Value = entity.Nif
            _cmd.Parameters("@nif").Direction = ParameterDirection.Input

            _cmd.Parameters.Add("@email", SqlDbType.VarChar, 128).Value = entity.Email
            _cmd.Parameters("@email").Direction = ParameterDirection.Input

            _cmd.Parameters.Add("@telefone", SqlDbType.Char, 9).Value = entity.Tel
            _cmd.Parameters("@telefone").Direction = ParameterDirection.Input

            _cmd.Parameters.Add("@morada", SqlDbType.VarChar, 256).Value = entity.Morada
            _cmd.Parameters("@morada").Direction = ParameterDirection.Input

            _cmd.Parameters.Add("@nome", SqlDbType.VarChar, 128).Value = entity.Nome
            _cmd.Parameters("@nome").Direction = ParameterDirection.Input

        Else
            Throw New System.Exception("Illegal Argument!")
        End If
    End Sub

    Private Sub set_output(tipo As String, ByRef entity As Object)
        If tipo = "create_arm" Or tipo = "create_item" Or tipo = "create_loja" Then
            entity.Cod_int = Convert.ToInt64(_cmd.Parameters("@codigo_interno").Value)
        End If
    End Sub

    Private Function set_read(tipo As String) As String
        If tipo = "read_all_arm" Then
            Return "SELECT * FROM FranquiaLojas.read_all_armazem();"
        ElseIf tipo = "read_all_forn" Then
            Return "SELECT * FROM FranquiaLojas.read_all_fornecedor();"
        ElseIf tipo = "read_all_loja" Then
            Return "SELECT * FROM FranquiaLojas.read_all_loja();"
        ElseIf tipo = "read_all_item" Then
            Return "SELECT * FROM FranquiaLojas.read_all_item();"
        ElseIf tipo = "read_all_func" Then
            Return "SELECT * FROM FranquiaLojas.read_all_funcionario();"
        ElseIf tipo = "read_all_pessoa" Then
            Return "SELECT * FROM FranquiaLojas.read_all_pessoa();"
        Else
            Throw New System.Exception("Illegal Argument!")
        End If
    End Function

    Private Function read_item(tipo As String) As Object
        If tipo = "read_all_arm" Then
            Return New Armazem(
                _reader.Item("codigo_interno"),
                Convert.ToString(IIf(_reader.IsDBNull(_reader.GetOrdinal("nome")), "", _reader.Item("nome"))),
                _reader.Item("morada"),
                _reader.Item("email"),
                _reader.Item("telefone")
            )
        ElseIf tipo = "read_all_item" Then
            Return New Item(
                _reader.Item("codigo_interno"),
                _reader.Item("nome"),
                _reader.Item("preco"),
                Convert.ToString(IIf(_reader.IsDBNull(_reader.GetOrdinal("descricao")), "", _reader.Item("descricao")))
            )
        ElseIf tipo = "read_all_forn" Then
            Return New Fornecedor(
                _reader.Item("nif"),
                Convert.ToString(IIf(_reader.IsDBNull(_reader.GetOrdinal("nome")), "", _reader.Item("nome"))),
                _reader.Item("morada"),
                _reader.Item("email"),
                _reader.Item("telefone")
            )
        ElseIf tipo = "read_all_loja" Then
            Return New Loja(
                _reader.Item("codigo_interno"),
                Convert.ToString(IIf(_reader.IsDBNull(_reader.GetOrdinal("nome")), "", _reader.Item("nome"))),
                _reader.Item("morada"),
                _reader.Item("email"),
                _reader.Item("telefone"),
                _reader.Item("cod_int_armazem"),
                IIf(_reader.IsDBNull(_reader.GetOrdinal("cod_int_gerente")), -1, _reader.Item("cod_int_gerente"))
            )
        ElseIf tipo = "read_all_func" Then
            Return New Funcionario(
                _reader.Item("codigo_interno"),
                _reader.Item("nif"),
                _reader.Item("nome"),
                _reader.Item("morada"),
                _reader.Item("email"),
                _reader.Item("telefone"),
                _reader.Item("cod_int_loja")
            )
        ElseIf tipo = "read_all_pessoa" Then
            Return New Pessoa(
                _reader.Item("nif"),
                _reader.Item("nome"),
                _reader.Item("morada"),
                _reader.Item("email"),
                _reader.Item("telefone")
            )
        Else
            Throw New System.Exception("Illegal Argument!")
        End If
    End Function

End Class
