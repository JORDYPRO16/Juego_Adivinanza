Public Class ResolucionP

    Dim random As New Random()
    Dim num1, num2, result As Integer
    Dim operador As Char
    Dim respuestasCorrectas As Integer = 0
    Dim respuestasIncorrectas As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub ResolucionP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerarProblemaMatematico()
    End Sub

    Private Sub RCT_Click(sender As Object, e As EventArgs) Handles RCT.Click

    End Sub

    Private Sub RIC_Click(sender As Object, e As EventArgs) Handles RIC.Click

    End Sub

    Private Sub BtnResolver_Click(sender As Object, e As EventArgs) Handles BtnResolver.Click

        If Not IsNumeric(TxtRespuesta.Text) Then
            MsgBox("Debes digitar un número")
        Else
            Dim respuestaCorrecta As Boolean = False

            Select Case operador
                Case "+"
                    result = num1 + num2
                    If result = TxtRespuesta.Text Then
                        respuestaCorrecta = True
                    Else
                        respuestaCorrecta = False

                    End If

                Case "-"
                    result = num1 - num2
                    If result = TxtRespuesta.Text Then

                        respuestaCorrecta = True
                    Else
                        respuestaCorrecta = False
                    End If

                Case "*"
                    result = num1 * num2
                    If result = TxtRespuesta.Text Then


                        respuestaCorrecta = True
                    Else
                        respuestaCorrecta = False
                    End If

                Case "%"
                    result = num1 + num2
                    If result = TxtRespuesta.Text Then


                        respuestaCorrecta = True
                    Else
                        respuestaCorrecta = False
                    End If
            End Select

            If respuestaCorrecta Then
                TxtRespuesta.Clear()
                GenerarProblemaMatematico()
                respuestasCorrectas += 1
                RCT.Text = respuestasCorrectas.ToString()
            Else
                TxtRespuesta.Clear()
                GenerarProblemaMatematico()
                respuestasIncorrectas += 1
                RIC.Text = respuestasIncorrectas.ToString()
            End If
        End If


    End Sub

    Private Sub GenerarProblemaMatematico()
        num1 = random.Next(1, 300)
        num2 = random.Next(1, 900)

        Dim operadores() As Char = {"+", "-", "*", "%"}
        operador = operadores(random.Next(0, operadores.Length))

        LblOP.Text = $"{num1} {operador} {num2} = ?"

    End Sub
End Class