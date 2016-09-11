Public Class Form1
    Private Sub CalcButton_Click(sender As Object, e As EventArgs) Handles CalcButton.Click
        Dim total As Integer
        Dim pikachu As Integer
        Dim squirtle As Integer
        Dim charmander As Integer
        Dim costtotal As Integer
        Dim pikachutot As Integer
        Dim squirtletot As Integer
        Dim charmandertot As Integer
        Dim outputlabel1 As Decimal


        pikachu = PikachuTextBox.Text
        squirtle = SquirtleTextBox.Text
        charmander = CharmanderTextBox.Text
        total = pikachu + squirtle + charmander

        pikachutot = pikachu * 6
        squirtletot = squirtle * 5
        charmandertot = charmander * 5
        costtotal = pikachutot + squirtletot + charmandertot

        If pikachu = 1 AndAlso squirtle = 1 AndAlso charmander = 1 Then
            outputlabel1 = 12.8

        ElseIf pikachu = 2 AndAlso squirtle = 1 AndAlso charmander = 1 Then
            outputlabel1 = 18.8
        ElseIf pikachu = 2 AndAlso squirtle = 1 AndAlso charmander = 0 Then
            outputlabel1 = 15.9


        ElseIf pikachu = 2 AndAlso squirtle = 0 AndAlso charmander = 0 Then
            outputlabel1 = costtotal

        Else
            If PikachuTextBox.Text = SquirtleTextBox.Text Then

                If total = 2 Or total = 4 Or total = 6 Then
                    outputlabel1 = costtotal - (0.1 * costtotal)
                ElseIf total = 3 Or total = 6 Or total = 9 Then
                    outputlabel1 = costtotal - (0.1 * costtotal)
                Else
                    outputlabel1 = costtotal
                End If
            Else
                If PikachuTextBox.Text = CharmanderTextBox.Text Then
                    If total = 2 Or total = 4 Or total = 6 Then
                        outputlabel1 = costtotal - (0.1 * costtotal)
                    ElseIf total = 3 Or total = 6 Or total = 9 Then
                        outputlabel1 = costtotal - (0.1 * costtotal)
                    Else
                        outputlabel1 = costtotal
                    End If
                Else
                    If CharmanderTextBox.Text = SquirtleTextBox.Text Then
                        If total = 2 Or total = 4 Or total = 6 Then
                            outputlabel1 = costtotal - (0.1 * costtotal)
                        ElseIf total = 3 Or total = 6 Or total = 9 Then
                            outputlabel1 = costtotal - (0.1 * costtotal)
                        Else
                            outputlabel1 = costtotal
                        End If
                    Else
                        outputlabel1 = costtotal
                    End If
                End If
            End If
        End If
        OutputLabel.Text = outputlabel1.ToString("C2")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
