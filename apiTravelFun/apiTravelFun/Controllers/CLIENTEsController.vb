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
    Public Class CLIENTEsController
        Inherits System.Web.Http.ApiController

        Private db As New Model1

        ' GET: api/CLIENTEs
        Function GetCLIENTE() As IQueryable(Of CLIENTE)
            Return db.CLIENTE
        End Function

        ' GET: api/CLIENTEs/5
        <ResponseType(GetType(CLIENTE))>
        Function GetCLIENTE(ByVal id As Integer) As IHttpActionResult
            Dim cLIENTE As CLIENTE = db.CLIENTE.Find(id)
            If IsNothing(cLIENTE) Then
                Return NotFound()
            End If

            Return Ok(cLIENTE)
        End Function

        ' PUT: api/CLIENTEs/5
        <ResponseType(GetType(Void))>
        Function PutCLIENTE(ByVal id As Integer, ByVal cLIENTE As CLIENTE) As IHttpActionResult
            If Not ModelState.IsValid Then
                Return BadRequest(ModelState)
            End If

            If Not id = cLIENTE.Id_Cliente Then
                Return BadRequest()
            End If

            db.Entry(cLIENTE).State = EntityState.Modified

            Try
                db.SaveChanges()
            Catch ex As DbUpdateConcurrencyException
                If Not (CLIENTEExists(id)) Then
                    Return NotFound()
                Else
                    Throw
                End If
            End Try

            Return StatusCode(HttpStatusCode.NoContent)
        End Function

        ' POST: api/CLIENTEs
        <ResponseType(GetType(CLIENTE))>
        Function PostCLIENTE(ByVal cLIENTE As CLIENTE) As IHttpActionResult
            If Not ModelState.IsValid Then
                Return BadRequest(ModelState)
            End If

            db.CLIENTE.Add(cLIENTE)

            Try
                db.SaveChanges()
            Catch ex As DbUpdateException
                If (CLIENTEExists(cLIENTE.Id_Cliente)) Then
                    Return Conflict()
                Else
                    Throw
                End If
            End Try

            Return CreatedAtRoute("DefaultApi", New With {.id = cLIENTE.Id_Cliente}, cLIENTE)
        End Function

        ' DELETE: api/CLIENTEs/5
        <ResponseType(GetType(CLIENTE))>
        Function DeleteCLIENTE(ByVal id As Integer) As IHttpActionResult
            Dim cLIENTE As CLIENTE = db.CLIENTE.Find(id)
            If IsNothing(cLIENTE) Then
                Return NotFound()
            End If

            db.CLIENTE.Remove(cLIENTE)
            db.SaveChanges()

            Return Ok(cLIENTE)
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        Private Function CLIENTEExists(ByVal id As Integer) As Boolean
            Return db.CLIENTE.Count(Function(e) e.Id_Cliente = id) > 0
        End Function
    End Class
End Namespace