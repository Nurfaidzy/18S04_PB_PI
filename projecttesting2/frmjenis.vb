Imports MySql.Data.MySqlClient
Public Class frmjenis
    Private Sub TampilGrid()
        Call ConnDB()
        da = New MySqlDataAdapter("SELECT * FROM `jenisbarang`", CN)

        ds = New DataSet
        da.Fill(ds, "jenisbarang")
        DataGridView1.DataSource = (ds.tables("jenisbarang"))


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Call TampilGrid()
    End Sub
End Class