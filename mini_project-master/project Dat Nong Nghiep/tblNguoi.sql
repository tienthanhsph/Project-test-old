
CREATE TABLE [dbo].[tblNguoi](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[MaGiaDinh] [bigint] NULL,
	[HoTen] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[CMND] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[NgaySinh] [datetime] NULL,
	[CoKhau] [bit] NULL,
	[isNguoiDaiDien] [bit] NULL,
	[MaSo_in_tblChu] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[AddCol2] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[AddCol3] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_tblNguoi] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
