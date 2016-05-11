REM  Oracle.LinuxCompatibility.MySQL.CodeGenerator
REM  MYSQL Schema Mapper
REM      for Microsoft VisualBasic.NET 

REM  Dump @12/3/2015 8:49:20 PM


Imports Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes

Namespace MySQL.Tables

''' <summary>
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `association_isoform`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `association_isoform` (
'''   `association_id` int(11) NOT NULL,
'''   `gene_product_id` int(11) NOT NULL,
'''   KEY `association_id` (`association_id`),
'''   KEY `gene_product_id` (`gene_product_id`)
''' ) ENGINE=MyISAM DEFAULT CHARSET=latin1;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' 
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("association_isoform", Database:="go")>
Public Class association_isoform: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("association_id"), PrimaryKey, NotNull, DataType(MySqlDbType.Int64, "11")> Public Property association_id As Long
    <DatabaseField("gene_product_id"), NotNull, DataType(MySqlDbType.Int64, "11")> Public Property gene_product_id As Long
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `association_isoform` (`association_id`, `gene_product_id`) VALUES ('{0}', '{1}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `association_isoform` (`association_id`, `gene_product_id`) VALUES ('{0}', '{1}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `association_isoform` WHERE `association_id` = '{0}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `association_isoform` SET `association_id`='{0}', `gene_product_id`='{1}' WHERE `association_id` = '{2}';</SQL>
#End Region
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, association_id)
    End Function
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, association_id, gene_product_id)
    End Function
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, association_id, gene_product_id)
    End Function
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, association_id, gene_product_id, association_id)
    End Function
#End Region
End Class


End Namespace
