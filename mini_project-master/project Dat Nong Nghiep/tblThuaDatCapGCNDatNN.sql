
CREATE TABLE [dbo].[tblThuaDatCapGCNDatNN](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[MaHoSoCapGCNDatNN] [bigint] NULL,
	[MaDonViHanhChinh] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ToBanDo] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[SoThua] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[DienTich] [float] NULL,
	[DienTichTangGiam] [float] NULL,
	[LoaiDat] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[MucDich] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[LoaiThoiHan] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ThoiHan] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[NguonGoc] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[XuDong] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[GhiChu] [nvarchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[DauThau] [bit] NULL CONSTRAINT [DF_tblThuaDatCapGCNDatNN_DauThau]  DEFAULT ((0)),
	[Thue] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL CONSTRAINT [DF_tblThuaDatCapGCNDatNN_Thue]  DEFAULT ((0)),
	[GiaDauThau] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL CONSTRAINT [DF_tblThuaDatCapGCNDatNN_GiaDauThau]  DEFAULT ((0)),
	[TienDaNop] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL CONSTRAINT [DF_tblThuaDatCapGCNDatNN_TienDaNop]  DEFAULT ((0)),
 CONSTRAINT [PK_tblThuaDatCapGCNDatNN] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
