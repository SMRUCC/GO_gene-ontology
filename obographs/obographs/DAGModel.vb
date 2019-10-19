Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic.Data.visualize.Network.Graph
Imports Microsoft.VisualBasic.Linq
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

        ' 每一个term都单独构建出一条通往base namespace的途径
        For Each termId As String In terms.SafeQuery

        Next

        Return g
    End Function
End Module
