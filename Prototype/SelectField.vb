Public Class SelectField

    Private fieldName As String
    Private fieldDesc As String
    Private fieldType As Byte

    Public Sub New(ByVal inName As String, ByVal inDesc As String, ByVal inType As Byte)
        fieldName = inName
        fieldDesc = inDesc
        fieldType = inType
    End Sub

    Public Function getFieldName() As String
        Return fieldName
    End Function

    Public Function getFieldDesc() As String
        Return fieldDesc
    End Function

    Public Function getFieldType() As Byte
        Return fieldType
    End Function

End Class
