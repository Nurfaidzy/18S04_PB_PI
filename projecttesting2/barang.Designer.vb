<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class barang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.kodebarang = New System.Windows.Forms.TextBox()
        Me.namabarang = New System.Windows.Forms.TextBox()
        Me.hargabeli = New System.Windows.Forms.TextBox()
        Me.grosir = New System.Windows.Forms.TextBox()
        Me.hargaeceran = New System.Windows.Forms.TextBox()
        Me.satuan = New System.Windows.Forms.ComboBox()
        Me.jenisbarang = New System.Windows.Forms.ComboBox()
        Me.jumlahstock = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(236, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(236, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(236, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Satuan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(236, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jenis Barang"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(236, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Harga Beli"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(236, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Harga Jual Grosir"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(236, 175)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Harga Jual Eceran"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(596, 123)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Jumlah Stock"
        '
        'kodebarang
        '
        Me.kodebarang.Location = New System.Drawing.Point(334, 14)
        Me.kodebarang.Name = "kodebarang"
        Me.kodebarang.ReadOnly = True
        Me.kodebarang.Size = New System.Drawing.Size(163, 20)
        Me.kodebarang.TabIndex = 8
        '
        'namabarang
        '
        Me.namabarang.Location = New System.Drawing.Point(334, 40)
        Me.namabarang.Name = "namabarang"
        Me.namabarang.Size = New System.Drawing.Size(163, 20)
        Me.namabarang.TabIndex = 9
        '
        'hargabeli
        '
        Me.hargabeli.Location = New System.Drawing.Point(334, 120)
        Me.hargabeli.Name = "hargabeli"
        Me.hargabeli.Size = New System.Drawing.Size(163, 20)
        Me.hargabeli.TabIndex = 10
        '
        'grosir
        '
        Me.grosir.Location = New System.Drawing.Point(334, 146)
        Me.grosir.Name = "grosir"
        Me.grosir.Size = New System.Drawing.Size(163, 20)
        Me.grosir.TabIndex = 11
        '
        'hargaeceran
        '
        Me.hargaeceran.Location = New System.Drawing.Point(334, 172)
        Me.hargaeceran.Name = "hargaeceran"
        Me.hargaeceran.Size = New System.Drawing.Size(163, 20)
        Me.hargaeceran.TabIndex = 12
        '
        'satuan
        '
        Me.satuan.FormattingEnabled = True
        Me.satuan.Items.AddRange(New Object() {"Kotak", "Kg", "Liter"})
        Me.satuan.Location = New System.Drawing.Point(334, 66)
        Me.satuan.Name = "satuan"
        Me.satuan.Size = New System.Drawing.Size(428, 21)
        Me.satuan.TabIndex = 16
        '
        'jenisbarang
        '
        Me.jenisbarang.FormattingEnabled = True
        Me.jenisbarang.Items.AddRange(New Object() {"Baku", "Cair"})
        Me.jenisbarang.Location = New System.Drawing.Point(334, 93)
        Me.jenisbarang.Name = "jenisbarang"
        Me.jenisbarang.Size = New System.Drawing.Size(428, 21)
        Me.jenisbarang.TabIndex = 17
        '
        'jumlahstock
        '
        Me.jumlahstock.Location = New System.Drawing.Point(503, 147)
        Me.jumlahstock.Name = "jumlahstock"
        Me.jumlahstock.Size = New System.Drawing.Size(259, 45)
        Me.jumlahstock.TabIndex = 18
        Me.jumlahstock.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(239, 200)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Simpan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(320, 200)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Hapus"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(406, 200)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Batal"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(488, 201)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(193, 20)
        Me.TextBox6.TabIndex = 22
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(687, 198)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 23
        Me.Button4.Text = "Refresh"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 227)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(958, 218)
        Me.DataGridView1.TabIndex = 24
        '
        'barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 457)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.jumlahstock)
        Me.Controls.Add(Me.jenisbarang)
        Me.Controls.Add(Me.satuan)
        Me.Controls.Add(Me.hargaeceran)
        Me.Controls.Add(Me.grosir)
        Me.Controls.Add(Me.hargabeli)
        Me.Controls.Add(Me.namabarang)
        Me.Controls.Add(Me.kodebarang)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "barang"
        Me.Text = "Form Barang"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents kodebarang As TextBox
    Friend WithEvents namabarang As TextBox
    Friend WithEvents hargabeli As TextBox
    Friend WithEvents grosir As TextBox
    Friend WithEvents hargaeceran As TextBox
    Friend WithEvents satuan As ComboBox
    Friend WithEvents jenisbarang As ComboBox
    Friend WithEvents jumlahstock As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
