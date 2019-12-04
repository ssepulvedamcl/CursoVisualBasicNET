Imports App1

Public Class Paciente
    Inherits Persona
    Implements IPaciente

    Private _fechaUltimaCita As Date
    Private _id As String

    Public Property FechaUltimaCita As Date Implements IPaciente.FechaUltimaCita
        Get
            Return _fechaUltimaCita
        End Get
        Set(value As Date)
            _fechaUltimaCita = value
        End Set
    End Property

    Public Property ID As String Implements IPaciente.ID
        Get
            Return _id
        End Get
        Set(value As String)
            _id = value
        End Set
    End Property

    Public Event CitaAgendada() Implements IPaciente.CitaAgendada
    Public Event FichaCreada() Implements IPaciente.FichaCreada


End Class
