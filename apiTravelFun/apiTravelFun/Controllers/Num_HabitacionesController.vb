Imports System.Data
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports System.Linq
Imports System.Net
Imports System.Net.Http
Imports System.Web.Http
Imports System.Web.Http.Description
Imports apiTravelFun

Namespace Controllers
    Public Class Num_HabitacionesController
        Inherits System.Web.Http.ApiController

        Private db As New Model1

        ' GET: api/Num_Habitaciones
        Function GetNum_Habitaciones() As IQueryable(Of Num_Habitaciones)
            Return db.Num_Habitaciones
        End Function

        ' GET: api/Num_Habitaciones/5
        <ResponseType(GetType(Num_Habitaciones))>
        Function GetNum_Habitaciones(ByVal id As Integer) As IHttpActionResult
            Dim num_Habitaciones As Num_Habitaciones = db.Num_Habitaciones.Find(id)
            If IsNothing(num_Habitaciones) Then
                Return NotFound()
            End If

            Return Ok(num_Habitaciones)
        End Function

        ' PUT: api/Num_Habitaciones/5
        <ResponseType(GetType(Void))>
        Function PutNum_Habitaciones(ByVal id As Integer, ByVal num_Habitaciones As Num_Habitaciones) As IHttpActionResult
            If Not ModelState.IsValid Then
                Return BadRequest(ModelState)
            End If

            If Not id = num_Habitaciones.Id_Habitacion Then
                Return BadRequest()
            End If

            db.Entry(num_Habitaciones).State = EntityState.Modified

            Try
                db.SaveChanges()
            Catch ex As DbUpdateConcurrencyException
                If Not (Num_HabitacionesExists(id)) Then
                    Return NotFound()
                Else
                    Throw
                End If
            End Try

            Return StatusCode(HttpStatusCode.NoContent)
        End Function

        ' POST: api/Num_Habitaciones
        <ResponseType(GetType(Num_Habitaciones))>
        Function PostNum_Habitaciones(ByVal num_Habitaciones As Num_Habitaciones) As IHttpActionResult
            If Not ModelState.IsValid Then
                Return BadRequest(ModelState)
            End If

            db.Num_Habitaciones.Add(num_Habitaciones)
            db.SaveChanges()

            Return CreatedAtRoute("DefaultApi", New With {.id = num_Habitaciones.Id_Habitacion}, num_Habitaciones)
        End Function

        ' DELETE: api/Num_Habitaciones/5
        <ResponseType(GetType(Num_Habitaciones))>
        Function DeleteNum_Habitaciones(ByVal id As Integer) As IHttpActionResult
            Dim num_Habitaciones As Num_Habitaciones = db.Num_Habitaciones.Find(id)
            If IsNothing(num_Habitaciones) Then
                Return NotFound()
            End If

            db.Num_Habitaciones.Remove(num_Habitaciones)
            db.SaveChanges()

            Return Ok(num_Habitaciones)
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Function Num_HabitacionesExists(ByVal id As Integer) As Boolean
            Return db.Num_Habitaciones.Count(Function(e) e.Id_Habitacion = id) > 0
        End Function
    End Class
End Namespace