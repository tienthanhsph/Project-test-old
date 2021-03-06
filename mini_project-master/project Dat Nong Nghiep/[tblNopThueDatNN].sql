USE [georgetown_ThanhTri]
GO
/****** Object:  Table [dbo].[tblNopThueDatNN]    Script Date: 08/14/2015 16:03:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNopThueDatNN](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[MaHoSoCapGCNDatNN] [bigint] NULL,
	[MaDonViHanhChinh] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[TienNopThue] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[DuocMien] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Nam] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[NgayNopThue] [datetime] NULL,
	[NguoiNopThue] [nvarchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[GhiChu] [nvarchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_tblNopThueDatNN] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
