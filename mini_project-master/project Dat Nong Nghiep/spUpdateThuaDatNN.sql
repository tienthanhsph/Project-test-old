
create procedure spUpdateThuaDatNN
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
	UPDATE [tblThuaDatCapGCNDatNN]
   SET 
       [MaHoSoCapGCNDatNN] =@MaHoSoCapGCNDatNN
      ,[MaDonViHanhChinh] = @MaDonViHanhChinh
      ,[ToBanDo] =@ToBanDo
      ,[SoThua] = @SoThua
      ,[DienTich] =@DienTich
      ,[DienTichTangGiam] = @DienTichTangGiam
      ,[LoaiDat] = @LoaiDat
      ,[MucDich] =@MucDich
      ,[LoaiThoiHan] = @LoaiThoiHan
      ,[ThoiHan] = @ThoiHan
      ,[NguonGoc] = @NguonGoc
      ,[XuDong] = @XuDong
      ,[GhiChu] = @GhiChu      
      ,[Thue] = @Thue
      
 WHERE ID= @ID
END