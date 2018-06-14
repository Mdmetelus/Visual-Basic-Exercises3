Public Class frmMath

    Private Sub lstResults_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstResults.SelectedIndexChanged

    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        lstResults.Items.Clear()
        lstResults.Items.Add(3 * 4)
        lstResults.Items.Add(7 ^ 2)
        lstResults.Items.Add(1 / (2 ^ 3))
        lstResults.Items.Add((5 - 3) * 4)
        lstResults.Items.Add(3 * ((-2) ^ 5))
        lstResults.Items.Add(7 \ 3)
        lstResults.Items.Add(14 Mod 4)
        lstResults.Items.Add(7 Mod 3)
        lstResults.Items.Add(14 \ 4)

    End Sub
End Class
