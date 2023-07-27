<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DatosHotel
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DatosHotel))
        Me.DGVInfoHotel = New System.Windows.Forms.DataGridView()
        Me.PnlBordeDerec = New System.Windows.Forms.Panel()
        Me.PnlBordeIzqu = New System.Windows.Forms.Panel()
        Me.PnlBordeSup = New System.Windows.Forms.Panel()
        Me.lblTituloNumVenta = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LblNombreTienda = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DGVInfoHotel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlBordeSup.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVInfoHotel
        '
        Me.DGVInfoHotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVInfoHotel.Location = New System.Drawing.Point(49, 90)
        Me.DGVInfoHotel.Name = "DGVInfoHotel"
        Me.DGVInfoHotel.Size = New System.Drawing.Size(562, 216)
        Me.DGVInfoHotel.TabIndex = 0
        '
        'PnlBordeDerec
        '
        Me.PnlBordeDerec.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.PnlBordeDerec.Dock = System.Windows.Forms.DockStyle.Right
        Me.PnlBordeDerec.Location = New System.Drawing.Point(648, 42)
        Me.PnlBordeDerec.Name = "PnlBordeDerec"
        Me.PnlBordeDerec.Size = New System.Drawing.Size(17, 304)
        Me.PnlBordeDerec.TabIndex = 66
        '
        'PnlBordeIzqu
        '
        Me.PnlBordeIzqu.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.PnlBordeIzqu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlBordeIzqu.Location = New System.Drawing.Point(0, 42)
        Me.PnlBordeIzqu.Name = "PnlBordeIzqu"
        Me.PnlBordeIzqu.Size = New System.Drawing.Size(17, 304)
        Me.PnlBordeIzqu.TabIndex = 65
        '
        'PnlBordeSup
        '
        Me.PnlBordeSup.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.PnlBordeSup.Controls.Add(Me.lblTituloNumVenta)
        Me.PnlBordeSup.Controls.Add(Me.PictureBox1)
        Me.PnlBordeSup.Controls.Add(Me.LblNombreTienda)
        Me.PnlBordeSup.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlBordeSup.Location = New System.Drawing.Point(0, 0)
        Me.PnlBordeSup.Name = "PnlBordeSup"
        Me.PnlBordeSup.Size = New System.Drawing.Size(665, 42)
        Me.PnlBordeSup.TabIndex = 64
        '
        'lblTituloNumVenta
        '
        Me.lblTituloNumVenta.AutoSize = True
        Me.lblTituloNumVenta.BackColor = System.Drawing.SystemColors.Control
        Me.lblTituloNumVenta.Font = New System.Drawing.Font("Malgun Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloNumVenta.Location = New System.Drawing.Point(246, 9)
        Me.lblTituloNumVenta.Name = "lblTituloNumVenta"
        Me.lblTituloNumVenta.Size = New System.Drawing.Size(178, 25)
        Me.lblTituloNumVenta.TabIndex = 18
        Me.lblTituloNumVenta.Text = "Hotel Wolf Nights"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 36)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'LblNombreTienda
        '
        Me.LblNombreTienda.AutoSize = True
        Me.LblNombreTienda.BackColor = System.Drawing.SystemColors.Control
        Me.LblNombreTienda.Location = New System.Drawing.Point(58, 15)
        Me.LblNombreTienda.Name = "LblNombreTienda"
        Me.LblNombreTienda.Size = New System.Drawing.Size(119, 17)
        Me.LblNombreTienda.TabIndex = 1
        Me.LblNombreTienda.Text = "Wolf Technologies"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Malgun Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(259, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 20)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Información General"
        '
        'DatosHotel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 346)
        Me.Controls.Add(Me.PnlBordeDerec)
        Me.Controls.Add(Me.PnlBordeIzqu)
        Me.Controls.Add(Me.PnlBordeSup)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGVInfoHotel)
        Me.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "DatosHotel"
        Me.Text = "DatosHotel"
        CType(Me.DGVInfoHotel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlBordeSup.ResumeLayout(False)
        Me.PnlBordeSup.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVInfoHotel As DataGridView
    Friend WithEvents PnlBordeDerec As Panel
    Friend WithEvents PnlBordeIzqu As Panel
    Friend WithEvents PnlBordeSup As Panel
    Friend WithEvents lblTituloNumVenta As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LblNombreTienda As Label
    Friend WithEvents Label1 As Label
End Class
