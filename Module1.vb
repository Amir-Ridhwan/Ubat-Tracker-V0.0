Imports Microsoft.Data.SqlClient
Module Module1
    Public conn As SqlConnection
    Public databaseconnection As String = "Data Source=.\SQLEXPRESS; Initial Catalog=UBAT;Integrated Security=SSPI;Encrypt=False;"

    Public Sub openConnection()
        conn = New SqlConnection(databaseconnection)
        conn.Open()
    End Sub

    Public Sub closeConnection()
        conn.Close()
    End Sub

    Public Sub IUD(command As SqlCommand)
        command.Connection = conn
        command.ExecuteNonQuery()
        command.Dispose()
    End Sub

    Public Function getOneValue(command As SqlCommand) As String
        command.Connection = conn
        Dim result = command.ExecuteScalar()
        If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
            Return result.ToString()
        Else
            Return ""
        End If
    End Function

    Public Function getRecords(command As SqlCommand) As SqlDataReader
        command.Connection = conn
        Return command.ExecuteReader()
    End Function

    Public Function getDS(command As SqlCommand) As DataSet
        command.Connection = conn
        Dim dataadapter As New SqlDataAdapter(command)
        Dim ds As New DataSet()
        dataadapter.Fill(ds, "Record")
        Return ds
    End Function

End Module
