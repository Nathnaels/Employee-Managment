
Imports MySql.Data.MySqlClient
Module DatabaseConnection

    Public ConnectionString As String = "server=localhost;user id=root;password=;database=EmployeeManagement"
    Public Connection As MySqlConnection = New MySqlConnection(ConnectionString)

    Public Sub OpenConnection()
        If Connection.State = ConnectionState.Closed Then
            Connection.Open()
        End If
    End Sub

    Public Sub CloseConnection()
        If Connection.State = ConnectionState.Open Then
            Connection.Close()
        End If
    End Sub
End Module


