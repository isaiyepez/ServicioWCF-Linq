' NOTE: You can use the "Rename" command on the context menu to change the class name "Service1" in code, svc and config file together.
' NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.vb at the Solution Explorer and start debugging.
Imports ServicioWCF_Linq

Public Class Service
    Implements IService

    Public Sub New()
    End Sub

    Public Function ObtenerTfno(tf As String) As telefonos Implements IService.ObtenerTfno
        Return New telefonosBll().ObtenerTfnoBll(tf)
    End Function

    Public Function ObtenerTfnos() As List(Of Detalles) Implements IService.ObtenerTfnos
        Return New telefonosBll.ObtenerTfnosBll()
    End Function

    Public Sub ActualizarTfno(ByVal entidad As telefonos) Implements IService.ActualizarTfno
        Dim obj As New telefonosBll
        obj.ActualizarTfnoBll(entidad)
    End Sub
End Class
