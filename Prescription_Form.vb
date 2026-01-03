Imports Microsoft.Data.SqlClient

Public Class Prescription_Form
    Private ds1 As DataSet
    Private ds2 As DataSet

    Private Sub Prescription_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        showcombo()
        showcombo2()
    End Sub

    Private Sub showcombo()
        Try
            Dim query As String = "SELECT * FROM Pill ORDER BY Pill_Name"
            Dim command As New SqlCommand(query)

            openConnection()
            ds1 = getDS(command)

            ComboBox1.DataSource = ds1.Tables(0)
            ComboBox1.DisplayMember = "Pill_Name"
            ComboBox1.ValueMember = "Pill_Name"

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            closeConnection()
        End Try
    End Sub

    Private Sub showcombo2()
        Try
            Dim query As String = "SELECT * FROM Pill ORDER BY Pill_Name"
            Dim command As New SqlCommand(query)

            openConnection()
            ds2 = getDS(command)

            ComboBox2.DataSource = ds2.Tables(0)
            ComboBox2.DisplayMember = "Pill_Name"
            ComboBox2.ValueMember = "Pill_Name"

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles Button_Save.Click
        ' --- Input Validation ---
        If ComboBox1.SelectedItem Is Nothing OrElse String.IsNullOrWhiteSpace(ComboBox1.SelectedValue.ToString()) Then
            MessageBox.Show("Please select a pill.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(TextBox_Intake.Text) Then
            MessageBox.Show("Please enter the intake frequency.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' --- Database Insertion ---
        Try
            Dim query As String = "INSERT INTO Prescription (IC, Pill_Name, Intake_Frequency, Before_After_Meal) " &
                                "VALUES (@IC, @Pill_Name, @Intake_Frequency, @Before_After_Meal)"

            Dim command As New SqlCommand(query)
            command.Parameters.AddWithValue("@IC", Display_IC.Text)
            command.Parameters.AddWithValue("@Pill_Name", ComboBox1.SelectedValue)
            command.Parameters.AddWithValue("@Intake_Frequency", TextBox_Intake.Text)

            If RadioButton_Before.Checked Then
                command.Parameters.AddWithValue("@Before_After_Meal", "Before")
            Else
                command.Parameters.AddWithValue("@Before_After_Meal", "After")
            End If

            openConnection()
            IUD(command)

            MessageBox.Show("Prescription saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            closeConnection()
        End Try
    End Sub

    Private Sub Button_Update_Click(sender As Object, e As EventArgs) Handles Button_Update.Click
        ' --- Input Validation ---
        If ComboBox2.SelectedItem Is Nothing OrElse String.IsNullOrWhiteSpace(ComboBox2.SelectedValue.ToString()) Then
            MessageBox.Show("Please select a pill to update.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(TextBox_Update_Intake.Text) Then
            MessageBox.Show("Please enter the new intake frequency.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' --- Database Update ---
        Try
            Dim query As String = "UPDATE Prescription SET Intake_Frequency = @Intake_Frequency, Before_After_Meal = @Before_After_Meal " &
                                "WHERE IC = @IC AND Pill_Name = @Pill_Name"

            Dim command As New SqlCommand(query)
            command.Parameters.AddWithValue("@Intake_Frequency", TextBox_Update_Intake.Text)

            If RadioButton_Update_Before.Checked Then
                command.Parameters.AddWithValue("@Before_After_Meal", "Before")
            Else
                command.Parameters.AddWithValue("@Before_After_Meal", "After")
            End If

            command.Parameters.AddWithValue("@IC", Display_IC.Text)
            command.Parameters.AddWithValue("@Pill_Name", ComboBox2.SelectedValue)

            openConnection()
            IUD(command)

            MessageBox.Show("Prescription updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            closeConnection()
        End Try
    End Sub

    Private Sub Button_Delete_Click(sender As Object, e As EventArgs) Handles Button_Delete.Click
        ' --- Input Validation ---
        If ComboBox2.SelectedItem Is Nothing OrElse String.IsNullOrWhiteSpace(ComboBox2.SelectedValue.ToString()) Then
            MessageBox.Show("Please select a pill to delete.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' --- Database Deletion ---
        Try
            Dim query As String = "DELETE FROM Prescription WHERE IC = @IC AND Pill_Name = @Pill_Name"

            Dim command As New SqlCommand(query)
            command.Parameters.AddWithValue("@IC", Display_IC.Text)
            command.Parameters.AddWithValue("@Pill_Name", ComboBox2.SelectedValue)

            openConnection()
            IUD(command)

            MessageBox.Show("Prescription deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

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
End Class
