Public Class AbaLogin

    Public Shared conn As DBConnection


    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        If UserTextBox.Text = "" Or PassTextBox.Text = "" Then
            MsgBox("Campo utilizador e Senha não podem ser vazios")
            Return

        End If

        Dim user As String = UserTextBox.Text
        Dim pass As String = PassTextBox.Text

        Dim dbserver = "tcp:mednat.ieeta.pt\SQLSERVER,8101"
        Dim dbname = "p7g5"


        Dim conn As DBConnection
        DBConnection.Connect(conn, dbserver, dbname, "p7g5", "93168_98495@BD")
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