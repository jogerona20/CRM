Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class Num_Habitaciones
    <Key>
    Public Property Id_Habitacion As Integer

    Public Property Tipo_Habitacion As Integer?

    Public Property Id_Hotel As Integer?
End Class
