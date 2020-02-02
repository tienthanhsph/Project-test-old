CREATE PROCEDURE spUpdateNguoi
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
UPDATE [tblNguoi]
   SET [MaSoGiaDinh] =@MaSoGiaDinh
      ,[HoTen] = @HoTen
      ,[CMND] = @CMND
      ,[NgaySinh] = @NgaySinh
      ,[CoKhau] = @CoKhau
      ,[isNguoiDaiDien] =@IsNguoiDaiDien
      ,[MaSo_in_tblChu] = ''
      ,[DiaChi] = @DiaChi
      
 WHERE ID =@ID
END

