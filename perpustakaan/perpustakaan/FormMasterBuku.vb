Imports System.Data.SqlClient
Public Class FormMasterBuku
    Sub Awal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        ComboBox1.Text = ""
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        ComboBox1.Enabled = False
        Button1.Text = "INPUT"
        Button2.Text = "EDIT"
        Button3.Text = "DELETE"
        Button4.Text = "CLOSE"
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True

        Call Koneksi()
        Da = New SqlDataAdapter("Select * from Tb_buku", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "Tb_buku")
        DataGridView1.DataSource = (Ds.Tables("Tb_buku"))

        Dim tahun As String
        tahun = Date.Now().Year
        ComboBox1.Items.Clear()
        With ComboBox1
            While tahun >= 2012
                .Items.Add(tahun)
                tahun = tahun - 1
            End While
        End With

    End Sub
    Sub fill()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        TextBox5.Enabled = True
        ComboBox1.Enabled = True
    End Sub

    Private Sub FormMasterBuku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Awal()

        TextBox1.MaxLength = 6
        TextBox2.MaxLength = 100
        TextBox3.MaxLength = 50
        TextBox4.MaxLength = 100
        ComboBox1.MaxLength = 6


    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "INPUT" Then
            Button1.Text = "SAVE"
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Text = "CANCEL"
            Call fill()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Wajib diisi semua!")
            Else
                Call Koneksi()
                Dim SimpanData As String = "insert into Tb_buku values ('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "', '" & ComboBox1.Text & "', '" & TextBox5.Text & "')"
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
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Wajib diisi semua!")
            Else
                Call Koneksi()
                Dim UbahData As String = "update Tb_buku set JudulBuku = '" & TextBox2.Text & "', Pengarang = '" & TextBox3.Text & "', Penerbit = '" & TextBox4.Text & "', Tahun = '" & ComboBox1.Text & "', JumlahBuku = '" & TextBox5.Text & "' where Kodebuku = '" & TextBox1.Text & "'"
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
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Wajib diisi semua!")
            Else
                Call Koneksi()
                Dim HapusData As String = "delete Tb_buku where Kodebuku = '" & TextBox1.Text & "'"
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
            sql = New SqlCommand("Select * from Tb_buku where Kodebuku= '" & TextBox1.Text & "'", Conn)
            Dr = sql.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                TextBox2.Text = Dr.Item("JudulBuku")
                TextBox3.Text = Dr.Item("Pengarang")
                TextBox4.Text = Dr.Item("Penerbit")
                ComboBox1.Text = Dr.Item("Tahun")
                TextBox5.Text = Dr.Item("JumlahBuku")
            Else
                MsgBox("Data tidak ada")
            End If
        End If
    End Sub
End Class