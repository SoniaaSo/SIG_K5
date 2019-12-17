Imports System.Text

Public Class Form3


    Sub map()
        Dim onlinemap As New StringBuilder
        onlinemap.Append("https://www.google.com/maps?q=")
        WebBrowser1.Navigate(onlinemap.ToString)

    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet_Sekolah.tbSekolah' table. You can move, or remove it, as needed.
        Me.TbSekolahTableAdapter.Fill(Me.DataSet_Sekolah.tbSekolah)
        Me.MdiParent = Form2
        map()

    End Sub

    Private Sub btnMundur_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMundur.Click
        bs_Sekolah.MovePrevious()
        map()
    End Sub

    Private Sub btnMaju_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMaju.Click
        bs_Sekolah.MoveNext()
        map()
    End Sub

    'Private Sub Form3_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    '   End
    'End Sub

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        WebBrowser1.ScriptErrorsSuppressed = True
    End Sub

End Class