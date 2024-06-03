Public Class Mainmenu


    Private Sub Mainmenu_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            ' User clicked the close button
            ' You can put your closing logic here
            ' For example, you can ask for confirmation before closing the form
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to close the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.No Then
                ' Cancel the form closing event
                e.Cancel = True
            End If
        End If
        login.Close()
    End Sub


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

    Private Sub Mainmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Me.Close()

    End Sub





End Class