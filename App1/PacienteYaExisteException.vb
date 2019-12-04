Public Class PacienteYaExisteException
    Inherits ApplicationException

    Private _Paciente As Paciente
    Public ReadOnly Property Paciente As Paciente
        Get
            Return _Paciente
        End Get
    End Property

    Public Sub New(Message As String, Paciente As Paciente)
        MyBase.New(Message + ":: Paciente ya existe!")
        _Paciente = Paciente
    End Sub
End Class
