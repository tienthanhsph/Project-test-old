CREATE PROCEDURE spXoaNguoi
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
 DELETE FROM [tblNguoi]   
 WHERE ID =@ID
END

