Public Class Mainmenu
    Private Sub emp_management_Click(sender As Object, e As EventArgs) Handles emp_management.Click
        Me.Hide()
        Dim mainForm As New emp_management
        mainForm.Show()
    End Sub

    Private Sub dept_management_Click(sender As Object, e As EventArgs) Handles dept_management.Click
        Me.Hide()
        Dim mainForm As New dept_management()
        mainForm.Show()
    End Sub
End Class