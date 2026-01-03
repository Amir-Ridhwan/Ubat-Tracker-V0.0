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

        'MysqlConn = New MySqlConnection
        'MysqlConn.ConnectionString = "server=localhost;userid=root; database=UBAT"
        'Dim READER As MySqlDataReader


        'Try
        '    MysqlConn.Open()
        '    Dim Query As String
        '    Query = "SELECT * FROM UBAT.Users WHERE Email ='" & TextBox1.Text & "' and password = '" & TextBox2.Text & "' "
        '    COMMAND = New MySqlCommand(Query, MysqlConn)
        '    READER = COMMAND.ExecuteReader

        '    Dim count As Integer
        '    count = 0

        '    While READER.Read
        '        count = count + 1

        '        While TextBox1.Text = "" Or TextBox2.Text = ""
        '            If TextBox1.Text = "" Then
        '                MessageBox.Show("Missing input data on Email")
        '                Exit Sub
        '                TextBox1.Focus()
        '            End If

        '            If TextBox2.Text = "" Then
        '                MessageBox.Show("Missing input data on Password")
        '                Exit Sub
        '                TextBox2.Focus()
        '            End If

        '        End While

        '    End While

        '    If count = 1 Then
        '        MessageBox.Show("Email and Password are Correct")

        '        Email = TextBox1.Text
        '        TextBox1.Clear()
        '        TextBox2.Clear()
        '        MainDashboard.Show()
        '        Me.Hide()

        '    ElseIf count > 1 Then
        '        MessageBox.Show("Email and Password are Duplicate")

        '        TextBox1.Clear()
        '        TextBox2.Clear()

        '    Else
        '        MessageBox.Show("Email or Password are Incorrect")

        '        TextBox1.Clear()
        '        TextBox2.Clear()

        '    End If

        '    MysqlConn.Close()

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)

        'Finally
        '    MysqlConn.Dispose()


        'End Try

        ' Define the connection string
        Dim connectionString As String = "Data Source=.\SQLEXPRESS; Initial Catalog=UBAT;Integrated Security=SSPI;Encrypt=False;"


        ' Define the SQL query using parameters to prevent SQL injection
        Dim query As String = "SELECT * FROM Users WHERE Email = @Email AND Password = @password"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                ' Add parameters with values from the text boxes
                command.Parameters.Add("@Email", SqlDbType.VarChar).Value = TextBox1.Text
                command.Parameters.Add("@password", SqlDbType.VarChar).Value = TextBox2.Text ' Passwords should be hashed in a real app

                ' Open the connection and execute the command
                Try
                    connection.Open()
                    Dim adapter As New SqlDataAdapter(command)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    ' Check if a matching user was found
                    If table.Rows.Count > 0 Then
                        MessageBox.Show("Login Successful!")

                        Email = TextBox1.Text
                        TextBox1.Clear()
                        TextBox2.Clear()
                        MainDashboard.Show()
                        Me.Hide()

                    Else
                        MessageBox.Show("Invalid Username or Password", "Unauthorized", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        TextBox1.Clear()
                        TextBox2.Clear()
                    End If
                Catch ex As Exception
                    MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using



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

        'MysqlConn = New MySqlConnection
        'MysqlConn.ConnectionString = "server=localhost;userid=root;database=UBAT"

        'Try
        '    MysqlConn.Open()
        '    MessageBox.Show("Connnection Succesful")
        '    MysqlConn.Close()

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)

        'Finally
        '    MysqlConn.Dispose()


        'End Try

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
