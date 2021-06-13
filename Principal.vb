Public Class Principal

    Dim conn As DBConnection

    Public Sub New(ByRef conn As DBConnection)
        Me.conn = conn
        InitializeComponent()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim abaarm As New SSArm(Me.conn)
        Console.WriteLine(Me.conn)
        abaarm.Show()
    End Sub
End Class