﻿#Region "Microsoft.VisualBasic::14982c76a71e966737c9abb9b07580ba, data\GO_gene-ontology\Test\mapParserTest.vb"

    ' Author:
    ' 
    '       asuka (amethyst.asuka@gcmodeller.org)
    '       xie (genetics@smrucc.org)
    '       xieguigang (xie.guigang@live.com)
    ' 
    ' Copyright (c) 2018 GPL3 Licensed
    ' 
    ' 
    ' GNU GENERAL PUBLIC LICENSE (GPL3)
    ' 
    ' 
    ' This program is free software: you can redistribute it and/or modify
    ' it under the terms of the GNU General Public License as published by
    ' the Free Software Foundation, either version 3 of the License, or
    ' (at your option) any later version.
    ' 
    ' This program is distributed in the hope that it will be useful,
    ' but WITHOUT ANY WARRANTY; without even the implied warranty of
    ' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    ' GNU General Public License for more details.
    ' 
    ' You should have received a copy of the GNU General Public License
    ' along with this program. If not, see <http://www.gnu.org/licenses/>.



    ' /********************************************************************************/

    ' Summaries:

    ' Module mapParserTest
    ' 
    '     Sub: Main
    ' 
    ' /********************************************************************************/

#End Region

Imports SMRUCC.genomics.Data.GeneOntology.Annotation.xref2go

Module mapParserTest
    Sub Main()
        Dim maps = toGO.Parse2GO("P:\2019_bio_videos\20190826_go_annotation\pfam2go.txt").ToArray

        Pause()
    End Sub
End Module
