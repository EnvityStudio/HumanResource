---------------------------- THUẦN -------------------


-- Tạo thủ tục lấy danh sách thời gian công tác
create  Proc GetListThoiGianCongTac
as
	begin
		select *from NHANVIEN
	end

--- Tạo thủ tục lấy danh sách bảng lương
create Proc GetListLuong
as 
	begin 
		select *from LUONG
	end


---- function tăng mã tự động 

	alter function func_ma_next(@last_ma varchar(10),@char1 varchar(4),@size int) returns varchar(10)
		as
		begin
			if(@last_ma='')
				set @last_ma=@char1+REPLICATE(0,@size-LEN(@char1))
			declare @num_next_ma int,@next_ma varchar(10)
			set @last_ma=LTRIM(RTRIM(@last_ma))
			set @num_next_ma=REPLACE(@last_ma,@char1,'')+1
			set @size=@size-len(@char1)
			set @next_ma=@char1 + REPLICATE(0,@size-LEN(@char1))
			set @next_ma=@char1+RIGHT(REPLICATE(0,@size)+CONVERT(varchar(MAX),@num_next_ma),@size)
			return @next_ma
		end
		
----- tạo trigger tăng mã tự động cho nhân viên 
	
	create trigger trigger_next_MaNhanVien on NHANVIEN for insert
	as 
	begin 
	declare @last_ma varchar(10)
		set @last_ma=(select Top 1 MaNV from NHANVIEN order by MaNV desc)
		update NHANVIEN set MaNV=(select dbo.func_ma_next(@last_ma,'NV',5)) where MaNV=''
		end
----- tạo trigger tăng mã tự động cho phòng ban 

	create trigger trigger_next_MaPhongBan on PHONGBAN for insert 
	as 
	begin 
	declare @last_ma varchar(10)
		set @last_ma=(select Top 1 MaPB from PHONGBAN order by MaPB desc)
		update PHONGBAN set MaPB = (select dbo.func_ma_next(@last_ma,'PB',5))where MaPB=''
		end
	select *from PHONGBAN
	insert into PHONGBAN(MaPB,TenPB,DiaChi,SdtPB) values ('','Thuan2','Ha noi','324')
	

---- tạo trigger tăng mã tự động cho Chức vụ 

	create trigger trigger_next_MaChucVu on CHUCVU for insert
	as 
	begin 
	declare @last_ma varchar(10)
		set @last_ma = (select top 1 MaCV from CHUCVU order by MaCV desc)
		update CHUCVU set MaCV =(select dbo.func_ma_next(@last_ma,'CV',5))where MaCV=''
		end
	select *from CHUCVU
	insert into CHUCVU values ('','CTO')
	insert into CHUCVU values ('','COO')
----- tạo trigger tăng mã tự động cho trình độ học vấn
	create trigger trigger_next_MaTrinhDoHocVan on TRINHDOHOCVAN for insert 
	as
	begin 
	declare @last_ma varchar(10)
		set @last_ma =(select top 1 MaTDHV from TRINHDOHOCVAN order by MaTDHV desc)
		update TRINHDOHOCVAN set MaTDHV=(select dbo.func_ma_next(@last_ma,'TDHV',6)) where MaTDHV=''
		end

	select *from TRINHDOHOCVAN
	insert into TRINHDOHOCVAN values ('','Expert','Marketing')
	-- tạo thủ tục thêm nhân viên
 create PROCEDURE ThemNhanVien (@MaNV char(10) , @HoTen nvarchar(50) , @NgaySinh date, @QueQuan	nvarchar(50)
								,@GioiTinh nvarchar(10), @DanToc nvarchar(50), @SDT decimal(18,0), @MaPB char(10), @MaCV char(10), @MaTDHV char(10), @BacLuong int , @Anh char(20))
as
begin
	insert into NHANVIEN(MaNV,HoTen,NgaySinh,QueQuan,GioiTinh,DanToc,Sdt,MaPB,MaCV,MaTDHV,BacLuong,Anh) values(@MaNV,@HoTen,@NgaySinh,@QueQuan,@GioiTinh,@DanToc,@SDT,@MaPB,@MaCV,@MaTDHV,@BacLuong,@Anh)
end
----- Proc sửa nhân viên 
create proc SuaNhanVien(@MaNV char(10) , @HoTen nvarchar(50) , @NgaySinh date, @QueQuan	nvarchar(50)
								,@GioiTinh nvarchar(10), @DanToc nvarchar(50), @SDT decimal(18,0), @MaPB char(10), @MaCV char(10), @MaTDHV char(10), @BacLuong int , @Anh char(20))
as
begin
	Update NHANVIEN
	set HoTen=@HoTen,NgaySinh=@NgaySinh,QueQuan=@QueQuan,GioiTinh=@GioiTinh,DanToc=@DanToc,Sdt=@SDT,MaPB=@MaPB,MaCV=@MaCV,MaTDHV=@MaTDHV,BacLuong=@BacLuong,Anh=@Anh
	where MaNV=@MaNV
end

----- Proc Xoá nhân viên
create proc XoaNhanVien(@MaNV char(10))
as 
begin 
	Delete NHANVIEN
	where MaNV=@MaNV
end
------- Proc Thêm Phòng Ban 
create proc ThemPhongBan(@MaPB char (10), @TenPB nvarchar(30),@DiaChi nvarchar(50),@SdtPB decimal(12,0),@TongSoNV int)
as 
begin insert into PHONGBAN(MaPB,TenPB,DiaChi,SdtPB,TongSoNV) values (@MaPB,@TenPB,@DiaChi,@SdtPB,@TongSoNV) 
end
-------- Proc sửa phòng ban 
create proc SuaPhongBan (@MaPB char (10), @TenPB nvarchar(30),@DiaChi nvarchar(50),@SdtPB decimal(12,0))
as 
begin 
	Update PHONGBAN
	set TenPB=@TenPB,DiaChi=@DiaChi,SdtPB=@SdtPB
	where MaPB=@MaPB
end
--------- Proc xóa phòng ban
create proc XoaPhongBan (@MaPB char(10))
as
begin 
delete PHONGBAN
where MaPB=@MaPB
end
---------- Proc thêm chức vụ
create proc ThemChucVu(@MaCV char(10),@TenCV nvarchar(20))
as
begin 
	insert into CHUCVU(MaCV,TenCV) values (@MaCV,@TenCV)
end
 
----------Proc Sửa chức vụ
create proc SuaChucVu(@MaCV char(10),@TenCV nvarchar(20))
as
begin 
	Update CHUCVU
	set TenCV=@TenCV
	where MaCV=@MaCV
end
----------- Proc Xóa chức vụ 
create proc XoaChucVu (@MaCV char(10))
as 
begin 
	Delete CHUCVU
	where MaCV=@MaCV
end
------ Proc Thêm trình độ học vấn
create proc ThemTrinhDoHocVan(@MaTDHV char(10),@TenTrinhDo nvarchar(20),@ChuyenNganh nvarchar(20))
as
begin 
	insert into TRINHDOHOCVAN(MaTDHV,TenTrinhDo,ChuyenNganh) values (@MaTDHV,@TenTrinhDo,@ChuyenNganh)
end
---------- Proc Sửa trình độ học vấn
create proc SuaTrinhDoHocVan(@MaTDHV char(10),@TenTrinhDo nvarchar(20),@ChuyenNganh nvarchar(20))
as
begin 
	Update TRINHDOHOCVAN
	set TenTrinhDo=@TenTrinhDo,ChuyenNganh=@ChuyenNganh
	where MaTDHV=@MaTDHV
end
----------- Proc Xóa trình độ học vấn
create proc XoaTrinhDoHocVan (@MaTDHV char(10))
as 
begin
	Delete TRINHDOHOCVAN
	where MaTDHV=@MaTDHV
end
-------------- Proc Thêm Lương 
create proc ThemLuong (@BacLuong decimal(18,0),@LuongCoBan decimal(18,0),@HeSoLuong decimal (18,0),@HeSoPhuCap decimal(18,0))
as
begin 
	insert into LUONG(BacLuong,LuongCoBan,HeSoLuong,HeSoPhuCap) values (@BacLuong,@LuongCoBan,@HeSoLuong,@HeSoPhuCap)
end
---------------- Proc Sửa lương
create proc SuaLuong(@BacLuong decimal(18,0),@LuongCoBan decimal(18,0),@HeSoLuong decimal (18,0),@HeSoPhuCap decimal(18,0))
as
begin 
	Update LUONG
	set LuongCoBan=@LuongCoBan,HeSoLuong=@HeSoLuong,HeSoPhuCap=@HeSoPhuCap
	where BacLuong=@BacLuong
end
--------------- Proc Xóa Lương
create proc XoaLuong(@BacLuong decimal(18,0))
as 
begin 
	Delete LUONG
	where BacLuong=@BacLuong
end
------------- Proc thêm Thời gian công tác 
create proc ThemThoiGianCongTac (@MaNV char (10),@MaCV char(10),@NgayNhamChuc date)
as 
begin 
	insert into THOIGIANCONGTAC(MaNV,MaCV,NgayNhamChuc) values (@MaNV,@MaCV,@NgayNhamChuc)
end
-------------- Proc sửa thời gian công tác
create proc SuaThoiGianCongTac(@MaNV char (10),@MaCV char(10),@NgayNhamChuc date)
as 
begin 
	Update THOIGIANCONGTAC
	set NgayNhamChuc=NgayNhamChuc
	where MaNV=@MaNV and MaCV=@MaCV
end

------------- Proc xóa thời gian công tác
create proc XoaThoiGianCongTac (@MaNV char (10),@MaCV char(10))
as
begin 
	Delete THOIGIANCONGTAC
	where MaNV=@MaNV and MaCV=@MaCV
end



---- proc lấy mã nhân viên tiếp theo 
create proc GetMaNhanVienTiepTheo
as
begin 
	select dbo.func_ma_next((select Top 1 MaNV from NHANVIEN order by MaNV desc),'NV','5') as MaNV
end

------ proc lấy mã phòng ban tiếp theo 
create proc GetMaPhongBanTiepTheo
as
begin 
	select dbo.func_ma_next((select Top 1 MaPB from PHONGBAN order by MaPB desc),'PB','5') as MaPB
end 


---------- Proc lấy mã trình độ học vấn tiếp theo 
create proc GetMaTrinhDoHocVan
as 
begin 
	select dbo.func_ma_next((select top 1 MaTDHV from TRINHDOHOCVAN order by MaTDHV desc),'TDHV',6) as MaTDHV
end

--------- Proc lấy mã chức vụ tiếp theo
create proc GetMaChucVu
as 
begin 
	select dbo.func_ma_next((select top 1 MaCV from CHUCVU order by MaCV desc),'CV',5) as MaCV
end

----------- trigger tăng số nhân viên trong phòng ban 
create trigger trigger_UpdateSoNhanVien on NHANVIEN for insert,update, delete 
as
declare @MaPB1 char(10),@MaPB2 char (10)
begin 
		select @MaPB1 =MaPB from inserted
		select @MaPB2 =MaPB from deleted 
		update PHONGBAN 
		set TongSoNV=TongSoNV+1
		where MaPB=@MaPB1

		 Update PHONGBAN
		 set TongSoNV=TongSoNV-1
		 where MaPB=@MaPB2
end

select *from TRINHDOHOCVAN
select *from THOIGIANCONGTAC
select *from Luong
select *from NHANVIEN
select *from PHONGBAN
select *from CHUCVU

