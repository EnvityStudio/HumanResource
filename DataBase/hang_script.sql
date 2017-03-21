/*Than nhan*/
/*GetListThanNhanNV
InsertThanNhan
DeleteThanNhan
UpdateThanNhan
GetListThanNhan
GetMaTNNext
*/

create proc GetListThanNhanNV(@maNV char(10)) 
as
begin
	select *from THANNHAN
	where MaNV=@maNV
end
GetListThanNhanNV NV0003

select *from THANNHAN
delete from THANNHAN
where HoTen='fdg'

alter proc InsertThanNhan(@maNV  char(10) , @maTN char(10), @hoTen nvarchar(50) , @gioiTinh nvarchar(10),  @quanHe nvarchar(50))
as 
begin
	insert into THANNHAN(MaTN,MaNV,HoTen,GioiTinh,QuanHe)
	values (@maTN, @maNV, @hoTen,@gioiTinh,@quanHe)
end

create proc GetMaTNNext 
as
begin
	select dbo.func_ma_next((select top 1 MaTN from THANNHAN order by MaTN desc),'TN',6) as MaPB
end
/*ma sinh tu dong*/
	create function [dbo].[func_ma_next](@last_ma varchar(10),@char1 varchar(3),@size int) returns varchar(10)
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
		
create proc DeleteThanNhan (@maTN char(10))
as
begin
	delete from THANNHAN
	where MaTN=@MaTN
end

select *from THANNHAN
create proc UpdateThanNhan(@maNV  char(10) ,   @maTN char(10) , @hoTen nvarchar(50) , @gioiTinh nvarchar(10),  @quanHe nvarchar(50))
as
begin
	Update THANNHAN
	set MaNV=@maNV, HoTen=@hoTen, GioiTinh=@gioiTinh, QuanHe=@quanHe
	where MaTN=@maTN 
end

UpdateThanNhan 'NV0001','TN0001',N'Lê Minh Vương ','Nam','con'

create proc GetListThanNhan
as
begin
	select *from THANNHAN
end

/*Phong ban*/
/*GetListPhongBan
InsertPhongBan
DeletePhongBan
UpdatePhongBan
GetMaPBNext
TRIGGER
Delete*/

select *from PHONGBAN
create proc GetListPhongBan
as
begin
	select *from PHONGBAN
end	

alter proc InsertPhongBan(@maPB char(10),@tenPB nvarchar(50), @maTP char(10), @diaChi nvarchar (50) , @sdt char(12))
as
begin
	declare @tongNV int
	set @tongNV=0
	insert into PHONGBAN
	values (@maPB,@tenPB,@maTP,@diaChi,@sdt,@tongNV)
end


delete from PHONGBAN where TongNV=0

select *from NHANVIEN

create proc DeletePhongBan(@maPB char(10))
as
begin
	delete from PHONGBAN
	where MaPB=@MaPB
end

create proc UpdatePhongBan(@maPB char(10),@tenPB nvarchar(50), @maTP char(10), @diaChi nvarchar (50) , @sdt char(12))
as
begin
	declare @tongNV int
	set @tongNV=0
	Update PHONGBAN
	set MaPB=@maPB, TenPB=@tenPB, MaTP=@maTP, DiaChi=@diaChi, SDT=@sdt, TongNV=@tongNV 
	where MaPB=@maPB 
end


create proc GetMaPBNext
as 
begin 
	select dbo.func_ma_next((select top 1 MaPB from PHONGBAN order by MaPB desc),'PB',6) as MaPB
end
/*
alter trigger tg_DeletePB on PhongBan for delete
as
declare @maPB char(10)
begin
	Update NHANVIEN
	set MaPB=Null
end
*/
------------ Tạo trigger khi delete 
alter trigger tg_DeletePB on PhongBan instead of delete
as
declare @maPB char(10)
begin
	select @maPB=MaPB from deleted
	
	Update NHANVIEN
	set MaPB=Null
	where MaPB=@maPB

	Delete PHONGBAN
	where MaPB=@maPB

end

/*Luong*/
/*GetListLuong
InsertLuong
DeleteLuong
UpdateLuong
GetBacLuongNext
TRIGGER
Delete*/


create proc GetListLuong
as
begin
	select *from LUONG
end	

create proc InsertLuong(@bacLuong char(10) , @luongCoBan decimal(9,0) , @heSoLuong int , @heSoPhuCap  float)
as
begin
	insert into LUONG
	values (@bacLuong, @luongCoBan,@heSoLuong,@heSoPhuCap)
end


create proc DeleteLuong(@bacLuong char(10))
as
begin
	delete from LUONG
	where BacLuong=@bacLuong
end

create proc UpdateLuong(@bacLuong char(10) , @luongCoBan decimal(9,0) , @heSoLuong int , @heSoPhuCap  float)
as
begin
	Update LUONG
	set LuongCoBan=@luongCoBan, HeSoLuong=@heSoLuong,HeSoPhuCap=@heSoPhuCap
	where BacLuong=@bacLuong
end


create proc GetBacLuongNext
as 
begin 
	select dbo.func_ma_next((select top 1 BacLuong from LUONG order by BacLuong desc),'BL',4) as BacLuong
end
/*
create trigger tg_DeleteLuong on Luong for delete
as
declare @bacLuong char(10)
begin
	Update NHANVIEN
	set BacLuong=Null
end
*/
alter trigger tg_DeleteLuong on Luong instead of  delete
as
declare @bacLuong char(10)
begin
	select @bacLuong=BacLuong from deleted
	Update NHANVIEN
	set BacLuong=Null
	where BacLuong=@bacLuong

	Delete LUONG
	where BacLuong=@bacLuong
end


/*Theo doi*/
/*GetListTheoDoi
InsertTheoDoi
DeleteTheoDoi
UpdateTheoDoi
TheoDoiNhanVien
GetMaTheoDoiNext*/


create proc GetListTheoDoi
as
begin
	select *from THEODOI
end	

create proc InsertTheoDoi(@maTD char(10),  @maNV char(10) ,  @ngayThang date , @suKien  nvarchar(1000))
as
begin
	insert into THEODOI
	values (@maTD,@maNV,@ngayThang,@suKien)
end


create proc DeleteTheoDoi(@maTD char(10))
as
begin
	delete from THEODOI
	where MaSoTD=@maTD
end

create proc UpdateTheoDoi(@maTD char(10),  @maNV char(10) ,  @ngayThang date , @suKien  nvarchar(1000))
as
begin
	Update THEODOI
	set MaNV=@maNV, ThoiGian=@ngayThang, SuKien=@suKien
	where MaSoTD=@maTD
end

/*
create proc GetMaTheoDoiNext
as 
begin 
	select dbo.func_ma_next((select top 1 MaSoTD from THEODOI order by MaSoTD desc),'TD',4) as BacLuong
end
*/

/**/