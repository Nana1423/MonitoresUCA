Imports System.Data.SqlClient
Imports System.Security.Cryptography.X509Certificates

Public Class FormCiudades
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsCiudades.Cuidad' Puede moverla o quitarla según sea necesario.
        Me.CuidadTableAdapter.Fill(Me.DsCiudades.Cuidad)
    End Sub

    Public Sub MostrarPosicion()
        Dim iTotal As Integer = CuidadBindingSource.Count
        Dim iPos As Integer
        If iTotal = 0 Then
            etPosicion.Text = "No. de Registros"
        Else
            iPos = CuidadBindingSource.Position + 1
            etPosicion.Text = iPos.ToString & " de " & iTotal.ToString
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btAnterior.Click
        CuidadBindingSource.Position -= 1
        MostrarPosicion()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btSiguiente.Click
        CuidadBindingSource.Position += 1
        MostrarPosicion()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btPrimero.Click
        CuidadBindingSource.Position = 0
        MostrarPosicion()
    End Sub

    Private Sub btUltimo_Click(sender As Object, e As EventArgs) Handles btUltimo.Click
        CuidadBindingSource.Position = CuidadBindingSource.Count - 1
        MostrarPosicion()
    End Sub

    Private Sub btAnadir_Click(sender As Object, e As EventArgs) Handles btAnadir.Click
        Dim miTabla As DataTable = DsCiudades.Cuidad
        Dim cfilas As DataRowCollection = miTabla.Rows
        Dim nuevaFila As DataRow
        Dim ultimafila As DataRow = miTabla.Rows(miTabla.Rows.Count - 1)
        Dim ultimoID As Integer = Convert.ToInt32(ultimafila("id"))
        Try
            nuevaFila = miTabla.NewRow()
            nuevaFila(0) = ultimoID + 1
            nuevaFila(1) = "nombre"
            nuevaFila(2) = True
            nuevaFila(3) = "observaciones"
            cfilas.Add(nuevaFila)
            btUltimo.PerformClick()
            MostrarPosicion()
            ctNombre.Focus()
        Catch ex As System.Data.ConstraintException
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btBorrar_Click(sender As Object, e As EventArgs) Handles btBorrar.Click
        Dim vistaFilaActual As DataRowView
        Dim NL As String = Environment.NewLine

        If (MessageBox.Show("Desea borrar este registro?" & NL, "Buscar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            vistaFilaActual = CuidadBindingSource.Current
            vistaFilaActual.Row.Delete()
        End If

    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        Dim cmd As New SqlCommand()
        If Me.Validate Then
            Try
                If (DsCiudades.HasChanges()) Then
                    Me.CuidadBindingSource.EndEdit()
                    Me.CuidadTableAdapter.Update(Me.DsCiudades.Cuidad)
                    MessageBox.Show("Base de datos actualizada")
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " + ex.Message)
            End Try

        Else
            MessageBox.Show(Me, "Errores de validacion.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Dim miTabla As DataTable = DsCiudades.Cuidad
        Dim cFilas As DataRowCollection = miTabla.Rows
        Dim filaBuscada() As DataRow
        Dim NL As String = Environment.NewLine
        Dim criterio As String = "Nombre Like '*" & ctBuscar.Text & "*'"

        filaBuscada = miTabla.Select(criterio)

        If (filaBuscada.GetUpperBound(0) < 0) Then
            MessageBox.Show("No se encontraron registros coincidentes", "Buscar")
            Exit Sub
        End If
        Dim i, j As Integer
        For i = 0 To filaBuscada.GetUpperBound(0)
            If (MessageBox.Show("Este es el nombre buscado?" & NL & filaBuscada(i)(1) & NL, "Buscar",
                MessageBoxButtons.YesNo) = DialogResult.Yes) Then
                CuidadBindingSource.Position = cFilas.IndexOf(filaBuscada(i))
                MostrarPosicion()
                Exit For
            End If
        Next i
    End Sub
End Class