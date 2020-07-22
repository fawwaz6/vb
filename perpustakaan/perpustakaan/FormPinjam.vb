Imports System.Data.SqlClient
Public Class FormPinjam
    Sub awal()
        lbalamat.Text = ""
        lbjudul.Text = ""
        lbnama.Text = ""
        lbtelpon.Text = ""
        lbtot.Text = "0"
        ComboBox1.Text = ""
        lbthn.Text = ""
        lbpeng.Text = ""
        lbptgs.Text = FormMenuUtama.lbstatus4.Text
        Call nomerauto()
        Call popupAnggota()
        Call kolom()

    End Sub
    Private Sub FormPinjam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call awal()
        lbtgl.Text = Today

    End Sub
    Sub popupAnggota()
        Call Koneksi()
        ComboBox1.Items.Clear()
        sql = New SqlCommand("select * from Tb_anggota", Conn)
        Dr = sql.ExecuteReader
        Do While Dr.Read
            ComboBox1.Items.Add(Dr.Item(0))
        Loop
    End Sub
    Sub munculanggota()
        Call Koneksi()
        sql = New SqlCommand("select * from Tb_anggota where KodeAnggota = '" & ComboBox1.Text & "'", Conn)
        Dr = sql.ExecuteReader
        Dr.Read()
        If Dr.HasRows Then
            lbnama.Text = Dr!NamaAnggota
            lbalamat.Text = Dr!Alamat
            lbtelpon.Text = Dr!Telepon
        End If
    End Sub
    Sub nomerauto()
        Call Koneksi()
        sql = New SqlCommand("select * from Tbl_pinjam where NoPinjam in (select max(NoPinjam) from Tbl_pinjam)", Conn)
        Dim urutkode As String
        Dim hitung As Long
        Dr = sql.ExecuteReader
        Dr.Read()
        If Not Dr.HasRows Then
            urutkode = "PNJ" + Format(Now, "yyMMdd") + "001"
        Else
            hitung = Microsoft.VisualBasic.Right(Dr.GetString(0), 9) + 1
            urutkode = "PNJ" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("000" & hitung, 3)
        End If
        lbpinjam.Text = urutkode
    End Sub
    Sub kolom()
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("Kode", "Kode Buku")
        DataGridView1.Columns.Add("Judul", "Judul Buku")
        DataGridView1.Columns.Add("Pengarang", "Pengarang")
        DataGridView1.Columns.Add("Penerbit", "Penerbit")
        DataGridView1.Columns.Add("Jumlah", "Jumlah")

    End Sub
    Sub totalbuku()
        Dim hitungitem As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            hitungitem = hitungitem + DataGridView1.Rows(i).Cells(4).Value
            lbtot.Text = hitungitem
        Next
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbjam.Text = TimeOfDay
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call munculanggota()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Koneksi()
            sql = New SqlCommand("Select * from Tb_buku where Kodebuku= '" & TextBox1.Text & "'", Conn)
            Dr = sql.ExecuteReader
            Dr.Read()
            If Not Dr.HasRows Then
                MsgBox("Kode Buku tidak ada")
            Else
                TextBox1.Text = Dr.Item("KodeBuku")
                lbjudul.Text = Dr.Item("JudulBuku")
                lbpeng.Text = Dr.Item("Pengarang")
                lbthn.Text = Dr.Item("Tahun")
                TextBox2.Enabled = True
                TextBox2.Text = "1"
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If lbtot.Text >= 5 Or Val(lbtot.Text) + Val(TextBox2.Text) > 5 Then
            MsgBox("buku yang dipinjam melebihi maksimal !")
        Else
            If lbjudul.Text = "" Or TextBox2.Text = "" Then
                MsgBox("Silahkan masukan kode Buku dan Tekan ENTER!")
            Else
                DataGridView1.Rows.Add(New String() {TextBox1.Text, lbjudul.Text, lbpeng.Text, lbthn.Text, TextBox2.Text})
                TextBox1.Text = ""
                TextBox2.Text = ""
                lbjudul.Text = ""
                lbpeng.Text = ""
                lbthn.Text = ""
                Call totalbuku()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If lbnama.Text = "" Then
            MsgBox("tidak dapat bertransaksi")
        Else
            Call Koneksi()
            Dim tglsql As String
            tglsql = Format(Today, "yyyy-MM-dd")
            lbjam.Text = Format(Now, "hh:mm:ss")
            Dim pinjam As String = "insert into Tbl_pinjam values ('" & lbpinjam.Text & "', '" & tglsql & "', '" & lbjam.Text & "', '" & ComboBox1.Text & "', '" & lbtot.Text & "', '" & lbtot.Text & "', '" & FormMenuUtama.lbstatus2.Text & "')"
            sql = New SqlCommand(pinjam, Conn)
            sql.ExecuteNonQuery()

            For baris As Integer = 0 To DataGridView1.Rows.Count - 2
                Call Koneksi()
                Dim simpandetail As String = " insert into Tb_detail values ('" & lbpinjam.Text & "', '" & DataGridView1.Rows(baris).Cells(0).Value & "', '" & DataGridView1.Rows(baris).Cells(1).Value & "', '" & DataGridView1.Rows(baris).Cells(4).Value & "')"
                sql = New SqlCommand(simpandetail, Conn)
                Dr = sql.ExecuteReader
                Dr.Read()
                Call Koneksi()
                sql = New SqlCommand("select * from Tb_buku where KodeBuku = '" & DataGridView1.Rows(baris).Cells(0).Value & "'", Conn)
                Dr = sql.ExecuteReader
                Dr.Read()
                Call Koneksi()
                Dim kurang As String = "update Tb_buku set JumlahBuku ='" & Dr.Item("JumlahBuku") - DataGridView1.Rows(baris).Cells(4).Value & "' where KodeBuku ='" & DataGridView1.Rows(baris).Cells(0).Value & "'"
                sql = New SqlCommand(kurang, Conn)
                sql.ExecuteNonQuery()
            Next
            Call awal()
            MsgBox("Transaksi Berhasil disimpan")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call awal()
    End Sub
End Class