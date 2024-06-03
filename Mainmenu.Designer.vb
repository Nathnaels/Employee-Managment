<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mainmenu
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
        Label1 = New Label()
        emp_management = New Button()
        dept_management = New Button()
        btnlogout = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(60, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(651, 33)
        Label1.TabIndex = 0
        Label1.Text = "Wellcome to UU Employee managment System"
        ' 
        ' emp_management
        ' 
        emp_management.Location = New Point(279, 103)
        emp_management.Name = "emp_management"
        emp_management.Size = New Size(208, 50)
        emp_management.TabIndex = 1
        emp_management.Text = "Employee management Panel"
        emp_management.UseVisualStyleBackColor = True
        ' 
        ' dept_management
        ' 
        dept_management.Location = New Point(279, 189)
        dept_management.Name = "dept_management"
        dept_management.Size = New Size(208, 50)
        dept_management.TabIndex = 2
        dept_management.Text = "Department management Panel"
        dept_management.UseVisualStyleBackColor = True
        ' 
        ' btnlogout
        ' 
        btnlogout.Location = New Point(540, 271)
        btnlogout.Name = "btnlogout"
        btnlogout.Size = New Size(75, 23)
        btnlogout.TabIndex = 3
        btnlogout.Text = "log out"
        btnlogout.UseVisualStyleBackColor = True
        ' 
        ' Mainmenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnlogout)
        Controls.Add(dept_management)
        Controls.Add(emp_management)
        Controls.Add(Label1)
        Name = "Mainmenu"
        Text = "Mainmenu"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents emp_management As Button
    Friend WithEvents dept_management As Button
    Friend WithEvents btnlogout As Button
End Class
