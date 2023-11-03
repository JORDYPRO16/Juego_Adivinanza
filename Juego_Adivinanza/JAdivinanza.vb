Public Class Form1
    Dim Random As New Random()
    Dim numeroAleatorio As Integer = Random.Next(100, 1000)
    Dim intentos As Integer = 5
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lblintetos.Text = intentos
    End Sub
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub

    Private Sub BtnAdivinar_Click(sender As Object, e As EventArgs) Handles BtnAdivinar.Click
        Dim NumeroDigitado As Integer

        intentos -= 1 ' Resta un intento antes de verificar el número
        Lblintetos.Text = intentos ' Actualiza el valor de Lblintetos

        If Not IsNumeric(TxtNumeroD.Text) Then
            MsgBox("Debes digitar un número")
        Else
            NumeroDigitado = CInt(TxtNumeroD.Text)
            If NumeroDigitado = numeroAleatorio Then
                LblMensaje.Text = "Felicitaciones, LOGRASTE ADIVINAR EL NÚMERO " + CStr(numeroAleatorio)
            ElseIf NumeroDigitado < numeroAleatorio Then
                LblMensaje.Text = "El número a adivinar es mayor"
                TxtNumeroD.Clear()
            Else
                LblMensaje.Text = "El número a adivinar es menor"
                TxtNumeroD.Clear()
            End If
        End If

        If intentos = 0 Then
            LblMensaje.Text = "Ya no tienes intentos, vuelve a intentarlo"
            BtnAdivinar.Enabled = False
            BtnJDN.Enabled = True ' Habilita el botón para jugar de nuevo
        End If
    End Sub

    Private Sub BtnJDN_Click(sender As Object, e As EventArgs) Handles BtnJDN.Click
        ' Restablece el juego para jugar de nuevo
        intentos = 5 ' Establece el número de intentos deseado
        Lblintetos.Text = intentos
        BtnAdivinar.Enabled = True
        BtnJDN.Enabled = False
        ' Genera un nuevo número aleatorio si es necesario
        ' númeroAleatorio = ... (genera un nuevo número aleatorio)


    End Sub
End Class
