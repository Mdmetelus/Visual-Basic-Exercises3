Public Class Form1

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim Revenue As Double = 98456
        revenue = 98456
        Dim cost As Double = 45000
        cost = 45000
        Dim Profit As Double = Revenue - cost
        lstOutput.Items.Add(Profit)

    End Sub

    Private Sub lstOutput_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstOutput.SelectedIndexChanged

    End Sub
End Class
