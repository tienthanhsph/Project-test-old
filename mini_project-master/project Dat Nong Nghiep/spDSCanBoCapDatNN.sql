ALTER procedure spDSCanBoCapDatNN
@ID nvarchar(50) = null,
@flag nvarchar(20)= null,
@DanhMuc nvarchar(200)= null,
@Ten nvarchar(200)= null,
@ChucVu nvarchar(200)= null
as
BEGIN
	if(@flag = 1)
	begin
		INSERT INTO [tblDSCanBoCapDatNN]
           ([DanhMuc]
           ,[Ten]
           ,[ChucVu])
		 VALUES
           (@DanhMuc
           ,@Ten
           ,@ChucVu)
		
	end

	if(@flag = 2)
	begin
		UPDATE [tblDSCanBoCapDatNN]
		   SET [DanhMuc] = @DanhMuc
			  ,[Ten] = @Ten
			  ,[ChucVu] = @ChucVu
		
		 WHERE ID =@ID
	end

	if(@flag = 3)
	begin
		DELETE FROM tblDSCanBoCapDatNN
		WHERE  ID =@ID
	end
END