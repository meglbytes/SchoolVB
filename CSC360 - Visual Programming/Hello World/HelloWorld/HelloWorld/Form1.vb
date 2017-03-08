Public Class HelloWorld

    Private Sub PushMe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PushMe.Click
        Label1.Text = "Hello Matt!"
    End Sub

    Private Sub Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub
End Class
