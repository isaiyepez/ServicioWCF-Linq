Imports bd_telefonos2Model
Imports System.Collections.Generic

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IService1" in both code and config file together.
<ServiceContract()>
Public Interface IService

    <OperationContract()>
    Function ObtenerTfnos() As List(Of Detalles)

    <OperationContract()>
    Function ObtenerTfno(ByVal tf As String) As telefonos

    <OperationContract()>
    Sub ActualizarTfno(ByVal entidad As telefonos)

End Interface

' Use a data contract as illustrated in the sample below to add composite types to service operations.

<DataContract()>
Public Class Detalles
    Private _apellido1 As String
    Private _telefono As String

    Public Sub New(ByVal ap As String, ByVal tf As String)
        _apellido1 = ap
        _telefono = tf
    End Sub

    <DataMember()>
    Public Property apellido1() As String
        Get
            Return _apellido1
        End Get
        Set(ByVal value As String)
            _apellido1 = value
        End Set
    End Property

    <DataMember()>
    Public Property telefono() As String
        Get
            Return _telefono
        End Get
        Set(ByVal value As String)
            _telefono = value
        End Set
    End Property

End Class
