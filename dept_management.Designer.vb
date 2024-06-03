<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dept_management
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
        GroupBox3 = New GroupBox()
        btnFind = New Button()
        Label12 = New Label()
        Id = New TextBox()
        Label7 = New Label()
        sala = New TextBox()
        Label11 = New Label()
        fname = New TextBox()
        btnEdit = New Button()
        GroupBox2 = New GroupBox()
        lbFoundDept = New ListBox()
        Label14 = New Label()
        txtSearchDeptID = New TextBox()
        Label13 = New Label()
        txtSearchDeptName = New TextBox()
        btnSearch = New Button()
        btnDelete = New Button()
        GroupBox1 = New GroupBox()
        Label4 = New Label()
        Label1 = New Label()
        txtHeadID = New TextBox()
        txtDeptName = New TextBox()
        btnAdd = New Button()
        mainmenu = New Button()
        GroupBox3.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(btnFind)
        GroupBox3.Controls.Add(Label12)
        GroupBox3.Controls.Add(Id)
        GroupBox3.Controls.Add(Label7)
        GroupBox3.Controls.Add(sala)
        GroupBox3.Controls.Add(Label11)
        GroupBox3.Controls.Add(fname)
        GroupBox3.Controls.Add(btnEdit)
        GroupBox3.Location = New Point(537, 24)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(227, 295)
        GroupBox3.TabIndex = 9
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
        Label12.Size = New Size(219, 15)
        Label12.TabIndex = 23
        Label12.Text = "Enter the ID of the Dept you want to edit"
        ' 
        ' Id
        ' 
        Id.Location = New Point(7, 42)
        Id.Name = "Id"
        Id.Size = New Size(100, 23)
        Id.TabIndex = 22
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(7, 133)
        Label7.Name = "Label7"
        Label7.Size = New Size(77, 15)
        Label7.TabIndex = 20
        Label7.Text = "Dept Head ID"
        ' 
        ' sala
        ' 
        sala.Location = New Point(90, 130)
        sala.Name = "sala"
        sala.Size = New Size(100, 23)
        sala.TabIndex = 19
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(7, 87)
        Label11.Name = "Label11"
        Label11.Size = New Size(67, 15)
        Label11.TabIndex = 15
        Label11.Text = "Dept Name"
        ' 
        ' fname
        ' 
        fname.Location = New Point(88, 84)
        fname.Name = "fname"
        fname.Size = New Size(100, 23)
        fname.TabIndex = 12
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(63, 239)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(75, 23)
        btnEdit.TabIndex = 2
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(lbFoundDept)
        GroupBox2.Controls.Add(Label14)
        GroupBox2.Controls.Add(txtSearchDeptID)
        GroupBox2.Controls.Add(Label13)
        GroupBox2.Controls.Add(txtSearchDeptName)
        GroupBox2.Controls.Add(btnSearch)
        GroupBox2.Controls.Add(btnDelete)
        GroupBox2.Location = New Point(315, 40)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(200, 268)
        GroupBox2.TabIndex = 8
        GroupBox2.TabStop = False
        GroupBox2.Text = "Modify Employee Data"
        ' 
        ' lbFoundDept
        ' 
        lbFoundDept.FormattingEnabled = True
        lbFoundDept.ItemHeight = 15
        lbFoundDept.Location = New Point(37, 102)
        lbFoundDept.Name = "lbFoundDept"
        lbFoundDept.Size = New Size(120, 94)
        lbFoundDept.TabIndex = 10
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(12, 66)
        Label14.Name = "Label14"
        Label14.Size = New Size(45, 15)
        Label14.TabIndex = 9
        Label14.Text = "Dept Id"
        ' 
        ' txtSearchDeptID
        ' 
        txtSearchDeptID.Location = New Point(82, 63)
        txtSearchDeptID.Name = "txtSearchDeptID"
        txtSearchDeptID.Size = New Size(100, 23)
        txtSearchDeptID.TabIndex = 8
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(12, 30)
        Label13.Name = "Label13"
        Label13.Size = New Size(67, 15)
        Label13.TabIndex = 7
        Label13.Text = "Dept Name"
        ' 
        ' txtSearchDeptName
        ' 
        txtSearchDeptName.Location = New Point(82, 27)
        txtSearchDeptName.Name = "txtSearchDeptName"
        txtSearchDeptName.Size = New Size(100, 23)
        txtSearchDeptName.TabIndex = 6
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
        ' btnDelete
        ' 
        btnDelete.Location = New Point(12, 223)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 23)
        btnDelete.TabIndex = 1
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txtHeadID)
        GroupBox1.Controls.Add(txtDeptName)
        GroupBox1.Controls.Add(btnAdd)
        GroupBox1.Location = New Point(22, 37)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(271, 291)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        GroupBox1.Text = "Add New Dept"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(15, 64)
        Label4.Name = "Label4"
        Label4.Size = New Size(49, 15)
        Label4.TabIndex = 8
        Label4.Text = "Head ID"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(15, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 15)
        Label1.TabIndex = 5
        Label1.Text = "Dept Name"
        ' 
        ' txtHeadID
        ' 
        txtHeadID.Location = New Point(85, 61)
        txtHeadID.Name = "txtHeadID"
        txtHeadID.Size = New Size(100, 23)
        txtHeadID.TabIndex = 4
        ' 
        ' txtDeptName
        ' 
        txtDeptName.Location = New Point(85, 32)
        txtDeptName.Name = "txtDeptName"
        txtDeptName.Size = New Size(100, 23)
        txtDeptName.TabIndex = 1
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = SystemColors.ActiveCaption
        btnAdd.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnAdd.Location = New Point(61, 226)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(110, 30)
        btnAdd.TabIndex = 0
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' mainmenu
        ' 
        mainmenu.Location = New Point(315, 366)
        mainmenu.Name = "mainmenu"
        mainmenu.Size = New Size(103, 30)
        mainmenu.TabIndex = 10
        mainmenu.Text = "Main menu"
        mainmenu.UseVisualStyleBackColor = True
        ' 
        ' dept_management
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(mainmenu)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "dept_management"
        Text = "dept_management"
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnFind As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Id As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents sala As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents fname As TextBox
    Friend WithEvents btnEdit As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtSearchDeptID As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtSearchDeptName As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtHeadID As TextBox
    Friend WithEvents txtDeptName As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents mainmenu As Button
    Friend WithEvents lbFoundDept As ListBox
End Class
