ALTER 
--create
 PROCEDURE SpUpdatetblHoSoCapGCNDatNN
@MaHoSoCapGCNDatNN nvarchar(50),
@flag nvarchar(50)
as
BEGIN
if(@flag ='1')
	begin
		declare @DTTheoNghiDinh float
		declare @DTTangGiam float
		declare @DT float
		declare @DTDeNghiCapGCN float

		set @DTTheoNghiDinh = (select KhauChinhThuc from tblHoGiaDinh where MaHoSoCapGCNDatNN=@MaHoSoCapGCNDatNN)*100
		set @DTTangGiam = (select SUM(DienTichTangGiam) from tblThuaDatCapGCNDatNN where  MaHoSoCapGCNDatNN=@MaHoSoCapGCNDatNN )
		set @DT = (select SUM(DienTich) from tblThuaDatCapGCNDatNN where  MaHoSoCapGCNDatNN=@MaHoSoCapGCNDatNN )
		set @DTDeNghiCapGCN =@DT+@DTTangGiam


		UPDATE tblHoSoCapGCNDatNN
			set DienTichDuocGiaoTheoNghiDinh=@DTTheoNghiDinh
				,DienTich= @DT
				,DienTichTangGiam = @DTTangGiam
				,DienTichDeNghiCapGCN =@DTDeNghiCapGCN
			where  MaHoSoCapGCNDatNN=@MaHoSoCapGCNDatNN

	end
END
--
--  Execute SpUpdatetblHoSoCapGCNDatNN '100',1
--dROP PROCEDURE SpUpdatetblHoSoCapGCNDatNN