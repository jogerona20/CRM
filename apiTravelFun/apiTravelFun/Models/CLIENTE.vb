Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("CLIENTE")>
Partial Public Class CLIENTE
    <Key>
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property Id_Cliente As Integer

    <StringLength(50)>
    Public Property Nombre As String

    <StringLength(50)>
    Public Property Apellido As String

    <StringLength(50)>
    Public Property Telefono As String

    <StringLength(50)>
    Public Property Correo_electronico As String
End Class
