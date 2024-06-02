<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class emp_management
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnAddEmployee = New Button()
        btnDelete = New Button()
        btnEdit = New Button()
        btnSearch = New Button()
        GroupBox1 = New GroupBox()
        DOB = New DateTimePicker()
        Label6 = New Label()
        Listofdepts = New ComboBox()
        Label5 = New Label()
        txtSalary = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtLastname = New TextBox()
        txtPosition = New TextBox()
        txtFirstname = New TextBox()
        GroupBox2 = New GroupBox()
        Label14 = New Label()
        TextBox2 = New TextBox()
        Label13 = New Label()
        TextBox1 = New TextBox()
        found_emps = New ListBox()
        GroupBox3 = New GroupBox()
        btnFind = New Button()
        Label12 = New Label()
        Id = New TextBox()
        depts = New ComboBox()
        Label7 = New Label()
        sala = New TextBox()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        lname = New TextBox()
        pos = New TextBox()
        fname = New TextBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnAddEmployee
        ' 
        btnAddEmployee.BackColor = SystemColors.ActiveCaption
        btnAddEmployee.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnAddEmployee.Location = New Point(61, 226)
        btnAddEmployee.Name = "btnAddEmployee"
        btnAddEmployee.Size = New Size(110, 30)
        btnAddEmployee.TabIndex = 0
        btnAddEmployee.Text = "Add"
        btnAddEmployee.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(26, 223)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 23)
        btnDelete.TabIndex = 1
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(19, 254)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(75, 23)
        btnEdit.TabIndex = 2
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(107, 223)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(75, 23)
        btnSearch.TabIndex = 3
        btnSearch.Text = "search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(DOB)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Listofdepts)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(txtSalary)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txtLastname)
        GroupBox1.Controls.Add(txtPosition)
        GroupBox1.Controls.Add(txtFirstname)
        GroupBox1.Controls.Add(btnAddEmployee)
        GroupBox1.Location = New Point(35, 36)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(271, 291)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "Add New Employee"
        ' 
        ' DOB
        ' 
        DOB.Location = New Point(85, 189)
        DOB.Name = "DOB"
        DOB.Size = New Size(153, 23)
        DOB.TabIndex = 13
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(15, 189)
        Label6.Name = "Label6"
        Label6.Size = New Size(31, 15)
        Label6.TabIndex = 12
        Label6.Text = "DOB"
        ' 
        ' Listofdepts
        ' 
        Listofdepts.FormattingEnabled = True
        Listofdepts.Items.AddRange(New Object() {"IT", "Finance", "Marketing and Sells", "Management"})
        Listofdepts.Location = New Point(85, 96)
        Listofdepts.Name = "Listofdepts"
        Listofdepts.Size = New Size(100, 23)
        Listofdepts.TabIndex = 11
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(15, 157)
        Label5.Name = "Label5"
        Label5.Size = New Size(37, 15)
        Label5.TabIndex = 10
        Label5.Text = "salary"
        ' 
        ' txtSalary
        ' 
        txtSalary.Location = New Point(85, 154)
        txtSalary.Name = "txtSalary"
        txtSalary.Size = New Size(100, 23)
        txtSalary.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(15, 64)
        Label4.Name = "Label4"
        Label4.Size = New Size(63, 15)
        Label4.TabIndex = 8
        Label4.Text = "Last Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(15, 96)
        Label3.Name = "Label3"
        Label3.Size = New Size(35, 15)
        Label3.TabIndex = 7
        Label3.Text = "Dept "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(15, 128)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 15)
        Label2.TabIndex = 6
        Label2.Text = "Position"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(15, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 15)
        Label1.TabIndex = 5
        Label1.Text = "First Name"
        ' 
        ' txtLastname
        ' 
        txtLastname.Location = New Point(85, 61)
        txtLastname.Name = "txtLastname"
        txtLastname.Size = New Size(100, 23)
        txtLastname.TabIndex = 4
        ' 
        ' txtPosition
        ' 
        txtPosition.Location = New Point(85, 125)
        txtPosition.Name = "txtPosition"
        txtPosition.Size = New Size(100, 23)
        txtPosition.TabIndex = 3
        ' 
        ' txtFirstname
        ' 
        txtFirstname.Location = New Point(85, 32)
        txtFirstname.Name = "txtFirstname"
        txtFirstname.Size = New Size(100, 23)
        txtFirstname.TabIndex = 1
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label14)
        GroupBox2.Controls.Add(TextBox2)
        GroupBox2.Controls.Add(Label13)
        GroupBox2.Controls.Add(TextBox1)
        GroupBox2.Controls.Add(found_emps)
        GroupBox2.Controls.Add(btnSearch)
        GroupBox2.Controls.Add(btnDelete)
        GroupBox2.Location = New Point(328, 39)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(200, 268)
        GroupBox2.TabIndex = 5
        GroupBox2.TabStop = False
        GroupBox2.Text = "Modify Employee Data"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(12, 66)
        Label14.Name = "Label14"
        Label14.Size = New Size(18, 15)
        Label14.TabIndex = 9
        Label14.Text = "ID"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(82, 63)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 8
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(12, 30)
        Label13.Name = "Label13"
        Label13.Size = New Size(64, 15)
        Label13.TabIndex = 7
        Label13.Text = "First Name"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(82, 27)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 6
        ' 
        ' found_emps
        ' 
        found_emps.FormattingEnabled = True
        found_emps.ItemHeight = 15
        found_emps.Location = New Point(26, 114)
        found_emps.Name = "found_emps"
        found_emps.ScrollAlwaysVisible = True
        found_emps.Size = New Size(139, 94)
        found_emps.TabIndex = 4
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(btnFind)
        GroupBox3.Controls.Add(Label12)
        GroupBox3.Controls.Add(Id)
        GroupBox3.Controls.Add(depts)
        GroupBox3.Controls.Add(Label7)
        GroupBox3.Controls.Add(sala)
        GroupBox3.Controls.Add(Label8)
        GroupBox3.Controls.Add(Label9)
        GroupBox3.Controls.Add(Label10)
        GroupBox3.Controls.Add(Label11)
        GroupBox3.Controls.Add(lname)
        GroupBox3.Controls.Add(pos)
        GroupBox3.Controls.Add(fname)
        GroupBox3.Controls.Add(btnEdit)
        GroupBox3.Location = New Point(550, 23)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(227, 295)
        GroupBox3.TabIndex = 6
        GroupBox3.TabStop = False
        GroupBox3.Text = "Modify Employee Data"
        ' 
        ' btnFind
        ' 
        btnFind.Location = New Point(113, 42)
        btnFind.Name = "btnFind"
        btnFind.Size = New Size(75, 23)
        btnFind.TabIndex = 24
        btnFind.Text = "Find"
        btnFind.UseVisualStyleBackColor = True
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(0, 24)
        Label12.Name = "Label12"
        Label12.Size = New Size(218, 15)
        Label12.TabIndex = 23
        Label12.Text = "Enter the ID of the emp you want to edit"
        ' 
        ' Id
        ' 
        Id.Location = New Point(7, 42)
        Id.Name = "Id"
        Id.Size = New Size(100, 23)
        Id.TabIndex = 22
        ' 
        ' depts
        ' 
        depts.FormattingEnabled = True
        depts.Items.AddRange(New Object() {"IT", "Finance", "Marketing and Sells", "Management"})
        depts.Location = New Point(77, 148)
        depts.Name = "depts"
        depts.Size = New Size(100, 23)
        depts.TabIndex = 21
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(7, 209)
        Label7.Name = "Label7"
        Label7.Size = New Size(37, 15)
        Label7.TabIndex = 20
        Label7.Text = "salary"
        ' 
        ' sala
        ' 
        sala.Location = New Point(77, 206)
        sala.Name = "sala"
        sala.Size = New Size(100, 23)
        sala.TabIndex = 19
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(7, 116)
        Label8.Name = "Label8"
        Label8.Size = New Size(63, 15)
        Label8.TabIndex = 18
        Label8.Text = "Last Name"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(7, 148)
        Label9.Name = "Label9"
        Label9.Size = New Size(35, 15)
        Label9.TabIndex = 17
        Label9.Text = "Dept "
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(7, 180)
        Label10.Name = "Label10"
        Label10.Size = New Size(50, 15)
        Label10.TabIndex = 16
        Label10.Text = "Position"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(7, 87)
        Label11.Name = "Label11"
        Label11.Size = New Size(64, 15)
        Label11.TabIndex = 15
        Label11.Text = "First Name"
        ' 
        ' lname
        ' 
        lname.Location = New Point(77, 113)
        lname.Name = "lname"
        lname.Size = New Size(100, 23)
        lname.TabIndex = 14
        ' 
        ' pos
        ' 
        pos.Location = New Point(77, 177)
        pos.Name = "pos"
        pos.Size = New Size(100, 23)
        pos.TabIndex = 13
        ' 
        ' fname
        ' 
        fname.Location = New Point(77, 84)
        fname.Name = "fname"
        fname.Size = New Size(100, 23)
        fname.TabIndex = 12
        ' 
        ' emp_management
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "emp_management"
        Text = "emp_management"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnAddEmployee As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtLastname As TextBox
    Friend WithEvents txtPosition As TextBox
    Friend WithEvents txtFirstname As TextBox
    Friend WithEvents Listofdepts As ComboBox
    Friend WithEvents DOB As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnFind As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Id As TextBox
    Friend WithEvents depts As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents sala As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lname As TextBox
    Friend WithEvents pos As TextBox
    Friend WithEvents fname As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents found_emps As ListBox
End Class
