Public Class Principal

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim abaarm As New SSArm()
        abaarm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim abaforn As New SSForn()
        abaforn.show()
    End Sub
End Class