create procedure spTimKiemHoSoDatNN
@flag int,
@MaDonViHanhChinh nvarchar(50) = null,
@HoTen nvarchar(200)=null,
@CMND nvarchar(50) = null,
@DiaChi nvarchar(50) = null,
@ToBanDo nvarchar(50) = null,
@SoThua nvarchar(50) = null

as
BEGIN

if(@flag =0)
	begin
		select HS.MaHoSoCapGCNDatNN,GD.MaSoGiaDinh, GD.NguoiDaiDien, GD.ThanhVien, GD.DiaChi, HS.DienTichDeNghiCapGCN
		from tblHoSoCapGCNDatNN as HS
			full outer join tblHoGiaDinh as GD on GD.MaHoSoCapGCNDatNN =HS.MaHoSoCapGCNDatNN
			inner join tblNguoi as NG on NG.MaSoGiaDinh =GD.MaSoGiaDinh
		where LOWER(NG.HoTen) like '''%'+LOWER(@HoTen)+'%''' and NG.CMND like '''%'+@CMND+'%''' and HS.MaDonViHanhChinh = @MaDonViHanhChinh
			and LOWER(GD.DiaChi) like '''%'+LOWER(@DiaChi)+'%'''
	end -- flag =0
if(@flag =1)
	begin
		select HS.MaHoSoCapGCNDatNN,GD.MaSoGiaDinh, GD.NguoiDaiDien, GD.ThanhVien, GD.DiaChi, HS.DienTichDeNghiCapGCN, TD.ToBanDo, TD.SoThua
		from tblThuaDatCapGCNDatNN as TD
		inner join tblHoSoCapGCNDatNN as HS on TD.MaHoSoCapGCNDatNN =HS.MaHoSoCapGCNDatNN and TD.MaDonViHanhChinh=HS.MaDonViHanhChinh
		inner join tblHoGiaDinh as GD on GD.MaHoSoCapGCNDatNN =HS.MaHoSoCapGCNDatNN
		where LOWER(TD.ToBanDo) like '''%'+LOWER(@ToBanDo)+'%''' and LOWER(TD.SoThua) like '''%'+LOWER(@SoThua)+'%''' 
			and HS.MaDonViHanhChinh = @MaDonViHanhChinh 
	end -- flag =1
if(@flag =2)
	begin
		select * from tblMaHoSoCapGCNDatNN
	end -- flag =2
	

END