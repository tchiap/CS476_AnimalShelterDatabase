Public Class AppUser

    Dim userID As String
    Dim jobID As String
    Dim fName As String
    Dim lName As String
    Dim secLevel As Integer

    Public Function getUserID() As String
        Return userID
    End Function

    Public Function getJobID() As String
        Return jobID
    End Function

    Public Function getfName() As String
        Return fName
    End Function

    Public Function getlName() As String
        Return lName
    End Function

    Public Function getName() As String
        Return fName.Trim() + " " + lName.Trim()
    End Function

    Public Function userAllowed(ByVal inFunction As Integer) As Boolean
        Return secLevel And inFunction
    End Function

End Class
