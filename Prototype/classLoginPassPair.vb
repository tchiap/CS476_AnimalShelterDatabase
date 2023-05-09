'--------------------------------------------------------------------- 
' File: classLoginPassPair.vb
' Version: 1.1 - By: Tim Dresen
'
' Class: LoginPassPair
'  
' Description: This is used in return statments as a way
'              of returning both a username and a password.
'              By default VB only allows the returning of
'              a single datatype not two as needed.  So we created
'              this type to allow the return both items.
'---------------------------------------------------------------------

Public Class LoginPassPair
    'The Users Login Name
    Public Login As String

    ' The Password
    Public Pass As String
End Class
