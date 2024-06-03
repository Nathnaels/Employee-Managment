Imports MySql.Data.MySqlClient

Public Class emp_management




    'add employee


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







    ' get selected departments from the department listin the add section



    Private Function GetSelectedDepartments() As List(Of Integer)
        Dim selectedDepartments As New List(Of Integer)

        For Each item In Listofdepts.CheckedItems
            selectedDepartments.Add(CType(item, KeyValuePair(Of Integer, String)).Key)
        Next

        Return selectedDepartments
    End Function





    ' back to main menu button


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Dim mainForm As New Mainmenu()
        mainForm.Show()
    End Sub





    ' default form load method

    Private Sub emp_management_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDepartments()
    End Sub






    'load departments method for editing record section 



    Private Sub LoadDepartment()
        dept.Items.Clear()

        Dim query As String = "SELECT DeptID, DeptName FROM Departments"
        Dim cmd As MySqlCommand = New MySqlCommand(query, DatabaseConnection.Connection)

        DatabaseConnection.OpenConnection()
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()
            dept.Items.Add(New With {.name = reader("DeptName"), .id = reader("DeptID")})
        End While

        DatabaseConnection.CloseConnection()
    End Sub







    ' load departments for add section



    Private Sub LoadDepartments()
        Dim query As String = "SELECT DeptID, DeptName FROM Departments"
        Dim cmd As MySqlCommand = New MySqlCommand(query, DatabaseConnection.Connection)
        dept.Items.Clear()
        DatabaseConnection.OpenConnection()
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()
            Dim deptID As Integer = reader("DeptID")
            Dim deptName As String = reader("DeptName")
            Listofdepts.Items.Add(New KeyValuePair(Of Integer, String)(deptID, deptName))
            'dept.Items.Add(New KeyValuePair(Of Integer, String)(deptID, deptName))
        End While

        DatabaseConnection.CloseConnection()
    End Sub







    'search button logic 



    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim firstName As String = txtSearchFirstName.Text.Trim()
        Dim employeeID As String = txtSearchEmployeeID.Text.Trim()

        Dim query As String = ""
        Dim cmd As MySqlCommand

        If Not String.IsNullOrEmpty(firstName) AndAlso Not String.IsNullOrEmpty(employeeID) Then
            ' Both first name and ID have values
            query = "SELECT Employees.EmployeeID, Employees.FirstName, Employees.LastName, GROUP_CONCAT(Departments.DeptName SEPARATOR ', ') AS DeptNames
                     FROM Employees 
                     LEFT JOIN EmployeeDepartments ON Employees.EmployeeID = EmployeeDepartments.EmployeeID 
                     LEFT JOIN Departments ON EmployeeDepartments.DeptID = Departments.DeptID 
                     WHERE Employees.FirstName LIKE @FirstName AND Employees.EmployeeID = @EmployeeID
                     GROUP BY Employees.EmployeeID"
            cmd = New MySqlCommand(query, DatabaseConnection.Connection)
            cmd.Parameters.AddWithValue("@FirstName", "%" & firstName & "%")
            cmd.Parameters.AddWithValue("@EmployeeID", employeeID)
        ElseIf Not String.IsNullOrEmpty(firstName) Then
            ' Only first name has value
            query = "SELECT Employees.EmployeeID, Employees.FirstName, Employees.LastName, GROUP_CONCAT(Departments.DeptName SEPARATOR ', ') AS DeptNames
                     FROM Employees 
                     LEFT JOIN EmployeeDepartments ON Employees.EmployeeID = EmployeeDepartments.EmployeeID 
                     LEFT JOIN Departments ON EmployeeDepartments.DeptID = Departments.DeptID 
                     WHERE Employees.FirstName LIKE @FirstName
                     GROUP BY Employees.EmployeeID"
            cmd = New MySqlCommand(query, DatabaseConnection.Connection)
            cmd.Parameters.AddWithValue("@FirstName", "%" & firstName & "%")
        ElseIf Not String.IsNullOrEmpty(employeeID) Then
            ' Only ID has value
            query = "SELECT Employees.EmployeeID, Employees.FirstName, Employees.LastName, GROUP_CONCAT(Departments.DeptName SEPARATOR ', ') AS DeptNames
                     FROM Employees 
                     LEFT JOIN EmployeeDepartments ON Employees.EmployeeID = EmployeeDepartments.EmployeeID 
                     LEFT JOIN Departments ON EmployeeDepartments.DeptID = Departments.DeptID 
                     WHERE Employees.EmployeeID = @EmployeeID
                     GROUP BY Employees.EmployeeID"
            cmd = New MySqlCommand(query, DatabaseConnection.Connection)
            cmd.Parameters.AddWithValue("@EmployeeID", employeeID)
        Else
            MessageBox.Show("Please enter a first name, an employee ID, or both.")
            Return
        End If

        DatabaseConnection.OpenConnection()
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        found_emp.Items.Clear()
        While reader.Read()
            Dim displayText As String = String.Format("ID: {0,-10} FirstName: {1,-20} LastName: {2,-20} Department(s): {3}",
                                                      reader("EmployeeID"),
                                                      reader("FirstName"),
                                                      reader("LastName"),
                                                      reader("DeptNames"))
            found_emp.Items.Add(displayText)
        End While

        DatabaseConnection.CloseConnection()
    End Sub






    'delete button logic


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If found_emp.SelectedItem Is Nothing Then
            MessageBox.Show("Please select an employee to delete.")
            Return
        End If

        ' Extract employee ID from the selected item
        Dim selectedEmployee As String = found_emp.SelectedItem.ToString()
        Dim employeeID As String = selectedEmployee.Split(" "c)(1)

        Dim query As String = "DELETE FROM Employees WHERE EmployeeID = @EmployeeID; 
                               DELETE FROM EmployeeDepartments WHERE EmployeeID = @EmployeeID"
        Dim cmd As MySqlCommand = New MySqlCommand(query, DatabaseConnection.Connection)
        cmd.Parameters.AddWithValue("@EmployeeID", employeeID)

        DatabaseConnection.OpenConnection()
        cmd.ExecuteNonQuery()
        DatabaseConnection.CloseConnection()

        MessageBox.Show("Employee deleted successfully.")
        found_emp.Items.Remove(found_emp.SelectedItem)
    End Sub






    'find button logic

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click

        Dim employeeID As String = Id.Text.Trim()

        If String.IsNullOrEmpty(employeeID) Then
            MessageBox.Show("Please enter an employee ID.")
            Return
        End If

        ' Load all departments
        LoadDepartment()

        Dim query As String = "SELECT Employees.FirstName, Employees.LastName, Employees.Position, Employees.Salary, GROUP_CONCAT(EmployeeDepartments.DeptID) AS DeptIDs
                           FROM Employees
                           LEFT JOIN EmployeeDepartments ON Employees.EmployeeID = EmployeeDepartments.EmployeeID
                           LEFT JOIN Departments ON EmployeeDepartments.DeptID = Departments.DeptID
                           WHERE Employees.EmployeeID = @EmployeeID
                           GROUP BY Employees.EmployeeID"

        Dim cmd As MySqlCommand = New MySqlCommand(query, DatabaseConnection.Connection)
        cmd.Parameters.AddWithValue("@EmployeeID", employeeID)

        DatabaseConnection.OpenConnection()
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        If reader.Read() Then
            fname.Text = reader("FirstName").ToString()
            lname.Text = reader("LastName").ToString()
            pos.Text = reader("Position").ToString()
            sala.Text = reader("Salary").ToString()

            ' Uncheck all items first
            For i As Integer = 0 To dept.Items.Count - 1
                dept.SetItemChecked(i, False)
            Next

            ' Check the departments associated with the employee
            Dim deptIDs As String = reader("DeptIDs").ToString()
            Dim deptIDArray As String() = deptIDs.Split(",")

            For Each deptID As String In deptIDArray
                For i As Integer = 0 To dept.Items.Count - 1
                    Dim clbItem = CType(dept.Items(i), Object)
                    If clbItem.id.ToString() = deptID Then
                        dept.SetItemChecked(i, True)
                    End If
                Next
            Next
        Else
            MessageBox.Show("Employee not found.")
        End If

        DatabaseConnection.CloseConnection()
    End Sub





    ' edit button logic 


    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim employeeID As String = Id.Text.Trim()
        Dim firstName As String = fname.Text.Trim()
        Dim lastName As String = lname.Text.Trim()
        Dim position As String = pos.Text.Trim()
        Dim salary As Decimal = Convert.ToDecimal(sala.Text.Trim())
        Dim selectedDepartments As New List(Of Integer)

        For Each item In dept.CheckedItems
            selectedDepartments.Add(CType(item, Object).id)
        Next

        Dim updateEmployeeQuery As String = "UPDATE Employees SET FirstName = @FirstName, LastName = @LastName, Position = @Position, Salary = @Salary
                                             WHERE EmployeeID = @EmployeeID"
        Dim cmd As MySqlCommand = New MySqlCommand(updateEmployeeQuery, DatabaseConnection.Connection)
        cmd.Parameters.AddWithValue("@FirstName", firstName)
        cmd.Parameters.AddWithValue("@LastName", lastName)
        cmd.Parameters.AddWithValue("@Position", position)
        cmd.Parameters.AddWithValue("@Salary", salary)
        cmd.Parameters.AddWithValue("@EmployeeID", employeeID)

        DatabaseConnection.OpenConnection()
        cmd.ExecuteNonQuery()

        Dim deleteDeptQuery As String = "DELETE FROM EmployeeDepartments WHERE EmployeeID = @EmployeeID"
        Dim deleteCmd As MySqlCommand = New MySqlCommand(deleteDeptQuery, DatabaseConnection.Connection)
        deleteCmd.Parameters.AddWithValue("@EmployeeID", employeeID)
        deleteCmd.ExecuteNonQuery()

        For Each deptID In selectedDepartments
            Dim insertDeptQuery As String = "INSERT INTO EmployeeDepartments (EmployeeID, DeptID) VALUES (@EmployeeID, @DeptID)"
            Dim insertCmd As MySqlCommand = New MySqlCommand(insertDeptQuery, DatabaseConnection.Connection)
            insertCmd.Parameters.AddWithValue("@EmployeeID", employeeID)
            insertCmd.Parameters.AddWithValue("@DeptID", deptID)
            insertCmd.ExecuteNonQuery()
        Next

        DatabaseConnection.CloseConnection()
        MessageBox.Show("Employee updated successfully.")
    End Sub


    ' closing

    Private Sub emp_management_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
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

End Class

