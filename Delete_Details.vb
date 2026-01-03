Imports Microsoft.Data.SqlClient

Public Class Delete_Details

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Main_Dashboard.Show()
        Me.Visible = False
    End Sub

    Private Sub Delete_Button_Click(sender As Object, e As EventArgs) Handles Delete_Button.Click

        If String.IsNullOrWhiteSpace(TextBox_Delete.Text) Then
            MessageBox.Show("No IC Number!")
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("You are about to delete data. Press Ok to continue.", "Confirm Deletion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If result = DialogResult.OK Then
            Try
                Dim query As String = "DELETE FROM Users WHERE IC = @IC"
                Dim command As New SqlCommand(query)
                command.Parameters.AddWithValue("@IC", TextBox_Delete.Text)

                openConnection()
                IUD(command)
                MessageBox.Show("Data Deleted!")
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                closeConnection()
            End Try
        End If

    End Sub
End Class
