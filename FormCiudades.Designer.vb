<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCiudades
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ctId = New System.Windows.Forms.TextBox()
        Me.CuidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCiudades = New MonitoresUCA.dsCiudades()
        Me.ctNombre = New System.Windows.Forms.TextBox()
        Me.ctEstado = New System.Windows.Forms.TextBox()
        Me.ctObservaciones = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ctBuscar = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btAnadir = New System.Windows.Forms.Button()
        Me.btBorrar = New System.Windows.Forms.Button()
        Me.btGuardar = New System.Windows.Forms.Button()
        Me.btPrimero = New System.Windows.Forms.Button()
        Me.btAnterior = New System.Windows.Forms.Button()
        Me.btSiguiente = New System.Windows.Forms.Button()
        Me.btUltimo = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.etPosicion = New System.Windows.Forms.Label()
        Me.CuidadTableAdapter = New MonitoresUCA.dsCiudadesTableAdapters.CuidadTableAdapter()
        Me.btBuscar = New System.Windows.Forms.Button()
        CType(Me.CuidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCiudades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(354, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Listado de Ciudades"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(87, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Id:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(87, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(87, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Estado:"
        '
        'ctId
        '
        Me.ctId.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.CuidadBindingSource, "id", True))
        Me.ctId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuidadBindingSource, "id", True))
        Me.ctId.Location = New System.Drawing.Point(235, 142)
        Me.ctId.Name = "ctId"
        Me.ctId.Size = New System.Drawing.Size(96, 22)
        Me.ctId.TabIndex = 4
        '
        'CuidadBindingSource
        '
        Me.CuidadBindingSource.DataMember = "Cuidad"
        Me.CuidadBindingSource.DataSource = Me.DsCiudades
        '
        'DsCiudades
        '
        Me.DsCiudades.DataSetName = "dsCiudades"
        Me.DsCiudades.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ctNombre
        '
        Me.ctNombre.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.CuidadBindingSource, "nombre", True))
        Me.ctNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuidadBindingSource, "nombre", True))
        Me.ctNombre.Location = New System.Drawing.Point(235, 186)
        Me.ctNombre.Name = "ctNombre"
        Me.ctNombre.Size = New System.Drawing.Size(96, 22)
        Me.ctNombre.TabIndex = 5
        '
        'ctEstado
        '
        Me.ctEstado.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.CuidadBindingSource, "estado", True))
        Me.ctEstado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuidadBindingSource, "estado", True))
        Me.ctEstado.Location = New System.Drawing.Point(235, 237)
        Me.ctEstado.Name = "ctEstado"
        Me.ctEstado.Size = New System.Drawing.Size(96, 22)
        Me.ctEstado.TabIndex = 6
        '
        'ctObservaciones
        '
        Me.ctObservaciones.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.CuidadBindingSource, "observaciones", True))
        Me.ctObservaciones.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CuidadBindingSource, "observaciones", True))
        Me.ctObservaciones.Location = New System.Drawing.Point(235, 285)
        Me.ctObservaciones.Multiline = True
        Me.ctObservaciones.Name = "ctObservaciones"
        Me.ctObservaciones.Size = New System.Drawing.Size(193, 102)
        Me.ctObservaciones.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(87, 285)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Observaciones:"
        '
        'ctBuscar
        '
        Me.ctBuscar.Location = New System.Drawing.Point(620, 321)
        Me.ctBuscar.Name = "ctBuscar"
        Me.ctBuscar.Size = New System.Drawing.Size(214, 22)
        Me.ctBuscar.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(546, 321)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Buscar:"
        '
        'btAnadir
        '
        Me.btAnadir.Location = New System.Drawing.Point(620, 179)
        Me.btAnadir.Name = "btAnadir"
        Me.btAnadir.Size = New System.Drawing.Size(100, 31)
        Me.btAnadir.TabIndex = 11
        Me.btAnadir.Text = "Anadir"
        Me.btAnadir.UseVisualStyleBackColor = True
        '
        'btBorrar
        '
        Me.btBorrar.Location = New System.Drawing.Point(620, 242)
        Me.btBorrar.Name = "btBorrar"
        Me.btBorrar.Size = New System.Drawing.Size(100, 31)
        Me.btBorrar.TabIndex = 12
        Me.btBorrar.Text = "Borrar"
        Me.btBorrar.UseVisualStyleBackColor = True
        '
        'btGuardar
        '
        Me.btGuardar.Location = New System.Drawing.Point(620, 208)
        Me.btGuardar.Name = "btGuardar"
        Me.btGuardar.Size = New System.Drawing.Size(100, 31)
        Me.btGuardar.TabIndex = 13
        Me.btGuardar.Text = "Guardar"
        Me.btGuardar.UseVisualStyleBackColor = True
        '
        'btPrimero
        '
        Me.btPrimero.Location = New System.Drawing.Point(147, 487)
        Me.btPrimero.Name = "btPrimero"
        Me.btPrimero.Size = New System.Drawing.Size(100, 31)
        Me.btPrimero.TabIndex = 14
        Me.btPrimero.Text = "Primero"
        Me.btPrimero.UseVisualStyleBackColor = True
        '
        'btAnterior
        '
        Me.btAnterior.Location = New System.Drawing.Point(256, 487)
        Me.btAnterior.Name = "btAnterior"
        Me.btAnterior.Size = New System.Drawing.Size(100, 31)
        Me.btAnterior.TabIndex = 15
        Me.btAnterior.Text = "Anterior"
        Me.btAnterior.UseVisualStyleBackColor = True
        '
        'btSiguiente
        '
        Me.btSiguiente.Location = New System.Drawing.Point(544, 487)
        Me.btSiguiente.Name = "btSiguiente"
        Me.btSiguiente.Size = New System.Drawing.Size(100, 31)
        Me.btSiguiente.TabIndex = 16
        Me.btSiguiente.Text = "Siguiente"
        Me.btSiguiente.UseVisualStyleBackColor = True
        '
        'btUltimo
        '
        Me.btUltimo.Location = New System.Drawing.Point(650, 487)
        Me.btUltimo.Name = "btUltimo"
        Me.btUltimo.Size = New System.Drawing.Size(100, 31)
        Me.btUltimo.TabIndex = 17
        Me.btUltimo.Text = "Ultimo"
        Me.btUltimo.UseVisualStyleBackColor = True
        '
        'etPosicion
        '
        Me.etPosicion.AutoSize = True
        Me.etPosicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etPosicion.Location = New System.Drawing.Point(410, 494)
        Me.etPosicion.Name = "etPosicion"
        Me.etPosicion.Size = New System.Drawing.Size(86, 16)
        Me.etPosicion.TabIndex = 18
        Me.etPosicion.Text = "No Registros"
        Me.etPosicion.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CuidadTableAdapter
        '
        Me.CuidadTableAdapter.ClearBeforeFill = True
        '
        'btBuscar
        '
        Me.btBuscar.Location = New System.Drawing.Point(666, 349)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(100, 31)
        Me.btBuscar.TabIndex = 19
        Me.btBuscar.Text = "Buscar"
        Me.btBuscar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 566)
        Me.Controls.Add(Me.btBuscar)
        Me.Controls.Add(Me.etPosicion)
        Me.Controls.Add(Me.btUltimo)
        Me.Controls.Add(Me.btSiguiente)
        Me.Controls.Add(Me.btAnterior)
        Me.Controls.Add(Me.btPrimero)
        Me.Controls.Add(Me.btGuardar)
        Me.Controls.Add(Me.btBorrar)
        Me.Controls.Add(Me.btAnadir)
        Me.Controls.Add(Me.ctBuscar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ctObservaciones)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ctEstado)
        Me.Controls.Add(Me.ctNombre)
        Me.Controls.Add(Me.ctId)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.CuidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCiudades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ctId As TextBox
    Friend WithEvents ctNombre As TextBox
    Friend WithEvents ctEstado As TextBox
    Friend WithEvents ctObservaciones As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ctBuscar As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btAnadir As Button
    Friend WithEvents btBorrar As Button
    Friend WithEvents btGuardar As Button
    Friend WithEvents btPrimero As Button
    Friend WithEvents btAnterior As Button
    Friend WithEvents btSiguiente As Button
    Friend WithEvents btUltimo As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents etPosicion As Label
    Friend WithEvents DsCiudades As dsCiudades
    Friend WithEvents CuidadBindingSource As BindingSource
    Friend WithEvents CuidadTableAdapter As dsCiudadesTableAdapters.CuidadTableAdapter
    Friend WithEvents btBuscar As Button
End Class
