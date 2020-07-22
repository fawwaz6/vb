Imports System.Data.SqlClient
Public Class FormMasterAnggota
    Sub Awal()
        Call Koneksi()
        Da = New SqlDataAdapter("Select * from Tb_anggota", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "Tb_anggota")
        DataGridView1.DataSource = (Ds.Tables("Tb_anggota"))
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("Pria")
        ComboBox1.Items.Add("Wanita")
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ComboBox1.Text = ""
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        ComboBox1.Enabled = False
        Button1.Text = "INPUT"
        Button2.Text = "EDIT"
        Button3.Text = "DELETE"
        Button4.Text = "CLOSE"
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
    End Sub
    Sub fill()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        ComboBox1.Enabled = True
    End Sub

    Private Sub FormMasterAnggota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Awal()
        TextBox1.MaxLength = 6
        TextBox2.MaxLength = 30
        TextBox3.MaxLength = 100
        TextBox4.MaxLength = 15

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "INPUT" Then
            Button1.Text = "SAVE"
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Text = "CANCEL"
            Call fill()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Wajib diisi semua!")
            Else
                Call Koneksi()
                Dim SimpanData As String = "insert into Tb_anggota values ('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & ComboBox1.Text & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "')"
                sql = New SqlCommand(SimpanData, Conn)
                sql.ExecuteNonQuery()
                MsgBox("Data berhasil diinput")
                Call Awal()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text = "EDIT" Then
            Button2.Text = "SAVE"
            Button1.Enabled = False
            Button3.Enabled = False
            Button4.Text = "CANCEL"
            Call fill()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Wajib diisi semua!")
            Else
                Call Koneksi()
                Dim UbahData As String = "update Tb_anggota set NamaAnggota = '" & TextBox2.Text & "', Alamat = '" & TextBox3.Text & "', Telepon = '" & TextBox4.Text & "', JenisKelamin = '" & ComboBox1.Text & "' where KodeAnggota = '" & TextBox1.Text & "'"
                sql = New SqlCommand(UbahData, Conn)
                sql.ExecuteNonQuery()
                MsgBox("Data berhasil diupdate")
                Call Awal()
            End If
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Button3.Text = "DELETE" Then
            Button3.Text = "DELETE!"
            Button1.Enabled = False
            Button2.Enabled = False
            Button4.Text = "CANCEL"
            Call fill()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Wajib diisi semua!")
            Else
                Call Koneksi()
                Dim HapusData As String = "delete Tb_anggota where KodeAnggota = '" & TextBox1.Text & "'"
                sql = New SqlCommand(HapusData, Conn)
                sql.ExecuteNonQuery()
                MsgBox("Data berhasil dihapus")
                Call Awal()
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Button4.Text = "CLOSE" Then
            Me.Close()
        Else
            Call Awal()
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Koneksi()
            sql = New SqlCommand("Select * from Tb_anggota where KodeAnggota= '" & TextBox1.Text & "'", Conn)
            Dr = sql.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                TextBox2.Text = Dr.Item("NamaAnggota")
                ComboBox1.Text = Dr.Item("JenisKelamin")
                TextBox3.Text = Dr.Item("Alamat")
                TextBox4.Text = Dr.Item("Telepon")
            Else
                MsgBox("Data tidak ada")
            End If
        End If
    End Sub
End Class