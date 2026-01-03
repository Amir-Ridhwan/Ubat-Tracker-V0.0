
Imports Microsoft.Data.SqlClient
Module Module1
    Public conn As SqlConnection
    Public databaseconnection As String = "Data Source=.\SQLEXPRESS; Initial Catalog=UBAT;Integrated Security=SSPI;Encrypt=False;"
    Public cmd As SqlCommand
    Public sql As String
    Public reader As SqlDataReader
    Public ds1 As DataSet

    Public Sub openConnection()
        conn = New SqlConnection(databaseconnection)
        conn.Open()
    End Sub

    Public Sub closeConnection()
        conn.Close()
    End Sub

    Public Sub IUD()
        cmd = New SqlCommand(sql, conn)
        cmd.ExecuteNonQuery()
        cmd.Dispose()
    End Sub

    Public Function getOneValue() As String
        Dim v As String
        cmd = New SqlCommand(sql, conn)
        If cmd.ExecuteScalar() <> Nothing Then
            v = cmd.ExecuteScalar().ToString()
        Else
            v = ""
        End If
        cmd.Dispose()
        Return v
    End Function

    Public Function getRecords() As SqlDataReader
        Dim r As SqlDataReader
        cmd = New SqlCommand(sql, conn)
        r = cmd.ExecuteReader()
        cmd.Dispose()
        Return r
    End Function

    Public Function getDS() As DataSet
        Dim dataadapter As New SqlDataAdapter(sql, conn)
        Dim ds As New DataSet()
        dataadapter.Fill(ds, "Record")
        Return ds
    End Function

End Module


