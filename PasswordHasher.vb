Imports BCryptNet

Public Class PasswordHasher
    Public Shared Function HashPassword(password As String) As String
        Return BCryptNet.BCrypt.HashPassword(password)
    End Function

    Public Shared Function VerifyPassword(password As String, hashedPassword As String) As Boolean
        Return BCryptNet.BCrypt.Verify(password, hashedPassword)
    End Function
End Class
