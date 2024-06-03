<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        user_name = New TextBox()
        password = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        log_in = New Button()
        GroupBox1 = New GroupBox()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' user_name
        ' 
        user_name.Location = New Point(157, 44)
        user_name.Name = "user_name"
        user_name.Size = New Size(100, 23)
        user_name.TabIndex = 0
        ' 
        ' password
        ' 
        password.Location = New Point(157, 92)
        password.Name = "password"
        password.Size = New Size(100, 23)
        password.TabIndex = 1
        password.UseSystemPasswordChar = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(45, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(65, 15)
        Label1.TabIndex = 2
        Label1.Text = "User Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(45, 95)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 3
        Label2.Text = "password"
        ' 
        ' log_in
        ' 
        log_in.BackColor = SystemColors.ActiveCaption
        log_in.Location = New Point(142, 156)
        log_in.Name = "log_in"
        log_in.Size = New Size(128, 23)
        log_in.TabIndex = 4
        log_in.Text = "Login"
        log_in.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ButtonHighlight
        GroupBox1.Controls.Add(log_in)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(password)
        GroupBox1.Controls.Add(user_name)
        GroupBox1.Location = New Point(238, 40)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(328, 235)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox1)
        Name = "login"
        Text = "login"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents user_name As TextBox
    Friend WithEvents password As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents log_in As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
