<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.components = New System.ComponentModel.Container()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.bs_Sekolah = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_Sekolah = New WindowsApplication1.DataSet_Sekolah()
        Me.lbl_Nama = New System.Windows.Forms.Label()
        Me.lbl_Telp = New System.Windows.Forms.Label()
        Me.lbl_Akreditasi = New System.Windows.Forms.Label()
        Me.btnMundur = New System.Windows.Forms.Button()
        Me.btnMaju = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_Alamat = New System.Windows.Forms.Label()
        Me.lbl_Link = New System.Windows.Forms.Label()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.TbSekolahTableAdapter = New WindowsApplication1.DataSet_SekolahTableAdapters.tbSekolahTableAdapter()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.bs_Sekolah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_Sekolah, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TableLayoutPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.WebBrowser1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1378, 644)
        Me.SplitContainer1.SplitterDistance = 774
        Me.SplitContainer1.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.38542!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.61459!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_Nama, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_Telp, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_Akreditasi, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.btnMundur, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.btnMaju, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_Alamat, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_Link, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 223.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(774, 644)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Sylfaen", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 504)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 42)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Link"
        Me.Label6.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bs_Sekolah, "ID", True))
        Me.Label7.Font = New System.Drawing.Font("Sylfaen", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(222, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 36)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Label7"
        '
        'bs_Sekolah
        '
        Me.bs_Sekolah.DataMember = "tbSekolah"
        Me.bs_Sekolah.DataSource = Me.DataSet_Sekolah
        '
        'DataSet_Sekolah
        '
        Me.DataSet_Sekolah.DataSetName = "DataSet_Sekolah"
        Me.DataSet_Sekolah.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lbl_Nama
        '
        Me.lbl_Nama.AutoSize = True
        Me.lbl_Nama.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bs_Sekolah, "Nama_Sekolah", True))
        Me.lbl_Nama.Font = New System.Drawing.Font("Sylfaen", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Nama.Location = New System.Drawing.Point(222, 104)
        Me.lbl_Nama.Name = "lbl_Nama"
        Me.lbl_Nama.Size = New System.Drawing.Size(92, 36)
        Me.lbl_Nama.TabIndex = 7
        Me.lbl_Nama.Text = "Label8"
        '
        'lbl_Telp
        '
        Me.lbl_Telp.AutoSize = True
        Me.lbl_Telp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bs_Sekolah, "No_Telepon", True))
        Me.lbl_Telp.Font = New System.Drawing.Font("Sylfaen", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Telp.Location = New System.Drawing.Point(222, 390)
        Me.lbl_Telp.Name = "lbl_Telp"
        Me.lbl_Telp.Size = New System.Drawing.Size(106, 36)
        Me.lbl_Telp.TabIndex = 9
        Me.lbl_Telp.Text = "Label10"
        '
        'lbl_Akreditasi
        '
        Me.lbl_Akreditasi.AutoSize = True
        Me.lbl_Akreditasi.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bs_Sekolah, "Akreditasi", True))
        Me.lbl_Akreditasi.Font = New System.Drawing.Font("Sylfaen", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Akreditasi.Location = New System.Drawing.Point(222, 442)
        Me.lbl_Akreditasi.Name = "lbl_Akreditasi"
        Me.lbl_Akreditasi.Size = New System.Drawing.Size(106, 36)
        Me.lbl_Akreditasi.TabIndex = 10
        Me.lbl_Akreditasi.Text = "Label11"
        '
        'btnMundur
        '
        Me.btnMundur.Location = New System.Drawing.Point(3, 569)
        Me.btnMundur.Name = "btnMundur"
        Me.btnMundur.Size = New System.Drawing.Size(205, 72)
        Me.btnMundur.TabIndex = 12
        Me.btnMundur.Text = "<<"
        Me.btnMundur.UseVisualStyleBackColor = True
        '
        'btnMaju
        '
        Me.btnMaju.Location = New System.Drawing.Point(222, 569)
        Me.btnMaju.Name = "btnMaju"
        Me.btnMaju.Size = New System.Drawing.Size(345, 72)
        Me.btnMaju.TabIndex = 13
        Me.btnMaju.Text = ">>"
        Me.btnMaju.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sylfaen", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 42)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "No"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sylfaen", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(208, 42)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Nama Sekolah"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sylfaen", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 42)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Alamat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Sylfaen", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 390)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(174, 42)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "No Telepon"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Sylfaen", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 442)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 42)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Akreditasi"
        '
        'lbl_Alamat
        '
        Me.lbl_Alamat.AutoSize = True
        Me.lbl_Alamat.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bs_Sekolah, "Alamat_Sekolah", True))
        Me.lbl_Alamat.Font = New System.Drawing.Font("Sylfaen", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Alamat.Location = New System.Drawing.Point(222, 167)
        Me.lbl_Alamat.Name = "lbl_Alamat"
        Me.lbl_Alamat.Size = New System.Drawing.Size(92, 36)
        Me.lbl_Alamat.TabIndex = 8
        Me.lbl_Alamat.Text = "Label9"
        '
        'lbl_Link
        '
        Me.lbl_Link.AutoSize = True
        Me.lbl_Link.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bs_Sekolah, "Link", True))
        Me.lbl_Link.Font = New System.Drawing.Font("Sylfaen", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Link.Location = New System.Drawing.Point(222, 504)
        Me.lbl_Link.Name = "lbl_Link"
        Me.lbl_Link.Size = New System.Drawing.Size(106, 36)
        Me.lbl_Link.TabIndex = 11
        Me.lbl_Link.Text = "Label12"
        Me.lbl_Link.Visible = False
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(600, 644)
        Me.WebBrowser1.TabIndex = 0
        '
        'TbSekolahTableAdapter
        '
        Me.TbSekolahTableAdapter.ClearBeforeFill = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1378, 644)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Form3"
        Me.Text = "UAS SIG K5 Map"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.bs_Sekolah, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_Sekolah, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbl_Nama As System.Windows.Forms.Label
    Friend WithEvents lbl_Alamat As System.Windows.Forms.Label
    Friend WithEvents lbl_Telp As System.Windows.Forms.Label
    Friend WithEvents lbl_Akreditasi As System.Windows.Forms.Label
    Friend WithEvents lbl_Link As System.Windows.Forms.Label
    Friend WithEvents btnMundur As System.Windows.Forms.Button
    Friend WithEvents btnMaju As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataSet_Sekolah As WindowsApplication1.DataSet_Sekolah
    Friend WithEvents bs_Sekolah As System.Windows.Forms.BindingSource
    Friend WithEvents TbSekolahTableAdapter As WindowsApplication1.DataSet_SekolahTableAdapters.tbSekolahTableAdapter
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
End Class
