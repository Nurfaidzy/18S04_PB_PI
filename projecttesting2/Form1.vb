Imports MySql.Data.MySqlClient
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public dicoba As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            If Textbox1.Text = "" Or Textbox2.Text = "" Then
                MsgBox("Silahkan Isi User ID Dan Password dengan Benar", MsgBoxStyle.Exclamation, "Data Tidak Valid")
                Exit Sub
            End If

            Call ConnDB()
            cSQL = "Select * from login where userid='" & Textbox1.Text & "' and password='" & Textbox2.Text & "'"
            Cmd = New MySqlCommand(cSQL, CN)
            dr = Cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If dr.Read Then
                MDIParent1.Show()
                MsgBox("Selamat Datang Di aplikasi Inventori ", MsgBoxStyle.Information, "Welcome")
                Me.Hide()

            Else
                dicoba = dicoba + 1
                MsgBox("User dan Password Salah", MsgBoxStyle.Critical, "Sudah Salah " & dicoba & " Kali")
                If dicoba >= 3 Then Me.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Gagal Login")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
