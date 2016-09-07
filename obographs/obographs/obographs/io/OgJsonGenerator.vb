Namespace org.geneontology.obographs.io


	Public Class OgJsonGenerator

		Public Shared Function render(ByVal obj As Object) As String
			Return prettyJsonString(obj)
		End Function

		Private Shared Function prettyJsonString(ByVal obj As Object) As String
			Dim mapper As New com.fasterxml.jackson.databind.ObjectMapper
			mapper.SerializationInclusion = com.fasterxml.jackson.annotation.JsonInclude.Include.NON_NULL
			Dim writer As com.fasterxml.jackson.databind.ObjectWriter = mapper.writerWithDefaultPrettyPrinter()
			Return writer.writeValueAsString(obj)
		End Function

	End Class

End Namespace