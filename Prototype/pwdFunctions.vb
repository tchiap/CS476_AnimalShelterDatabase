Imports System.Security.Cryptography

Module pwdFunctions
    Public loggedInUser As String
    Public currPass As String
    Public loggedInID As Integer

    Public Function hashPassword(ByVal text As String) As String

        Dim result As Byte()
        Dim str As String
        Try
            Dim sha1 As SHA1
            sha1 = New SHA1CryptoServiceProvider
            result = sha1.ComputeHash(System.Text.Encoding.UTF8.GetBytes(text))
            str = Convert.ToBase64String(result)

            Return str
        Catch ce As CryptographicException
            MessageBox.Show("Error encountered in hash function")
            Return 0
        End Try

    End Function
End Module
