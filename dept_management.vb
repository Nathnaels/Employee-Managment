Imports MySql.Data.MySqlClient

Public Class dept_management
    Private Sub mainmenu_Click(sender As Object, e As EventArgs) Handles mainmenu.Click
        Me.Close()
        Dim mainForm As New Mainmenu()
        mainForm.Show()
    End Sub



    Private Sub dept_management_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
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









    ' new     new         new     newe


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim deptName As String = txtDeptName.Text
        Dim headID As Integer = Convert.ToInt32(txtHeadID.Text)

        Try
            DatabaseConnection.OpenConnection()

            Dim query As String = "INSERT INTO Departments (DeptName, HeadID) VALUES (@DeptName, @HeadID)"
            Using command As New MySqlCommand(query, DatabaseConnection.Connection)
                command.Parameters.AddWithValue("@DeptName", deptName)
                command.Parameters.AddWithValue("@HeadID", headID)
                command.ExecuteNonQuery()
            End Using

            MessageBox.Show("Department added successfully.")
            ClearTextBoxes()
        Catch ex As Exception
            MessageBox.Show("An error occurred while adding the department: " & ex.Message)
        Finally
            DatabaseConnection.CloseConnection()
        End Try
    End Sub







    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchDeptName As String = txtSearchDeptName.Text
        Dim searchDeptID As Integer = If(Integer.TryParse(txtSearchDeptID.Text, searchDeptID), searchDeptID, -1)

        Dim query As String = "SELECT DeptID, DeptName FROM Departments WHERE 1=1"
        If Not String.IsNullOrWhiteSpace(searchDeptName) Then
            query &= $" AND DeptName LIKE '%{searchDeptName}%'"
        End If
        If searchDeptID <> -1 Then
            query &= $" AND DeptID = {searchDeptID}"
        End If

        Try
            DatabaseConnection.OpenConnection()

            Dim dt As New DataTable()
            Using adapter As New MySqlDataAdapter(query, DatabaseConnection.Connection)
                adapter.Fill(dt)
            End Using

            lbFoundDept.DataSource = dt
            lbFoundDept.DisplayMember = "DeptName"
            lbFoundDept.ValueMember = "DeptID"
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            DatabaseConnection.CloseConnection()
        End Try
    End Sub






    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim selectedDeptID As Integer = If(lbFoundDept.SelectedItem IsNot Nothing, Convert.ToInt32(lbFoundDept.SelectedValue), -1)
        If selectedDeptID = -1 Then
            MessageBox.Show("Please select a department to delete.")
            Return
        End If

        ' Check if the department ID is referenced in the EmployeeDepartments table
        Dim isReferenced As Boolean = CheckIfDeptIsReferenced(selectedDeptID)
        If isReferenced Then
            Dim confirmResult As DialogResult = MessageBox.Show("This department is referenced in the EmployeeDepartments table. Deleting it will affect related records. Are you sure you want to proceed?", "Confirm Delete", MessageBoxButtons.YesNo)
            If confirmResult = DialogResult.No Then
                Return
            End If
        End If

        Try
            DatabaseConnection.OpenConnection()

            Dim query As String = "DELETE FROM Departments WHERE DeptID = @DeptID"
            Using command As New MySqlCommand(query, DatabaseConnection.Connection)
                command.Parameters.AddWithValue("@DeptID", selectedDeptID)
                command.ExecuteNonQuery()
            End Using

            MessageBox.Show("Department deleted successfully.")
            btnSearch.PerformClick() ' Refresh search results
        Catch ex As Exception
            MessageBox.Show("An error occurred while deleting the department: " & ex.Message)
        Finally
            DatabaseConnection.CloseConnection()
        End Try
    End Sub



    Private Function CheckIfDeptIsReferenced(deptID As Integer) As Boolean
        Dim isReferenced As Boolean = False
        Try
            Dim query As String = "SELECT COUNT(*) FROM EmployeeDepartments WHERE DeptID = @DeptID"
            Using connection As New MySqlConnection(DatabaseConnection.ConnectionString)
                connection.Open()
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@DeptID", deptID)
                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                    isReferenced = count > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while checking if the department is referenced: " & ex.Message)
        End Try
        Return isReferenced
    End Function


    Private Sub ClearTextBoxes()
        txtDeptName.Clear()
        txtHeadID.Clear()
    End Sub






    Private Sub dept_management_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

