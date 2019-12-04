Imports App1

Public Class Persona
    Implements IPersona

    Private _nombre As String

    Public Property Nombre As String Implements IPersona.Nombre
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
End Class
