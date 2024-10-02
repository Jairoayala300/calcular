Public Class Form1

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim num1 As Integer
        Dim num2 As Integer
        Dim suma, resta, mult As Integer
        Dim div As Double
        Dim potencia As Integer
        Dim raiz As Double

        num1 = Val(txtnum1.Text)
        num2 = Val(txtnum2.Text)

        suma = num1 + num2
        resta = num1 - num2
        mult = num1 * num2
        div = num1 / num2
        potencia = num1 ^ num2
        raiz = num1 ^ (1 / num2)

        txtsuma.Text = suma
        txtresta.Text = resta
        txtmulti.Text = mult
        txtdivision.Text = div
        txtpotencia.Text = potencia
        txtraiz.Text = raiz


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtsuma.Clear()
        txtresta.Clear()
        txtmulti.Clear()
        txtdivision.Clear()
        txtpotencia.Clear()
        txtraiz.Clear()
    End Sub
End Class
