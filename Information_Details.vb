Imports Microsoft.Data.SqlClient
Public Class Information_Details

    Private Sub Button_Save1_Click(sender As Object, e As EventArgs) Handles Button_Save1.Click

        ' --- Input Validation ---
        If String.IsNullOrWhiteSpace(TextBox_IC.Text) OrElse TextBox_IC.Text.Length < 12 Then
            MessageBox.Show("IC must be 12 characters long.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox_IC.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(TextBox_Name.Text) Then
            MessageBox.Show("Missing input data on Name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox_Name.Focus()
            Return
        End If

        If ComboBox_Age.SelectedItem Is Nothing OrElse String.IsNullOrWhiteSpace(ComboBox_Age.SelectedItem.ToString()) Then
            MessageBox.Show("Missing input data on Age.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ComboBox_Age.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(TextBox_Email.Text) Then
            MessageBox.Show("Missing input data on Email.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox_Email.Focus()
            Return
        End If

        If ComboBox_Gender.SelectedItem Is Nothing OrElse String.IsNullOrWhiteSpace(ComboBox_Gender.SelectedItem.ToString()) Then
            MessageBox.Show("Missing input data on Gender.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ComboBox_Gender.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(TextBox_PhoneNumber.Text) Then
            MessageBox.Show("Missing input data on Phone Number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox_PhoneNumber.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(TextBox_password.Text) Then
            MessageBox.Show("Missing input data on Password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox_password.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(RichTextBox_Bio.Text) Then
            MessageBox.Show("Missing input data on Bio.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            RichTextBox_Bio.Focus()
            Return
        End If

        ' --- Database Insertion ---
        Try
            ' Hash the password
            Dim hashedPassword As String = PasswordHasher.HashPassword(TextBox_password.Text)

            ' Create parameterized query
            Dim query As String = "INSERT INTO Users (IC, Name, Age, Email, PhoneNumber, Bio, Gender, password) " &
                                "VALUES (@IC, @Name, @Age, @Email, @PhoneNumber, @Bio, @Gender, @password)"

            Dim command As New SqlCommand(query)
            command.Parameters.AddWithValue("@IC", TextBox_IC.Text)
            command.Parameters.AddWithValue("@Name", TextBox_Name.Text)
            command.Parameters.AddWithValue("@Age", ComboBox_Age.SelectedItem.ToString())
            command.Parameters.AddWithValue("@Email", TextBox_Email.Text)
            command.Parameters.AddWithValue("@PhoneNumber", TextBox_PhoneNumber.Text)
            command.Parameters.AddWithValue("@Bio", RichTextBox_Bio.Text)
            command.Parameters.AddWithValue("@Gender", ComboBox_Gender.SelectedItem.ToString())
            command.Parameters.AddWithValue("@password", hashedPassword)

            ' Execute the command
            openConnection()
            IUD(command)

            MessageBox.Show("All data are saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Reset()

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            closeConnection()
        End Try
    End Sub

    Private Sub Reset()
        TextBox_IC.Clear()
        TextBox_Name.Clear()
        ComboBox_Age.SelectedIndex = -1
        TextBox_Email.Clear()
        ComboBox_Gender.SelectedIndex = -1
        TextBox_PhoneNumber.Clear()
        TextBox_password.Clear()
        RichTextBox_Bio.Clear()
        TextBox_IC.Focus()
    End Sub

    Private Sub TextBox_IC_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_IC.KeyPress
        ' Allow only numbers and backspace, and limit length to 12
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
        If TextBox_IC.Text.Length >= 12 AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox_PhoneNumber_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox_PhoneNumber.KeyPress
        ' Allow only numbers and backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim LoginPage As New Login_Page
        LoginPage.Show()
        Me.Visible = False
    End Sub

    ' Unused event handlers, can be removed if not needed for the designer.
    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    End Sub


    Private Sub Information_Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub TextBox_IC_TextChanged(sender As Object, e As EventArgs) Handles TextBox_IC.TextChanged
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
    End Sub
End Class
