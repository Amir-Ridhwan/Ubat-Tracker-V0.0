Imports MySql.Data.MySqlClient
Public Class Delete_Details

    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Main_Dashboard.Show()
        Me.Visible = False
    End Sub

    Private Sub Delete_Button_Click(sender As Object, e As EventArgs) Handles Delete_Button.Click

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root; password=password;database=UBAT"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "DELETE FROM UBAT.Users WHERE IC ='" & TextBox_Delete.Text & "'"

            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            MessageBox.Show("You are about to delete data. Press Ok to continue.")

            While TextBox_Delete.Text = ""
                MessageBox.Show("No IC Number!")
                Exit Sub
            End While

            MessageBox.Show("Data Deleted!")

            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            MysqlConn.Dispose()

        End Try
    End Sub
End Class