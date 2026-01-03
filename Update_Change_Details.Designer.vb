<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Update_Change_Details
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
        Panel1 = New Panel()
        TextBox_Gender = New TextBox()
        TextBox_Age = New TextBox()
        Label16 = New Label()
        TextBox_password = New TextBox()
        Button_Update_Information = New Button()
        RichTextBox_Bio = New RichTextBox()
        Label15 = New Label()
        TextBox_Email = New TextBox()
        TextBox_IC = New TextBox()
        TextBox_PhoneNumber = New TextBox()
        Label7 = New Label()
        TextBox_Name = New TextBox()
        Label14 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Button_Load_IC = New Button()
        Display_IC = New Label()
        Label1 = New Label()
        Button2 = New Button()
        Button1 = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(TextBox_Gender)
        Panel1.Controls.Add(TextBox_Age)
        Panel1.Controls.Add(Label16)
        Panel1.Controls.Add(TextBox_password)
        Panel1.Controls.Add(Button_Update_Information)
        Panel1.Controls.Add(RichTextBox_Bio)
        Panel1.Controls.Add(Label15)
        Panel1.Controls.Add(TextBox_Email)
        Panel1.Controls.Add(TextBox_IC)
        Panel1.Controls.Add(TextBox_PhoneNumber)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(TextBox_Name)
        Panel1.Controls.Add(Label14)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(49, 137)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(358, 403)
        Panel1.TabIndex = 1
        ' 
        ' TextBox_Gender
        ' 
        TextBox_Gender.Location = New Point(89, 141)
        TextBox_Gender.Name = "TextBox_Gender"
        TextBox_Gender.Size = New Size(126, 23)
        TextBox_Gender.TabIndex = 17
        ' 
        ' TextBox_Age
        ' 
        TextBox_Age.Location = New Point(89, 81)
        TextBox_Age.Name = "TextBox_Age"
        TextBox_Age.Size = New Size(126, 23)
        TextBox_Age.TabIndex = 16
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(12, 144)
        Label16.Name = "Label16"
        Label16.Size = New Size(45, 15)
        Label16.TabIndex = 15
        Label16.Text = "Gender"
        ' 
        ' TextBox_password
        ' 
        TextBox_password.Location = New Point(89, 201)
        TextBox_password.Name = "TextBox_password"
        TextBox_password.Size = New Size(258, 23)
        TextBox_password.TabIndex = 7
        ' 
        ' Button_Update_Information
        ' 
        Button_Update_Information.Location = New Point(130, 359)
        Button_Update_Information.Name = "Button_Update_Information"
        Button_Update_Information.Size = New Size(85, 39)
        Button_Update_Information.TabIndex = 9
        Button_Update_Information.Text = "Update User Information"
        Button_Update_Information.UseVisualStyleBackColor = True
        ' 
        ' RichTextBox_Bio
        ' 
        RichTextBox_Bio.Location = New Point(89, 248)
        RichTextBox_Bio.Name = "RichTextBox_Bio"
        RichTextBox_Bio.Size = New Size(258, 96)
        RichTextBox_Bio.TabIndex = 8
        RichTextBox_Bio.Text = ""
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(12, 209)
        Label15.Name = "Label15"
        Label15.Size = New Size(57, 15)
        Label15.TabIndex = 13
        Label15.Text = "Password"
        ' 
        ' TextBox_Email
        ' 
        TextBox_Email.Location = New Point(89, 110)
        TextBox_Email.Name = "TextBox_Email"
        TextBox_Email.PlaceholderText = "example@example.com"
        TextBox_Email.Size = New Size(258, 23)
        TextBox_Email.TabIndex = 4
        ' 
        ' TextBox_IC
        ' 
        TextBox_IC.Location = New Point(89, 52)
        TextBox_IC.MaxLength = 12
        TextBox_IC.Name = "TextBox_IC"
        TextBox_IC.PlaceholderText = "000000000000"
        TextBox_IC.Size = New Size(258, 23)
        TextBox_IC.TabIndex = 2
        ' 
        ' TextBox_PhoneNumber
        ' 
        TextBox_PhoneNumber.Location = New Point(89, 170)
        TextBox_PhoneNumber.MaxLength = 11
        TextBox_PhoneNumber.Name = "TextBox_PhoneNumber"
        TextBox_PhoneNumber.Size = New Size(258, 23)
        TextBox_PhoneNumber.TabIndex = 6
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(-1, 178)
        Label7.Name = "Label7"
        Label7.Size = New Size(88, 15)
        Label7.TabIndex = 4
        Label7.Text = "Phone Number"
        ' 
        ' TextBox_Name
        ' 
        TextBox_Name.Location = New Point(89, 24)
        TextBox_Name.Name = "TextBox_Name"
        TextBox_Name.Size = New Size(258, 23)
        TextBox_Name.TabIndex = 1
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(3, 251)
        Label14.Name = "Label14"
        Label14.Size = New Size(61, 15)
        Label14.TabIndex = 5
        Label14.Text = "Biography"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 118)
        Label5.Name = "Label5"
        Label5.Size = New Size(36, 15)
        Label5.TabIndex = 3
        Label5.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 84)
        Label4.Name = "Label4"
        Label4.Size = New Size(28, 15)
        Label4.TabIndex = 2
        Label4.Text = "Age"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 55)
        Label3.Name = "Label3"
        Label3.Size = New Size(21, 15)
        Label3.TabIndex = 1
        Label3.Text = "IC "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 27)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 15)
        Label2.TabIndex = 0
        Label2.Text = "Full Name"
        ' 
        ' Button_Load_IC
        ' 
        Button_Load_IC.Location = New Point(306, 100)
        Button_Load_IC.Name = "Button_Load_IC"
        Button_Load_IC.Size = New Size(101, 23)
        Button_Load_IC.TabIndex = 3
        Button_Load_IC.Text = "Load IC Details"
        Button_Load_IC.UseVisualStyleBackColor = True
        ' 
        ' Display_IC
        ' 
        Display_IC.AutoSize = True
        Display_IC.BackColor = SystemColors.InactiveCaption
        Display_IC.Location = New Point(188, 104)
        Display_IC.Name = "Display_IC"
        Display_IC.Size = New Size(59, 15)
        Display_IC.TabIndex = 11
        Display_IC.Text = "Display IC"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.InactiveCaption
        Label1.Location = New Point(49, 104)
        Label1.Name = "Label1"
        Label1.Size = New Size(133, 15)
        Label1.TabIndex = 10
        Label1.Text = "Identification Card (IC): "
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ActiveCaption
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(222, 22)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 52)
        Button2.TabIndex = 13
        Button2.Text = "Sign-Out"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaption
        Button1.BackgroundImageLayout = ImageLayout.Center
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(113, 22)
        Button1.Name = "Button1"
        Button1.Size = New Size(103, 52)
        Button1.TabIndex = 12
        Button1.Text = "Back To Main Dashboard"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Update_Change_Details
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.InactiveCaption
        ClientSize = New Size(448, 577)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Display_IC)
        Controls.Add(Label1)
        Controls.Add(Button_Load_IC)
        Controls.Add(Panel1)
        Name = "Update_Change_Details"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Update/Change Details"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents TextBox_password As TextBox
    Friend WithEvents Button_Update_Information As Button
    Friend WithEvents RichTextBox_Bio As RichTextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox_Email As TextBox
    Friend WithEvents TextBox_IC As TextBox
    Friend WithEvents TextBox_PhoneNumber As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox_Name As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_Age As TextBox
    Friend WithEvents TextBox_Gender As TextBox
    Friend WithEvents Button_Load_IC As Button
    Friend WithEvents Display_IC As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
