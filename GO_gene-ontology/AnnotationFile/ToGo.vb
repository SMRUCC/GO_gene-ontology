Imports System.Text.RegularExpressions

''' <summary>
''' The reference links between the Go database and other biological database.
''' (Go数据库和其他的生物学数据库的相互之间的外键连接)
''' </summary>
''' <remarks></remarks>
Public Class ToGo

    Public Property DbXrefID As String
    Public Property GO_ID As String
    Public Property FunctionAnnotation As String

    Public Overrides Function ToString() As String
        Return DbXrefID & " <===> " & GO_ID
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Path"></param>
    ''' <param name="DbXrefHead">COG/EC/MetaCyc/KEGG/Pfam/Reactome/SMART</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function LoadDocument(Path As String, DbXrefHead As String) As ToGo()
        Dim OffSet As Integer = Len(DbXrefHead) + 2
        Dim Document As String() = (From s As String In IO.File.ReadAllLines(Path) Where s.First <> "!"c Select Mid(s, OffSet)).ToArray
        Dim LQuery = (From s As String In Document.AsParallel
                      Let Tokens As String() = s.Split
                      Let annotation As String = Regex.Match(s, "GO:.+;").Value
                      Select New ToGo With {
                          .DbXrefID = Tokens.First,
                          .GO_ID = Tokens.Last,
                          .FunctionAnnotation = annotation}).ToArray
        Return LQuery
    End Function
End Class
