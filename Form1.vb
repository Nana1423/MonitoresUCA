Imports System.Data.SqlClient

Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsCiudades.Ciudad' table. You can move, or remove it, as needed.
        Me.CiudadTableAdapter.Fill(Me.DsCiudades.Ciudad)
        MostrarPosicion()

    End Sub
    Public Sub MostrarPosicion()
        Dim iTotal As Integer = CiudadBindingSource.Count
        Dim iPos As Integer
        If iTotal = 0 Then
            etPosicion.Text = "No. de registros"
        Else
            iPos = CiudadBindingSource.Position + 1
            etPosicion.Text = iPos.ToString & "de" & iTotal.ToString()
        End If
    End Sub



    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btAgregar.Click
        Dim miTabla As DataTable = DsCiudades.Ciudad
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

    Private Sub ctId_TextChanged(sender As Object, e As EventArgs) Handles ctId.TextChanged

    End Sub

    Private Sub btPrimero_Click(sender As Object, e As EventArgs) Handles btPrimero.Click
        CiudadBindingSource.Position = 0
        MostrarPosicion()
    End Sub

    Private Sub btAnterior_Click(sender As Object, e As EventArgs) Handles btAnterior.Click
        CiudadBindingSource.Position -= 1
        MostrarPosicion()
    End Sub

    Private Sub btSiguiente_Click(sender As Object, e As EventArgs) Handles btSiguiente.Click
        CiudadBindingSource.Position += 1
        MostrarPosicion()
    End Sub

    Private Sub btUltimo_Click(sender As Object, e As EventArgs) Handles btUltimo.Click
        CiudadBindingSource.Position = CiudadBindingSource.Count - 1
        MostrarPosicion()
    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        Dim cmd As New SqlCommand()
        If Me.Validate Then
            Try
                If (DsCiudades.HasChanges()) Then
                    Me.CiudadBindingSource.EndEdit()
                    Me.CiudadTableAdapter.Update(Me.DsCiudades.Ciudad)
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
        Dim miTabla As DataTable = DsCiudades.Ciudad
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
                CiudadBindingSource.Position = cFilas.IndexOf(filaBuscada(i))
                MostrarPosicion()
                Exit For
            End If
        Next i
    End Sub
End Class
