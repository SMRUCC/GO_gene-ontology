Imports System.Runtime.CompilerServices

Namespace xref2go

    Public MustInherit Class XrefId

        ''' <summary>
        ''' Parsing from raw string
        ''' </summary>
        ''' <param name="xrefId"></param>
        Sub New(xrefId As String)

        End Sub
    End Class

    Public Module XrefIdParser

        <Extension>
        Public Function Parse(Of uid As XrefId)(raw As String) As uid

        End Function
    End Module
End Namespace