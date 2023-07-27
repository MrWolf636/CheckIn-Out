Imports System.Data.SqlClient

Public Class DatosHotel

    Dim conexion As SqlConnection
    Dim comando As SqlCommand
    Private Sub DGVInfoHotel_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVInfoHotel.CellContentClick

    End Sub

    Private Sub DatosHotel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conexion = New SqlConnection("server=MRWOLF\SQLEXPRESS; database=Hotel;integrated security=true")

        If conexion.State <> ConnectionState.Open Then
            conexion.Open()
        End If

        Dim consulta As String = "SELECT U.nombre, U.apellido, U.identificacion, H.numero_habitacion, H.estado FROM Usuarios U INNER JOIN Habitaciones H ON U.numero_habitacion = H.numero_habitacion"

        Dim comando As New SqlCommand(consulta, conexion)
        Dim dataAdapter As New SqlDataAdapter(comando)

        Dim table As New DataTable()

        dataAdapter.Fill(table)

        DGVInfoHotel.DataSource = table

        DGVInfoHotel.Columns("nombre").HeaderText = "Nombres"
        DGVInfoHotel.Columns("apellido").HeaderText = "Apellidos"
        DGVInfoHotel.Columns("identificacion").HeaderText = "Identificaciones"
        DGVInfoHotel.Columns("numero_habitacion").HeaderText = "Número de Habitacióne"
        DGVInfoHotel.Columns("estado").HeaderText = "Estado de Habitaciones"

        conexion.Close()



    End Sub
End Class