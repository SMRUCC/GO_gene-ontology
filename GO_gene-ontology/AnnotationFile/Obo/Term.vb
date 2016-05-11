
''' <summary>
''' 功能定义
''' </summary>
''' <remarks></remarks>
Public Class Term

    <Field("id")> Public Property id As String
    <Field("name")> Public Property name As String
    <Field("namespace")> Public Property [namespace] As String
    <Field("def")> Public Property def As String
    <Field("synonym")> Public Property synonym As String()
    <Field("xref")> Public Property xref As String()
    <Field("is_a")> Public Property is_a As String
    <Field("subset")> Public Property subset As String
    <Field("relationship")> Public Property relationship As String()

    Public Const TERM As String = "[Term]"

    Public Overrides Function ToString() As String
        Return String.Format("[{0}] {1}: {2}", [namespace], id, name)
    End Function
End Class
