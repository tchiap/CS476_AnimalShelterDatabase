''--------------------------------------------------------------------- 
'' File: modGlobalFunctions.vb
''
'' Module: GlobalFunctions
''  
'' Description: Contains a series of functions common to
''              the entire applications
''--------------------------------------------------------------------- 
'Module GlobalFunctions

'    '--------------------------------------------------------------------- 
'    ' Function: EnDeCrypt
'    ' Version: 1.0 - By: Tim Dresen
'    '
'    ' Parameter:  String as encrypted or decrypted
'    ' Return:     String as encrypted or decrypted
'    '  
'    ' Description: Takes an encrypted password and decrypts it or
'    '                  takes a plain text password and encrypts
'    '--------------------------------------------------------------------- 
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

'    '--------------------------------------------------------------------- 
'    ' Function: FieldToString
'    ' Version: 1.0 - By: Brendon Bourdo
'    '
'    ' Parameter:  Data.OleDb.OleDbDataReader of the data we are reading,
'    '             The field number of the data to read
'    ' Return:     String value of data we read.
'    '  
'    ' Description: Takes an encrypted password and decrypts it or
'    '                  takes a plain text password and encrypts
'    '--------------------------------------------------------------------- 
'    Function FieldToString(ByVal inDataRdr As Data.OleDb.OleDbDataReader, ByVal inFieldNo As Integer) As String
'        Dim tmpString As String
'        If inDataRdr.GetFieldType(inFieldNo).Name.Equals("Int16") Then tmpString = inDataRdr.GetInt16(inFieldNo).ToString()
'        If inDataRdr.GetFieldType(inFieldNo).Name.Equals("Int32") Then tmpString = inDataRdr.GetInt32(inFieldNo).ToString()
'        If inDataRdr.GetFieldType(inFieldNo).Name.Equals("Int64") Then tmpString = inDataRdr.GetInt64(inFieldNo).ToString()
'        If inDataRdr.GetFieldType(inFieldNo).Name.Equals("String") Then tmpString = inDataRdr.GetString(inFieldNo)
'        If inDataRdr.GetFieldType(inFieldNo).Name.Equals("Single") Then tmpString = inDataRdr.GetFloat(inFieldNo).ToString()
'        If inDataRdr.GetFieldType(inFieldNo).Name.Equals("Boolean") Then
'            If inDataRdr(inFieldNo) = True Then tmpString = "T" Else tmpString = "F"
'        End If
'        If inDataRdr.GetFieldType(inFieldNo).Name.Equals("Double") Then tmpString = inDataRdr.GetDouble(inFieldNo).ToString()
'        If inDataRdr.GetFieldType(inFieldNo).Name.Equals("DateTime") Then tmpString = inDataRdr.GetDateTime(inFieldNo).ToString("MM/dd/yyyy")
'        Return tmpString
'    End Function

'End Module
