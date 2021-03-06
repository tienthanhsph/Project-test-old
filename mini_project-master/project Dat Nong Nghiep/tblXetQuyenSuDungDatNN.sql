USE [georgetown_ThanhTri]
GO
/****** Object:  Table [dbo].[tblXetQuyenSuDungDatNN]    Script Date: 08/10/2015 15:46:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblXetQuyenSuDungDatNN](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[MaHoSoCapGCNDatNN] [bigint] NULL,
	[MaDonViHanhChinh] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[UBNDNgayKy] [datetime] NULL,
	[UBNDTieuDeKy] [nvarchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[UBNDNguoiKy] [nvarchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[UBNDNoiDung] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[CQDCNgayKy] [datetime] NULL,
	[CQDCNguoiKy] [nvarchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[CQDCNoiDung] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_tblXetQuyenSuDungDatNN] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
