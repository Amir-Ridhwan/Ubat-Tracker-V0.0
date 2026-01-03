Imports System.Configuration
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Markup
Imports Microsoft.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class Main_Dashboard

    Public Property Email As String = Login_Page.Email
    'Dim MysqlConn As MySqlConnection
    'Dim COMMAND As MySqlCommand

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Timer1.Tick

        Clock1.Text = Date.Now.ToString("dd-MM-yyyy hh:mm:ss")

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles welcome.VisibleChanged

        'MysqlConn = New MySqlConnection
        'MysqlConn.ConnectionString = "server=localhost;userid=root; database=UBAT"
        'Dim READER As MySqlDataReader

        'If Email = "" Then

        'Else
        '    Try
        '        MysqlConn.Open()
        '        Dim Query As String
        '        Query = "SELECT Name FROM UBAT.Users WHERE Email ='" & Email & "'"

        '        COMMAND = New MySqlCommand(Query, MysqlConn)
        '        READER = COMMAND.ExecuteReader
        '        READER.Read()

        '        welcome.Text = "Welcome " + READER.Item(0).ToString()

        '        MysqlConn.Close()

        '    Catch ex As Exception
        '        MessageBox.Show(ex.Message)

        '    Finally
        '        MysqlConn.Dispose()

        '    End Try

        'End If

        If Email = "" Then

        Else
            Try
                sql = "SELECT Name FROM Users WHERE Email ='" & Login_Page.Email & "'"
                Dim record As SqlDataReader
                openConnection()
                record = getRecords()
                If record.HasRows Then
                    record.Read()
                    welcome.Text = "Welcome " + record.Item("Name")
                End If
                closeConnection()
            Catch ex As Exception
                MsgBox("SQL Error: " & ex.Message)
            End Try
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Login_Page.Show()
        Email = Login_Page.Email
        Me.Hide()

    End Sub

    Private Sub welcome_Click(sender As Object, e As EventArgs) Handles welcome.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Add_New_Pill.Show
        Me.Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Delete_Details.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Update_Change_Details.Show()
        Me.Hide()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Prescription_Form.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Report_Form.Show()
        Me.Hide()
    End Sub
End Class