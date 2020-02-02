alter PROCEDURE spThemHoGiaDinh
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
	INSERT INTO [tblHoGiaDinh]
           (
			[NguoiDaiDien]
           ,[SoNguoi]
           ,[DiaChi]
           ,[KhauChinhThuc]
           ,[KhauXemXet]
           ,[GhiChu]
           ,[MaHoSoCapGCNDatNN]
           )
     VALUES
		   (
            @DaiDien
           ,@SoNguoi
           ,@DiaChi
           ,@KhauChinhThuc
           ,@KhauXemXet
           ,@GhiChu
           ,@MaHoSoCapGCNDatNN
           )

END