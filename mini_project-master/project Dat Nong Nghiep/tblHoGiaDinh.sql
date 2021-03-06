
CREATE TABLE [dbo].[tblHoGiaDinh](
	[MaSoGiaDinh] [bigint] IDENTITY(1,1) NOT NULL,
	[MaHoSoCapGCNDatNN] [bigint] NULL,
	[NguoiDaiDien] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ThanhVien] [nvarchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[SoNguoi] [int] NULL,
	[DiaChi] [nvarchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[KhauChinhThuc] [int] NULL,
	[KhauXemXet] [int] NULL,
	[GhiChu] [nvarchar](1000) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_tblHoGiaDinh] PRIMARY KEY CLUSTERED 
(
	[MaSoGiaDinh] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
