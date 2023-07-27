<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Interfaz
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Interfaz))
        Me.PnlMenuLateral = New System.Windows.Forms.Panel()
        Me.PctrBxFirmaMrWolf = New System.Windows.Forms.PictureBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnSoporte = New System.Windows.Forms.Button()
        Me.BtnFacturacion = New System.Windows.Forms.Button()
        Me.PnlLogo = New System.Windows.Forms.Panel()
        Me.LblAdministrador = New System.Windows.Forms.Label()
        Me.PctrBxLogoPrimario = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PnlMenuLateral.SuspendLayout()
        CType(Me.PctrBxFirmaMrWolf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlLogo.SuspendLayout()
        CType(Me.PctrBxLogoPrimario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlMenuLateral
        '
        Me.PnlMenuLateral.AutoScroll = True
        Me.PnlMenuLateral.BackColor = System.Drawing.Color.LightGray
        Me.PnlMenuLateral.Controls.Add(Me.PctrBxFirmaMrWolf)
        Me.PnlMenuLateral.Controls.Add(Me.BtnSalir)
        Me.PnlMenuLateral.Controls.Add(Me.BtnSoporte)
        Me.PnlMenuLateral.Controls.Add(Me.BtnFacturacion)
        Me.PnlMenuLateral.Controls.Add(Me.PnlLogo)
        Me.PnlMenuLateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlMenuLateral.Location = New System.Drawing.Point(0, 0)
        Me.PnlMenuLateral.Name = "PnlMenuLateral"
        Me.PnlMenuLateral.Size = New System.Drawing.Size(200, 634)
        Me.PnlMenuLateral.TabIndex = 1
        '
        'PctrBxFirmaMrWolf
        '
        Me.PctrBxFirmaMrWolf.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PctrBxFirmaMrWolf.Image = CType(resources.GetObject("PctrBxFirmaMrWolf.Image"), System.Drawing.Image)
        Me.PctrBxFirmaMrWolf.Location = New System.Drawing.Point(0, 525)
        Me.PctrBxFirmaMrWolf.Name = "PctrBxFirmaMrWolf"
        Me.PctrBxFirmaMrWolf.Size = New System.Drawing.Size(200, 109)
        Me.PctrBxFirmaMrWolf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PctrBxFirmaMrWolf.TabIndex = 4
        Me.PctrBxFirmaMrWolf.TabStop = False
        '
        'BtnSalir
        '
        Me.BtnSalir.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnSalir.FlatAppearance.BorderSize = 0
        Me.BtnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Font = New System.Drawing.Font("Malgun Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Image = CType(resources.GetObject("BtnSalir.Image"), System.Drawing.Image)
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.Location = New System.Drawing.Point(0, 194)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.BtnSalir.Size = New System.Drawing.Size(200, 30)
        Me.BtnSalir.TabIndex = 3
        Me.BtnSalir.Text = " Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnSoporte
        '
        Me.BtnSoporte.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnSoporte.FlatAppearance.BorderSize = 0
        Me.BtnSoporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnSoporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.BtnSoporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSoporte.Font = New System.Drawing.Font("Malgun Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSoporte.Image = CType(resources.GetObject("BtnSoporte.Image"), System.Drawing.Image)
        Me.BtnSoporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSoporte.Location = New System.Drawing.Point(0, 164)
        Me.BtnSoporte.Name = "BtnSoporte"
        Me.BtnSoporte.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.BtnSoporte.Size = New System.Drawing.Size(200, 30)
        Me.BtnSoporte.TabIndex = 2
        Me.BtnSoporte.Text = "Datos Generales"
        Me.BtnSoporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSoporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSoporte.UseVisualStyleBackColor = True
        '
        'BtnFacturacion
        '
        Me.BtnFacturacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnFacturacion.FlatAppearance.BorderSize = 0
        Me.BtnFacturacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnFacturacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.BtnFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFacturacion.Font = New System.Drawing.Font("Malgun Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFacturacion.Image = CType(resources.GetObject("BtnFacturacion.Image"), System.Drawing.Image)
        Me.BtnFacturacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnFacturacion.Location = New System.Drawing.Point(0, 134)
        Me.BtnFacturacion.Name = "BtnFacturacion"
        Me.BtnFacturacion.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.BtnFacturacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnFacturacion.Size = New System.Drawing.Size(200, 30)
        Me.BtnFacturacion.TabIndex = 1
        Me.BtnFacturacion.Text = "Check In - Check On"
        Me.BtnFacturacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnFacturacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnFacturacion.UseVisualStyleBackColor = True
        '
        'PnlLogo
        '
        Me.PnlLogo.Controls.Add(Me.LblAdministrador)
        Me.PnlLogo.Controls.Add(Me.PctrBxLogoPrimario)
        Me.PnlLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlLogo.Location = New System.Drawing.Point(0, 0)
        Me.PnlLogo.Name = "PnlLogo"
        Me.PnlLogo.Size = New System.Drawing.Size(200, 134)
        Me.PnlLogo.TabIndex = 0
        '
        'LblAdministrador
        '
        Me.LblAdministrador.AutoSize = True
        Me.LblAdministrador.Location = New System.Drawing.Point(44, 101)
        Me.LblAdministrador.Name = "LblAdministrador"
        Me.LblAdministrador.Size = New System.Drawing.Size(109, 17)
        Me.LblAdministrador.TabIndex = 1
        Me.LblAdministrador.Text = "Michael Huamán"
        '
        'PctrBxLogoPrimario
        '
        Me.PctrBxLogoPrimario.Image = CType(resources.GetObject("PctrBxLogoPrimario.Image"), System.Drawing.Image)
        Me.PctrBxLogoPrimario.Location = New System.Drawing.Point(43, 0)
        Me.PctrBxLogoPrimario.Name = "PctrBxLogoPrimario"
        Me.PctrBxLogoPrimario.Size = New System.Drawing.Size(113, 108)
        Me.PctrBxLogoPrimario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PctrBxLogoPrimario.TabIndex = 0
        Me.PctrBxLogoPrimario.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(200, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(841, 634)
        Me.Panel1.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(841, 634)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Interfaz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1041, 634)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PnlMenuLateral)
        Me.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Interfaz"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Control Hotel Wolf Nights"
        Me.PnlMenuLateral.ResumeLayout(False)
        CType(Me.PctrBxFirmaMrWolf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlLogo.ResumeLayout(False)
        Me.PnlLogo.PerformLayout()
        CType(Me.PctrBxLogoPrimario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlMenuLateral As Panel
    Friend WithEvents PctrBxFirmaMrWolf As PictureBox
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnSoporte As Button
    Friend WithEvents BtnFacturacion As Button
    Friend WithEvents PnlLogo As Panel
    Friend WithEvents LblAdministrador As Label
    Friend WithEvents PctrBxLogoPrimario As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
