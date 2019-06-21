Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports System.Data.Objects

' bd_telefonos3EntitiesEx (métodos extensores): extensión a bd_telefonos3Entities derivada de ObjectContext
Public Module bd_telefonos3EntitiesEx
    <System.Runtime.CompilerServices.Extension>
    Public Function ObtenerObjectContext(contex As DbContext) As ObjectContext
        Return (TryCast(contex, IObjectContextAdapter)).ObjectContext
    End Function

    <System.Runtime.CompilerServices.Extension>
    Public Sub Detach(ByVal contex As DbContext, ByVal entity As Object)
        ObtenerObjectContext(contex).Detach(entity)
    End Sub
End Module
