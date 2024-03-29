﻿Public Class AdministradorPacientes
    Private _pacientes As Hashtable = New Hashtable()
    Public Event PacienteCreado(Paciente As Paciente)
    Public Event PacienteEliminado(Paciente As Paciente)
    Public ReadOnly Property Pacientes As Hashtable
        Get
            Return _pacientes
        End Get
    End Property

    Public Sub AgregarPaciente(ByRef Paciente As Paciente)
        Try
            _pacientes.Add(Paciente.ID, Paciente)
            RaiseEvent PacienteCreado(Paciente)
        Catch ex As Exception
            Throw New PacienteYaExisteException("Paciente ya existe!", Paciente)
        End Try

        'Try
        '   _pacientes.Add(Paciente.ID, Paciente)
        '   RaiseEvent PacienteCreado(Paciente)
        'Catch ex As Exception
        '   Console.WriteLine("Paciente ya existe " & Paciente.ID)
        'End Try

        'If Not (_pacientes.ContainsKey(Paciente.ID)) Then
        '   _pacientes.Add(Paciente.ID, Paciente)
        '   RaiseEvent PacienteCreado(Paciente)
        'End If
    End Sub

    Public Sub EliminarPaciente(ID As String)

        Dim Paciente = _pacientes.Item(ID)
        If (Not IsNothing(Paciente)) Then
            _pacientes.Remove(ID)
            RaiseEvent PacienteEliminado(Paciente)
        End If

    End Sub

End Class
