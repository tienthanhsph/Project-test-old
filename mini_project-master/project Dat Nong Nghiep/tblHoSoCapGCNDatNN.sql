
CREATE TABLE [dbo].[tblHoSoCapGCNDatNN](
	[MaHoSoCapGCNDatNN] [bigint] IDENTITY(1,1) NOT NULL,
	[MaDonViHanhChinh] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[DienTichDuocGiaoTheoNghiDinh] [float] NULL,
	[DienTichTangGiam] [float] NULL,
	[DienTichDeNghiCapGCN] [float] NULL,
	[DienTich] [float] NULL,
	[GhiChu] [nvarchar](1000) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[TrangThaiHoSo] [int] NULL,
	[BaoXoa] [bit] NULL,
	[NgayCapGCN] [datetime] NULL,
	[NguoiKyGCN] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[DaXongThue] [bit] NULL CONSTRAINT [DF_tblHoSoCapGCNDatNN_DaXongThue]  DEFAULT ((0)),
 CONSTRAINT [PK_tblHoSoCapGCNDatNN] PRIMARY KEY CLUSTERED 
(
	[MaHoSoCapGCNDatNN] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
