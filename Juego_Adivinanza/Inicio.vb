Public Class InicioJuegos
    Private Sub InicioJuegos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub BtnJAdivinanza_Click(sender As Object, e As EventArgs) Handles BtnJAdivinanza.Click
        MsgBox("Suerte Adivinando")
        Form1.ShowDialog()

    End Sub

    Private Sub BtnRProblemas_Click(sender As Object, e As EventArgs) Handles BtnRProblemas.Click
        MsgBox("Buena suerte resolviendo problemas")
        ResolucionP.ShowDialog()

    End Sub
End Class