'Imports MySql.Data.MySqlClient
Imports Microsoft.Data.SqlClient
Public Class Information_Details

    'Dim MysqlConn As MySqlConnection
    'Dim COMMAND As MySqlCommand

    Dim Email As String = Login_Page.TextBox1.Text

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Information_Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button_Save1_Click(sender As Object, e As EventArgs) Handles Button_Save1.Click

        'MysqlConn = New MySqlConnection
        'MysqlConn.ConnectionString = "server=localhost;userid=root; database=UBAT"
        'Dim READER As MySqlDataReader

        'If TextBox_IC.Text.Length < 11 Then
        '    MessageBox.Show("IC not enough Characters")
        '    TextBox_IC.Clear()
        '    TextBox_IC.Select()

        'End If

        'While TextBox_IC.Text = "" Or TextBox_Name.Text = "" Or ComboBox_Age.SelectedItem = "" Or TextBox_Email.Text = "" Or TextBox_PhoneNumber.Text = "" Or RichTextBox_Bio.Text = "" Or TextBox_password.Text = ""


        '    If TextBox_Name.Text = "" Then
        '        MessageBox.Show("Missing input data on Name")
        '        Exit Sub
        '        TextBox_Name.Focus()
        '    End If
        '    If ComboBox_Age.Text = "" Then
        '        MessageBox.Show("Missing input data on Age")
        '        Exit Sub
        '        ComboBox_Age.Focus()
        '    End If
        '    If TextBox_Email.Text = "" Then
        '        MessageBox.Show("Missing input data on Email")
        '        Exit Sub
        '        TextBox_Email.Focus()
        '    End If
        '    If ComboBox_Gender.Text = "" Then
        '        MessageBox.Show("Missing input data on Gender")
        '        Exit Sub
        '        ComboBox_Gender.Focus()
        '    End If
        '    If TextBox_PhoneNumber.Text = "" Then
        '        MessageBox.Show("Missing input data on Phone Number")
        '        Exit Sub
        '        TextBox_PhoneNumber.Focus()
        '    End If
        '    If TextBox_password.Text = "" Then
        '        MessageBox.Show("Missing input data on Password")
        '        Exit Sub
        '        TextBox_password.Focus()
        '    End If

        '    Dim rchtxt As Control
        '    For Each rchtxt In Panel1.Controls

        '        If TypeOf rchtxt Is RichTextBox Then
        '            If rchtxt.Text = "" Then
        '                MessageBox.Show("Missing input data on Bio")
        '                Exit Sub
        '                rchtxt.Focus()
        '            End If
        '        End If
        '    Next

        'End While

        'Try

        '    MysqlConn.Open()
        '    Dim Query As String
        '    Query = "INSERT INTO UBAT.Users (IC, Name, Age, Email, PhoneNumber, Bio, Gender, password) 

        '    VALUES ('" & TextBox_IC.Text & "',
        '    '" & TextBox_Name.Text & "',
        '    '" & ComboBox_Age.SelectedItem & "',
        '    '" & TextBox_Email.Text & "',
        '    '" & TextBox_PhoneNumber.Text & "',
        '    '" & RichTextBox_Bio.Text & "',
        '    '" & ComboBox_Gender.SelectedItem & "',
        '    '" & TextBox_password.Text & "')"

        '    COMMAND = New MySqlCommand(Query, MysqlConn)
        '    READER = COMMAND.ExecuteReader


        '    MessageBox.Show("All data are saved")

        '    MysqlConn.Close()

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)

        'Finally
        '    MysqlConn.Dispose()

        'End Try

        If TextBox_IC.Text.Length < 12 Then
            MessageBox.Show("IC not enough Characters")
            TextBox_IC.Clear()
            TextBox_IC.Select()

        End If

        While TextBox_IC.Text = "" Or TextBox_Name.Text = "" Or ComboBox_Age.SelectedItem = "" Or TextBox_Email.Text = "" Or TextBox_PhoneNumber.Text = "" Or RichTextBox_Bio.Text = "" Or TextBox_password.Text = ""


            If TextBox_Name.Text = "" Then
                MessageBox.Show("Missing input data on Name")
                Exit Sub
                TextBox_Name.Focus()
            End If
            If ComboBox_Age.Text = "" Then
                MessageBox.Show("Missing input data on Age")
                Exit Sub
                ComboBox_Age.Focus()
            End If
            If TextBox_Email.Text = "" Then
                MessageBox.Show("Missing input data on Email")
                Exit Sub
                TextBox_Email.Focus()
            End If
            If ComboBox_Gender.Text = "" Then
                MessageBox.Show("Missing input data on Gender")
                Exit Sub
                ComboBox_Gender.Focus()
            End If
            If TextBox_PhoneNumber.Text = "" Then
                MessageBox.Show("Missing input data on Phone Number")
                Exit Sub
                TextBox_PhoneNumber.Focus()
            End If
            If TextBox_password.Text = "" Then
                MessageBox.Show("Missing input data on Password")
                Exit Sub
                TextBox_password.Focus()
            End If

            Dim rchtxt As Control
            For Each rchtxt In Panel1.Controls

                If TypeOf rchtxt Is RichTextBox Then
                    If rchtxt.Text = "" Then
                        MessageBox.Show("Missing input data on Bio")
                        Exit Sub
                        rchtxt.Focus()
                    End If
                End If
            Next

        End While

        Try


            sql = "INSERT INTO Users (IC, Name, Age, Email, PhoneNumber, Bio, Gender, password) 

            VALUES ('" & TextBox_IC.Text & "',
            '" & TextBox_Name.Text & "',
            '" & ComboBox_Age.SelectedItem & "',
            '" & TextBox_Email.Text & "',
            '" & TextBox_PhoneNumber.Text & "',
            '" & RichTextBox_Bio.Text & "',
            '" & ComboBox_Gender.SelectedItem & "',
            '" & TextBox_password.Text & "')"

            openConnection()
            IUD()

            MessageBox.Show("All data are saved")

            closeConnection()
            Reset()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try



    End Sub

    Private Sub TextBox_IC_TextChanged(sender As Object, e As EventArgs) Handles TextBox_IC.TextChanged

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub TextBox_IC_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_IC.KeyPress
        If TextBox_PhoneNumber.Text.Length > 11 Then
            e.Handled = True
            Return
        End If
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox_PhoneNumber_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_PhoneNumber.KeyPress
        If TextBox_PhoneNumber.Text.Length > 12 Then
            e.Handled = True
            Return
        End If
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim LoginPage As New Login_Page
        LoginPage.Show()
        Me.Visible = False
    End Sub
End Class