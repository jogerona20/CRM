Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("Hotel")>
Partial Public Class Hotel
    <Key>
    Public Property Id_Hotel As Integer

    <StringLength(30)>
    Public Property Nombre_Hotel As String

    <StringLength(50)>
    Public Property Direccion As String
End Class
