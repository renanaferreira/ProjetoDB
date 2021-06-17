Public Class Principal

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim aba As New SSArm()
        show(aba)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim aba As New SSForn()
        show(aba)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim aba As New SSItem()
        show(aba)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim aba As New SSLoja()
        show(aba)
    End Sub

    Private Sub show(ByRef aba As Form)
        aba.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim aba As New SSFunc
        aba.Show()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim aba As New SSPes
        aba.Show()
    End Sub
End Class