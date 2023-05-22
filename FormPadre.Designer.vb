<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPadre
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
        Me.menuArchivo = New System.Windows.Forms.MenuStrip()
        Me.BarraMenusFormPadre = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArchivoCerrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuFormularios = New System.Windows.Forms.ToolStripMenuItem()
        Me.opFormularioCRUD = New System.Windows.Forms.ToolStripMenuItem()
        Me.opFormularioA = New System.Windows.Forms.ToolStripMenuItem()
        Me.opFormularioB = New System.Windows.Forms.ToolStripMenuItem()
        Me.opFormularioC = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuReportes = New System.Windows.Forms.ToolStripMenuItem()
        Me.opReporte1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.opReporte2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.opReporte3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuArchivo.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuArchivo
        '
        Me.menuArchivo.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.menuArchivo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BarraMenusFormPadre, Me.menuFormularios, Me.menuReportes})
        Me.menuArchivo.Location = New System.Drawing.Point(0, 0)
        Me.menuArchivo.Name = "menuArchivo"
        Me.menuArchivo.Size = New System.Drawing.Size(800, 30)
        Me.menuArchivo.TabIndex = 1
        Me.menuArchivo.Text = "MenuStrip1"
        '
        'BarraMenusFormPadre
        '
        Me.BarraMenusFormPadre.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoCerrar})
        Me.BarraMenusFormPadre.Name = "BarraMenusFormPadre"
        Me.BarraMenusFormPadre.Size = New System.Drawing.Size(73, 24)
        Me.BarraMenusFormPadre.Text = "Archivo"
        '
        'ArchivoCerrar
        '
        Me.ArchivoCerrar.Name = "ArchivoCerrar"
        Me.ArchivoCerrar.Size = New System.Drawing.Size(224, 26)
        Me.ArchivoCerrar.Text = "Cerrar"
        '
        'menuFormularios
        '
        Me.menuFormularios.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.opFormularioCRUD, Me.opFormularioA, Me.opFormularioB, Me.opFormularioC})
        Me.menuFormularios.Name = "menuFormularios"
        Me.menuFormularios.Size = New System.Drawing.Size(101, 26)
        Me.menuFormularios.Text = "Formularios"
        '
        'opFormularioCRUD
        '
        Me.opFormularioCRUD.Name = "opFormularioCRUD"
        Me.opFormularioCRUD.Size = New System.Drawing.Size(224, 26)
        Me.opFormularioCRUD.Text = "Formulario CRUD"
        '
        'opFormularioA
        '
        Me.opFormularioA.Name = "opFormularioA"
        Me.opFormularioA.Size = New System.Drawing.Size(224, 26)
        Me.opFormularioA.Text = "Formulario A"
        '
        'opFormularioB
        '
        Me.opFormularioB.Name = "opFormularioB"
        Me.opFormularioB.Size = New System.Drawing.Size(224, 26)
        Me.opFormularioB.Text = "Formulario B"
        '
        'opFormularioC
        '
        Me.opFormularioC.Name = "opFormularioC"
        Me.opFormularioC.Size = New System.Drawing.Size(224, 26)
        Me.opFormularioC.Text = "Formulario C"
        '
        'menuReportes
        '
        Me.menuReportes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.opReporte1, Me.opReporte2, Me.opReporte3})
        Me.menuReportes.Name = "menuReportes"
        Me.menuReportes.Size = New System.Drawing.Size(82, 26)
        Me.menuReportes.Text = "Reportes"
        '
        'opReporte1
        '
        Me.opReporte1.Name = "opReporte1"
        Me.opReporte1.Size = New System.Drawing.Size(224, 26)
        Me.opReporte1.Text = "Reporte 1"
        '
        'opReporte2
        '
        Me.opReporte2.Name = "opReporte2"
        Me.opReporte2.Size = New System.Drawing.Size(224, 26)
        Me.opReporte2.Text = "Reporte 2"
        '
        'opReporte3
        '
        Me.opReporte3.Name = "opReporte3"
        Me.opReporte3.Size = New System.Drawing.Size(224, 26)
        Me.opReporte3.Text = "Reporte 3"
        '
        'FormPadre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.menuArchivo)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.menuArchivo
        Me.Name = "FormPadre"
        Me.Text = "FormPadre"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.menuArchivo.ResumeLayout(False)
        Me.menuArchivo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menuArchivo As MenuStrip
    Friend WithEvents BarraMenusFormPadre As ToolStripMenuItem
    Friend WithEvents menuFormularios As ToolStripMenuItem
    Friend WithEvents menuReportes As ToolStripMenuItem
    Friend WithEvents ArchivoCerrar As ToolStripMenuItem
    Friend WithEvents opFormularioCRUD As ToolStripMenuItem
    Friend WithEvents opFormularioA As ToolStripMenuItem
    Friend WithEvents opFormularioB As ToolStripMenuItem
    Friend WithEvents opFormularioC As ToolStripMenuItem
    Friend WithEvents opReporte1 As ToolStripMenuItem
    Friend WithEvents opReporte2 As ToolStripMenuItem
    Friend WithEvents opReporte3 As ToolStripMenuItem
End Class
