
-- tạo thủ tục lấy danh sách nhân viên
create PROCEDURE  GetListNhanVien
as 
begin
 select * from NHANVIEN
 end

 GetListNhanVien

 -- tạo thủ tục thêm nhân viên
 create PROCEDURE ThemNhanVien (@maNV char(10) , @hoTen nvarchar(50) , @ngaySinh date, @queQuan	nvarchar(50)
								,@gioiTinh nvarchar(10), @danToc nvarchar(50), @sdt decimal(18,0), @maPB char(10), @maCV char(10), @maTDHV char(10), @bacLuong int , @anh char(20))
as
begin
	insert into NHANVIEN(MaNV,HoTen,NgaySinh,QueQuan,GioiTinh,DanToc,Sdt,MaPB,MaCV,MaTDHV,BacLuong,Anh) values(@maNV,@hoTen,@ngaySinh,@queQuan,@gioiTinh,@danToc,@sdt,@maPB,@maCV,@maTDHV,@bacLuong,@anh)
end

----- tạo trigger tăng mã tự động cho nhân viên 
	create trigger trigger_next_MaNhanVien on NHANVIEN for insert
	as 
	begin 
	declare @last_ma varchar(10)
		set @last_ma=(select Top 1 MaNV from NHANVIEN order by MaNV desc)
		update NHANVIEN set MaNV=(select dbo.func_ma_next(@last_ma,'NV',5)) where MaNV=''
		end


drop procedure ThemNhanVien

create procedure ThemNhanVien ( @hoTen nvarchar(50) , @ngaySinh date, @queQuan	nvarchar(50)
								,@gioiTinh nvarchar(10), @danToc nvarchar(50), @sdt decimal(18,0), @maPB char(10), @maCV char(10), @maTDHV char(10), @bacLuong int , @anh char(20))
as
begin 
insert into NHANVIEN values('',@hoTen,@ngaySinh,@queQuan,@gioiTinh,@danToc,@sdt,@maPB,@maCV,@maTDHV,@bacLuong,@anh)
end

ThemNhanVien (N'Alex Hưng','1995/04/12',N'Hà Nội',N'Nam',N'Kinh','01342324','PB001','CV001','TDHV01','1','alexHung.jpg')

insert into NHANVIEN values ('',N'Alex Tran','1996/02/12',N'Hà Nội',N'Nam',N'Kinh','01665324','PB001','CV001','TDHV01','1','alexnguyen.jpg')

select * from NHANVIEN 

drop procedure ThemNhanVien

create procedure GetListNhanVien
as
	begin
		select * from NHANVIEN 
	end