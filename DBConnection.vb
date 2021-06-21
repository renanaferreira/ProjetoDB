Imports System.Data.SqlClient

Public Class DBConnection

    Private _conn As SqlConnection
    Private _url As String
    Private _cmd As SqlCommand
    Private _reader As SqlDataReader

    Shared Function Connect(dbserver As String, dbname As String, username As String, password As String) As DBConnection
        Dim url As String = "Data Source = " + dbserver + ";" +
                            "Initial Catalog = " + dbname + ";" +
                            "uid = " + username + ";" +
                            "password = " + password
        Dim db As New SqlConnection(url)
        Try
            db.Open()
            If db.State = ConnectionState.Open Then
                db.Close()
                Return New DBConnection(url, db)
            End If
            Return Nothing
        Catch ex As Exception
            Return Nothing
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

    Public Function Create(tipo As String, ByRef entity As Object) As Boolean
        _cmd.CommandType = CommandType.StoredProcedure
        _cmd.Parameters.Clear()
        If tipo = "armazem" Then
            Dim ent As Armazem = CType(entity, Armazem)
            _cmd.CommandText = "FranquiaLojas.armazem_create"
            _cmd.Parameters.Add("@codigo_interno", SqlDbType.Int).Direction = ParameterDirection.Output

            _cmd.Parameters.Add("@email", SqlDbType.VarChar, 128).Value = ent.Email
            _cmd.Parameters("@email").Direction = ParameterDirection.Input

            _cmd.Parameters.Add("@telefone", SqlDbType.Char, 9).Value = ent.Tel
            _cmd.Parameters("@telefone").Direction = ParameterDirection.Input

            _cmd.Parameters.Add("@morada", SqlDbType.VarChar, 256).Value = ent.Morada
            _cmd.Parameters("@morada").Direction = ParameterDirection.Input

            If ent.Nome <> "" Then
                _cmd.Parameters.Add("@nome", SqlDbType.VarChar, 128).Value = ent.Nome
                _cmd.Parameters("@nome").Direction = ParameterDirection.Input
            End If
        ElseIf tipo = "fornecedor" Then
            Dim ent As Fornecedor = CType(entity, Fornecedor)
            _cmd.CommandText = "FranquiaLojas.fornecedor_create"

            _cmd.Parameters.Add("@nif", SqlDbType.Char, 9).Value = ent.Nif
            _cmd.Parameters("@nif").Direction = ParameterDirection.Input

            _cmd.Parameters.Add("@email", SqlDbType.VarChar, 128).Value = ent.Email
            _cmd.Parameters("@email").Direction = ParameterDirection.Input

            _cmd.Parameters.Add("@telefone", SqlDbType.Char, 9).Value = ent.Tel
            _cmd.Parameters("@telefone").Direction = ParameterDirection.Input

            _cmd.Parameters.Add("@morada", SqlDbType.VarChar, 256).Value = ent.Morada
            _cmd.Parameters("@morada").Direction = ParameterDirection.Input

            If ent.Nome <> "" Then
                _cmd.Parameters.Add("@nome", SqlDbType.VarChar, 128).Value = ent.Nome
                _cmd.Parameters("@nome").Direction = ParameterDirection.Input
            End If
        ElseIf tipo = "funcionario" Then
            Dim ent As Funcionario = CType(entity, Funcionario)
            _cmd.CommandText = "FranquiaLojas.create_funcionario"
            _cmd.Parameters.Add("@codigo_interno", SqlDbType.Int).Direction = ParameterDirection.Output

            _cmd.Parameters.Add("@nif", SqlDbType.Char, 9).Value = ent.Nif
            _cmd.Parameters("@nif").Direction = ParameterDirection.Input

            _cmd.Parameters.Add("@email", SqlDbType.VarChar, 128).Value = ent.Email
            _cmd.Parameters("@email").Direction = ParameterDirection.Input

            _cmd.Parameters.Add("@telefone", SqlDbType.Char, 9).Value = ent.Tel
            _cmd.Parameters("@telefone").Direction = ParameterDirection.Input

            _cmd.Parameters.Add("@morada", SqlDbType.VarChar, 256).Value = ent.Morada
            _cmd.Parameters("@morada").Direction = ParameterDirection.Input

            _cmd.Parameters.Add("@nome", SqlDbType.VarChar, 128).Value = ent.Nome
            _cmd.Parameters("@nome").Direction = ParameterDirection.Input

            _cmd.Parameters.Add("@codigo_interno_loja", SqlDbType.Int).Value = ent.Cod_int_loja
            _cmd.Parameters("@codigo_interno_loja").Direction = ParameterDirection.Input
        ElseIf tipo = "item" Then
            Dim ent As Item = CType(entity, Item)
            _cmd.CommandText = "FranquiaLojas.item_create"
            _cmd.Parameters.Add("@codigo_interno", SqlDbType.Int).Direction = ParameterDirection.Output

            _cmd.Parameters.Add("@nome", SqlDbType.VarChar, 128).Value = ent.Nome
            _cmd.Parameters("@nome").Direction = ParameterDirection.Input

            _cmd.Parameters.Add("@preco", SqlDbType.Float).Value = ent.Preço
            _cmd.Parameters("@preco").Direction = ParameterDirection.Input

            _cmd.Parameters.Add("@descricao", SqlDbType.VarChar, 512).Value = ent.Descricao
            _cmd.Parameters("@descricao").Direction = ParameterDirection.Input

        ElseIf tipo = "loja" Then
            Dim ent As Loja = CType(entity, Loja)
            _cmd.CommandText = "FranquiaLojas.loja_create"
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
        ElseIf tipo = "pessoa" Then
            Dim ent As Pessoa = CType(entity, Pessoa)
            _cmd.CommandText = "FranquiaLojas.create_pessoa"

            _cmd.Parameters.Add("@nif", SqlDbType.Char, 9).Value = ent.Nif
            _cmd.Parameters("@nif").Direction = ParameterDirection.Input

            _cmd.Parameters.Add("@email", SqlDbType.VarChar, 128).Value = ent.Email
            _cmd.Parameters("@email").Direction = ParameterDirection.Input

            _cmd.Parameters.Add("@telefone", SqlDbType.Char, 9).Value = ent.Tel
            _cmd.Parameters("@telefone").Direction = ParameterDirection.Input

            _cmd.Parameters.Add("@morada", SqlDbType.VarChar, 256).Value = ent.Morada
            _cmd.Parameters("@morada").Direction = ParameterDirection.Input

            _cmd.Parameters.Add("@nome", SqlDbType.VarChar, 128).Value = ent.Nome
            _cmd.Parameters("@nome").Direction = ParameterDirection.Input
        Else
            Throw New Exception("Illegal Argument")
        End If
        Dim status As Boolean = execute()
        If status Then
            MsgBox("Inserção feita com sucesso!")
            If tipo = "armazem" Then
                Dim ent As Armazem = CType(entity, Armazem)
                ent.Cod_int = Convert.ToInt64(_cmd.Parameters("@codigo_interno").Value)
            ElseIf tipo = "loja" Then
                Dim ent As Loja = CType(entity, Loja)
                ent.Cod_int = Convert.ToInt64(_cmd.Parameters("@codigo_interno").Value)
            ElseIf tipo = "funcionario" Then
                Dim ent As Funcionario = CType(entity, Funcionario)
                ent.Cod_int = Convert.ToInt64(_cmd.Parameters("@codigo_interno").Value)
                'ElseIf tipo = "item" Then
                'Dim ent As Item = CType(entity, Item)
                'ent.Cod_int = Convert.ToInt64(_cmd.Parameters("@codigo_interno").Value)
            End If
        Else
            MsgBox("Erro na inserção")
        End If
        Return status
    End Function

    Public Function Inactivate(tipo As String, ByRef entity As Object) As Boolean
        _cmd.CommandType = CommandType.StoredProcedure
        _cmd.Parameters.Clear()
        If tipo = "armazem" Then
            Dim ent As Armazem = CType(entity, Armazem)
            _cmd.CommandText = "FranquiaLojas.armazem_inactivate"

            _cmd.Parameters.Add("@codigo_interno", SqlDbType.Int).Value = ent.Cod_int
            _cmd.Parameters("@codigo_interno").Direction = ParameterDirection.Input
        ElseIf tipo = "fornecedor" Then
            Dim ent As Fornecedor = CType(entity, Fornecedor)
            _cmd.CommandText = "FranquiaLojas.fornecedor_inactivate"

            _cmd.Parameters.Add("@nif", SqlDbType.Char, 9).Value = ent.Nif
            _cmd.Parameters("@nif").Direction = ParameterDirection.Input
        ElseIf tipo = "item" Then
            Dim ent As Item = CType(entity, Item)
            _cmd.CommandText = "FranquiaLojas.item_inactivate"

            _cmd.Parameters.Add("@codigo_interno", SqlDbType.Int).Value = ent.Cod_int
            _cmd.Parameters("@codigo_interno").Direction = ParameterDirection.Input
        Else
            Throw New Exception("Illegal Argument")
        End If
        Dim status As Boolean = execute()
        If status Then
            MsgBox("Desativação realizada com sucesso")
        Else
            MsgBox("Erro na desativação")
        End If
        Return status
    End Function

    Public Function Update(tipo As String, ByRef entity As Object) As Boolean
        _cmd.CommandType = CommandType.StoredProcedure
        _cmd.Parameters.Clear()
        If tipo = "armazem" Then
            Dim ent As Armazem = CType(entity, Armazem)
            _cmd.CommandText = "FranquiaLojas.armazem_update"

            _cmd.Parameters.Add("@codigo_interno", SqlDbType.Int).Value = ent.Cod_int
            _cmd.Parameters("@codigo_interno").Direction = ParameterDirection.Input

            _cmd.Parameters.Add("@email", SqlDbType.VarChar, 128).Value = ent.Email
            _cmd.Parameters("@email").Direction = ParameterDirection.Input

            _cmd.Parameters.Add("@morada", SqlDbType.VarChar, 512).Value = ent.Morada
            _cmd.Parameters("@morada").Direction = ParameterDirection.Input

            _cmd.Parameters.Add("@telefone", SqlDbType.Char, 9).Value = ent.Tel
            _cmd.Parameters("@telefone").Direction = ParameterDirection.Input

            _cmd.Parameters.Add("@nome", SqlDbType.VarChar, 128).Value = ent.Nome
            _cmd.Parameters("@nome").Direction = ParameterDirection.Input
        ElseIf tipo = "fornecedor" Then
            Dim ent As Fornecedor = CType(entity, Fornecedor)
            _cmd.CommandText = "FranquiaLojas.fornecedor_update"

            _cmd.Parameters.Add("@email", SqlDbType.VarChar, 128).Value = ent.Email
            _cmd.Parameters("@email").Direction = ParameterDirection.Input

            _cmd.Parameters.Add("@morada", SqlDbType.VarChar, 512).Value = ent.Morada
            _cmd.Parameters("@morada").Direction = ParameterDirection.Input

            _cmd.Parameters.Add("@tel", SqlDbType.Char, 9).Value = ent.Tel
            _cmd.Parameters("@tel").Direction = ParameterDirection.Input

            _cmd.Parameters.Add("@nome", SqlDbType.VarChar, 128).Value = ent.Nome
            _cmd.Parameters("@nome").Direction = ParameterDirection.Input

            _cmd.Parameters.Add("@nif", SqlDbType.Char, 9).Value = ent.Nif
            _cmd.Parameters("@nif").Direction = ParameterDirection.Input
        ElseIf tipo = "item" Then

            Dim ent As Item = CType(entity, Item)
            _cmd.CommandText = "FranquiaLojas.item_update"

            _cmd.Parameters.Add("@codigo_interno", SqlDbType.Int).Value = ent.Cod_int
            _cmd.Parameters("@codigo_interno").Direction = ParameterDirection.Input

            _cmd.Parameters.Add("@nome", SqlDbType.VarChar, 128).Value = ent.Nome
            _cmd.Parameters("@nome").Direction = ParameterDirection.Input

            _cmd.Parameters.Add("@preco", SqlDbType.Float).Value = ent.Preço
            _cmd.Parameters("@preco").Direction = ParameterDirection.Input


            _cmd.Parameters.Add("@descricao", SqlDbType.VarChar, 512).Value = ent.Descricao
            _cmd.Parameters("@descricao").Direction = ParameterDirection.Input
        Else
            Throw New Exception("Illegal Argument")
        End If
        Dim status = execute()
        If status Then
            MsgBox("Atualização efetuada")
        Else
            MsgBox("Erro na atualização")
        End If
        Return status
    End Function

    Private Function execute() As Boolean
        _cmd.Parameters.Add("@status", SqlDbType.Int).Direction = ParameterDirection.ReturnValue
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
            Return lista
        Catch ex As Exception
            MsgBox(ex.Message)
            If _conn.State = ConnectionState.Open Then
                _conn.Close()
            End If
            Return New List(Of Object)
        End Try


    End Function

    Private Sub set_command(tipo As String, ByRef entity As Object)
        _cmd.CommandText = "FranquiaLojas.inactivate_arm"
        _cmd.Parameters.Add("@cod_int", SqlDbType.Int).Value = entity.Cod_int
        _cmd.Parameters("@cod_int").Direction = ParameterDirection.Input

    End Sub

    Private Function set_read(tipo As String) As String
        If tipo = "armazem" Then
            Return "SELECT * FROM FranquiaLojas.read_armazem();"
        ElseIf tipo = "fornecedor" Then
            Return "SELECT * FROM FranquiaLojas.read_fornecedor();"
        ElseIf tipo = "loja" Then
            Return "SELECT * FROM FranquiaLojas.read_loja();"
        ElseIf tipo = "item" Then
            Return "SELECT * FROM FranquiaLojas.read_item();"
        ElseIf tipo = "funcionario" Then
            Return "SELECT * FROM FranquiaLojas.read_funcionario();"
        ElseIf tipo = "pessoa" Then
            Return "SELECT * FROM FranquiaLojas.read_pessoa();"
        Else
            Throw New System.Exception("Illegal Argument!")
        End If
    End Function

    Private Function read_item(tipo As String) As Object
        If tipo = "armazem" Then
            Return New Armazem(
                _reader.Item("codigo_interno"),
                Convert.ToString(IIf(_reader.IsDBNull(_reader.GetOrdinal("nome")), "", _reader.Item("nome"))),
                _reader.Item("morada"),
                _reader.Item("email"),
                _reader.Item("telefone")
            )
        ElseIf tipo = "item" Then
            Return New Item(
                _reader.Item("codigo_interno"),
                _reader.Item("nome"),
                _reader.Item("preco"),
                Convert.ToString(IIf(_reader.IsDBNull(_reader.GetOrdinal("descricao")), "", _reader.Item("descricao")))
            )
        ElseIf tipo = "fornecedor" Then
            Return New Fornecedor(
                _reader.Item("nif"),
                Convert.ToString(IIf(_reader.IsDBNull(_reader.GetOrdinal("nome")), "", _reader.Item("nome"))),
                _reader.Item("morada"),
                _reader.Item("email"),
                _reader.Item("telefone")
            )
        ElseIf tipo = "loja" Then
            Return New Loja(
                _reader.Item("codigo_interno"),
                Convert.ToString(IIf(_reader.IsDBNull(_reader.GetOrdinal("nome")), "", _reader.Item("nome"))),
                _reader.Item("morada"),
                _reader.Item("email"),
                _reader.Item("telefone"),
                _reader.Item("cod_int_armazem"),
                IIf(_reader.IsDBNull(_reader.GetOrdinal("cod_int_gerente")), -1, _reader.Item("cod_int_gerente"))
            )
        ElseIf tipo = "funcionario" Then
            Return New Funcionario(
                _reader.Item("codigo_interno"),
                _reader.Item("nif"),
                _reader.Item("nome"),
                _reader.Item("morada"),
                _reader.Item("email"),
                _reader.Item("telefone"),
                _reader.Item("cod_int_loja")
            )
        ElseIf tipo = "pessoa" Then
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
