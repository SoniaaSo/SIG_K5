Public Class Form2

    Private Sub mtsHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mtsHome.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub mtsDaftar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mtsDaftar.Click
        Form3.Show()
    End Sub

    Private Sub mts_Tambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mts_Tambah.Click
        Form4.Show()
    End Sub

    Private Sub Form2_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub
End Class