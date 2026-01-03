<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Information_Details
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
        ComboBox_Gender = New ComboBox()
        ComboBox_Age = New ComboBox()
        Label16 = New Label()
        TextBox_password = New TextBox()
        Button_Save1 = New Button()
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
        Label1 = New Label()
        Label6 = New Label()
        Panel2 = New Panel()
        Label13 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Button1 = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(ComboBox_Gender)
        Panel1.Controls.Add(ComboBox_Age)
        Panel1.Controls.Add(Label16)
        Panel1.Controls.Add(TextBox_password)
        Panel1.Controls.Add(Button_Save1)
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
        Panel1.Location = New Point(12, 103)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(358, 403)
        Panel1.TabIndex = 0
        ' 
        ' ComboBox_Gender
        ' 
        ComboBox_Gender.FormattingEnabled = True
        ComboBox_Gender.Items.AddRange(New Object() {"Male", "Female"})
        ComboBox_Gender.Location = New Point(89, 141)
        ComboBox_Gender.Name = "ComboBox_Gender"
        ComboBox_Gender.Size = New Size(258, 23)
        ComboBox_Gender.TabIndex = 5
        ' 
        ' ComboBox_Age
        ' 
        ComboBox_Age.FormattingEnabled = True
        ComboBox_Age.Items.AddRange(New Object() {"0", "1 ", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100"})
        ComboBox_Age.Location = New Point(89, 81)
        ComboBox_Age.Name = "ComboBox_Age"
        ComboBox_Age.Size = New Size(258, 23)
        ComboBox_Age.TabIndex = 3
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(28, 144)
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
        ' Button_Save1
        ' 
        Button_Save1.Location = New Point(130, 359)
        Button_Save1.Name = "Button_Save1"
        Button_Save1.Size = New Size(85, 39)
        Button_Save1.TabIndex = 9
        Button_Save1.Text = "Save User Information"
        Button_Save1.UseVisualStyleBackColor = True
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
        Label15.Location = New Point(16, 204)
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
        Label14.Location = New Point(22, 248)
        Label14.Name = "Label14"
        Label14.Size = New Size(61, 15)
        Label14.TabIndex = 5
        Label14.Text = "Biography"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(37, 113)
        Label5.Name = "Label5"
        Label5.Size = New Size(36, 15)
        Label5.TabIndex = 3
        Label5.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(45, 84)
        Label4.Name = "Label4"
        Label4.Size = New Size(28, 15)
        Label4.TabIndex = 2
        Label4.Text = "Age"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(52, 55)
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(25, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(609, 37)
        Label1.TabIndex = 1
        Label1.Text = "Personal Information And Medications Details"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 85)
        Label6.Name = "Label6"
        Label6.Size = New Size(96, 15)
        Label6.TabIndex = 2
        Label6.Text = "User Information"
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Label13)
        Panel2.Controls.Add(Label12)
        Panel2.Controls.Add(Label11)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(Label9)
        Panel2.Location = New Point(404, 103)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(375, 294)
        Panel2.TabIndex = 3
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(3, 140)
        Label13.Name = "Label13"
        Label13.Size = New Size(132, 15)
        Label13.TabIndex = 4
        Label13.Text = "Next Appointment Date"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(3, 109)
        Label12.Name = "Label12"
        Label12.Size = New Size(118, 15)
        Label12.TabIndex = 3
        Label12.Text = "Current Pills Amount"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(3, 82)
        Label11.Name = "Label11"
        Label11.Size = New Size(121, 15)
        Label11.TabIndex = 2
        Label11.Text = "Name of Medications"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(3, 55)
        Label10.Name = "Label10"
        Label10.Size = New Size(133, 15)
        Label10.TabIndex = 1
        Label10.Text = "Amount of Medications"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(3, 27)
        Label9.Name = "Label9"
        Label9.Size = New Size(108, 15)
        Label9.TabIndex = 0
        Label9.Text = "Name of the Illness"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(404, 85)
        Label8.Name = "Label8"
        Label8.Size = New Size(105, 15)
        Label8.TabIndex = 4
        Label8.Text = "Medication Details"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(654, 11)
        Button1.Name = "Button1"
        Button1.Size = New Size(121, 60)
        Button1.TabIndex = 5
        Button1.Text = "Back to Login Page"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Information_Details
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(788, 650)
        Controls.Add(Button1)
        Controls.Add(Label8)
        Controls.Add(Panel2)
        Controls.Add(Label6)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Name = "Information_Details"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Information Details"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox_IC As TextBox
    Friend WithEvents TextBox_Name As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Button_Save1 As Button
    Friend WithEvents RichTextBox_Bio As RichTextBox
    Friend WithEvents TextBox_PhoneNumber As TextBox
    Friend WithEvents TextBox_Email As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox_password As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents ComboBox_Gender As ComboBox
    Friend WithEvents ComboBox_Age As ComboBox
End Class
