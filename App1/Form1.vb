Imports App1

Public Class Form1

    Dim WithEvents AdministradorPacientes As New AdministradorPacientes

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Paciente As New Paciente()
        Paciente.ID = TxtId.Text
        Paciente.Nombre = TxtNombre.Text

        AdministradorPacientes.AgregarPaciente(Paciente)


    End Sub

    Private Sub AdministradorPacientes_PacienteCreado(Paciente As Paciente) Handles AdministradorPacientes.PacienteCreado
        MessageBox.Show("Paciente creado " + Paciente.ID + " " + Paciente.Nombre)
    End Sub

    Private Sub btnEliminarPaciente_Click(sender As Object, e As EventArgs) Handles btnEliminarPaciente.Click
        AdministradorPacientes.EliminarPaciente(TxtId.Text)

    End Sub

    Private Sub AdministradorPacientes_PacienteEliminado(Paciente As Paciente) Handles AdministradorPacientes.PacienteEliminado
        MessageBox.Show("Paciente eliminado " + Paciente.ID + " " + Paciente.Nombre)
    End Sub

End Class
