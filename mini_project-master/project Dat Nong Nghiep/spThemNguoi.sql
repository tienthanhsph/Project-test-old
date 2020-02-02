CREATE PROCEDURE spThemNguoi
@ID nvarchar(50),
@MaSoGiaDinh nvarchar(50),
@HoTen nvarchar(500),
@CMND nvarchar(50),
@NgaySinh nvarchar(50),
@DiaChi nvarchar(500),
@IsNguoiDaiDien nvarchar(50),
@CoKhau nvarchar(50)
AS
BEGIN
INSERT INTO [tblNguoi]
           ([MaSoGiaDinh]
           ,[HoTen]
           ,[CMND]
           ,[NgaySinh]
           ,[CoKhau]
           ,[isNguoiDaiDien]
           ,[MaSo_in_tblChu]
		   ,[DiaChi]
          )
     VALUES
           (@MaSoGiaDinh
           ,@HoTen
           ,@CMND
           ,@NgaySinh
           ,@CoKhau
           ,@IsNguoiDaiDien
           ,''
		   ,@DiaChi
          )

END

