ALTER PROCEDURE spXetQuyenSDDatNN
@flag nvarchar(20) = null,
@MaHoSoCapGCNDatNN nvarchar(50) = null, 
@MaDonViHanhChinh nvarchar(50) = null, 
@UBNDNgayKy nvarchar(50) = null, 
@UBNDTieuDeKy nvarchar(500) = null, 
@UBNDNguoiKy nvarchar(500) = null, 
@UBNDNoiDung nvarchar(max) = null, 
@CQDCNgayKy nvarchar(500) = null, 
@CQDCNguoiKy nvarchar(500) = null, 
@CQDCNoiDung nvarchar(max) = null
as 
BEGIN
	if(@flag = '0')-- create
	BEGIN
		INSERT INTO tblXetQuyenSuDungDatNN
           ([MaHoSoCapGCNDatNN]
           ,[MaDonViHanhChinh]
           ,[UBNDNgayKy]
           ,[UBNDTieuDeKy]
           ,[UBNDNguoiKy]
           ,[UBNDNoiDung]
           ,[CQDCNgayKy]
           ,[CQDCNguoiKy]
           ,[CQDCNoiDung])
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


	if(@flag = '1') -- cap nhat ubnd
	BEGIN
		UPDATE tblXetQuyenSuDungDatNN
		   SET [UBNDNgayKy] = @UBNDNgayKy
			  ,[UBNDTieuDeKy] = @UBNDTieuDeKy
			  ,[UBNDNguoiKy] = @UBNDNguoiKy
			  ,[UBNDNoiDung] = @UBNDNoiDung
			  
		 WHERE MaDonViHanhChinh = @MaDonViHanhChinh and MaHoSoCapGCNDatNN = @MaHoSoCapGCNDatNN
	END


	if(@flag ='2') --cap nhat DC
	BEGIN
		UPDATE tblXetQuyenSuDungDatNN
		   SET [CQDCNgayKy] = @CQDCNgayKy
			  ,[CQDCNguoiKy] = @CQDCNguoiKy
			  ,[CQDCNoiDung] = @CQDCNoiDung
		 WHERE MaDonViHanhChinh = @MaDonViHanhChinh and MaHoSoCapGCNDatNN = @MaHoSoCapGCNDatNN
	END


END