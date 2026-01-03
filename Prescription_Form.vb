Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Data.SqlClient

Public Class Prescription_Form
    Private Sub Prescription_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        getdata()

    End Sub

    Sub getdata()
        Try
            openConnection()

            sql = "select * from Pill order by Pill_Name"
            Dim ds1 = New DataSet
            ds1 = getDS()
            ComboBox1.DataSource = ds1.Tables(0)
            ComboBox1.DisplayMember = "Pill_Name"
            ComboBox1.ValueMember = "Pill_Name"

            sql = "select * from Pill order by Pill_Name"
            Dim ds2 = New DataSet
            ds2 = getDS()
            ComboBox2.DataSource = ds2.Tables(0)
            ComboBox2.DisplayMember = "Disease"
            ComboBox2.ValueMember = "Disease"

            closeConnection()
        Catch e As Exception
            MessageBox.Show(e.Message)
        End Try

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Main_Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Login_Page.Show()
        Me.Hide()
        Display_IC.Text = ""

    End Sub

    Private Sub cancel_button_Click(sender As Object, e As EventArgs) Handles cancel_button.Click
        Reset()
    End Sub
    Sub Reset()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""

    End Sub

    Private Sub submit_button_Click(sender As Object, e As EventArgs) Handles submit_button.Click


        ' 1. Define your connection string
        Dim connString As String = "Data Source=.\SQLEXPRESS; Initial Catalog=UBAT;Integrated Security=SSPI;Encrypt=False;"

        ' 2. Define your SQL query with parameters
        Dim query As String = "INSERT INTO Prescription (IC, Pill_Name, Pill_Dosage, Pill_Quantity, Disease) " &
                           "VALUES (@IC, @Pill_Name, @Pill_Dosage, @Pill_Quantity, @Disease ); "

        ' 3. Use 'Using' blocks to ensure connections are closed and disposed of properly
        Using conn As New SqlConnection(connString)
            Using cmd As New SqlCommand(query, conn)
                ' 4. Add parameters with their respective values
                cmd.Parameters.AddWithValue("IC", Display_IC.Text)
                cmd.Parameters.AddWithValue("@Pill_Name", ComboBox1.SelectedValue)
                cmd.Parameters.AddWithValue("@Pill_Dosage", TextBox1.Text)
                cmd.Parameters.AddWithValue("@Pill_Quantity", TextBox2.Text)
                cmd.Parameters.AddWithValue("@Disease", ComboBox2.SelectedValue)


                Try
                    conn.Open()
                    ' 5. Execute the update
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        Console.WriteLine("Record insert sucessfully")
                        MsgBox("Record insert sucessfully")

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