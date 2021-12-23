Imports MySql.Data.MySqlClient
Public Class supplier

    Private Sub TampilGrid()
        Call ConnDB()
        cSQL = "SELECT * FROM `supplier`;"
        da = New MySqlDataAdapter(cSQL, CN)
        dt = New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Cari()
        Call ConnDB()
        cSQL = "SELECT * FROM `supplier` where nama='" & nama.Text & "'or alamat='" & alamat.Text & "'or telp='" & nomor.Text & "'or keterangan = '" & ket.Text & "';"
        da = New MySqlDataAdapter(cSQL, CN)
        dt = New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Auto_Inc_jenis()
        cSQL = "Select right(kodesupplier ,3) As kodesupplier from supplier order by kodesupplier desc"
        da = New MySqlDataAdapter(cSQL, CN)
        dt = New DataTable
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            kode.Text = "SUP-" & Format(CInt(dt.Rows(0).Item("kodesupplier").ToString) + 1, "000")
        Else
            kode.Text = "SUP-001"
        End If
    End Sub

    Private Sub supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call TampilGrid()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call ConnDB()

        cSQL = "Select * from supplier where kodesupplier='" & kode.Text & "'"
        da = New MySqlDataAdapter(cSQL, CN)
        dt = New DataTable
        da.Fill(dt)
        If CBool(dt.Rows.Count) Then
            cSQL = "update supplier set nama='" & nama.Text & "', alamat='" & alamat.Text & "', telp='" & nomor.Text & "',keterangan='" & ket.Text & "'where kodesupplier='" & kode.Text & "'"
        Else
            cSQL = "insert into supplier values ( '" & kode.Text & "','" & nama.Text & "','" & alamat.Text & "','" & nomor.Text & "','" & ket.Text & "')"
        End If
        Call ConnDB()
        cmd = New MySqlCommand(cSQL, CN)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil Disimpan")
        Call TampilGrid()



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call TampilGrid()
        kode.Text = ""
        nama.Text = ""
        alamat.Text = ""
        nomor.Text = ""
        ket.Text = ""
        mencari.Text = ""
        Call Auto_Inc_jenis()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call ConnDB()
        cSQL = "Delete From supplier Where kodesupplier ='" & kode.Text & "'"
        cmd = New MySqlCommand(cSQL, CN)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil Di hapus")
        Call TampilGrid()
        Call Button3_Click(sender, e)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        kode.Text = CType(DataGridView1.SelectedCells(0).Value, String)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call Cari()
    End Sub
End Class