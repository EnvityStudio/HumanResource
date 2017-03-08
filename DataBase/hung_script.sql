
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

-- Tạo trigger thêm nhân viên

create 