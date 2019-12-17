Public Class Form1

    Private Sub btnMulai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMulai.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
