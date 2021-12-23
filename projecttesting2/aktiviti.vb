Imports MySql.Data.MySqlClient

Module aktiviti
    Public CN As MySqlConnection


    Public cSQL As String
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public dt As DataTable
    Public dr As MySqlDataReader

    Public Sub ConnDB()
        Dim strCN As String
        Try
            strCN = "server=localhost;user id=root;password=;
                     database=inventory;allow zero datetime=true"
            CN = New MySqlConnection(strCN)

            If CN.State = ConnectionState.Open Then CN.Close()
            CN.Open()

        Catch ex As Exception
            MsgBox("Tejadi kesalahan dalam Melakukan Koneksi Ke Server, " & vbCrLf &
                   "Silahkan Cek Jaringan Komunikasi Data Anda", MsgBoxStyle.Critical,
                   "Gagal Terhubung Ke Server")
            Application.DoEvents()
        End Try

    End Sub
End Module