Imports System.Security.Cryptography.X509Certificates
'Imports MySql.Data.MySqlClient
Imports Microsoft.Data.SqlClient

Public Class Login_Page

    'Dim MysqlConn As MySqlConnection
    'Dim COMMAND As MySqlCommand
    Public Property Email As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim MainDashboard As New Main_Dashboard
        MainDashboard.Email = TextBox1.Text

        If String.IsNullOrWhiteSpace(TextBox1.Text) OrElse String.IsNullOrWhiteSpace(TextBox2.Text) Then
            MessageBox.Show("Please enter both email and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim userEmail As String = TextBox1.Text
        Dim password As String = TextBox2.Text
        Dim hashedPasswordFromDb As String = ""

        ' Define the SQL query to get the hashed password for the user
        Dim query As String = "SELECT password FROM Users WHERE Email = @Email"
        Dim command As New SqlCommand(query)
        command.Parameters.AddWithValue("@Email", userEmail)

        Try
            openConnection()
            hashedPasswordFromDb = getOneValue(command)
        Catch ex As Exception
            MessageBox.Show("An error occurred while connecting to the database: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            closeConnection()
        End Try

        ' Verify the password if a hash was found
        If Not String.IsNullOrEmpty(hashedPasswordFromDb) AndAlso PasswordHasher.VerifyPassword(password, hashedPasswordFromDb) Then
            MessageBox.Show("Login Successful!")
            Email = userEmail
            TextBox1.Clear()
            TextBox2.Clear()
            MainDashboard.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid Username or Password", "Unauthorized", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            TextBox1.Clear()
            TextBox2.Clear()
        End If

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs)

        TextBox1.Clear()
        TextBox2.Clear()

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click

        Dim MainDashboard As New Main_Dashboard
        MainDashboard.Show()
        Me.Visible = False

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        Dim InformationDetails As New Information_Details
        InformationDetails.Show()
        Me.Visible = False

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            openConnection()
            MessageBox.Show("Database connected sucessfully")
            closeConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
End Class
