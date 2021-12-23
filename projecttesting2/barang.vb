Imports MySql.Data.MySqlClient

Public Class barang
    Private Sub TampilGrid()
        Call ConnDB()
        cSQL = "SELECT kodebarang, namabarang, satuan, stok, hargabeli, hargajual_grosir, hargajual_ecer,tglentry,userid FROM `barang`;"
        da = New MySqlDataAdapter(cSQL, CN)
        dt = New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Cari()
        Call ConnDB()
        cSQL = "SELECT * FROM `barang` where namabarang='" & TextBox6.Text & "'or kodebarang='" & TextBox6.Text & "'or tglentry='" & TextBox6.Text & "';"
        da = New MySqlDataAdapter(cSQL, CN)
        dt = New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Auto_Inc_jenis()
        cSQL = "Select right(kodebarang,3) As kodebarang from barang order by kodebarang desc"
        da = New MySqlDataAdapter(cSQL, CN)
        dt = New DataTable
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            kodebarang.Text = "K-" & Format(CInt(dt.Rows(0).Item("kodebarang").ToString) + 1, "000")
        Else
            kodebarang.Text = "K-001"
        End If
    End Sub

    Private Sub barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call TampilGrid()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call ConnDB()

        Dim tanggal As String
        tanggal = Format(Now, "yyyy-MM-dd")

        cSQL = "Select * from barang where kodebarang='" & kodebarang.Text & "'"
        da = New MySqlDataAdapter(cSQL, CN)
        dt = New DataTable
        da.Fill(dt)
        If CBool(dt.Rows.Count) Then
            cSQL = "update barang set namabarang='" & namabarang.Text & "',kodejenis='" & 0 & "',satuan='" & satuan.Text & "',stok='" & jumlahstock.Text & "',hargabeli='" & hargabeli.Text & "',hargajual_grosir='" & grosir.Text & "',hargajual_ecer='" & hargaeceran.Text & "',tglentry='" & tanggal & "',userid='" & 1 & "'where kodebarang='" & kodebarang.Text & "'"
        Else
            cSQL = "insert into barang values ( '" & kodebarang.Text & "','" & namabarang.Text & "','" & 0 & "','" & satuan.Text & "','" & jumlahstock.Text & "','" & hargabeli.Text & "','" & grosir.Text & "','" & hargaeceran.Text & "','" & tanggal & "','" & 1 & "')"
        End If
        Call ConnDB()
        cmd = New MySqlCommand(cSQL, CN)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil Disimpan")
        Call TampilGrid()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call TampilGrid()
        kodebarang.Text = ""
        namabarang.Text = ""
        satuan.Text = ""
        jumlahstock.Text = ""
        hargabeli.Text = ""
        grosir.Text = ""
        hargaeceran.Text = ""
        Call Auto_Inc_jenis()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call ConnDB()
        cSQL = "Delete From barang Where kodebarang='" & kodebarang.Text & "'"
        cmd = New MySqlCommand(cSQL, CN)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil Di hapus")
        Call TampilGrid()
        Call Button3_Click(sender, e)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        kodebarang.Text = CType(DataGridView1.SelectedCells(0).Value, String)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call Cari()
    End Sub

End Class