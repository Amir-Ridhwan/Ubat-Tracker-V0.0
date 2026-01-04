Imports Microsoft.Data.SqlClient

Public Class Prescription_Form
    Private ds1 As DataSet
    Private ds2 As DataSet

    Private Sub Prescription_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        getdata()
    End Sub

    Sub getdata()
        Try
            openConnection()

            Dim query1 As String = "SELECT * FROM Pill ORDER BY Pill_Name"
            Dim command1 As New SqlCommand(query1)
            ds1 = getDS(command1)
            ComboBox1.DataSource = ds1.Tables(0)
            ComboBox1.DisplayMember = "Pill_Name"
            ComboBox1.ValueMember = "Pill_Name"

            Dim query2 As String = "SELECT * FROM Pill ORDER BY Pill_Name"
            Dim command2 As New SqlCommand(query2)
            ds2 = getDS(command2)
            ComboBox2.DataSource = ds2.Tables(0)
            ComboBox2.DisplayMember = "Disease"
            ComboBox2.ValueMember = "Disease"

        Catch e As Exception
            MessageBox.Show(e.Message)
        Finally
            closeConnection()
        End Try
    End Sub

    Private Sub Display_IC_VisibleChanged(sender As Object, e As EventArgs) Handles Display_IC.VisibleChanged
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
        Try
            Dim query As String = "INSERT INTO Prescription (IC, Pill_Name, Pill_Dosage, Pill_Quantity, Disease) " &
                               "VALUES (@IC, @Pill_Name, @Pill_Dosage, @Pill_Quantity, @Disease);"

            Using command As New SqlCommand(query)
                command.Parameters.AddWithValue("@IC", Display_IC.Text)
                command.Parameters.AddWithValue("@Pill_Name", ComboBox1.SelectedValue)
                command.Parameters.AddWithValue("@Pill_Dosage", TextBox1.Text)
                command.Parameters.AddWithValue("@Pill_Quantity", TextBox2.Text)
                command.Parameters.AddWithValue("@Disease", ComboBox2.SelectedValue)

                openConnection()
                IUD(command)

                MessageBox.Show("Record insert successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
            Reset()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            closeConnection()
        End Try
    End Sub
End Class
