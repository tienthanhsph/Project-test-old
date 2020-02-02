CREATE PROCEDURE spUpdateHoGiaDinh
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
	UPDATE [tblHoGiaDinh]
   SET [NguoiDaiDien] =@DaiDien
      ,[ThanhVien] = @ThanhVien
      ,[SoNguoi] = @SoNguoi
      ,[DiaChi] = @DiaChi
      ,[KhauChinhThuc] = @KhauChinhThuc
      ,[KhauXemXet] = @KhauXemXet
      ,[GhiChu] = @GhiChu
      ,[MaHoSoCapGCNDatNN] = @MaHoSoCapGCNDatNN
      
 WHERE MaSoGiaDinh = @MaSoGiaDinh

END