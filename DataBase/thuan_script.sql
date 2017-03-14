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
select *from THOIGIANCONGTAC
select *from Luonghung
select *from NHANVIENTHUANoccho

select *from CHUCVU

abcdec

thuan depo trai
asfadfadfas

