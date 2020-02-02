ALTER PROCEDURE spXetGiaoDatNN
@flag nvarchar(20) = null,
@MaHoSoCapGCNDatNN nvarchar(50) = null, 
@MaDonViHanhChinh nvarchar(50) = null, 
@UBNDNgayKy nvarchar(50) = null, 
@UBNDTieuDeKy nvarchar(500) = null, 
@UBNDNguoiKy nvarchar(500) = null, 
@UBNDNoiDung nvarchar(max) = null, 
@HDGDNgayKy nvarchar(500) = null, 
@HDGDNguoiKy nvarchar(500) = null, 
@HDGDNoiDung nvarchar(max) = null

as 
BEGIN
	if(@flag = '0')-- create
	BEGIN
		INSERT INTO tblXetGiaoDatNN
           ([MaHoSoCapGCNDatNN]
           ,[MaDonViHanhChinh]
           ,[UBNDNgayKy]
           ,[UBNDTieuDeKy]
           ,[UBNDNguoiKy]
           ,[UBNDNoiDung]
           ,[HDGDNgayKy]
           ,[HDGDNguoiKy]
           ,[HDGDNoiDung])
		VALUES
			(
			@MaHoSoCapGCNDatNN,
			@MaDonViHanhChinh,
			N'',
			N'',
			N'',
			N'',
			N'',
			N'',
			N''
			)
	END


	if(@flag = '1') -- cap nhat HDGD
	BEGIN
		UPDATE tblXetGiaoDatNN
	     SET [HDGDNgayKy] = @HDGDNgayKy
		  ,[HDGDNguoiKy] = @HDGDNguoiKy
		  ,[HDGDNoiDung] = @HDGDNoiDung
		 WHERE MaDonViHanhChinh = @MaDonViHanhChinh and MaHoSoCapGCNDatNN = @MaHoSoCapGCNDatNN
	END


	if(@flag ='2') --cap nhat UBND
	BEGIN
		UPDATE tblXetGiaoDatNN
		   SET [UBNDNgayKy] = @UBNDNgayKy
			  ,[UBNDTieuDeKy] =@UBNDTieuDeKy
			  ,[UBNDNguoiKy] = @UBNDNguoiKy
			  ,[UBNDNoiDung] = @UBNDNoiDung  
		 WHERE MaDonViHanhChinh = @MaDonViHanhChinh and MaHoSoCapGCNDatNN = @MaHoSoCapGCNDatNN
	END


END