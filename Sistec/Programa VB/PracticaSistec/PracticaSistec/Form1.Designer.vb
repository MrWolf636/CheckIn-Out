<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DTPEntrada = New System.Windows.Forms.DateTimePicker()
        Me.RegistrarEntrada = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtbIDUsuarioIn = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtbIDUsuarioOut = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.RegistrarSalida = New System.Windows.Forms.Button()
        Me.DTPSalida = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmHabitacionesEntrada = New System.Windows.Forms.ComboBox()
        Me.HotelDataSet = New PracticaSistec.HotelDataSet()
        Me.HabitacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HabitacionesTableAdapter = New PracticaSistec.HotelDataSetTableAdapters.HabitacionesTableAdapter()
        Me.HabitacionesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnbuscarIn = New System.Windows.Forms.Button()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.lblapellido = New System.Windows.Forms.Label()
        Me.lblapellidoout = New System.Windows.Forms.Label()
        Me.lblnombreout = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnBuscarOut = New System.Windows.Forms.Button()
        Me.lblnumhOut = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblfechaingreso = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtbNombreUsuario = New System.Windows.Forms.TextBox()
        Me.txtbIDUsuario = New System.Windows.Forms.TextBox()
        Me.RegistrarUsuarios = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtbApellidoUsuario = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PnlBordeDerec = New System.Windows.Forms.Panel()
        Me.PnlBordeIzqu = New System.Windows.Forms.Panel()
        Me.PnlBordeSup = New System.Windows.Forms.Panel()
        Me.lblTituloNumVenta = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LblNombreTienda = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.HotelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HabitacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HabitacionesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.PnlBordeSup.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Malgun Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(304, 50)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(232, 20)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Proceso de check in - check out"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(292, 356)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Fecha de ingreso:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(45, 356)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "N° de habitación:"
        '
        'DTPEntrada
        '
        Me.DTPEntrada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPEntrada.Location = New System.Drawing.Point(295, 376)
        Me.DTPEntrada.Name = "DTPEntrada"
        Me.DTPEntrada.Size = New System.Drawing.Size(112, 25)
        Me.DTPEntrada.TabIndex = 11
        '
        'RegistrarEntrada
        '
        Me.RegistrarEntrada.BackColor = System.Drawing.Color.Lime
        Me.RegistrarEntrada.FlatAppearance.BorderSize = 0
        Me.RegistrarEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RegistrarEntrada.Location = New System.Drawing.Point(440, 373)
        Me.RegistrarEntrada.Name = "RegistrarEntrada"
        Me.RegistrarEntrada.Size = New System.Drawing.Size(96, 25)
        Me.RegistrarEntrada.TabIndex = 28
        Me.RegistrarEntrada.Text = "Registrar"
        Me.RegistrarEntrada.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(679, 282)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 17)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "Apellido:"
        '
        'txtbIDUsuarioIn
        '
        Me.txtbIDUsuarioIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbIDUsuarioIn.Location = New System.Drawing.Point(48, 302)
        Me.txtbIDUsuarioIn.Name = "txtbIDUsuarioIn"
        Me.txtbIDUsuarioIn.Size = New System.Drawing.Size(177, 25)
        Me.txtbIDUsuarioIn.TabIndex = 33
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(45, 282)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(90, 17)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Identificación:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Location = New System.Drawing.Point(437, 282)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(60, 17)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "Nombre:"
        '
        'txtbIDUsuarioOut
        '
        Me.txtbIDUsuarioOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbIDUsuarioOut.Location = New System.Drawing.Point(48, 497)
        Me.txtbIDUsuarioOut.Name = "txtbIDUsuarioOut"
        Me.txtbIDUsuarioOut.Size = New System.Drawing.Size(177, 25)
        Me.txtbIDUsuarioOut.TabIndex = 44
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(45, 477)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 17)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Identificación:"
        '
        'RegistrarSalida
        '
        Me.RegistrarSalida.BackColor = System.Drawing.Color.Lime
        Me.RegistrarSalida.FlatAppearance.BorderSize = 0
        Me.RegistrarSalida.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RegistrarSalida.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegistrarSalida.Location = New System.Drawing.Point(549, 115)
        Me.RegistrarSalida.Name = "RegistrarSalida"
        Me.RegistrarSalida.Size = New System.Drawing.Size(96, 25)
        Me.RegistrarSalida.TabIndex = 40
        Me.RegistrarSalida.Text = "Registrar"
        Me.RegistrarSalida.UseVisualStyleBackColor = False
        '
        'DTPSalida
        '
        Me.DTPSalida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPSalida.Location = New System.Drawing.Point(440, 563)
        Me.DTPSalida.Name = "DTPSalida"
        Me.DTPSalida.Size = New System.Drawing.Size(112, 25)
        Me.DTPSalida.TabIndex = 39
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(437, 543)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(104, 17)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "Fecha de salida:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Location = New System.Drawing.Point(45, 543)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(113, 17)
        Me.Label17.TabIndex = 36
        Me.Label17.Text = "N° de habitación:"
        '
        'cmHabitacionesEntrada
        '
        Me.cmHabitacionesEntrada.DataSource = Me.HabitacionesBindingSource1
        Me.cmHabitacionesEntrada.DisplayMember = "numero_habitacion"
        Me.cmHabitacionesEntrada.FormattingEnabled = True
        Me.cmHabitacionesEntrada.Location = New System.Drawing.Point(48, 376)
        Me.cmHabitacionesEntrada.Name = "cmHabitacionesEntrada"
        Me.cmHabitacionesEntrada.Size = New System.Drawing.Size(177, 25)
        Me.cmHabitacionesEntrada.TabIndex = 47
        '
        'HotelDataSet
        '
        Me.HotelDataSet.DataSetName = "HotelDataSet"
        Me.HotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HabitacionesBindingSource
        '
        Me.HabitacionesBindingSource.DataMember = "Habitaciones"
        Me.HabitacionesBindingSource.DataSource = Me.HotelDataSet
        '
        'HabitacionesTableAdapter
        '
        Me.HabitacionesTableAdapter.ClearBeforeFill = True
        '
        'HabitacionesBindingSource1
        '
        Me.HabitacionesBindingSource1.DataMember = "Habitaciones"
        Me.HabitacionesBindingSource1.DataSource = Me.HotelDataSet
        '
        'btnbuscarIn
        '
        Me.btnbuscarIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnbuscarIn.FlatAppearance.BorderSize = 0
        Me.btnbuscarIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnbuscarIn.Location = New System.Drawing.Point(256, 302)
        Me.btnbuscarIn.Name = "btnbuscarIn"
        Me.btnbuscarIn.Size = New System.Drawing.Size(96, 25)
        Me.btnbuscarIn.TabIndex = 48
        Me.btnbuscarIn.Text = "Buscar"
        Me.btnbuscarIn.UseVisualStyleBackColor = False
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblnombre.Location = New System.Drawing.Point(437, 305)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(2, 19)
        Me.lblnombre.TabIndex = 49
        '
        'lblapellido
        '
        Me.lblapellido.AutoSize = True
        Me.lblapellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblapellido.Location = New System.Drawing.Point(679, 310)
        Me.lblapellido.Name = "lblapellido"
        Me.lblapellido.Size = New System.Drawing.Size(2, 19)
        Me.lblapellido.TabIndex = 50
        '
        'lblapellidoout
        '
        Me.lblapellidoout.AutoSize = True
        Me.lblapellidoout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblapellidoout.Location = New System.Drawing.Point(679, 505)
        Me.lblapellidoout.Name = "lblapellidoout"
        Me.lblapellidoout.Size = New System.Drawing.Size(2, 19)
        Me.lblapellidoout.TabIndex = 54
        '
        'lblnombreout
        '
        Me.lblnombreout.AutoSize = True
        Me.lblnombreout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblnombreout.Location = New System.Drawing.Point(437, 500)
        Me.lblnombreout.Name = "lblnombreout"
        Me.lblnombreout.Size = New System.Drawing.Size(2, 19)
        Me.lblnombreout.TabIndex = 53
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Location = New System.Drawing.Point(679, 477)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(60, 17)
        Me.Label18.TabIndex = 52
        Me.Label18.Text = "Apellido:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Location = New System.Drawing.Point(437, 477)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(60, 17)
        Me.Label19.TabIndex = 51
        Me.Label19.Text = "Nombre:"
        '
        'btnBuscarOut
        '
        Me.btnBuscarOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBuscarOut.FlatAppearance.BorderSize = 0
        Me.btnBuscarOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBuscarOut.Location = New System.Drawing.Point(256, 500)
        Me.btnBuscarOut.Name = "btnBuscarOut"
        Me.btnBuscarOut.Size = New System.Drawing.Size(96, 25)
        Me.btnBuscarOut.TabIndex = 55
        Me.btnBuscarOut.Text = "Buscar"
        Me.btnBuscarOut.UseVisualStyleBackColor = False
        '
        'lblnumhOut
        '
        Me.lblnumhOut.AutoSize = True
        Me.lblnumhOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblnumhOut.Location = New System.Drawing.Point(45, 569)
        Me.lblnumhOut.Name = "lblnumhOut"
        Me.lblnumhOut.Size = New System.Drawing.Size(2, 19)
        Me.lblnumhOut.TabIndex = 56
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(253, 543)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 17)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "Fecha de ingreso:"
        '
        'lblfechaingreso
        '
        Me.lblfechaingreso.AutoSize = True
        Me.lblfechaingreso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblfechaingreso.Location = New System.Drawing.Point(253, 569)
        Me.lblfechaingreso.Name = "lblfechaingreso"
        Me.lblfechaingreso.Size = New System.Drawing.Size(2, 19)
        Me.lblfechaingreso.TabIndex = 58
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(279, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nombre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Identificación:"
        '
        'txtbNombreUsuario
        '
        Me.txtbNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbNombreUsuario.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbNombreUsuario.Location = New System.Drawing.Point(282, 54)
        Me.txtbNombreUsuario.Name = "txtbNombreUsuario"
        Me.txtbNombreUsuario.Size = New System.Drawing.Size(177, 25)
        Me.txtbNombreUsuario.TabIndex = 5
        '
        'txtbIDUsuario
        '
        Me.txtbIDUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbIDUsuario.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbIDUsuario.Location = New System.Drawing.Point(35, 54)
        Me.txtbIDUsuario.Name = "txtbIDUsuario"
        Me.txtbIDUsuario.Size = New System.Drawing.Size(177, 25)
        Me.txtbIDUsuario.TabIndex = 6
        '
        'RegistrarUsuarios
        '
        Me.RegistrarUsuarios.BackColor = System.Drawing.Color.Lime
        Me.RegistrarUsuarios.FlatAppearance.BorderSize = 0
        Me.RegistrarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RegistrarUsuarios.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegistrarUsuarios.Location = New System.Drawing.Point(34, 99)
        Me.RegistrarUsuarios.Name = "RegistrarUsuarios"
        Me.RegistrarUsuarios.Size = New System.Drawing.Size(96, 30)
        Me.RegistrarUsuarios.TabIndex = 21
        Me.RegistrarUsuarios.Text = "Registrar"
        Me.RegistrarUsuarios.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(521, 34)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 17)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Apellido:"
        '
        'txtbApellidoUsuario
        '
        Me.txtbApellidoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbApellidoUsuario.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbApellidoUsuario.Location = New System.Drawing.Point(524, 54)
        Me.txtbApellidoUsuario.Name = "txtbApellidoUsuario"
        Me.txtbApellidoUsuario.Size = New System.Drawing.Size(177, 25)
        Me.txtbApellidoUsuario.TabIndex = 23
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.BtnNuevo)
        Me.GroupBox1.Controls.Add(Me.txtbApellidoUsuario)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtbNombreUsuario)
        Me.GroupBox1.Controls.Add(Me.txtbIDUsuario)
        Me.GroupBox1.Controls.Add(Me.RegistrarUsuarios)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(27, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(759, 146)
        Me.GroupBox1.TabIndex = 59
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registro Huespedes:"
        '
        'PnlBordeDerec
        '
        Me.PnlBordeDerec.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.PnlBordeDerec.Dock = System.Windows.Forms.DockStyle.Right
        Me.PnlBordeDerec.Location = New System.Drawing.Point(802, 42)
        Me.PnlBordeDerec.Name = "PnlBordeDerec"
        Me.PnlBordeDerec.Size = New System.Drawing.Size(17, 594)
        Me.PnlBordeDerec.TabIndex = 62
        '
        'PnlBordeIzqu
        '
        Me.PnlBordeIzqu.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.PnlBordeIzqu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlBordeIzqu.Location = New System.Drawing.Point(0, 42)
        Me.PnlBordeIzqu.Name = "PnlBordeIzqu"
        Me.PnlBordeIzqu.Size = New System.Drawing.Size(17, 594)
        Me.PnlBordeIzqu.TabIndex = 61
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
        Me.PnlBordeSup.Size = New System.Drawing.Size(819, 42)
        Me.PnlBordeSup.TabIndex = 60
        '
        'lblTituloNumVenta
        '
        Me.lblTituloNumVenta.AutoSize = True
        Me.lblTituloNumVenta.BackColor = System.Drawing.SystemColors.Control
        Me.lblTituloNumVenta.Font = New System.Drawing.Font("Malgun Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloNumVenta.Location = New System.Drawing.Point(326, 9)
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
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(27, 258)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(759, 161)
        Me.GroupBox2.TabIndex = 63
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Check In:"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.RegistrarSalida)
        Me.GroupBox3.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(27, 448)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(759, 161)
        Me.GroupBox3.TabIndex = 64
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Check Out:"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.Lime
        Me.BtnNuevo.FlatAppearance.BorderSize = 0
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNuevo.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.Location = New System.Drawing.Point(174, 99)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(96, 30)
        Me.BtnNuevo.TabIndex = 24
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Lime
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(549, 115)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 25)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Nuevo"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Lime
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(657, 115)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 25)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "Nuevo"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(819, 636)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.PnlBordeDerec)
        Me.Controls.Add(Me.PnlBordeIzqu)
        Me.Controls.Add(Me.PnlBordeSup)
        Me.Controls.Add(Me.lblfechaingreso)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblnumhOut)
        Me.Controls.Add(Me.btnBuscarOut)
        Me.Controls.Add(Me.lblapellidoout)
        Me.Controls.Add(Me.lblnombreout)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.lblapellido)
        Me.Controls.Add(Me.lblnombre)
        Me.Controls.Add(Me.btnbuscarIn)
        Me.Controls.Add(Me.cmHabitacionesEntrada)
        Me.Controls.Add(Me.txtbIDUsuarioOut)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DTPSalida)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtbIDUsuarioIn)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.RegistrarEntrada)
        Me.Controls.Add(Me.DTPEntrada)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Font = New System.Drawing.Font("Malgun Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.HotelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HabitacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HabitacionesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PnlBordeSup.ResumeLayout(False)
        Me.PnlBordeSup.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DTPEntrada As DateTimePicker
    Friend WithEvents RegistrarEntrada As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents txtbIDUsuarioIn As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtbIDUsuarioOut As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents RegistrarSalida As Button
    Friend WithEvents DTPSalida As DateTimePicker
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents cmHabitacionesEntrada As ComboBox
    Friend WithEvents HotelDataSet As HotelDataSet
    Friend WithEvents HabitacionesBindingSource As BindingSource
    Friend WithEvents HabitacionesTableAdapter As HotelDataSetTableAdapters.HabitacionesTableAdapter
    Friend WithEvents HabitacionesBindingSource1 As BindingSource
    Friend WithEvents btnbuscarIn As Button
    Friend WithEvents lblnombre As Label
    Friend WithEvents lblapellido As Label
    Friend WithEvents lblapellidoout As Label
    Friend WithEvents lblnombreout As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents btnBuscarOut As Button
    Friend WithEvents lblnumhOut As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblfechaingreso As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtbNombreUsuario As TextBox
    Friend WithEvents txtbIDUsuario As TextBox
    Friend WithEvents RegistrarUsuarios As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents txtbApellidoUsuario As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PnlBordeDerec As Panel
    Friend WithEvents PnlBordeIzqu As Panel
    Friend WithEvents PnlBordeSup As Panel
    Friend WithEvents lblTituloNumVenta As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LblNombreTienda As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
