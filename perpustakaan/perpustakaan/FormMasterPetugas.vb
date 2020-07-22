Imports System.Data.SqlClient
Public Class FormMasterPetugas
    Sub Awal()
        Call Koneksi()
        Da = New SqlDataAdapter("Select KdPetugas, NamaPetugas, LevelUser from Tb_petugas", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "Tb_petugas")
        DataGridView1.DataSource = (Ds.Tables("Tb_petugas"))
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("admin")
        ComboBox1.Items.Add("user")
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Text = ""
        TextBox3.PasswordChar = "*"
    End Sub

    Private Sub FormMasterPetugas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Awal()
        TextBox1.MaxLength = 6
        TextBox2.MaxLength = 30
        TextBox3.MaxLength = 30
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Wajib diisi semua!")
        Else
            Call Koneksi()
            Dim SimpanData As String = "insert into Tb_petugas values ('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & ComboBox1.Text & "')"
            sql = New SqlCommand(SimpanData, Conn)
            sql.ExecuteNonQuery()
            MsgBox("Data berhasil diinput")
            Call Awal()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Wajib diisi semua!")
        Else
            Call Koneksi()
            Dim UbahData As String = "update Tb_petugas set NamaPetugas = '" & TextBox2.Text & "', PassPetugas = '" & TextBox3.Text & "', LevelUser = '" & ComboBox1.Text & "' where KdPetugas = '" & TextBox1.Text & "'"
            sql = New SqlCommand(UbahData, Conn)
            sql.ExecuteNonQuery()
            MsgBox("Data berhasil diupdate")
            Call Awal()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Wajib diisi semua!")
        Else
            Call Koneksi()
            Dim HapusData As String = "delete Tb_petugas where KdPetugas = '" & TextBox1.Text & "'"
            sql = New SqlCommand(HapusData, Conn)
            sql.ExecuteNonQuery()
            MsgBox("Data berhasil dihapus")
            Call Awal()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Koneksi()
            sql = New SqlCommand("Select * from Tb_petugas where KdPetugas= '" & TextBox1.Text & "'", Conn)
            Dr = sql.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                TextBox2.Text = Dr.Item("NamaPetugas")
                TextBox3.Text = Dr.Item("PassPetugas")
                ComboBox1.Text = Dr.Item("LevelUser")
            Else
                MsgBox("Data tidak ada")
            End If
        End If
    End Sub
End Class