Imports System.Data.SqlClient

Public Class Form1

    Dim conexion As SqlConnection
    Dim comando As SqlCommand

    Private Sub ActualizarEstadoHabitacion(numHabitacion As String)

        If conexion.State <> ConnectionState.Open Then
            conexion.Open()
        End If

        Dim consultaUpdate As String = "UPDATE Habitaciones SET estado = 'No disponible' WHERE numero_habitacion = @numHabitacion"
        Dim comandoUpdate As New SqlCommand(consultaUpdate, conexion)
        comandoUpdate.Parameters.AddWithValue("@numHabitacion", numHabitacion)

        comandoUpdate.ExecuteNonQuery()

    End Sub

    Private Sub ActualizarComboHabitaciones()
        If conexion.State <> ConnectionState.Open Then
            conexion.Open()
        End If

        Dim consultaHabitaciones As String = "SELECT * FROM Habitaciones WHERE estado = 'Disponible'"
        Dim comandoHabitaciones As New SqlCommand(consultaHabitaciones, conexion)

        Dim reader As SqlDataReader = comandoHabitaciones.ExecuteReader()

        cmHabitacionesEntrada.DataSource = Nothing
        cmHabitacionesEntrada.Items.Clear()

        While reader.Read()
            cmHabitacionesEntrada.Items.Add(reader("numero_habitacion").ToString())
        End While

        reader.Close()

    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.HabitacionesTableAdapter.Fill(Me.HotelDataSet.Habitaciones)
        conexion = New SqlConnection("server=MRWOLF\SQLEXPRESS; database=Hotel;integrated security=true")
    End Sub

    Private Sub RegistrarUsuarios_Click(sender As Object, e As EventArgs) Handles RegistrarUsuarios.Click
        conexion.Open()
        Dim consulta As String = "insert into Usuarios (nombre, apellido, identificacion) values('" & txtbNombreUsuario.Text & "' ,'" & txtbApellidoUsuario.Text & "', '" & txtbIDUsuario.Text & "')"
        comando = New SqlCommand(consulta, conexion)
        comando.ExecuteNonQuery()

        MessageBox.Show("Cliente registrado correctamente.")

        conexion.Close()

        txtbIDUsuario.Clear()
        txtbNombreUsuario.Clear()
        txtbApellidoUsuario.Clear()

    End Sub

    Private Sub RegistrarEntrada_Click(sender As Object, e As EventArgs) Handles RegistrarEntrada.Click

        conexion.Open()

        Dim consultaUpdate As String = "UPDATE Usuarios SET numero_habitacion = @numHabitacion, entrada = @fechaEntrada WHERE identificacion = @id"
        Dim comandoUpdate As New SqlCommand(consultaUpdate, conexion)
        comandoUpdate.Parameters.AddWithValue("@numHabitacion", cmHabitacionesEntrada.Text)
        comandoUpdate.Parameters.AddWithValue("@fechaEntrada", DTPEntrada.Value)
        comandoUpdate.Parameters.AddWithValue("@id", txtbIDUsuarioIn.Text)

        comandoUpdate.ExecuteNonQuery()

        ActualizarEstadoHabitacion(cmHabitacionesEntrada.Text)

        ActualizarComboHabitaciones()

        MessageBox.Show("Check in realizado correctamente")

        conexion.Close()

        txtbIDUsuarioIn.Clear()
        lblnombre.Text = ""
        lblapellido.Text = ""


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnbuscarIn.Click

        Dim consultaSelect As String = "SELECT nombre, apellido FROM Usuarios WHERE identificacion = @id"
        Dim comandoSelect As New SqlCommand(consultaSelect, conexion)
        comandoSelect.Parameters.AddWithValue("@id", txtbIDUsuarioIn.Text)

        conexion.Open()
        Dim reader As SqlDataReader = comandoSelect.ExecuteReader()

        If reader.Read() Then
            lblnombre.Text = reader("nombre").ToString()
            lblapellido.Text = reader("apellido").ToString()
        End If

        reader.Close()
        conexion.Close()

    End Sub

    Private Sub btnBuscarOut_Click(sender As Object, e As EventArgs) Handles btnBuscarOut.Click
        Dim consultaSelect As String = "SELECT nombre, apellido, numero_habitacion, entrada FROM Usuarios WHERE identificacion = @id"
        Dim comandoSelect As New SqlCommand(consultaSelect, conexion)
        comandoSelect.Parameters.AddWithValue("@id", txtbIDUsuarioOut.Text)

        conexion.Open()
        Dim reader As SqlDataReader = comandoSelect.ExecuteReader()

        If reader.Read() Then
            lblnombreout.Text = reader("nombre").ToString()
            lblapellidoout.Text = reader("apellido").ToString()
            lblnumhOut.Text = reader("numero_habitacion").ToString()
            lblfechaingreso.Text = reader("entrada").ToString()
        End If

        reader.Close()
        conexion.Close()
    End Sub

    Private Sub RegistrarSalida_Click(sender As Object, e As EventArgs) Handles RegistrarSalida.Click

        If conexion.State <> ConnectionState.Open Then
            conexion.Open()
        End If
        Dim numeroHabitacion As String = lblnumhOut.Text

        Dim consultaUpdate As String = "UPDATE Usuarios SET salida = @fechaSalida WHERE identificacion = @id"
        Dim comandoUpdate As New SqlCommand(consultaUpdate, conexion)
        comandoUpdate.Parameters.AddWithValue("@fechaSalida", DTPSalida.Value)
        comandoUpdate.Parameters.AddWithValue("@id", txtbIDUsuarioIn.Text)

        comandoUpdate.ExecuteNonQuery()

        Dim consultaUpdateHabitacion As String = "UPDATE Habitaciones SET estado = 'Disponible' WHERE numero_habitacion = @numHabitacion"
        Dim comandoUpdateHabitacion As New SqlCommand(consultaUpdateHabitacion, conexion)
        comandoUpdateHabitacion.Parameters.AddWithValue("@numHabitacion", numeroHabitacion)

        comandoUpdateHabitacion.ExecuteNonQuery()

        ActualizarComboHabitaciones()

        MessageBox.Show("Check Out realizado correctamente")

        conexion.Close()

        txtbIDUsuarioOut.Clear()
        lblnombreout.Text = ""
        lblapellidoout.Text = ""
        lblnumhOut.Text = ""
        lblfechaingreso.Text = ""

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click

        txtbIDUsuario.Clear()
        txtbNombreUsuario.Clear()
        txtbApellidoUsuario.Clear()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        txtbIDUsuarioIn.Clear()
        lblnombre.Text = ""
        lblapellido.Text = ""

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        txtbIDUsuarioOut.Clear()
        lblnombreout.Text = ""
        lblapellidoout.Text = ""
        lblnumhOut.Text = ""
        lblfechaingreso.Text = ""

    End Sub
End Class
