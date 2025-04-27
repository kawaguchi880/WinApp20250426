Imports System.Configuration

Public Module ConnectionStringHelper
    ' ConnectionStringsの取得
    Public Function GetConnectionString(Name As String) As String
        Dim connString As String = ConfigurationManager.ConnectionStrings(Name).ConnectionString
        Return connString
    End Function
End Module
