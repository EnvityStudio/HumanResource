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

	alter function func_ma_next(@last_ma varchar(10),@char1 varchar(6),@size int) returns varchar(10)
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
	select dbo.func_ma_next((select Top 1 MaNV from NHANVIEN order by MaNV desc),'NV','6') as MaNV
end
--------- Danh sách Nhân viên
create proc GetListNhanVien
as 
begin 
	select *from NHANVIEN
end
------- Proc get list nhân viên hiện tại 
create proc GetListNhanVienHienTai
as 
begin 
	select *from NHANVIEN
	where TrangThai=1
end

	-- tạo thủ tục thêm nhân viên
create PROCEDURE InsertNhanVien (@maNV char(10) , @hoTen nvarchar(50) , @ngaySinh date,@SDT char(10), @queQuan	nvarchar(50)
								,@gioiTinh nvarchar(10), @danToc nvarchar(50),@maPB char(10), @maCV char(10), @maTDHV char(10), @bacLuong int , @Anh char(20),@matKhau char(20),@trangThai int,@CMND char(20),@Email varchar(50))
as
begin
	insert into NHANVIEN(MaNV,HoTen,NgaySinh,SDT,QueQuan,GioiTinh,DanToc,MaPB,MaCV,MaTDHV,BacLuong,Anh,MatKhau,TrangThai,CMND,Email) 
	values(@maNV,@hoTen,@ngaySinh,@SDT,@queQuan,@gioiTinh,@danToc,@maPB,@maCV,@maTDHV,@bacLuong,@Anh,@matKhau,@trangThai,@CMND,@Email)
end
----- Proc sửa nhân viên 
create proc UpdateNhanVien(@maNV char(10) , @hoTen nvarchar(50) , @ngaySinh date,@SDT char(10), @queQuan	nvarchar(50)
								,@gioiTinh nvarchar(10), @danToc nvarchar(50),@maPB char(10), @maCV char(10), @maTDHV char(10), @bacLuong int , @Anh char(20),@matKhau char(20),@trangThai int,@CMND char(20),@Email varchar(50))
as
begin
	Update NHANVIEN
	set HoTen=@hoTen,NgaySinh=@ngaySinh,SDT=@SDT,QueQuan=@queQuan,GioiTinh=@gioiTinh,DanToc=@danToc,MaPB=@maPB,MaCV=@maCV,MaTDHV=@maTDHV,BacLuong=@bacLuong,Anh=@Anh,MatKhau=@matKhau,TrangThai=@trangThai,CMND=@CMND,Email=@Email

	where MaNV=@maNV
end

----- Proc Xoá nhân viên
create proc DeleteNhanVien(@maNV char(10))
as 
begin 
	Delete NHANVIEN
	where MaNV=@maNV
end
---------- Đếm số nhân viên trong 1 PB

----------- trigger tăng số nhân viên trong phòng ban, số lượng trình độ học vấn 
create trigger trigger_UpdateSoNhanVien on NHANVIEN for insert,update, delete 
as
declare @MaPB1 char(10),@MaPB2 char (10),@MaTDHV1 char (10),@MaTDHV2 char (10)
begin 
		select @MaPB1 =MaPB from inserted
		select @MaPB2 =MaPB from deleted 
		select @MaTDHV1=MaTDHV from inserted
		select @MaTDHV2=MaTDHV from deleted
	
		update PHONGBAN 
		set TongNV=TongNV+1
		where MaPB=@MaPB1

		 Update PHONGBAN
		 set TongNV=TongNV-1
		 where MaPB=@MaPB2

		 Update TRINHDOHOCVAN
		 set SoLuong=SoLuong+1
		 where MaTDHV=@MaTDHV1

		 Update TRINHDOHOCVAN
		 set SoLuong=SoLuong-1
		 where MaTDHV=@MaTDHV2
end

----------------- trigger khi xóa 1 nhân viên sẽ tự động xóa các bản ghi 
----------------- của nhân viên đó ở bảng TheoDoi, THANNHAN, MaTP =null

alter trigger trigger_UpdateTheoDoi on NHANVIEN instead of delete
as
declare @MaNV char(10)
begin 
	select @MaNV =MaNV from deleted
	Update PHONGBAN
	set MaTP=null
	where MaTP=@MaNV
	--- xoa NV ở bảng theo dõi
	Delete THEODOI
	where MaNV = @MaNV
	---- xóa NV ở bảng thân nhân
	Delete THANNHAN
	where MaNV =@MaNV
	------xóa NV 
	Delete NHANVIEN
	where MaNV=@MaNV
end

---------- Proc tìm kiếm nhân viên theo MaNV
create proc SearchNhanVienTheoMaNV(@maNV char (10))
as
begin
	select *from NHANVIEN
	where MaNV=@maNV
end

-------- Proc tim kiem nhan vien theo  Phong Ban
create proc SearchNhanVienTheoPB (@maPB char(10))
as
begin 
	select *from NHANVIEN
	where MaPB=@maPB
end
--------Proc tim kiem nhan vien theo Chuc Vu
create proc SearchNhanVienTheoCV (@maCV char(10))
as
begin 
	select *from CHUCVU
	where MaCV =@maCV
end

----------- Proc tim kiem nhan vien theo TDHV
create proc SearchNhanVienTheoTDHV(@maTDHV char(10))
as
begin 
	select *from NHANVIEN
	where MaTDHV=@maTDHV
end
-------Proco tim kiem nhan vien theo QueQuan
create proc SearchNhanVienTheoQueQuann(@queQuan nvarchar(50))
as
begin 
	select *from NHANVIEN
	where QueQuan=@queQuan
end

-------Proc tim kiem nhan vien theo gioi tinh
create proc SearchNhanVienTheoGT (@gioiTinh nvarchar(50))
as
begin 
	select *from NHANVIEN
	where GioiTinh=@gioiTinh
end
---------- Proc tim kiem Nhan vien theo bac luong 
create proc SearchNhanVienTheoBacLuong(@bacLuong int)
as
begin 
	select *from NHANVIEN
	where BacLuong=@bacLuong
end
------- Proc tim kiem NhanVien theo trang thai
create proc SearchNhanVienTheoTrangThai(@trangThai int )
as 
begin 
	select *from NHANVIEN
	where TrangThai=@trangThai
end
-------------- Table CHUCVU
----- Proc Danh sách chức vụ 
create proc GetListChucVu
as 
begin 
	select *from CHUCVU
end

---------- Proc thêm chức vụ
create proc InsertChucVu(@maCV char(10),@tenCV nvarchar(20))
as
begin 
	insert into CHUCVU(MaCV,TenCV) values (@maCV,@tenCV)
end
 
----------Proc Sửa chức vụ
create proc UpdateChucVu(@maCV char(10),@tenCV nvarchar(20))
as
begin 
	Update CHUCVU
	set TenCV=@tenCV
	where MaCV=@maCV
end
----------- Proc Xóa chức vụ 
create proc DeleteChucVu (@maCV char(10))
as 
begin 
	Delete CHUCVU
	where MaCV=@maCV
end
----------- trigger xóa chức vụ thì bảng NV maCV = null
create trigger trigger_UpdateCVNhanVien on CHUCVU instead of delete 
as 
declare @MaCV char(10)
begin 
	select @MaCV=MaCV from deleted
	Update NHANVIEN
	set MaCV=null
	where MaCV=@MaCV
	Delete CHUCVU
	where MaCV=@MaCV
end
--------- Proc lấy mã chức vụ tiếp theo
create proc GetMaChucVuNext
as 
begin 
	select dbo.func_ma_next((select top 1 MaCV from CHUCVU order by MaCV desc),'CV',6) as MaCV
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
alter trigger trigger_UpdateTDHVNhanVien on TRINHDOHOCVAN instead of delete 
as
declare @MaTDHV char(10)
begin 
	select @MaTDHV=MaTDHV from deleted
	Update NHANVIEN
	set MaTDHV=null
	where MaTDHV=@MaTDHV
	
	Delete TRINHDOHOCVAN
	where MaTDHV=@MaTDHV
END



------ Proc Thêm trình độ học vấn
alter proc InsertTDHV(@maTDHV char(10),@tenTDHV nvarchar(20),@chuyenNganh nvarchar(20))
as
begin 
	insert into TRINHDOHOCVAN(MaTDHV,TenTDHV,ChuyenNganh) values (@MaTDHV,@tenTDHV,@chuyenNganh)
end
---------- Proc Sửa trình độ học vấn
create proc UpdateTDHV(@maTDHV char(10),@tenTDHV nvarchar(20),@chuyenNganh nvarchar(20))
as
begin 
	Update TRINHDOHOCVAN
	set TenTDHV=@tenTDHV,ChuyenNganh=@chuyenNganh
	where MaTDHV=@maTDHV
end
----------- Proc Xóa trình độ học vấn
create proc DeleteTDHV (@maTDHV char(10))
as 
begin
	Delete TRINHDOHOCVAN
	where MaTDHV=@MaTDHV
end




----------- Table THANNHAN



-----Proc get list than nhan hien tai 

create proc GetListThanNhanHienTai
as 
begin 
select *from THANNHAN
where MaNV in (select MaNV from NHANVIEN where TrangThai=1)
end





------------- Table THEODOI 
create proc GetListTheoDoiHienTai
as 
begin 
select *from THEODOI
where MaNV in (select MaNV from NHANVIEN where TrangThai=1)
end



----------- Table TheoDoi

--------- Proc get ma theo doi next
create proc GetMaTheoDoiNext
as
begin 
	select dbo.func_ma_next((select top 1 MaSoTD from THEODOI order by MaSoTD desc),'',4) as MaSoTD
end



------------------ chưa làm  trigger xóa, thêm Nhân ==> so Luong Trinh DO hoc van, Tong so nhan vien PB
---------------------- THEO DOI THANNHAN


---- Thuần 
select *from NHANVIEN