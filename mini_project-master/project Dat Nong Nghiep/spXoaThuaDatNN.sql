
ALTER procedure spXoaThuaDatNN
@ID nvarchar(50) = null,
@MaHoSoCapGCNDatNN nvarchar(50) = null,
@MaDonViHanhChinh nvarchar(50) = null,
@ToBanDo nvarchar(50) = null,
@SoThua nvarchar(50) = null,
@XuDong nvarchar(500) = null,
@DienTich nvarchar(50) = null,
@DienTichTangGiam nvarchar(50) = null,
@LoaiDat nvarchar(50) = null,
@LoaiThoiHan nvarchar(50) = null,
@ThoiHan nvarchar(50) = null,
@Thue nvarchar(50) = null,
@GhiChu nvarchar(2000) = null,
@NguonGoc nvarchar(200) = null,
@MucDich nvarchar(200) = null
as
BEGIN
	DELETE FROM [tblThuaDatCapGCNDatNN]     
	WHERE ID= @ID
END