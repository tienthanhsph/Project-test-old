CREATE PROCEDURE spXoaHoGiaDinh
@MaSoGiaDinh NVARCHAR(50),
@DaiDien NVARCHAR(200),
@ThanhVien  NVARCHAR(2000),
@SoNguoi NVARCHAR(50),
@DiaChi NVARCHAR(500),
@KhauChinhThuc NVARCHAR(50),
@KhauXemXet NVARCHAR(50),
@TongDienTich NVARCHAR(50),
@TongHopThue NVARCHAR(50),
@GhiChu NVARCHAR(2000),
@MaHoSoCapGCNDatNN NVARCHAR(50)

AS
BEGIN
	DELETE FROM [tblHoGiaDinh]     
	WHERE MaSoGiaDinh = @MaSoGiaDinh

END