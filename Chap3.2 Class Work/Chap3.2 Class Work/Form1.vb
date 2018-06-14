Public Class frmAge

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblDayofBirth.Click

    End Sub

    Private Sub txtFullDateOfBirth_TextChanged(sender As Object, e As EventArgs) Handles txtFullDateOfBirth.TextChanged

    End Sub

    Private Sub btnComputeofBirth_Click(sender As Object, e As EventArgs) Handles btnComputeofBirth.Click
        Dim dob As Date = CDate(mtbDayofBirth.Text)
        txtFullDateOfBirth.Text = dob.ToString("D")
        txtToday.Text = Today.ToString("D")
        txtAgeInDays.Text = DateDiff(DateInterval.Day, dob, Today).ToString("N0")

    End Sub
End Class
