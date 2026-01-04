Public Class PasswordHasher
    Public Shared Function HashPassword(password As String) As String
        Return BCrypt.Net.BCrypt.HashPassword(password)
    End Function

    Public Shared Function VerifyPassword(password As String, hashedPassword As String) As Boolean
        Return BCrypt.Net.BCrypt.Verify(password, hashedPassword)
    End Function
End Class
