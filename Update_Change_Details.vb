Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Azure
Imports Microsoft.Data.SqlClient

Public Class Update_Change_Details
    Private Sub Button_Load_IC_Click(sender As Object, e As EventArgs) Handles Button_Load_IC.Click
        Dim identification_card As String = Display_IC.Text

        Dim query As String = "SELECT * FROM Users WHERE IC = @IC"
        Dim command As New SqlCommand(query)
        command.Parameters.AddWithValue("@IC", identification_card)

        Dim record As SqlDataReader
        openConnection()
        record = getRecords(command)
        If record.HasRows Then
            record.Read()
            TextBox_Name.Text = record.Item("Name")
            TextBox_IC.Text = record.Item("IC")
            TextBox_Age.Text = record.Item("Age")
            TextBox_Email.Text = record.Item("Email")
            TextBox_Gender.Text = record.Item("Gender") '
            TextBox_PhoneNumber.Text = record.Item("PhoneNumber")
            TextBox_password.Text = "" ' Do not display the hashed password
            RichTextBox_Bio.Text = record.Item("Bio")
        End If
        closeConnection()
    End Sub

    Private Sub Display_IC_VisibleChanged(sender As Object, e As EventArgs) Handles Display_IC.VisibleChanged

        Dim query As String = "SELECT IC FROM Users WHERE Email = @Email"
        Dim command As New SqlCommand(query)
        command.Parameters.AddWithValue("@Email", Login_Page.Email)

        Dim record As SqlDataReader
        openConnection()
        record = getRecords(command)
        If record.HasRows Then
            record.Read()
            Display_IC.Text = record.Item("IC")
        End If
        closeConnection()
    End Sub

    Private Sub Button_Update_Information_Click(sender As Object, e As EventArgs) Handles Button_Update_Information.Click
        Dim identification_card As String = Display_IC.Text

        Dim hashedPassword As String = ""
        If Not String.IsNullOrWhiteSpace(TextBox_password.Text) Then
            hashedPassword = PasswordHasher.HashPassword(TextBox_password.Text)
        End If

        Dim query As String = "UPDATE Users SET IC = @IC, Name = @Name, Age = @Age, Email = @Email, PhoneNumber = @PhoneNumber, Bio = @Bio, Gender = @Gender"
        If Not String.IsNullOrWhiteSpace(hashedPassword) Then
            query &= ", password = @password"
        End If
        query &= " WHERE IC = @OriginalIC"


        Dim command As New SqlCommand(query)
        command.Parameters.AddWithValue("@IC", TextBox_IC.Text)
        command.Parameters.AddWithValue("@Name", TextBox_Name.Text)
        command.Parameters.AddWithValue("@Age", TextBox_Age.Text)
        command.Parameters.AddWithValue("@Email", TextBox_Email.Text)
        command.Parameters.AddWithValue("@PhoneNumber", TextBox_PhoneNumber.Text)
        command.Parameters.AddWithValue("@Bio", RichTextBox_Bio.Text)
        command.Parameters.AddWithValue("@Gender", TextBox_Gender.Text)
        If Not String.IsNullOrWhiteSpace(hashedPassword) Then
            command.Parameters.AddWithValue("@password", hashedPassword)
        End If
        command.Parameters.AddWithValue("@OriginalIC", identification_card)

        Try
            openConnection()
            IUD(command)
            MessageBox.Show("Update successful!")
        Catch ex As SqlException
            MessageBox.Show("SQL Error: " & ex.Message)
        Finally
            closeConnection()
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Main_Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Login_Page.Show()
        Me.Hide()
        Display_IC.Text = ""
    End Sub
End Class
