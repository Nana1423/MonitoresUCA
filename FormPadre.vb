Public Class FormPadre
    Private Sub ArchivoCerrar_Click(sender As Object, e As EventArgs) Handles ArchivoCerrar.Click
        Me.Close()
    End Sub

    Private Sub opFormularioCRUD_Click(sender As Object, e As EventArgs) Handles opFormularioCRUD.Click
        PantallaDePresentacion.Show()
    End Sub

    Private Sub opFormularioA_Click(sender As Object, e As EventArgs) Handles opFormularioA.Click
        FormularioA.Show()
    End Sub

    Private Sub opFormularioB_Click(sender As Object, e As EventArgs) Handles opFormularioB.Click
        FormularioB.Show()
    End Sub

    Private Sub opFormularioC_Click(sender As Object, e As EventArgs) Handles opFormularioC.Click
        FormularioC.Show()
    End Sub

    Private Sub opReporte1_Click(sender As Object, e As EventArgs) Handles opReporte1.Click
        FormReporte1.Show()
    End Sub

    Private Sub opReporte2_Click(sender As Object, e As EventArgs) Handles opReporte2.Click
        FormReporte2.Show()
    End Sub

    Private Sub opReporte3_Click(sender As Object, e As EventArgs) Handles opReporte3.Click
        FormReporte3.Show()
    End Sub
End Class