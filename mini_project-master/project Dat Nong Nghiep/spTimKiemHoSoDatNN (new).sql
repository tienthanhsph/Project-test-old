set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go


ALTER procedure [dbo].[spTimKiemHoSoDatNN]
@flag int,
@MaDonViHanhChinh nvarchar(50) ='',
@HoTen nvarchar(200)='',
@CMND nvarchar(50) = '',
@DiaChi nvarchar(50) = '',
@ToBanDo nvarchar(50) = '',
@SoThua nvarchar(50) = ''

as
BEGIN
DECLARE @sql nvarchar(max)
if(@flag =0)
	begin
		set @sql='
		select DISTINCT HS.MaHoSoCapGCNDatNN,GD.MaSoGiaDinh, GD.NguoiDaiDien, GD.ThanhVien, GD.DiaChi, HS.DienTichDeNghiCapGCN
		from tblHoSoCapGCNDatNN as HS
			inner join tblHoGiaDinh as GD on GD.MaHoSoCapGCNDatNN =HS.MaHoSoCapGCNDatNN
			inner join tblNguoi as NG on NG.MaSoGiaDinh =GD.MaSoGiaDinh
		where HS.MaDonViHanhChinh = '''+@MaDonViHanhChinh+''' '

	if(ltrim(rtrim(@HoTen)) <> '')
		set @sql = @sql + ' and  LOWER(NG.HoTen) like ''%'+LOWER(@HoTen)+'%'' '
	if(ltrim(rtrim(@CMND)) <> '')
		set @sql = @sql + 'and NG.CMND like ''%'+@CMND+'%'' '
	if(ltrim(rtrim(@DiaChi)) <> '')
		set @sql = @sql + 'and LOWER(GD.DiaChi) like ''%'+LOWER(@DiaChi)+'%'' '
		 

		print '@flag =0';
		print  @sql;
		execute (@sql)
	end -- flag =0
if(@flag =1)
	begin
		set @sql ='
		select DISTINCT HS.MaHoSoCapGCNDatNN,GD.MaSoGiaDinh, GD.NguoiDaiDien, GD.ThanhVien, GD.DiaChi, HS.DienTichDeNghiCapGCN, TD.ToBanDo, TD.SoThua
		from tblThuaDatCapGCNDatNN as TD
		inner join tblHoSoCapGCNDatNN as HS on TD.MaHoSoCapGCNDatNN =HS.MaHoSoCapGCNDatNN and TD.MaDonViHanhChinh=HS.MaDonViHanhChinh
		inner join tblHoGiaDinh as GD on GD.MaHoSoCapGCNDatNN =HS.MaHoSoCapGCNDatNN
		where HS.MaDonViHanhChinh = '''+@MaDonViHanhChinh +''''
	if(ltrim(rtrim(@ToBanDo)) <> '')
		set @sql = @sql + ' and LOWER(TD.ToBanDo) like ''%'+LOWER(@ToBanDo)+'%'' '
	if(ltrim(rtrim(@SoThua)) <> '')
		set @sql = @sql + ' and LOWER(TD.SoThua) like ''%'+LOWER(@SoThua)+'%'' '
 
		print '@flag =1';
		print @sql
		execute (@sql)
	end -- flag =1
if(@flag =2)
	begin
		select * from tblMaHoSoCapGCNDatNN

		print '@flag =2';
	end -- flag =2
	

END

