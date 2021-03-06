USE [georgetown_ThanhTri]
GO
/****** Object:  Table [dbo].[tblXetGiaoDatNN]    Script Date: 08/10/2015 15:46:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblXetGiaoDatNN](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[MaHoSoCapGCNDatNN] [bigint] NULL,
	[MaDonViHanhChinh] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[UBNDNgayKy] [datetime] NULL,
	[UBNDTieuDeKy] [nvarchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[UBNDNguoiKy] [nvarchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[UBNDNoiDung] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[HDGDNgayKy] [datetime] NULL,
	[HDGDNguoiKy] [nvarchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[HDGDNoiDung] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_tblXetGiaoDatNN] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
