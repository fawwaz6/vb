USE [dbPerpus]
GO
/****** Object:  Table [dbo].[Tb_anggota]    Script Date: 22/07/2020 18.41.36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tb_anggota](
	[KodeAnggota] [varchar](6) NOT NULL,
	[NamaAnggota] [varchar](30) NULL,
	[JenisKelamin] [varchar](20) NULL,
	[Alamat] [varchar](100) NULL,
	[Telepon] [varchar](15) NULL,
 CONSTRAINT [PK_Tb_anggota] PRIMARY KEY CLUSTERED 
(
	[KodeAnggota] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tb_buku]    Script Date: 22/07/2020 18.41.36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tb_buku](
	[KodeBuku] [varchar](6) NOT NULL,
	[JudulBuku] [varchar](100) NULL,
	[Pengarang] [varchar](50) NULL,
	[Penerbit] [varchar](100) NULL,
	[Tahun] [varchar](4) NULL,
	[JumlahBuku] [numeric](18, 0) NULL,
 CONSTRAINT [PK_Tb_buku] PRIMARY KEY CLUSTERED 
(
	[KodeBuku] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tb_detail]    Script Date: 22/07/2020 18.41.36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tb_detail](
	[NoPinjam] [varchar](12) NULL,
	[KodeBuku] [varchar](6) NULL,
	[JudulBuku] [varchar](100) NULL,
	[JumlahBuku] [numeric](18, 0) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tb_petugas]    Script Date: 22/07/2020 18.41.36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tb_petugas](
	[KdPetugas] [varchar](6) NOT NULL,
	[NamaPetugas] [varchar](30) NULL,
	[PassPetugas] [varchar](30) NULL,
	[LevelUser] [varchar](10) NULL,
 CONSTRAINT [PK_Tb_petugas] PRIMARY KEY CLUSTERED 
(
	[KdPetugas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tbl_pinjam]    Script Date: 22/07/2020 18.41.36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tbl_pinjam](
	[NoPinjam] [varchar](12) NOT NULL,
	[TglPinjam] [date] NULL,
	[JamPinjam] [time](7) NULL,
	[KodeAnggota] [varchar](6) NULL,
	[ItemPinjam] [numeric](18, 0) NULL,
	[TotalPinjam] [numeric](18, 0) NULL,
	[KdPetugas] [varchar](6) NULL,
 CONSTRAINT [PK_Tbl_pinjam] PRIMARY KEY CLUSTERED 
(
	[NoPinjam] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Tb_anggota] ([KodeAnggota], [NamaAnggota], [JenisKelamin], [Alamat], [Telepon]) VALUES (N'AG0001', N'Fawwaz', N'Pria', N'Cikarang', N'0821082199')
INSERT [dbo].[Tb_buku] ([KodeBuku], [JudulBuku], [Pengarang], [Penerbit], [Tahun], [JumlahBuku]) VALUES (N'BK002', N'Belajar VB', N'Multimedia', N'Sosial Media', N'2015', CAST(8 AS Numeric(18, 0)))
INSERT [dbo].[Tb_buku] ([KodeBuku], [JudulBuku], [Pengarang], [Penerbit], [Tahun], [JumlahBuku]) VALUES (N'BK003', N'Framework CodeIgniter', N'phpMyadmin', N'Xampp', N'2020', CAST(9 AS Numeric(18, 0)))
INSERT [dbo].[Tb_detail] ([NoPinjam], [KodeBuku], [JudulBuku], [JumlahBuku]) VALUES (N'PNJ200722001', N'BK003', N'Framework CodeIgniter', CAST(1 AS Numeric(18, 0)))
INSERT [dbo].[Tb_detail] ([NoPinjam], [KodeBuku], [JudulBuku], [JumlahBuku]) VALUES (N'PNJ200722002', N'BK003', N'Framework CodeIgniter', CAST(1 AS Numeric(18, 0)))
INSERT [dbo].[Tb_detail] ([NoPinjam], [KodeBuku], [JudulBuku], [JumlahBuku]) VALUES (N'PNJ200722003', N'BK002', N'Belajar VB', CAST(1 AS Numeric(18, 0)))
INSERT [dbo].[Tb_detail] ([NoPinjam], [KodeBuku], [JudulBuku], [JumlahBuku]) VALUES (N'PNJ200722004', N'BK003', N'Framework CodeIgniter', CAST(1 AS Numeric(18, 0)))
INSERT [dbo].[Tb_detail] ([NoPinjam], [KodeBuku], [JudulBuku], [JumlahBuku]) VALUES (N'PNJ200722005', N'BK002', N'Belajar VB', CAST(1 AS Numeric(18, 0)))
INSERT [dbo].[Tb_detail] ([NoPinjam], [KodeBuku], [JudulBuku], [JumlahBuku]) VALUES (N'PNJ200722006', N'BK003', N'Framework CodeIgniter', CAST(1 AS Numeric(18, 0)))
INSERT [dbo].[Tb_detail] ([NoPinjam], [KodeBuku], [JudulBuku], [JumlahBuku]) VALUES (N'PNJ200722007', N'BK003', N'Framework CodeIgniter', CAST(1 AS Numeric(18, 0)))
INSERT [dbo].[Tb_petugas] ([KdPetugas], [NamaPetugas], [PassPetugas], [LevelUser]) VALUES (N'P001', N'admin', N'admin', N'admin')
INSERT [dbo].[Tb_petugas] ([KdPetugas], [NamaPetugas], [PassPetugas], [LevelUser]) VALUES (N'P002', N'user', N'user', N'user')
INSERT [dbo].[Tbl_pinjam] ([NoPinjam], [TglPinjam], [JamPinjam], [KodeAnggota], [ItemPinjam], [TotalPinjam], [KdPetugas]) VALUES (N'PNJ200722001', CAST(N'2020-07-22' AS Date), CAST(N'00:00:00' AS Time), N'AG0001', CAST(1 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), N'P001')
INSERT [dbo].[Tbl_pinjam] ([NoPinjam], [TglPinjam], [JamPinjam], [KodeAnggota], [ItemPinjam], [TotalPinjam], [KdPetugas]) VALUES (N'PNJ200722002', CAST(N'2020-07-22' AS Date), CAST(N'00:00:00' AS Time), N'AG0001', CAST(1 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), N'P001')
INSERT [dbo].[Tbl_pinjam] ([NoPinjam], [TglPinjam], [JamPinjam], [KodeAnggota], [ItemPinjam], [TotalPinjam], [KdPetugas]) VALUES (N'PNJ200722003', CAST(N'2020-07-22' AS Date), CAST(N'00:00:00' AS Time), N'AG0001', CAST(1 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), N'P001')
INSERT [dbo].[Tbl_pinjam] ([NoPinjam], [TglPinjam], [JamPinjam], [KodeAnggota], [ItemPinjam], [TotalPinjam], [KdPetugas]) VALUES (N'PNJ200722004', CAST(N'2020-07-22' AS Date), CAST(N'00:00:00' AS Time), N'AG0001', CAST(3 AS Numeric(18, 0)), CAST(3 AS Numeric(18, 0)), N'P001')
INSERT [dbo].[Tbl_pinjam] ([NoPinjam], [TglPinjam], [JamPinjam], [KodeAnggota], [ItemPinjam], [TotalPinjam], [KdPetugas]) VALUES (N'PNJ200722005', CAST(N'2020-07-22' AS Date), CAST(N'00:00:00' AS Time), N'AG0001', CAST(1 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), N'P001')
INSERT [dbo].[Tbl_pinjam] ([NoPinjam], [TglPinjam], [JamPinjam], [KodeAnggota], [ItemPinjam], [TotalPinjam], [KdPetugas]) VALUES (N'PNJ200722006', CAST(N'2020-07-22' AS Date), CAST(N'00:00:00' AS Time), N'AG0001', CAST(1 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), N'P001')
INSERT [dbo].[Tbl_pinjam] ([NoPinjam], [TglPinjam], [JamPinjam], [KodeAnggota], [ItemPinjam], [TotalPinjam], [KdPetugas]) VALUES (N'PNJ200722007', CAST(N'2020-07-22' AS Date), CAST(N'00:00:00' AS Time), N'AG0001', CAST(1 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), N'P001')
