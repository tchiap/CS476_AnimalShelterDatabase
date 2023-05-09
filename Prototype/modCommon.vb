'Module modCommon

'    Public Const DBFILE = "C:\CAMODATA\CAMO.MDB"

'    Public Const ITYPE_ADOPT = 1
'    Public Const ITYPE_RETURN = 2
'    Public Const ITYPE_MEDICAL = 3
'    Public Const ITYPE_EUTH = 4
'    Public Const ITYPE_BITE = 5

'    Public Const STRING_FIELD = 1
'    Public Const INT_FIELD = 2

'    Public Const SAVE_NEW_REC = 0
'    Public Const SAVE_MOD_REC = 1

'    Public currentUser As New UserObject
'    Public arrSearchFields As ArrayList = New ArrayList
'    Public callingForm As Form
'    Public iTypeDesc(10) As String

'    Function FieldToString(ByVal inDataRdr As Data.OleDb.OleDbDataReader, ByVal inFieldNo As Integer) As String
'        Dim tmpString As String

'        If inDataRdr.GetFieldType(inFieldNo).Name.Equals("Int16") Then tmpString = inDataRdr.GetInt16(inFieldNo).ToString()
'        If inDataRdr.GetFieldType(inFieldNo).Name.Equals("Int32") Then tmpString = inDataRdr.GetInt32(inFieldNo).ToString()
'        If inDataRdr.GetFieldType(inFieldNo).Name.Equals("Int64") Then tmpString = inDataRdr.GetInt64(inFieldNo).ToString()
'        If inDataRdr.GetFieldType(inFieldNo).Name.Equals("String") Then tmpString = inDataRdr.GetString(inFieldNo).ToString()
'        If inDataRdr.GetFieldType(inFieldNo).Name.Equals("Single") Then tmpString = inDataRdr.GetFloat(inFieldNo).ToString()
'        If inDataRdr.GetFieldType(inFieldNo).Name.Equals("Boolean") Then
'            If inDataRdr(inFieldNo) = True Then tmpString = "T" Else tmpString = "F"
'        End If
'        If inDataRdr.GetFieldType(inFieldNo).Name.Equals("Double") Then tmpString = inDataRdr.GetDouble(inFieldNo).ToString()
'        If inDataRdr.GetFieldType(inFieldNo).Name.Equals("DateTime") Then tmpString = inDataRdr.GetDateTime(inFieldNo).ToString("MM/dd/yyyy")
'        Return tmpString
'    End Function

'    Public Function EnDecrypt(ByVal text As String) As String
'        Dim strtempchar As String
'        Dim i As Integer
'        For i = 1 To Len(text)
'            If Asc(Mid$(text, i, 1)) < 128 Then
'                strtempchar = CType(Asc(Mid$(text, i, 1)) + 128, String)
'            ElseIf Asc(Mid$(text, i, 1)) > 128 Then
'                strtempchar = CType(Asc(Mid$(text, i, 1)) - 128, String)
'            End If
'            Mid$(text, i, 1) = Chr(CType(strtempchar, Integer))
'        Next i
'        Return text
'    End Function

'    Class ListViewItemComparer
'        Implements IComparer

'        Private col As Integer

'        Public Sub New()
'            col = 0
'        End Sub

'        Public Sub New(ByVal column As Integer)
'            col = column
'        End Sub

'        Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer _
'           Implements IComparer.Compare
'            Return [String].Compare(CType(x, ListViewItem).SubItems(col).Text, CType(y, ListViewItem).SubItems(col).Text)
'        End Function
'    End Class
'End Module

