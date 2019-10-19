Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic.Data.visualize.Network.Graph
Imports Microsoft.VisualBasic.Linq
Imports Microsoft.VisualBasic.Serialization.JSON
Imports SMRUCC.genomics.Data.GeneOntology.OBO

Public Module DAGModel

    ''' <summary>
    ''' Create a <see cref="NetworkGraph"/> based on a given go term id list.
    ''' </summary>
    ''' <param name="go"></param>
    ''' <param name="terms">
    ''' A go term <see cref="Term.id"/> collection.
    ''' </param>
    ''' <returns></returns>
    <Extension>
    Public Function CreateGraph(go As GO_OBO, terms As IEnumerable(Of String)) As NetworkGraph
        Dim g As New NetworkGraph
        Dim termsTable As Dictionary(Of String, Term) = go.CreateTermTable

        ' 每一个term都单独构建出一条通往base namespace的途径
        For Each termId As String In terms.SafeQuery
            Dim term As Term = termsTable(termId)
            Dim relations As New OBO.OntologyRelations(term)

            ' add itself as node
            Call g.tryInsertNode(term)

        Next

        Return g
    End Function

    ''' <summary>
    ''' 在这里会尝试处理重复出现的term对象
    ''' </summary>
    ''' <param name="g"></param>
    ''' <param name="term"></param>
    ''' <returns>
    ''' 这个函数返回false说明对象已经被添加过了
    ''' 则其网络关系也已经添加过了？
    ''' </returns>
    <Extension>
    Private Function tryInsertNode(g As NetworkGraph, term As Term) As Boolean
        If Not g.ExistVertex(term.id) Then
            Dim def As Definition = Definition.Parse(term)
            Dim node As New Node With {
                .label = term.id,
                .data = New NodeData With {
                    .origID = term.id,
                    .label = term.name,
                    .Properties = New Dictionary(Of String, String) From {
                        {"definition", def.definition},
                        {"evidence", def.evidences.GetJson},
                        {"is_obsolete", def.isOBSOLETE.ToString.ToLower}
                    }
                }
            }

            Call g.AddNode(node)

            Return True
        Else
            Return False
        End If
    End Function
End Module
