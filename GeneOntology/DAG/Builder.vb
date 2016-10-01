Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic.Linq

Namespace DAG

    Public Module Builder

        <Extension>
        Public Function BuildTree(file As IEnumerable(Of OBO.Term)) As Dictionary(Of Term)
            Dim tree As New Dictionary(Of Term)

            For Each x As OBO.Term In file
                tree += New Term With {
                    .id = x.id,
                    .is_a = x.is_a.ToArray(Function(s) New is_a(s$)),
                    .relationship = x.relationship.ToArray(Function(s) New Relationship(s$))
                }
            Next

            Return tree
        End Function
    End Module
End Namespace