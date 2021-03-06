USE [WORK_WITH_PGN_FILE]
GO
/****** Object:  Table [dbo].[tblPGN]    Script Date: 10/02/2014 20:06:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPGN](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Events] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Site] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Date] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Rounds] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[White] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Black] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Result] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[WhiteElo] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[BlackElo] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ECO] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Plays] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_tblPGN] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
