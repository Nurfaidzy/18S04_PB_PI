Imports MySql.Data.MySqlClient
Public Class penjualananform

    Private Sub Auto_Inc_jenis()
        cSQL = "Select right(faktur ,3) As faktur from log_trans order by faktur desc"
        da = New MySqlDataAdapter(cSQL, CN)
        dt = New DataTable
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            TextBox2.Text = "FAK-" & Format(CInt(dt.Rows(0).Item("faktur").ToString) + 1, "000")
        Else
            TextBox2.Text = "FAK-001"
        End If
        CN.Close()
    End Sub

    Private Sub TampilGridCari_Barang_ya3()
        Call ConnDB()


        Try
            cSQL = "Select * from custumer"
            da = New MySqlDataAdapter(cSQL, CN)

            dt = New DataTable
            da.Fill(dt)

            cmd = New MySqlCommand(cSQL, CN)
            dr = cmd.ExecuteReader
            While dr.Read
                ComboBox1.Items.Add(dr("kodecustumer"))
            End While
        Catch ex As Exception
            CN.Close()

        End Try

    End Sub

    Private Sub TampilGridCari_Barang_ya2()
        Call ConnDB()

        cSQL = "Select * from barang WHERE kodebarang = '" & kode.Text & "'"
        da = New MySqlDataAdapter(cSQL, CN)
        dt = New DataTable
        da.Fill(dt)
        DataGridView2.DataSource = dt

        Dim hitung As String

        cmd = New MySqlCommand(cSQL, CN)
        dr = cmd.ExecuteReader
        If dr.HasRows = True Then
            dr.Read()
            nambar.Text = CType((dr!namabarang), String)
            satuan.Text = CType((dr!satuan), String)
            If CheckBox1.Checked = True Then
                hitung = CType((dr!hargajual_ecer), String)
            Else
                hitung = CType((dr!hargajual_grosir), String)
            End If
            harga.Text = hitung
        Else
        End If
        CN.Close()

    End Sub

    Private Sub TampilGridCari_Barang_ya()
        Call ConnDB()

        If TextBox7.Text = "" Then
            cSQL = "Select * from barang"
        Else
            cSQL = "Select * from barang WHERE namabarang like '%" & TextBox7.Text & "%'"
        End If
        da = New MySqlDataAdapter(cSQL, CN)
        dt = New DataTable
        da.Fill(dt)
        DataGridView2.DataSource = dt
        CN.Close()
    End Sub

    Private Sub TampilGridfaktur()
        Call ConnDB()
        cSQL = "SELECT * FROM `log_trans`;"
        da = New MySqlDataAdapter(cSQL, CN)
        dt = New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
        CN.Close()
    End Sub
    Private Sub bersih()

        ComboBox1.Text = "Pilih Data anda"
        kode.Focus()
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles kode.KeyDown
        If e.KeyCode = 112 Then
            GroupBox1.Visible = True
        End If
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        Call TampilGridCari_Barang_ya()

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
        Call TampilGridCari_Barang_ya()
    End Sub

    Private Sub DataGridView2_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView2.DoubleClick
        kode.Text = CType(DataGridView2.SelectedCells(0).Value, String)
        GroupBox1.Visible = False
    End Sub

    Private Sub kode_TextChanged(sender As Object, e As EventArgs) Handles kode.TextChanged
        Call TampilGridCari_Barang_ya2()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Call TampilGridCari_Barang_ya2()
    End Sub

    Private Sub penjualananform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call TampilGridCari_Barang_ya3()
        Call TampilGridfaktur()
        Call bersih()
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call ConnDB()



        cSQL = "Select * from log_trans where faktur='" & TextBox2.Text & "'"
        da = New MySqlDataAdapter(cSQL, CN)
        dt = New DataTable
        da.Fill(dt)
        If CBool(dt.Rows.Count) Then
            cSQL = "update log_trans set tgl='" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "', pelanggan='" & ComboBox1.Text & "', kode='" & kode.Text & "',namabarang='" & nambar.Text & "', satuan='" & satuan.Text & "',harga='" & harga.Text & "',jumlah='" & jumlah.Text & "'where faktur='" & TextBox2.Text & "'"
        Else
            cSQL = "insert into log_trans values ( '" & TextBox2.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & ComboBox1.Text & "','" & kode.Text & "','" & nambar.Text & "','" & satuan.Text & "','" & harga.Text & "','" & jumlah.Text & "')"
        End If
        Call ConnDB()
        cmd = New MySqlCommand(cSQL, CN)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil Disimpan")
        Call TampilGridfaktur()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call ConnDB()
        cSQL = "Delete From log_trans Where faktur ='" & TextBox2.Text & "'"
        cmd = New MySqlCommand(cSQL, CN)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil Di hapus")
        Call TampilGridfaktur()
        Call Button5_Click(sender, e)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        TextBox2.Text = CType(DataGridView1.SelectedCells(0).Value, String)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Call TampilGridfaktur()
        kode.Focus()
        kode.Text = ""
        ComboBox1.Text = "Pilih Data anda"
        nambar.Text = ""
        satuan.Text = ""
        harga.Text = ""
        jumlah.Text = ""
        Call Auto_Inc_jenis()
    End Sub

    Private Sub TextBox7_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox7.KeyDown
        If e.KeyCode = 27 Then
            GroupBox1.Visible = False
        End If
    End Sub

    Private Sub penjualananform_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 112 Then
            GroupBox1.Visible = True
        End If
    End Sub
End Class