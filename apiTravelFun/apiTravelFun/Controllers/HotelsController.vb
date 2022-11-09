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
    Public Class HotelsController
        Inherits System.Web.Http.ApiController

        Private db As New Model1

        ' GET: api/Hotels
        Function GetHotel() As IQueryable(Of Hotel)
            Return db.Hotel
        End Function

        ' GET: api/Hotels/5
        <ResponseType(GetType(Hotel))>
        Function GetHotel(ByVal id As Integer) As IHttpActionResult
            Dim hotel As Hotel = db.Hotel.Find(id)
            If IsNothing(hotel) Then
                Return NotFound()
            End If

            Return Ok(hotel)
        End Function

        ' PUT: api/Hotels/5
        <ResponseType(GetType(Void))>
        Function PutHotel(ByVal id As Integer, ByVal hotel As Hotel) As IHttpActionResult
            If Not ModelState.IsValid Then
                Return BadRequest(ModelState)
            End If

            If Not id = hotel.Id_Hotel Then
                Return BadRequest()
            End If

            db.Entry(hotel).State = EntityState.Modified

            Try
                db.SaveChanges()
            Catch ex As DbUpdateConcurrencyException
                If Not (HotelExists(id)) Then
                    Return NotFound()
                Else
                    Throw
                End If
            End Try

            Return StatusCode(HttpStatusCode.NoContent)
        End Function

        ' POST: api/Hotels
        <ResponseType(GetType(Hotel))>
        Function PostHotel(ByVal hotel As Hotel) As IHttpActionResult
            If Not ModelState.IsValid Then
                Return BadRequest(ModelState)
            End If

            db.Hotel.Add(hotel)
            db.SaveChanges()

            Return CreatedAtRoute("DefaultApi", New With {.id = hotel.Id_Hotel}, hotel)
        End Function

        ' DELETE: api/Hotels/5
        <ResponseType(GetType(Hotel))>
        Function DeleteHotel(ByVal id As Integer) As IHttpActionResult
            Dim hotel As Hotel = db.Hotel.Find(id)
            If IsNothing(hotel) Then
                Return NotFound()
            End If

            db.Hotel.Remove(hotel)
            db.SaveChanges()

            Return Ok(hotel)
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Function HotelExists(ByVal id As Integer) As Boolean
            Return db.Hotel.Count(Function(e) e.Id_Hotel = id) > 0
        End Function
    End Class
End Namespace