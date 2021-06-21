Public Class AbaLogin

    Public Shared conn As DBConnection

    Public Shared Function Inativar(ByRef form As InactivateEntity)
        If AbaLogin.conn.Inactivate(form.TipoEnt, form.Get_in_item) Then
            form.Sucesso()
        Else
            form.Erro()
        End If
    End Function

    Public Shared Function Adicionar(ByRef form As AddAba)
        If Not form.Check_input() Then
            Return 0
        End If
        If AbaLogin.conn.Create(form.Tipo(), form.New_item()) Then
            form.Limpar()
        End If
        Return 1
    End Function

    Public Shared Function Atualizar(ByRef form As FormAba)
        Dim newone = form.New_item()
        If AbaLogin.conn.Update(form.Tipo, newone) Then
            form.Set_item(newone)
        End If
        form.Carregar()
    End Function

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        If UserTextBox.Text = "" Or PassTextBox.Text = "" Then
            MsgBox("Campo utilizador e Senha não podem ser vazios")
            Return

        End If

        Dim user As String = UserTextBox.Text
        Dim pass As String = PassTextBox.Text

        Dim dbserver = "tcp:mednat.ieeta.pt\SQLSERVER,8101"
        Dim dbname = "p7g5"


        Dim conn = DBConnection.Connect(dbserver, dbname, "p7g5", "93168_98495@BD")
        If conn Is Nothing Then
            MsgBox("Erro na conexão da base de dados")
        Else
            MsgBox("Sucesso na conexão!")
            AbaLogin.conn = conn
            Dim aba As New Principal()
            aba.Show()
            Me.Close()
        End If

    End Sub
End Class