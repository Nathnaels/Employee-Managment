Imports MySql.Data.MySqlClient

Public Class emp_management
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Listofdepts.SelectedIndexChanged

    End Sub


    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        Dim firstName As String = txtFirstname.Text
        Dim lastName As String = txtLastname.Text
        Dim position As String = txtPosition.Text
        Dim salary As Decimal = CDec(txtSalary.Text)
        Dim selectedDepartments As List(Of Integer) = GetSelectedDepartments()

        Dim query As String = "INSERT INTO Employees (FirstName, LastName, Position, Salary) VALUES (@FirstName, @LastName, @Position, @Salary)"
        Dim cmd As MySqlCommand = New MySqlCommand(query, DatabaseConnection.Connection)
        cmd.Parameters.AddWithValue("@FirstName", firstName)
        cmd.Parameters.AddWithValue("@LastName", lastName)
        cmd.Parameters.AddWithValue("@Position", position)
        cmd.Parameters.AddWithValue("@Salary", salary)

        DatabaseConnection.OpenConnection()
        cmd.ExecuteNonQuery()

        Dim employeeID As Integer = cmd.LastInsertedId

        For Each deptID As Integer In selectedDepartments
            Dim deptQuery As String = "INSERT INTO EmployeeDepartments (EmployeeID, DeptID) VALUES (@EmployeeID, @DeptID)"
            Dim deptCmd As MySqlCommand = New MySqlCommand(deptQuery, DatabaseConnection.Connection)
            deptCmd.Parameters.AddWithValue("@EmployeeID", employeeID)
            deptCmd.Parameters.AddWithValue("@DeptID", deptID)
            deptCmd.ExecuteNonQuery()
        Next

        DatabaseConnection.CloseConnection()
        MessageBox.Show("Employee Added Successfully")
    End Sub

    Private Function GetSelectedDepartments() As List(Of Integer)

        Dim selected_depts As New List(Of String)

        For Each dept As String In Listofdepts.SelectedItem.ToString

            selected_depts.Add(dept)

        Next

        Dim selectedDepartments As New List(Of Integer)

        If (selected_depts.Contains("IT")) Then
            selectedDepartments.Add(1)
        End If

        If (selected_depts.Contains("Finance")) Then
            selectedDepartments.Add(2)
        End If

        If (selected_depts.Contains("Marketing and Sells")) Then
            selectedDepartments.Add(3)
        End If
        If (selected_depts.Contains("Management")) Then
            selectedDepartments.Add(4)
        End If




        Return selectedDepartments
    End Function

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

    End Sub

    ' Implement Edit, Remove, and Search functions similarly
End Class

