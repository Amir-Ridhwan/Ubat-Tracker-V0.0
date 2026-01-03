Imports Microsoft.Reporting.WinForms

Public Class Report_Form
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Main_Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Login_Page.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.ReportPath = "Report1.rdlc"
            openConnection()
            sql = "select * from PillView where IC = " & ComboBox1.SelectedValue
            Dim ds1 = New DataSet
            ds1 = getDS()

            Dim ReportDataSource As New ReportDataSource()
            ReportDataSource.Name = "DataSet1"
            ReportDataSource.Value = ds1.Tables(0)
            ReportViewer1.LocalReport.DataSources.Add(ReportDataSource)
            ReportViewer1.RefreshReport()
            closeConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Report_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getdata()
    End Sub

    Sub getdata()
        Try
            openConnection()
            sql = "select * from Users order by IC"
            Dim ds1 = New DataSet
            ds1 = getDS()
            ComboBox1.DataSource = ds1.Tables(0)
            ComboBox1.DisplayMember = "IC"
            ComboBox1.ValueMember = "IC"
            closeConnection()
        Catch e As Exception
            MessageBox.Show(e.Message)
        End Try

    End Sub
End Class