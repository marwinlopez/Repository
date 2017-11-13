Imports System.Web.Mvc
Imports System.Collections.Generic
Imports Model.Entity

Namespace Controllers
    Public Class VentasController
        Inherits Controller
        Public Property listCliente As List(Of Cliente)
        ' GET: Ventas
        Function Index() As ActionResult
            Return View()
        End Function
        Function Cliente() As ActionResult
            Return View()
        End Function
        Function NuevoCliente() As ActionResult
            Return View()
        End Function
        Function Articulo() As ActionResult
            Return View()
        End Function
        Function NuevoArticulo() As ActionResult
            Return View()
        End Function
        Function Servicio() As ActionResult
            Return View()
        End Function
        Function NuevoServicio() As ActionResult
            Return View()
        End Function
        Function DataCliente() As ActionResult
            listCliente = New List(Of Cliente)
            For index As Integer = 1 To 100
                listCliente.Add(New Cliente() With {.Id = index, .Codigo = "00000" & index, .Nombre = "Cliente Nro - " & index, .Saldo = index})
            Next
            Return Me.Json(listCliente.ToArray, JsonRequestBehavior.AllowGet)
        End Function
        Function DataArticulo() As ActionResult
            listCliente = New List(Of Cliente)
            Return Me.Json(listCliente.ToArray, JsonRequestBehavior.AllowGet)
        End Function
    End Class
End Namespace