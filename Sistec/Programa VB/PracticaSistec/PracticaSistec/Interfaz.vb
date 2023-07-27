Public Class Interfaz

    Private currentForm As Form = Nothing
    Private Sub openChildForm(childForm As Form)
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        Panel1.Controls.Add(childForm)
        Panel1.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub BtnFacturacion_Click(sender As Object, e As EventArgs) Handles BtnFacturacion.Click
        openChildForm(New Form1)
    End Sub

    Private Sub BtnSoporte_Click(sender As Object, e As EventArgs) Handles BtnSoporte.Click
        openChildForm(New DatosHotel)
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Close()
    End Sub
End Class