'------------------------------------------------------------
' File: classUserObject.vb
' Version: 1.1 - By: Tim Dresen
'
' Class: UserObject 
'
' Description: This Class is used to create an object for
'              the current user it also is used for
'              validating the users access permissions
'-------------------------------------------------------------

Public Class UserObject

    ' General user information
    Public EmployeeID As String = ""
    Public JobID As String = ""
    Public FirstName As String = ""
    Public LastName As String = ""
    Public RawPermissions As String = ""
    Public LoginName As String = ""

    ' The following holds the users permissions for each option
    Private addAnimal As Boolean = False
    Private viewAnimal As Boolean = False
    Private modifyAnimal As Boolean = False
    Private deleteAnimal As Boolean = False
    Private addClient As Boolean = False
    Private viewClient As Boolean = False
    Private modifyClient As Boolean = False
    Private deleteClient As Boolean = False
    Private addMem As Boolean = False
    Private viewMem As Boolean = False
    Private modifyMem As Boolean = False
    Private deleteMem As Boolean = False
    Private addVol As Boolean = False
    Private viewVol As Boolean = False
    Private modifyVol As Boolean = False
    Private deleteVol As Boolean = False


    '--------------------------------------------------------------------- 
    ' Creates an empty UserObject.
    '--------------------------------------------------------------------- 
    Public Sub New()
    End Sub

    '--------------------------------------------------------------------- 
    ' Creates a new UserObject based on the information given.
    '--------------------------------------------------------------------- 
    Public Sub New(ByVal newEmployeeID As String, ByVal newJobID As String, ByVal newFirstName As String, _
                   ByVal newLastName As String, ByVal newRawPermissions As String, ByVal newLoginName As String)

        Me.EmployeeID = newEmployeeID
        Me.JobID = newJobID
        Me.FirstName = newFirstName
        Me.LastName = newLastName
        Me.RawPermissions = newRawPermissions
        Me.LoginName = newLoginName
    End Sub

    '--------------------------------------------------------------------- 
    ' Returns true if the current user if the root user.
    '--------------------------------------------------------------------- 
    Public Function isRoot() As Boolean
        If Me.RawPermissions.Chars(0) = "0" Then Return True Else Return False
    End Function

    '--------------------------------------------------------------------- 
    ' Returns true if the current user is an admin
    '--------------------------------------------------------------------- 
    Public Function isAdmin() As Boolean
        If Me.RawPermissions.Chars(0) = "F" Then Return True Else Return False
    End Function

    '--------------------------------------------------------------------- 
    ' Returns true if the current user if currently active
    '--------------------------------------------------------------------- 
    Public Function isActive() As Boolean
        If Me.RawPermissions.Chars(1) = "F" Then Return True Else Return False
    End Function

    '--------------------------------------------------------------------- 
    ' Returns true if the current user can modify users
    '--------------------------------------------------------------------- 
    Public Function canAddModifyUsers() As Boolean
        If Me.RawPermissions.Chars(6) = "F" Then Return True Else Return False
    End Function

    '--------------------------------------------------------------------- 
    ' Returns true if the current user can print reports
    '--------------------------------------------------------------------- 
    Public Function canPrintReports() As Boolean
        If Me.RawPermissions.Chars(7) = "F" Then Return True Else Return False
    End Function

    '--------------------------------------------------------------------- 
    ' Animal Function
    ' Description:  This set of functions returns the users
    '               abilities to manipulate animals.
    '--------------------------------------------------------------------- 
    Public Function canAddAnimal() As Boolean
        Me.parsePermissions(Me.RawPermissions)
        Return Me.addAnimal
    End Function
    Public Function canViewAnimal() As Boolean
        Me.parsePermissions(Me.RawPermissions)
        Return Me.viewAnimal
    End Function
    Public Function canModifyAnimal() As Boolean
        Me.parsePermissions(Me.RawPermissions)
        Return Me.modifyAnimal
    End Function
    Public Function canDeleteAnimal() As Boolean
        Me.parsePermissions(Me.RawPermissions)
        Return Me.deleteAnimal
    End Function

    '--------------------------------------------------------------------- 
    ' Client Function
    ' Description:  This set of functions returns the users
    '               abilities to manipulate clients.
    '--------------------------------------------------------------------- 
    Public Function canAddClient() As Boolean
        Me.parsePermissions(Me.RawPermissions)
        Return Me.addClient
    End Function
    Public Function canViewClient() As Boolean
        Me.parsePermissions(Me.RawPermissions)
        Return Me.viewClient
    End Function
    Public Function canModifyClient() As Boolean
        Me.parsePermissions(Me.RawPermissions)
        Return Me.modifyClient
    End Function
    Public Function canDeleteClient() As Boolean
        Me.parsePermissions(Me.RawPermissions)
        Return Me.deleteClient
    End Function

    '--------------------------------------------------------------------- 
    ' Member Functions
    ' Description:  This set of functions returns the users
    '               abilities to manipulate members.
    '--------------------------------------------------------------------- 
    Public Function canAddMember() As Boolean
        Me.parsePermissions(Me.RawPermissions)
        Return Me.addMem
    End Function
    Public Function canViewMember() As Boolean
        Me.parsePermissions(Me.RawPermissions)
        Return Me.viewMem
    End Function
    Public Function canModifyMember() As Boolean
        Me.parsePermissions(Me.RawPermissions)
        Return Me.modifyMem
    End Function
    Public Function canDeleteMember() As Boolean
        Me.parsePermissions(Me.RawPermissions)
        Return Me.deleteMem
    End Function


    '--------------------------------------------------------------------- 
    ' Volunteer Functions
    ' Description:  This set of functions returns the users
    '               abilities to manipulate volunteer.
    '--------------------------------------------------------------------- 
    Public Function canAddVolunteer() As Boolean
        Me.parsePermissions(Me.RawPermissions)
        Return Me.addVol
    End Function
    Public Function canViewVolunteer() As Boolean
        Me.parsePermissions(Me.RawPermissions)
        Return Me.viewVol
    End Function
    Public Function canModifyVolunteer() As Boolean
        Me.parsePermissions(Me.RawPermissions)
        Return Me.modifyVol
    End Function
    Public Function canDeleteVolunteer() As Boolean
        Me.parsePermissions(Me.RawPermissions)
        Return Me.deleteVol
    End Function

    '--------------------------------------------------------------------- 
    '  Parameters:  The rawPermissions of a user as a HEX String
    '     Returns:  Nothing
    ' Description:  Set the boolean values of a users permissions
    '--------------------------------------------------------------------- 
    Private Sub parsePermissions(ByVal permissions As String)

        Dim animalPerm As Integer = HexToInt(permissions.Chars(2))
        Dim clientPerm As Integer = HexToInt(permissions.Chars(3))
        Dim memberPerm As Integer = HexToInt(permissions.Chars(4))
        Dim volPerm As Integer = HexToInt(permissions.Chars(5))

        ' Set Animal Permissions
        If animalPerm > 7 Then
            Me.deleteAnimal = True
            animalPerm = animalPerm - 8
        End If
        If animalPerm > 3 Then
            Me.modifyAnimal = True
            animalPerm = animalPerm - 4
        End If
        If animalPerm > 1 Then
            Me.viewAnimal = True
            animalPerm = animalPerm - 2
        End If
        If animalPerm > 0 Then
            Me.addAnimal = True
        End If

        ' Set Client Permissions
        If clientPerm > 7 Then
            Me.deleteClient = True
            clientPerm = clientPerm - 8
        End If
        If clientPerm > 3 Then
            Me.modifyClient = True
            clientPerm = clientPerm - 4
        End If
        If clientPerm > 1 Then
            Me.viewClient = True
            clientPerm = clientPerm - 2
        End If
        If clientPerm > 0 Then
            Me.addClient = True
        End If

        ' Set Member Permissions
        If memberPerm > 7 Then
            Me.deleteMem = True
            memberPerm = memberPerm - 8
        End If
        If memberPerm > 3 Then
            Me.modifyMem = True
            memberPerm = memberPerm - 4
        End If
        If memberPerm > 1 Then
            Me.viewMem = True
            memberPerm = memberPerm - 2
        End If
        If memberPerm > 0 Then
            Me.addMem = True
        End If

        ' Set Volunteer Permissions
        If volPerm > 7 Then
            Me.deleteVol = True
            volPerm = volPerm - 8
        End If
        If volPerm > 3 Then
            Me.modifyVol = True
            volPerm = volPerm - 4
        End If
        If volPerm > 1 Then
            Me.viewVol = True
            volPerm = volPerm - 2
        End If
        If volPerm > 0 Then
            Me.addVol = True
        End If

    End Sub

    '--------------------------------------------------------------------- 
    '  Parameters: a HEX digit as a String
    '     Returns: an Integer value of the Hex digit
    ' Description: Converts a HEX digit to an INT
    '--------------------------------------------------------------------- 
    Private Function HexToInt(ByVal value As String) As Integer
        If value = "A" Then Return 10
        If value = "B" Then Return 11
        If value = "C" Then Return 12
        If value = "D" Then Return 13
        If value = "E" Then Return 14
        If value = "F" Then Return 15
        Return CType(value, Int16)
    End Function

End Class


