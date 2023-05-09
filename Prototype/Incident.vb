Public Class Incident
    Private incidentID As Integer
    Private animalLogNumber As Integer
    Private incidentDate As DateTime
    Private incidentType As Integer
    Private description As String

    Sub New(ByVal inID As Integer, ByVal inLogNo As String, ByVal inDate As DateTime, ByVal inType As Integer, ByVal inDesc As String)
        incidentID = inID
        animalLogNumber = inLogNo
        incidentDate = inDate
        incidentType = inType
        description = inDesc
    End Sub

    Public Function getIncidentID() As Integer
        Return incidentID
    End Function

    Public Function getIncidentType() As Integer
        Return incidentType
    End Function

    Public Function getIncidentTypeString() As String
        Return iTypeDesc(incidentType)
    End Function

    Public Function getLogNumber() As Integer
        Return animalLogNumber
    End Function

    Public Function getDate() As DateTime
        Return incidentDate
    End Function

    Public Function getDescription() As String
        Return description
    End Function
End Class
