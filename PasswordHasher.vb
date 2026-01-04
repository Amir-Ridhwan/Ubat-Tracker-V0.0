Imports BCrypt.Net

Public Class PasswordHasher
    Public Shared Function HashPassword(password As String) As String
        Return BCrypt.HashPassword(password)
    End Function

    Public Shared Function VerifyPassword(password As String, hashedPassword As String) As Boolean
        Return BCrypt.Verify(password, hashedPassword)
    End Function
End Class
