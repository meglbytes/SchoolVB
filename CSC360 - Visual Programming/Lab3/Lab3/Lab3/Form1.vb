Public Class Form1
    Dim SnowboardsRentedVar As Integer
    Dim SnowboardswBootsRentedVar As Integer
    Dim Snowboards As Integer
    Dim Snowboards2 As Integer
    Dim TotalRentalChargesVar As Decimal
    Dim AvgChargePerCustomerVar As Decimal
    Const SnowboardPriceVar As Double = 20.0
    Const SnowboardwBootsVar As Double = 30.0
    Dim Customer As Integer = 0
    Private Sub Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        Me.Close()
    End Sub

    Private Sub Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Print.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clear.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
    End Sub

    Private Sub CalculateOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateOrder.Click
        Dim Total, Total2, Total3 As Decimal

        Try
            Snowboards = Integer.Parse(TextBox3.Text)
            Snowboards2 = Integer.Parse(TextBox4.Text)
            Customer = Customer + 1

            Total = Snowboards * SnowboardPriceVar
            TextBox5.Text = Total.ToString("C")

            Total2 = Snowboards2 * SnowboardwBootsVar
            TextBox6.Text = Total2.ToString("C")

            Total3 = Total + Total2
            TextBox7.Text = Total3.ToString("C")

            SnowboardsRentedVar = Snowboards + SnowboardsRentedVar
            TextBox8.Text = SnowboardsRentedVar.ToString()

            SnowboardswBootsRentedVar = Snowboards2 + SnowboardswBootsRentedVar
            TextBox9.Text = SnowboardswBootsRentedVar.ToString()

            TotalRentalChargesVar = Total3 + TotalRentalChargesVar
            TextBox10.Text = TotalRentalChargesVar.ToString("C")

            AvgChargePerCustomerVar = TotalRentalChargesVar / Customer
            TextBox11.Text = AvgChargePerCustomerVar.ToString("C")
        Catch
            MessageBox.Show("Please input the number of snowboards rented", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

       

    End Sub

    Private Sub ClearAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearAll.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        SnowboardsRentedVar = 0
        SnowboardswBootsRentedVar = 0
        TotalRentalChargesVar = 0
        AvgChargePerCustomerVar = 0
        Customer = 0
        TextBox1.Focus()
    End Sub
End Class