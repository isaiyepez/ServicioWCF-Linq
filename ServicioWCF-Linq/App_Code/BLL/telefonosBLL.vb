Imports bd_telefonos2Model
Imports System.Collections.Generic
Public Class telefonosBLL
    'Referencia al contexto de objetos
    Private contexto As bd_telefonos2Entities

    Public Sub New()
        'Crear el contexto 
        contexto = New bd_telefonos2Entities()
    End Sub

    Public Function ObtenerTfnoBll(ByVal tf As String) As telefonos
        Dim consulta = From tfno In contexto.telefonos
                       Where tfno.telefono = tf
                       Select tfno

        Dim registro As telefonos = consulta.First()
        contexto.Detach(registro)
        Return registro
    End Function

    Public Function ObtenerTfnosBll() As List(Of Detalles)
        Dim consulta = From persona In contexto.telefonos
                       Select New With {persona.apellido1, persona.telefono}

        Dim lista As New List(Of Detalles)()
        For Each e In consulta
            lista.Add(New Detalles(e.apellido1, e.telefono))
        Next

        Return lista
    End Function

    Public Sub ActualizarTfnoBll(ByVal entidad As telefonos)
        contexto.VincularObjeto(entidad) 'Método extensor
        contexto.SaveChanges()
    End Sub
End Class
