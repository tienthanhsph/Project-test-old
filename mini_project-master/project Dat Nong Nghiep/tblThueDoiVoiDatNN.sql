
CREATE TABLE [dbo].[tblThueDoiVoiDatNN](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[IDThuaDat] [bigint] NULL,
	[MaSoGiaDinh] [bigint] NULL,
	[NoiDung] [nvarchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[KhoanMuc] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[SoTien] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[NgayBatDauHopDong] [datetime] NULL,
	[NgayKetThucHopDong] [datetime] NULL,
	[DaNop] [bit] NULL,
	[NguoiNopThue] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[NguoiThuThue] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[NgayNopThue] [datetime] NULL,
	[GhiChu] [nvarchar](2000) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[AddCol1] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[AddCol2] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[AddCol3] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_tblThueDoiVoiDatNN] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
