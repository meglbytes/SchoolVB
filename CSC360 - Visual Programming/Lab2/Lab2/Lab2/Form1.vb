Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub display_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles display.Click
        Label3.Text = "90% of the game is half mental!"
    End Sub

    Private Sub happy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles happy.Click
        happy.Visible = False
        clickme.Visible = False
        bhappy.Visible = True
        behappy.Visible = True
        ohappy.Visible = False
        ohhappy.Visible = False
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles behappy.Click

    End Sub

    Private Sub clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear.Click
        TextBox1.Text = ""
        Label3.Text = ""
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Label3.ForeColor = Color.Blue
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Label3.ForeColor = Color.Yellow
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        Label3.ForeColor = Color.Green
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        Label3.ForeColor = Color.Red
    End Sub

    Private Sub bhappy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bhappy.Click
        happy.Visible = False
        clickme.Visible = False
        bhappy.Visible = False
        behappy.Visible = False
        ohappy.Visible = True
        ohhappy.Visible = True
    End Sub

    Private Sub ohhappy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ohhappy.Click

    End Sub

    Private Sub ohappy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ohappy.Click
        happy.Visible = True
        clickme.Visible = True
        bhappy.Visible = False
        behappy.Visible = False
        ohappy.Visible = False
        ohhappy.Visible = False
    End Sub

    Private Sub print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles print.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub
End Class
