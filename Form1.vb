Imports MySql.Data.MySqlClient

Public Class login
    Private Sub log_in_Click(sender As Object, e As EventArgs) Handles log_in.Click

        Dim uname As String = user_name.Text
        Dim pword As String = password.Text

        Dim query As String = "SELECT * FROM Administrators WHERE Username = @Username AND Password = @Password"
            Dim cmd As MySqlCommand = New MySqlCommand(query, DatabaseConnection.Connection)
        cmd.Parameters.AddWithValue("@Username", uname)
        cmd.Parameters.AddWithValue("@Password", pword)

        DatabaseConnection.OpenConnection()
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.HasRows Then
                MessageBox.Show("Login Successful")
                Me.Hide()
            Dim mainForm As New Mainmenu()
            mainForm.Show()
            Else
                MessageBox.Show("Invalid Username or Password")
            End If

            DatabaseConnection.CloseConnection()
        End Sub
    End Class


