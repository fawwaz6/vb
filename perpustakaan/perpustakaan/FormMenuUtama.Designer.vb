<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuUtama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PetugasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnggotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BukuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PeminjamanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lbstatus1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbstatus2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbstatus3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbstatus4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbstatus5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbstatus6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbstatus7 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbstatus8 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbstatus9 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbstatus10 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MasterToolStripMenuItem, Me.TransaksiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PetugasToolStripMenuItem, Me.AnggotaToolStripMenuItem, Me.BukuToolStripMenuItem})
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'PetugasToolStripMenuItem
        '
        Me.PetugasToolStripMenuItem.Name = "PetugasToolStripMenuItem"
        Me.PetugasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PetugasToolStripMenuItem.Text = "Petugas"
        '
        'AnggotaToolStripMenuItem
        '
        Me.AnggotaToolStripMenuItem.Name = "AnggotaToolStripMenuItem"
        Me.AnggotaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AnggotaToolStripMenuItem.Text = "Anggota"
        '
        'BukuToolStripMenuItem
        '
        Me.BukuToolStripMenuItem.Name = "BukuToolStripMenuItem"
        Me.BukuToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BukuToolStripMenuItem.Text = "Buku"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PeminjamanToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'PeminjamanToolStripMenuItem
        '
        Me.PeminjamanToolStripMenuItem.Name = "PeminjamanToolStripMenuItem"
        Me.PeminjamanToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PeminjamanToolStripMenuItem.Text = "Peminjaman"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbstatus1, Me.lbstatus2, Me.lbstatus3, Me.lbstatus4, Me.lbstatus5, Me.lbstatus6, Me.lbstatus7, Me.lbstatus8, Me.lbstatus9, Me.lbstatus10})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lbstatus1
        '
        Me.lbstatus1.Name = "lbstatus1"
        Me.lbstatus1.Size = New System.Drawing.Size(45, 17)
        Me.lbstatus1.Text = "KODE : "
        '
        'lbstatus2
        '
        Me.lbstatus2.Name = "lbstatus2"
        Me.lbstatus2.Size = New System.Drawing.Size(0, 17)
        '
        'lbstatus3
        '
        Me.lbstatus3.Name = "lbstatus3"
        Me.lbstatus3.Size = New System.Drawing.Size(52, 17)
        Me.lbstatus3.Text = "NAMA : "
        '
        'lbstatus4
        '
        Me.lbstatus4.Name = "lbstatus4"
        Me.lbstatus4.Size = New System.Drawing.Size(0, 17)
        '
        'lbstatus5
        '
        Me.lbstatus5.Name = "lbstatus5"
        Me.lbstatus5.Size = New System.Drawing.Size(44, 17)
        Me.lbstatus5.Text = "LEVEL :"
        '
        'lbstatus6
        '
        Me.lbstatus6.Name = "lbstatus6"
        Me.lbstatus6.Size = New System.Drawing.Size(0, 17)
        '
        'lbstatus7
        '
        Me.lbstatus7.Name = "lbstatus7"
        Me.lbstatus7.Size = New System.Drawing.Size(39, 17)
        Me.lbstatus7.Text = "JAM : "
        '
        'lbstatus8
        '
        Me.lbstatus8.Name = "lbstatus8"
        Me.lbstatus8.Size = New System.Drawing.Size(0, 17)
        '
        'lbstatus9
        '
        Me.lbstatus9.Name = "lbstatus9"
        Me.lbstatus9.Size = New System.Drawing.Size(68, 17)
        Me.lbstatus9.Text = "TANGGAL : "
        '
        'lbstatus10
        '
        Me.lbstatus10.Name = "lbstatus10"
        Me.lbstatus10.Size = New System.Drawing.Size(0, 17)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'FormMenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "FormMenuUtama"
        Me.Text = "Form Menu Utama Perpusatakaan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PetugasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnggotaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PeminjamanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lbstatus1 As ToolStripStatusLabel
    Friend WithEvents lbstatus2 As ToolStripStatusLabel
    Friend WithEvents lbstatus3 As ToolStripStatusLabel
    Friend WithEvents lbstatus4 As ToolStripStatusLabel
    Friend WithEvents lbstatus5 As ToolStripStatusLabel
    Friend WithEvents lbstatus6 As ToolStripStatusLabel
    Friend WithEvents lbstatus7 As ToolStripStatusLabel
    Friend WithEvents lbstatus8 As ToolStripStatusLabel
    Friend WithEvents lbstatus9 As ToolStripStatusLabel
    Friend WithEvents lbstatus10 As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
End Class
