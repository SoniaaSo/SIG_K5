Public Class Form4

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet_Sekolah.tbSekolah' table. You can move, or remove it, as needed.
        Me.TbSekolahTableAdapter.Fill(Me.DataSet_Sekolah.tbSekolah)
        Me.MdiParent = Form2
    End Sub

    Private Sub tsb_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_Save.Click
        bs_Sekolah.EndEdit()
        TbSekolahTableAdapter.Update(DataSet_Sekolah.tbSekolah)
    End Sub

    'Private Sub Form4_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    '   End
    'End Sub
End Class