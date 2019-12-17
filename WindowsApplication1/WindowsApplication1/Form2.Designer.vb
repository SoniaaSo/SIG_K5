<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mtsHome = New System.Windows.Forms.ToolStripMenuItem()
        Me.mtsDaftar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mts_Tambah = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mtsHome, Me.mtsDaftar, Me.mts_Tambah})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(829, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mtsHome
        '
        Me.mtsHome.Name = "mtsHome"
        Me.mtsHome.Size = New System.Drawing.Size(73, 29)
        Me.mtsHome.Text = "Home"
        '
        'mtsDaftar
        '
        Me.mtsDaftar.Name = "mtsDaftar"
        Me.mtsDaftar.Size = New System.Drawing.Size(140, 29)
        Me.mtsDaftar.Text = "Daftar Sekolah"
        '
        'mts_Tambah
        '
        Me.mts_Tambah.Name = "mts_Tambah"
        Me.mts_Tambah.Size = New System.Drawing.Size(153, 29)
        Me.mts_Tambah.Text = "Tambah Sekolah"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 463)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.Text = "UAS SIG K5 Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mtsHome As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mtsDaftar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mts_Tambah As System.Windows.Forms.ToolStripMenuItem
End Class
