USE [WORK_WITH_PGN_FILE]
GO
/****** Object:  StoredProcedure [dbo].[SPChonVanThua]    Script Date: 10/02/2014 20:06:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[SPChonVanThua]
@TenKienTuong nvarchar(50)
as
BEGIN
select * from tblPGN
where (Black like '%'+@TenKienTuong+'%' and Result like '%1-0%')or(White like '%'+@TenKienTuong+'%' and Result like '%0-1%')
END

