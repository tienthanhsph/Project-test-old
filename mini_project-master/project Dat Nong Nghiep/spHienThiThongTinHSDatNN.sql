set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go


ALTER procedure [dbo].[spHienThiThongTinHSDatNN]
@MaHoSoCapGCNDatNN nvarchar(50)
as
BEGIN

if(object_id('tempdb..#tmpTT') is not null)
drop table #tmpTT

SELECT gd.NguoiDaiDien, gd.DiaChi, gd.SoNguoi, hs.DienTichDeNghiCapGCN,hs.Thue,gd.KhauChinhThuc  into #tmpTT
FROM	tblHoSoCapGCNDatNN as hs 
		inner join tblHoGiaDinh as gd on hs.MaHoSoCapGCNDatNN=gd.MaHoSoCapGCNDatNN
WHERE hs.MaHoSoCapGCNDatNN =@MaHoSoCapGCNDatNN



select * from #tmpTT
END

--execute spHienThiThongTinHSDatNN 56
--
--
--select sum(convert(int,Thue)) from tblThuaDatCapGCNDatNN
--select * from tblThuaDatCapGCNDatNN

