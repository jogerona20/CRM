Imports System
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity
Imports System.Linq

Partial Public Class Model1
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=Model1")
    End Sub

    Public Overridable Property CLIENTE As DbSet(Of CLIENTE)
    Public Overridable Property Hotel As DbSet(Of Hotel)
    Public Overridable Property Num_Habitaciones As DbSet(Of Num_Habitaciones)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
        modelBuilder.Entity(Of CLIENTE)() _
            .Property(Function(e) e.Nombre) _
            .IsUnicode(False)

        modelBuilder.Entity(Of CLIENTE)() _
            .Property(Function(e) e.Apellido) _
            .IsUnicode(False)

        modelBuilder.Entity(Of CLIENTE)() _
            .Property(Function(e) e.Telefono) _
            .IsUnicode(False)

        modelBuilder.Entity(Of CLIENTE)() _
            .Property(Function(e) e.Correo_electronico) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Hotel)() _
            .Property(Function(e) e.Nombre_Hotel) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Hotel)() _
            .Property(Function(e) e.Direccion) _
            .IsUnicode(False)
    End Sub
End Class
