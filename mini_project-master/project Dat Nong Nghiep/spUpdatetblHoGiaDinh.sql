set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go

ALTER procedure [dbo].[spUpdatetblHoGiaDinh]
@MaSoGiaDinh nvarchar(50)
as
BEGIN
	UPDATE tblHoGiaDinh set NguoiDaiDien = (select top(1) HoTen from tblNguoi where MaSoGiaDinh = @MaSoGiaDinh and IsNguoiDaiDien =1 )
									
	WHERE MaSoGiaDinh = @MaSoGiaDinh

	if(object_id('tempdb..#tmpTVGD') is not null)
	drop table #tmpTVGD
	if(object_id('tempdb..#tmpTVGD1') is not null)
	drop table #tmpTVGD1
	
	SELECT  NG.HoTen, GD.MaSoGiaDinh	into #tmpTVGD
									FROM  tblNguoi as NG full OUTER JOIN
									 tblHoGiaDinh as GD ON GD.MaSoGiaDinh =  NG.MaSoGiaDinh
									where GD.MaSoGiaDinh =@MaSoGiaDinh

	SELECT DISTINCT 
			bag2.MaSoGiaDinh,
			(   SELECT  bag1.HoTen + ',' AS [text()]
				FROM #tmpTVGD bag1
				WHERE bag1.MaSoGiaDinh=bag2.MaSoGiaDinh
				ORDER BY bag1.MaSoGiaDinh
				FOR XML PATH(''))[HoTen]	
		into #tmpTVGD1	
		FROM #tmpTVGD bag2
					

	update tblHoGiaDinh set ThanhVien = 
										(
											select HoTen from #tmpTVGD1
										)
						where MaSoGiaDinh = @MaSoGiaDinh


END

