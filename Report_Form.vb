Imports Microsoft.Reporting.WinForms
Imports Microsoft.Data.SqlClient

Public Class Report_Form
    Private ds1 As DataSet

    Private Sub Report_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        showcombo()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim query As String = "SELECT * FROM PillView WHERE IC = @IC"
            Dim command As New SqlCommand(query)
            command.Parameters.AddWithValue("@IC", ComboBox1.SelectedValue)

            openConnection()
            ds1 = getDS(command)

            Dim rds As New ReportDataSource("DataSet1", ds1.Tables(0))
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.DataSources.Add(rds)
            ReportViewer1.LocalReport.ReportPath = "Report1.rdlc"
            ReportViewer1.RefreshReport()

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            closeConnection()
        End Try
    End Sub

    Private Sub showcombo()
        Try
            Dim query As String = "SELECT * FROM Users ORDER BY IC"
            Dim command As New SqlCommand(query)

            openConnection()
            ds1 = getDS(command)

            ComboBox1.DataSource = ds1.Tables(0)
            ComboBox1.DisplayMember = "Name"
            ComboBox1.ValueMember = "IC"

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            closeConnection()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Main_Dashboard.Show()
        Me.Hide()
    End Sub
End Class
