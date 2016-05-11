Public Class Head

    <Field("format-version")> Public Property Version As String
    <Field("data-version")> Public Property DataVersion As String
    <Field("date")> Public Property [Date] As String
    <Field("saved-by")> Public Property Author As String
    <Field("auto-generated-by")> Public Property Tools As String
    <Field("subsetdef")> Public Property SubsetDef As String()
    <Field("synonymtypedef")> Public Property SynonymTypeDef As String
    <Field("default-namespace")> Public Property DefaultNamespace As String
    <Field("remark")> Public Property Remark As String
    <Field("ontology")> Public Property Ontology As String
End Class
