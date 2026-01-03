Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar
Imports Microsoft.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Utilities.Collections

Public Class Add_New_Pill
    'Public Property Email As String
    'Dim MysqlConn As MySqlConnection
    'Dim COMMAND As MySqlCommand
    Private Sub Add_New_Pill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getdata()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Main_Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Login_Page.Show()
        Me.Hide()
        Display_Email.Text = ""
    End Sub

    Private Sub Display_Email_1(sender As Object, e As EventArgs) Handles Display_Email.VisibleChanged

        If Login_Page.Email = "" Then

            Display_Email.Text = "No Email!"

        Else
            Display_Email.Text = Login_Page.Email

        End If

    End Sub

    Private Sub Display_IC_1(sender As Object, e As EventArgs) Handles Display_IC.VisibleChanged

        If String.IsNullOrEmpty(Login_Page.Email) Then
            Display_IC.Text = "No IC!"
        Else
            Try
                Dim query As String = "SELECT IC FROM Users WHERE Email = @Email"
                Dim command As New SqlCommand(query)
                command.Parameters.AddWithValue("@Email", Login_Page.Email)

                openConnection()
                Dim record As SqlDataReader = getRecords(command)
                If record.HasRows Then
                    record.Read()
                    Display_IC.Text = record.Item("IC").ToString()
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                closeConnection()
            End Try
        End If
    End Sub


    Private Sub TextBox_Dosage_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        'If TextBox_Dosage.Text.Length > 4 Then
        '    e.Handled = True
        '    Return
        'End If
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Display_IC_Click(sender As Object, e As EventArgs) Handles Display_IC.Click

    End Sub

    Private Sub Display_Email_Click(sender As Object, e As EventArgs) Handles Display_Email.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles new_pill_information.Click

        ' 1. Define your connection string
        Dim connString As String = "Data Source=.\SQLEXPRESS; Initial Catalog=UBAT;Integrated Security=SSPI;Encrypt=False;"

        ' 2. Define your SQL query with parameters
        Dim query As String = "INSERT INTO Pill (Pill_Name, Dosage_Unit, Disease) " &
                           "VALUES (@Pill_Name, @Dosage_Unit, @Disease ); "

        ' 3. Use 'Using' blocks to ensure connections are closed and disposed of properly
        Using conn As New SqlConnection(connString)
            Using cmd As New SqlCommand(query, conn)
                ' 4. Add parameters with their respective values
                cmd.Parameters.AddWithValue("@Pill_Name", TextBox_Pill_Name.Text)
                cmd.Parameters.AddWithValue("@Dosage_Unit", ComboBox_Unit.SelectedItem)
                cmd.Parameters.AddWithValue("@Disease", ComboBox_Disease.SelectedItem)


                Try
                    conn.Open()
                    ' 5. Execute the update
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        Console.WriteLine("Adding New Pill is successful!")
                        MsgBox("Adding New Pill is successful!")

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
        Reset()
    End Sub

    Private Sub update_pill_information_Click(sender As Object, e As EventArgs) Handles update_pill_information.Click

        Dim Pill_Name As String = TextBox_Pill_Name.Text
        ' 1. Define your connection string
        Dim connString As String = "Data Source=.\SQLEXPRESS; Initial Catalog=UBAT;Integrated Security=SSPI;Encrypt=False;"

        ' 2. Define your SQL query with parameters
        Dim query As String = "UPDATE Pill SET Dosage_Unit = @Dosage_Unit, Disease = @Disease WHERE Pill_Name = @Pill_Name"


        ' 3. Use 'Using' blocks to ensure connections are closed and disposed of properly
        Using conn As New SqlConnection(connString)
            Using cmd As New SqlCommand(query, conn)
                ' 4. Add parameters with their respective values
                cmd.Parameters.AddWithValue("@Pill_Name", TextBox_Pill_Name.Text)
                cmd.Parameters.AddWithValue("@Dosage_Unit", ComboBox_Unit.SelectedItem)
                cmd.Parameters.AddWithValue("@Disease", ComboBox_Disease.SelectedItem)


                Try
                    conn.Open()
                    ' 5. Execute the update
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        Console.WriteLine("Updating Pill is successful!")
                        MsgBox("Updating Pill is successful!")

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
        Reset()

        'sql = "update Pill set Pill_Name = '" & TextBox_Pill_Name.Text &
        '"' where Pill_Name = '" & Pill_Name & "'"
        'openConnection()
        'IUD()
        'MessageBox.Show("Record update sucessfully")
        'closeConnection()
        'Reset()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        TextBox_Pill_Name.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        ComboBox_Unit.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        ComboBox_Disease.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        'new_pill_information.Enabled = False
        'update_pill_information.Enabled = True
        'delete_pill_information.Enabled = True
    End Sub

    Private Sub cancel_button_Click(sender As Object, e As EventArgs) Handles cancel_button.Click
        Reset()
    End Sub

    Sub Reset()
        TextBox_Pill_Name.Text = ""
        ComboBox_Unit.Text = ""
        ComboBox_Disease.Text = ""
        'new_pill_information.Enabled = True
        'update_pill_information.Enabled = False
        'delete_pill_information.Enabled = False
        getdata()
        TextBox_Pill_Name.Focus()
    End Sub

    Sub getdata()
        Try
            Dim query As String = "SELECT Pill_Name, Dosage_Unit, Disease FROM Pill ORDER BY Pill_Name"
            Dim command As New SqlCommand(query)

            openConnection()
            Dim ds As DataSet = getDS(command)
            DataGridView1.DataSource = ds.Tables(0)
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
            DataGridView1.Refresh()
        Catch ex As Exception
            MessageBox.Show("An error occurred while fetching data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            closeConnection()
        End Try
    End Sub


    Private Sub delete_pill_information_Click(sender As Object, e As EventArgs) Handles delete_pill_information.Click

        Dim Pill_Name As String = TextBox_Pill_Name.Text
        ' 1. Define your connection string
        Dim connString As String = "Data Source=.\SQLEXPRESS; Initial Catalog=UBAT;Integrated Security=SSPI;Encrypt=False;"

        ' 2. Define your SQL query with parameters
        Dim query As String = "DELETE FROM Pill WHERE Pill_Name = @Pill_Name "

        ' 3. Use 'Using' blocks to ensure connections are closed and disposed of properly
        Using conn As New SqlConnection(connString)
            Using cmd As New SqlCommand(query, conn)
                ' 4. Add parameters with their respective values
                cmd.Parameters.AddWithValue("@Pill_Name", TextBox_Pill_Name.Text)

                Try
                    conn.Open()
                    ' 5. Execute the update
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        Console.WriteLine("Deleting Pill is successful!")
                        MsgBox("Deleting Pill is successful!")

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
        Reset()
    End Sub
End Class
