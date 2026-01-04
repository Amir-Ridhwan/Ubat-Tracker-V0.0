Imports Microsoft.Data.SqlClient
Imports BCrypt.Net

Module MigratePasswords
    Sub Main()
        ' --- Database Connection ---
        Dim connectionString As String = "Data Source=.\SQLEXPRESS; Initial Catalog=UBAT;Integrated Security=SSPI;Encrypt=False;"
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Console.WriteLine("Database connection successful.")

                ' --- Fetch Users ---
                Dim selectQuery As String = "SELECT IC, password FROM Users"
                Using selectCommand As New SqlCommand(selectQuery, connection)
                    Using reader As SqlDataReader = selectCommand.ExecuteReader()
                        Dim usersToUpdate As New List(Of Tuple(Of String, String))()
                        While reader.Read()
                            Dim ic As String = reader.GetString(0)
                            Dim plaintextPassword As String = reader.GetString(1)

                            ' --- Hash Password ---
                            If Not String.IsNullOrEmpty(plaintextPassword) AndAlso Not plaintextPassword.StartsWith("$2a$") Then
                                Dim hashedPassword As String = BCrypt.HashPassword(plaintextPassword)
                                usersToUpdate.Add(Tuple.Create(ic, hashedPassword))
                            End If
                        End While
                        reader.Close()

                        ' --- Update Passwords ---
                        For Each user In usersToUpdate
                            Dim updateQuery As String = "UPDATE Users SET password = @password WHERE IC = @IC"
                            Using updateCommand As New SqlCommand(updateQuery, connection)
                                updateCommand.Parameters.AddWithValue("@password", user.Item2)
                                updateCommand.Parameters.AddWithValue("@IC", user.Item1)
                                updateCommand.ExecuteNonQuery()
                                Console.WriteLine($"Updated password for user with IC: {user.Item1}")
                            End Using
                        Next
                    End Using
                End Using
                Console.WriteLine("Password migration complete.")
            Catch ex As Exception
                Console.WriteLine("An error occurred: " & ex.Message)
            End Try
        End Using
    End Sub
End Module
