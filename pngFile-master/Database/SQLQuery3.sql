USE [WORK_WITH_PGN_FILE]
GO
/****** Object:  StoredProcedure [dbo].[SPChonVanHoa]    Script Date: 10/02/2014 20:06:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[SPChonVanHoa]
@TenKienTuong nvarchar(50)
as
BEGIN
select * from tblPGN
where Result like '%1/2%'
END
