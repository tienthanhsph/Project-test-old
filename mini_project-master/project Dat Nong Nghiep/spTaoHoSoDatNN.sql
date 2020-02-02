ALTER PROCEDURE spTaoHoSoDatNN
@MaDonViHanhChinh nvarchar(50)

as
BEGIN
	INSERT INTO [tblHoSoCapGCNDatNN]
           ([MaDonViHanhChinh])
          
     VALUES
          (@MaDonViHanhChinh)


	SELECT MAX(MaHoSoCapGCNDatNN) from tblHoSoCapGCNDatNN
END

