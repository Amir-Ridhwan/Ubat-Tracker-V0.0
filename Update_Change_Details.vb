Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Azure
Imports Microsoft.Data.SqlClient

Public Class Update_Change_Details
    Private Sub Button_Load_IC_Click(sender As Object, e As EventArgs) Handles Button_Load_IC.Click
        Dim identification_card As String = Display_IC.Text

        sql = "SELECT * FROM Users WHERE IC = '" & identification_card & "'"
        Dim record As SqlDataReader
        openConnection()
        record = getRecords()
        If record.HasRows Then
            record.Read()
            TextBox_Name.Text = record.Item("Name")
            TextBox_IC.Text = record.Item("IC")
            TextBox_Age.Text = record.Item("Age")
            TextBox_Email.Text = record.Item("Email")
            TextBox_Gender.Text = record.Item("Gender") '
            TextBox_PhoneNumber.Text = record.Item("PhoneNumber")
            TextBox_password.Text = record.Item("password")
            RichTextBox_Bio.Text = record.Item("Bio")
        End If
        closeConnection()
    End Sub

    Private Sub Display_IC_VisibleChanged(sender As Object, e As EventArgs) Handles Display_IC.VisibleChanged

        sql = "SELECT IC FROM Users WHERE Email ='" & Login_Page.Email & "'"
        Dim record As SqlDataReader
        openConnection()
        record = getRecords()
        If record.HasRows Then
            record.Read()
            Display_IC.Text = record.Item("IC")
        End If
        closeConnection()
    End Sub

    Private Sub Button_Update_Information_Click(sender As Object, e As EventArgs) Handles Button_Update_Information.Click
        Dim identification_card As String = Display_IC.Text


        ' 1. Define your connection string
        Dim connString As String = "Data Source=.\SQLEXPRESS; Initial Catalog=UBAT;Integrated Security=SSPI;Encrypt=False;"

        ' 2. Define your SQL query with parameters
        Dim query As String = "UPDATE Users SET IC = @IC, Name = @Name, Age = @Age, Email = @Email, PhoneNumber = @PhoneNumber, Bio = @Bio, Gender = @Gender, password = @password WHERE IC = @IC"

        ' 3. Use 'Using' blocks to ensure connections are closed and disposed of properly
        Using conn As New SqlConnection(connString)
            Using cmd As New SqlCommand(query, conn)
                ' 4. Add parameters with their respective values
                cmd.Parameters.AddWithValue("@IC", TextBox_IC.Text)
                cmd.Parameters.AddWithValue("@Name", TextBox_Name.Text)
                cmd.Parameters.AddWithValue("@Age", TextBox_Age.Text)
                cmd.Parameters.AddWithValue("@Email", TextBox_Email.Text)
                cmd.Parameters.AddWithValue("@PhoneNumber", TextBox_PhoneNumber.Text)
                cmd.Parameters.AddWithValue("@Bio", RichTextBox_Bio.Text)
                cmd.Parameters.AddWithValue("@Gender", TextBox_Gender.Text)
                cmd.Parameters.AddWithValue("@password", TextBox_password.Text)

                Try
                    conn.Open()
                    ' 5. Execute the update
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        Console.WriteLine("Update successful!")
                        MsgBox("Update successful!")

                    Else
                        Console.WriteLine("No record found with that ID.")
                        MsgBox("No record found with that ID.")
                    End If

                Catch ex As SqlException
                    Console.WriteLine("SQL Error: " & ex.Message)
                    MsgBox("SQL Error: " & ex.Message)
                End Try
            End Using
        End Using
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


