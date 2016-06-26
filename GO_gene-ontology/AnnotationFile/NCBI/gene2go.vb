Imports Microsoft.VisualBasic.Emit.Marshal
Imports Microsoft.VisualBasic.Serialization
Imports Microsoft.VisualBasic.Serialization.JSON

Namespace NCBI

    ''' <summary>
    ''' #Format: tax_id GeneID GO_ID Evidence Qualifier GO_term PubMed Category (tab is used as a separator, pound sign - start of a comment)
    ''' </summary>
    <Serializable> Public Class gene2go

        ' #Format: (TAB Is used As a separator, pound sign - start Of a comment)
        Public Property tax_id As String
        Public Property GeneID As String
        Public Property GO_ID As String
        Public Property Evidence As String
        Public Property Qualifier As String
        Public Property GO_term As String
        Public Property PubMed As String
        Public Property Category As String

        Public Overrides Function ToString() As String
            Return Me.GetJson
        End Function

        ''' <summary>
        ''' Load ncbi gene2go.txt document
        ''' </summary>
        ''' <param name="path">The doc path</param>
        ''' <returns></returns>
        Public Shared Function LoadDoc(path As String) As gene2go()
            Dim lines As String() = path.ReadAllLines
            Dim LQuery = (From line As String
                          In lines.AsParallel
                          Let tokens As String() = Strings.Split(line, vbTab)
                          Select __create(tokens.MarshalAs)).ToArray
            Return LQuery
        End Function

        Private Shared Function __create(tokens As Pointer(Of String)) As gene2go
            Dim gg As New gene2go With {
                .tax_id = (+tokens),
                .GeneID = (+tokens),
                .GO_ID = (+tokens),
                .Evidence = (+tokens),
                .Qualifier = (+tokens),
                .GO_term = (+tokens),
                .PubMed = (+tokens),
                .Category = (+tokens)
            }
            Return gg
        End Function
    End Class
End Namespace