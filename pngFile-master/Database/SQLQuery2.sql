USE [WORK_WITH_PGN_FILE]
GO
/****** Object:  StoredProcedure [dbo].[InsertTotblPGN]    Script Date: 10/02/2014 20:06:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[InsertTotblPGN]

@Events nvarchar(50)= NULL,
@Site nvarchar(50) = NULL,
@Date nvarchar(50)= NULL,
@Rounds nvarchar(50)= NULL,
@White nvarchar(50) =NULL,
@Black nvarchar(50) =NULL,
@Result nvarchar(50)= NULL,
@WhiteElo nvarchar(50) =NULL,
@BlackElo nvarchar(50) =NULL,
@ECO nvarchar(50)= NULL,
@Plays nvarchar(max) =NULL
as
BEGIN

INSERT INTO tblPGN(Events, Site,Date, Rounds,White,Black,Result,WhiteElo,BlackElo,ECO,Plays)
VALUES
(@Events,@Site,@Date,@Rounds,@White,@Black,@Result,@WhiteElo,@BlackElo,@ECO,@Plays)
END

