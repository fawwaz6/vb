Imports System.Data.SqlClient
Public Class FormLogin
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call Koneksi()
        sql = New SqlCommand("Select * From Tb_petugas where KdPetugas = '" & TextBox1.Text & "' and PassPetugas = '" & TextBox2.Text & "'", Conn)
        Dr = sql.ExecuteReader
        Dr.Read()
        If Dr.HasRows Then
            Me.Close()
            Call unlock()
            FormMenuUtama.lbstatus2.Text = Dr!KdPetugas
            FormMenuUtama.lbstatus4.Text = Dr!NamaPetugas
            FormMenuUtama.lbstatus6.Text = Dr!LevelUser

        Else
            MsgBox("Kode Petugas atau Password Salah")
        End If

    End Sub
    Sub unlock()
        FormMenuUtama.LoginToolStripMenuItem.Enabled = False
        FormMenuUtama.LogoutToolStripMenuItem.Enabled = True
        FormMenuUtama.MasterToolStripMenuItem.Enabled = True
        FormMenuUtama.TransaksiToolStripMenuItem.Enabled = True
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = "P001"
        TextBox2.Text = "admin"
        TextBox2.PasswordChar = "*"
    End Sub
End Class