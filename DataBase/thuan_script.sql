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

	create function func_ma_next(@last_ma varchar(10),@char1 varchar(4),@size int) returns varchar(10)
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




------ proc lấy mã phòng ban tiếp theo 
create proc GetMaPhongBan
as
begin 
	select dbo.func_ma_next((select Top 1 MaPB from PHONGBAN order by MaPB desc),'PB','5') as MaPB
end 





---- Proc Danh sách học vấn nhân viên

create proc DanhSachHocVanNhanVien
as
begin 
	select *from HOCVANNHANVIEN
end

------------ Table NHANVIEN

---- proc lấy mã nhân viên tiếp theo 
create proc GetMaNVNext
as
begin 
	select dbo.func_ma_next((select Top 1 MaNV from NHANVIEN order by MaNV desc),'NV','5') as MaNV
end
--------- Danh sách Nhân viên
create proc GetListNhanVien
as 
begin 
	select *from NHANVIEN
end

	-- tạo thủ tục thêm nhân viên
 create PROCEDURE InsertNhanVien (@MaNV char(10) , @HoTen nvarchar(50) , @NgaySinh date, @QueQuan	nvarchar(50)
								,@GioiTinh nvarchar(10), @DanToc nvarchar(50), @SDT decimal(18,0), @MaPB char(10), @MaCV char(10), @MaTDHV char(10), @BacLuong int , @Anh char(20))
as
begin
	insert into NHANVIEN(MaNV,HoTen,NgaySinh,QueQuan,GioiTinh,DanToc,Sdt,MaPB,MaCV,MaTDHV,BacLuong,Anh) values(@MaNV,@HoTen,@NgaySinh,@QueQuan,@GioiTinh,@DanToc,@SDT,@MaPB,@MaCV,@MaTDHV,@BacLuong,@Anh)
end
----- Proc sửa nhân viên 
create proc UpdateNhanVien(@MaNV char(10) , @HoTen nvarchar(50) , @NgaySinh date, @QueQuan	nvarchar(50)
								,@GioiTinh nvarchar(10), @DanToc nvarchar(50), @SDT decimal(18,0), @MaPB char(10), @MaCV char(10), @MaTDHV char(10), @BacLuong int , @Anh char(20))
as
begin
	Update NHANVIEN
	set HoTen=@HoTen,NgaySinh=@NgaySinh,QueQuan=@QueQuan,GioiTinh=@GioiTinh,DanToc=@DanToc,Sdt=@SDT,MaPB=@MaPB,MaCV=@MaCV,MaTDHV=@MaTDHV,BacLuong=@BacLuong,Anh=@Anh
	where MaNV=@MaNV
end

----- Proc Xoá nhân viên
create proc DeleteNhanVien(@MaNV char(10))
as 
begin 
	Delete NHANVIEN
	where MaNV=@MaNV
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

----------------- trigger khi xóa 1 nhân viên sẽ tự động xóa các bản ghi 
----------------- của nhân viên đó ở bảng TheoDoi

alter trigger trigger_UpdateTheoDoi on NHANVIEN instead of delete
as
declare @MaNV char(10)
begin 
	select @MaNV =MaNV from deleted

	Delete THEODOI
	where MaNV = @MaNV

	Delete NHANVIEN
	where MaNV=@MaNV
end
---------- Proc tìm kiếm nhân viên theo MaNV
create proc SearchNhanVienTheoMaNV(@MaNV char (10))
as
begin
	select *from NHANVIEN
	where MaNV=@MaNV
end

-------- Proc tim kiem nhan vien theo  Phong Ban
create proc SearchNhanVienTheoPB (@MaPB char(10))
as
begin 
	select *from NHANVIEN
	where MaPB=@MaPB
end
--------Proc tim kiem nhan vien theo Chuc Vu
create proc SearchNhanVienTheoCV (@MaCV char(10))
as
begin 
	select *from CHUCVU
	where MaCV =@MaCV
end

----------- Proc tim kiem nhan vien theo TDHV
create proc SearchNhanVienTheoTDHV(@MaTDHV char(10))
as
begin 
	select *from NHANVIEN
	where MaTDHV=@MaTDHV
end
-------Proco tim kiem nhan vien theo QueQuan
create proc SearchNhanVienTheoQueQuann(@QueQuan nvarchar(50))
as
begin 
	select *from NHANVIEN
	where QueQuan=@QueQuan
end

-------Proc tim kiem nhan vien theo gioi tinh
create proc SearchNhanVienTheoGT (@GioiTinh nvarchar(50))
as
begin 
	select *from NHANVIEN
	where GioiTinh=@GioiTinh
end
---------- Proc tim kiem Nhan vien theo bac luong 
create proc SearchNhanVienTheoBacLuong(@BacLuong int)
as
begin 
	select *from NHANVIEN
	where BacLuong=@BacLuong
end
-------------- Table CHUCVU
----- Proc Danh sách chức vụ 
create proc GetListChucVu
as 
begin 
	select *from CHUCVU
end

---------- Proc thêm chức vụ
create proc InsertChucVu(@MaCV char(10),@TenCV nvarchar(20))
as
begin 
	insert into CHUCVU(MaCV,TenCV) values (@MaCV,@TenCV)
end
 
----------Proc Sửa chức vụ
create proc UpdateChucVu(@MaCV char(10),@TenCV nvarchar(20))
as
begin 
	Update CHUCVU
	set TenCV=@TenCV
	where MaCV=@MaCV
end
----------- Proc Xóa chức vụ 
create proc DeleteChucVu (@MaCV char(10))
as 
begin 
	Delete CHUCVU
	where MaCV=@MaCV
end
--------- Proc lấy mã chức vụ tiếp theo
create proc GetMaChucVuNext
as 
begin 
	select dbo.func_ma_next((select top 1 MaCV from CHUCVU order by MaCV desc),'CV',5) as MaCV
end

------------ Table TRINHDOHOCVAN

---------- Proc Danh sách trình độ học vấn
create proc GetListTrinhDoHocVan
as 
begin 
	select *from TRINHDOHOCVAN
end
---------- Proc lấy mã trình độ học vấn tiếp theo 
create proc GetMaTDHVNext
as 
begin 
	select dbo.func_ma_next((select top 1 MaTDHV from TRINHDOHOCVAN order by MaTDHV desc),'TDHV',6) as MaTDHV
end

----------trigger khi xóa TDHV thì TDHV của NhanVien chuyển thành Null
create trigger trigger_UpdateTDHVNhanVien on TRINHDOHOCVAN for delete 
as
declare @MaTDHV char(10)



------ Proc Thêm trình độ học vấn
create proc InsertTDHV(@MaTDHV char(10),@TenTrinhDo nvarchar(20),@ChuyenNganh nvarchar(20))
as
begin 
	insert into TRINHDOHOCVAN(MaTDHV,TenTrinhDo,ChuyenNganh) values (@MaTDHV,@TenTrinhDo,@ChuyenNganh)
end
---------- Proc Sửa trình độ học vấn
create proc UpdateTDHV(@MaTDHV char(10),@TenTrinhDo nvarchar(20),@ChuyenNganh nvarchar(20))
as
begin 
	Update TRINHDOHOCVAN
	set TenTrinhDo=@TenTrinhDo,ChuyenNganh=@ChuyenNganh
	where MaTDHV=@MaTDHV
end
----------- Proc Xóa trình độ học vấn
create proc DeleteTDHV (@MaTDHV char(10))
as 
begin
	Delete TRINHDOHOCVAN
	where MaTDHV=@MaTDHV
end




------  Proc Thêm Hoc van nhan vien
create proc ThemHocVanNhanVien (@MaNV char(10), @MaTDHV char(10))
as 
begin 
	insert into HOCVANNHANVIEN(MaNV,MaTDHV) values (@MaNV,@MaTDHV)
end

------ Proc Sửa Hoc van nhan vien




---------- Proc Delete Học vấn nhân viên
create proc XoaHocVanNhanVien(@MaNV char(10),@MaTDHV char(10))
as 
begin 
	delete HOCVANNHANVIEN
	where MaNV=@MaNV and MaTDHV=@MaTDHV
end




---- Thuần 