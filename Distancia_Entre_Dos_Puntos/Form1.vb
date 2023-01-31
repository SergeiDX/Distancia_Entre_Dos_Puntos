Public Class Form1
    Private Sub BTNcalcular_Click(sender As Object, e As EventArgs) Handles BTNcalcular.Click
        If txtX1.Text = "" Then
            MessageBox.Show("teclea algo")
        Else
            Dim resultado As Operaciones = New Operaciones()
            txtresul.Text = resultado.Operacion(txtX2.Text, txtX1.Text, txtY2.Text, txtY1.Text)
        End If


    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        txtX1.Clear()
        txtX2.Clear()
        txtY1.Clear()
        txtY2.Clear()
        txtresul.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
