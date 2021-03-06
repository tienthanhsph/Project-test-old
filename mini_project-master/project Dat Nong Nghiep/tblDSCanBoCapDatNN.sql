USE [georgetown_ThanhTri]
GO
/****** Object:  Table [dbo].[tblDSCanBoCapDatNN]    Script Date: 08/10/2015 15:01:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDSCanBoCapDatNN](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[DanhMuc] [nvarchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Ten] [nvarchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ChucVu] [nvarchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_tblDSCanBoCapDatNN] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
