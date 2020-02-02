ALTER PROCEDURE spThueDatNN
@ID nvarchar(50) = null,
@MaHoSoCapGCNDatNN nvarchar(50) = null,
@MaDonViHanhChinh nvarchar(50) = null,
@NguoiNopThue nvarchar(500) = null,
@NgayNopThue datetime = null,
@TienNopthue nvarchar(50) = null,
@Nam nvarchar(50) = null,
@flag nvarchar(50) = null,
@GhiChu nvarchar(2000) = null,
@DuocMien nvarchar(50) = null
AS
BEGIN

	if(@flag = 1)
	begin
		INSERT INTO tblNopThueDatNN
           (
           [MaHoSoCapGCNDatNN]
           ,[MaDonViHanhChinh]
           ,[TienNopThue]
           ,[Nam]
           ,[NgayNopThue]
           ,[NguoiNopThue]
           ,[GhiChu]
		   ,[DuocMien])
     VALUES
           (
			@MaHoSoCapGCNDatNN,@MaDonViHanhChinh,@TienNopthue,@Nam,@NgayNopThue,@NguoiNopThue,@GhiChu,@DuocMien
			)
	end

	if(@flag = 2)
	begin
		UPDATE tblNopThueDatNN
		   SET 
			  [MaHoSoCapGCNDatNN] = @MaHoSoCapGCNDatNN
			  ,[MaDonViHanhChinh] = @MaDonViHanhChinh
			  ,[TienNopThue] =@TienNopthue
			  ,[Nam] = @Nam
			  ,[NgayNopThue] = @NgayNopThue
			  ,[NguoiNopThue] = @NguoiNopThue
			  ,[GhiChu] = @GhiChu
			  ,[DuocMien]=@DuocMien
		 WHERE ID =@ID
	end

	if(@flag = 3)
	begin
		DELETE FROM tblNopThueDatNN
		WHERE  ID =@ID
	end
	
--	if(@flag =4) --  tinh So Tien Con Phai Nop

--	begin
--		if(object_id('tempdb..#tmpThue') is not null)
--			drop table #tmpThue
--
--		select Thue,'' as TienConPhaiNop into #tmpThue from tblHoSoCapGCNDatNN where MaHoSoCapGCNDatNN=@MaHoSoCapGCNDatNN
--
--
--		select * from #tmpThue
--	end
END