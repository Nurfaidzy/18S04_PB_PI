Imports MySql.Data.MySqlClient
Public Class frmjenis
    Private Sub Auto_Inc_jenis()
        cSQL = "Select right(idjenis,3) as idjenis from jenisbarang order by idjenis desc"
        da = New MySqlDataAdapter(cSQL, CN)
        dt = New DataTable
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            TextBox1.Text = "J-" & Format(CInt(dt.Rows(0).Item("idjenis").ToString) + 1, "000")
        Else
            TextBox1.Text = "J-001"
        End If
    End Sub

    Private Sub TampilGrid()
        Call ConnDB()
        cSQL = "Select * from jenisbarang order by jenisbarang"
        da = New MySqlDataAdapter(cSQL, CN)
        dt = New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub frmjenis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call TampilGrid()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call ConnDB()
        cSQL = "select * from jenisbarang where idjenis='" & TextBox1.Text & "'"
        da = New MySqlDataAdapter(cSQL, CN)
        dt = New DataTable
        da.Fill(dt)
        If CBool(dt.Rows.Count) Then
            cSQL = "update jenisbarang set jenisbarang='" & TextBox2.Text & "'where idjenis='" & TextBox1.Text & "'"
        Else
            cSQL = "insert into jenisbarang (idjenis,jenisbarang) values ( '" & TextBox1.Text & "','" & TextBox2.Text & "')"
        End If
        Call ConnDB()
        cmd = New MySqlCommand(cSQL, CN)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil Disimpan")
        Call TampilGrid()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call TampilGrid()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox2.Focus()
        Call Auto_Inc_jenis()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call ConnDB()
        cSQL = "Delete From jenisbarang Where idjenis='" & TextBox1.Text & "'"
        cmd = New MySqlCommand(cSQL, CN)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil Di hapus")
        Call TampilGrid()
        Call Button3_Click(sender, e)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        TextBox1.Text = CType(DataGridView1.SelectedCells(0).Value, String)
    End Sub
End Class