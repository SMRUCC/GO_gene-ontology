Imports System.Collections.Generic

Namespace org.geneontology.obographs.model



	''' <summary>
	''' Holds a collection of graphs, plus document-level metadata
	''' 
	''' @author cjm
	''' 
	''' </summary>
	Public Class GraphDocument

		Private Sub New(ByVal builder As Builder)
			meta = builder.meta
			graphs = builder.graphs
			context = builder.context
		End Sub

		Private ReadOnly graphs As IList(Of Graph)
		Private ReadOnly meta As Meta

		''' <summary>
		''' The JSON-LD context for this document. This needs to be an unstructured
		''' Object, since it could be either a list or a map. We don't want to store
		''' it here as a Context because we want to roundtrip it the way it is written
		''' in the document.
		''' </summary>
'JAVA TO VB CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
		Private ReadOnly context As Object


		''' <returns> the graphs </returns>
		Public Overridable Property Graphs As IList(Of Graph)
			Get
				Return graphs
			End Get
		End Property



		''' <returns> the meta </returns>
		Public Overridable Property Meta As Meta
			Get
				Return meta
			End Get
		End Property






		Public Class Builder

'JAVA TO VB CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
			Private ___meta As Meta
'JAVA TO VB CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
			Private ___graphs As IList(Of Graph)
'JAVA TO VB CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
			Private ___context As Object



			Public Overridable Function meta(ByVal ___meta As Meta) As Builder
				Me.___meta = ___meta
				Return Me
			End Function
			Public Overridable Function graphs(ByVal ___graphs As IList(Of Graph)) As Builder
				Me.___graphs = ___graphs
				Return Me
			End Function
			Public Overridable Function context(ByVal ___context As Object) As Builder
				Me.___context = ___context
				Return Me
			End Function

			Public Overridable Function build() As GraphDocument
				Return New GraphDocument(Me)
			End Function

		End Class

	End Class

End Namespace