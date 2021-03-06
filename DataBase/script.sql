USE [master]
GO
/****** Object:  Database [HumanResource]    Script Date: 5/25/2017 4:32:31 PM ******/
CREATE DATABASE [HumanResource]
 GO
EXEC sys.sp_db_vardecimal_storage_format N'HumanResource', N'ON'
GO
USE [HumanResource]
GO
/****** Object:  UserDefinedFunction [dbo].[func_ma_next]    Script Date: 5/25/2017 4:32:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[func_ma_next](@last_ma varchar(10),@char1 varchar(6),@size int) returns varchar(10)
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



GO
/****** Object:  Table [dbo].[CHUCVU]    Script Date: 5/25/2017 4:32:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHUCVU](
	[MaCV] [char](10) NOT NULL,
	[TenCV] [nvarchar](50) NULL,
 CONSTRAINT [PK_CHUCVU] PRIMARY KEY CLUSTERED 
(
	[MaCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LUONG]    Script Date: 5/25/2017 4:32:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LUONG](
	[BacLuong] [char](10) NOT NULL,
	[LuongCoBan] [decimal](9, 0) NULL,
	[HeSoLuong] [float] NULL,
	[HeSoPhuCap] [float] NULL,
 CONSTRAINT [PK_LUONG] PRIMARY KEY CLUSTERED 
(
	[BacLuong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 5/25/2017 4:32:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [char](10) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[SDT] [char](12) NULL,
	[QueQuan] [nvarchar](500) NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[DanToc] [nvarchar](50) NULL,
	[MaPB] [char](10) NULL,
	[MaCV] [char](10) NULL,
	[MaTDHV] [char](10) NULL,
	[BacLuong] [char](10) NULL,
	[Anh] [nvarchar](500) NULL,
	[MatKhau] [varchar](50) NULL,
	[TrangThai] [int] NULL,
	[CMND] [char](20) NULL,
	[Email] [varchar](50) NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHONGBAN]    Script Date: 5/25/2017 4:32:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHONGBAN](
	[MaPB] [char](10) NOT NULL,
	[TenPB] [nvarchar](50) NULL,
	[MaTP] [char](10) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [char](12) NULL,
	[TongNV] [int] NULL,
 CONSTRAINT [PK_PHONGBAN] PRIMARY KEY CLUSTERED 
(
	[MaPB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[THANNHAN]    Script Date: 5/25/2017 4:32:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[THANNHAN](
	[MaTN] [char](10) NOT NULL,
	[MaNV] [char](10) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[QuanHe] [nvarchar](50) NULL,
 CONSTRAINT [PK_THANNHAN] PRIMARY KEY CLUSTERED 
(
	[MaTN] ASC,
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[THEODOI]    Script Date: 5/25/2017 4:32:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[THEODOI](
	[MaSoTD] [char](10) NOT NULL,
	[MaNV] [char](10) NOT NULL,
	[ThoiGian] [date] NULL,
	[SuKien] [nvarchar](1000) NULL,
 CONSTRAINT [PK_THEODOI] PRIMARY KEY CLUSTERED 
(
	[MaSoTD] ASC,
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TRINHDOHOCVAN]    Script Date: 5/25/2017 4:32:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TRINHDOHOCVAN](
	[MaTDHV] [char](10) NOT NULL,
	[TenTDHV] [nvarchar](50) NULL,
	[ChuyenNganh] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_TRINHDOHOCVAN] PRIMARY KEY CLUSTERED 
(
	[MaTDHV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[CHUCVU] ([MaCV], [TenCV]) VALUES (N'CV0001    ', N'Trưởng phòng')
INSERT [dbo].[CHUCVU] ([MaCV], [TenCV]) VALUES (N'CV0002    ', N'Nhân viên')
INSERT [dbo].[CHUCVU] ([MaCV], [TenCV]) VALUES (N'CV0003    ', N'Giám đốc')
INSERT [dbo].[CHUCVU] ([MaCV], [TenCV]) VALUES (N'CV0004    ', N'Cộng tác viên')
INSERT [dbo].[CHUCVU] ([MaCV], [TenCV]) VALUES (N'CV0005    ', N'Phó phòng')
INSERT [dbo].[CHUCVU] ([MaCV], [TenCV]) VALUES (N'CV0006    ', N'ddd')
INSERT [dbo].[CHUCVU] ([MaCV], [TenCV]) VALUES (N'CV0007    ', N'dsafdasf')
INSERT [dbo].[CHUCVU] ([MaCV], [TenCV]) VALUES (N'CV0008    ', N'ddd')
INSERT [dbo].[LUONG] ([BacLuong], [LuongCoBan], [HeSoLuong], [HeSoPhuCap]) VALUES (N'BL01      ', CAST(4000000 AS Decimal(9, 0)), 1, 0.5)
INSERT [dbo].[LUONG] ([BacLuong], [LuongCoBan], [HeSoLuong], [HeSoPhuCap]) VALUES (N'BL02      ', CAST(5000000 AS Decimal(9, 0)), 1, 0.5)
INSERT [dbo].[LUONG] ([BacLuong], [LuongCoBan], [HeSoLuong], [HeSoPhuCap]) VALUES (N'BL03      ', CAST(6000000 AS Decimal(9, 0)), 1, 0.5)
INSERT [dbo].[LUONG] ([BacLuong], [LuongCoBan], [HeSoLuong], [HeSoPhuCap]) VALUES (N'BL04      ', CAST(7000000 AS Decimal(9, 0)), 1, 0.5)
INSERT [dbo].[LUONG] ([BacLuong], [LuongCoBan], [HeSoLuong], [HeSoPhuCap]) VALUES (N'BL05      ', CAST(8000000 AS Decimal(9, 0)), 1, 0.5)
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [NgaySinh], [SDT], [QueQuan], [GioiTinh], [DanToc], [MaPB], [MaCV], [MaTDHV], [BacLuong], [Anh], [MatKhau], [TrangThai], [CMND], [Email]) VALUES (N'NV0001    ', N'Bùi Kim Quyên', CAST(N'1991-07-08' AS Date), N'0165321569  ', N'Hà Nội', N'Nữ', N'Kinh', N'PB0001    ', N'CV0001    ', N'TDHV02    ', N'BL01      ', N'/Resource/15181642_201002527022868_448714124136008389_n.jpg                                                                                                                                                                                                                                                                                                                                                                                                                                                         ', N'123', 1, N'123456789           ', N'ABC1@gmail.com')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [NgaySinh], [SDT], [QueQuan], [GioiTinh], [DanToc], [MaPB], [MaCV], [MaTDHV], [BacLuong], [Anh], [MatKhau], [TrangThai], [CMND], [Email]) VALUES (N'NV0002    ', N'Võ An Phước Thiện', CAST(N'1989-01-25' AS Date), N'0976425368  ', N'Hải Phòng', N'Nam', N'Kinh', N'PB0001    ', N'CV0001    ', N'TDHV01    ', N'BL01      ', N'/Resource/2.jpg', N'123', 0, N'123456788           ', N'ABC2@gmail.com')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [NgaySinh], [SDT], [QueQuan], [GioiTinh], [DanToc], [MaPB], [MaCV], [MaTDHV], [BacLuong], [Anh], [MatKhau], [TrangThai], [CMND], [Email]) VALUES (N'NV0003    ', N'Phạm Nguyễn Quỳnh', CAST(N'1987-04-28' AS Date), N'0125342150  ', N'Bắc Ninh', N'Nữ', N'Kinh', N'PB0001    ', N'CV0001    ', N'TDHV01    ', N'BL01      ', N'D:\Workspace\HumanResource\HumanResource/Resource/noimage.png                                                                                                                                                                                                                                                                                                                                                                                                                                                       ', N'213', 1, N'123456777           ', N'ABC4@gmail.com')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [NgaySinh], [SDT], [QueQuan], [GioiTinh], [DanToc], [MaPB], [MaCV], [MaTDHV], [BacLuong], [Anh], [MatKhau], [TrangThai], [CMND], [Email]) VALUES (N'NV0005    ', N'Phan Vinh Bính', CAST(N'1992-08-28' AS Date), N'0967201630  ', N'Hà Nội', N'Nam', N'Kinh', N'PB0001    ', N'CV0001    ', N'TDHV01    ', N'BL01      ', NULL, NULL, 1, N'123456778           ', N'noname1@gmail.com')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [NgaySinh], [SDT], [QueQuan], [GioiTinh], [DanToc], [MaPB], [MaCV], [MaTDHV], [BacLuong], [Anh], [MatKhau], [TrangThai], [CMND], [Email]) VALUES (N'NV0006    ', N'Võ Minh Thư', CAST(N'1994-10-21' AS Date), N'0972531658  ', N'Hà Nội', N'Nữ', N'Kinh', N'PB0002    ', N'CV0002    ', N'TDHV01    ', N'BL02      ', NULL, NULL, 1, N'123456768           ', N'noname2@gmail.com')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [NgaySinh], [SDT], [QueQuan], [GioiTinh], [DanToc], [MaPB], [MaCV], [MaTDHV], [BacLuong], [Anh], [MatKhau], [TrangThai], [CMND], [Email]) VALUES (N'NV0007    ', N'Phan Huỳnh Ngọc', CAST(N'1993-01-22' AS Date), N'01668542301 ', N'Thái Bình', N'Nữ', N'Kinh', N'PB0002    ', N'CV0002    ', N'TDHV01    ', N'BL02      ', NULL, NULL, 1, N'123456711           ', N'noname3@gmail.com')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [NgaySinh], [SDT], [QueQuan], [GioiTinh], [DanToc], [MaPB], [MaCV], [MaTDHV], [BacLuong], [Anh], [MatKhau], [TrangThai], [CMND], [Email]) VALUES (N'NV0008    ', N'Cao Thị Hiền', CAST(N'1992-06-01' AS Date), N'0914162689  ', N'Hà Nội', N'Nữ', N'Kinh', N'PB0002    ', N'CV0002    ', N'TDHV01    ', N'BL02      ', NULL, NULL, 1, N'123456011           ', N'noname4@gmail.com')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [NgaySinh], [SDT], [QueQuan], [GioiTinh], [DanToc], [MaPB], [MaCV], [MaTDHV], [BacLuong], [Anh], [MatKhau], [TrangThai], [CMND], [Email]) VALUES (N'NV0009    ', N'Tạ Thị Thanh', CAST(N'1993-09-07' AS Date), N'01669788679 ', N'Thái Bình', N'Nữ', N'Kinh', N'PB0002    ', N'CV0002    ', N'TDHV02    ', N'BL02      ', NULL, NULL, 1, N'123456355           ', N'noname5@gmail.com')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [NgaySinh], [SDT], [QueQuan], [GioiTinh], [DanToc], [MaPB], [MaCV], [MaTDHV], [BacLuong], [Anh], [MatKhau], [TrangThai], [CMND], [Email]) VALUES (N'NV0010    ', N'Võ Thị Tuyết', CAST(N'1991-04-10' AS Date), N'0978178764  ', N'Thái Bình', N'Nữ', N'Kinh', N'PB0003    ', N'CV0002    ', N'TDHV02    ', N'BL02      ', NULL, NULL, 1, N'123456955           ', N'noname6@gmail.com')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [NgaySinh], [SDT], [QueQuan], [GioiTinh], [DanToc], [MaPB], [MaCV], [MaTDHV], [BacLuong], [Anh], [MatKhau], [TrangThai], [CMND], [Email]) VALUES (N'NV0011    ', N'Mai Khánh Vân', CAST(N'1990-11-06' AS Date), N'0979809204  ', N'Hà Nội', N'Nữ', N'Kinh', N'PB0003    ', N'CV0002    ', N'TDHV02    ', N'BL02      ', N'C:\Users\khanhlq\Doc', N'123', 1, N'123456966           ', N'unknow1@gmail.com')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [NgaySinh], [SDT], [QueQuan], [GioiTinh], [DanToc], [MaPB], [MaCV], [MaTDHV], [BacLuong], [Anh], [MatKhau], [TrangThai], [CMND], [Email]) VALUES (N'NV0012    ', N'Đoàn Thị Mỹ', CAST(N'1986-06-18' AS Date), N'0905682529  ', N'Hà Nội', N'Nữ', N'Kinh', N'PB0003    ', N'CV0003    ', N'TDHV02    ', N'BL02      ', NULL, NULL, 1, N'123456311           ', N'unknow2@gmail.com')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [NgaySinh], [SDT], [QueQuan], [GioiTinh], [DanToc], [MaPB], [MaCV], [MaTDHV], [BacLuong], [Anh], [MatKhau], [TrangThai], [CMND], [Email]) VALUES (N'NV0013    ', N'Doãn Phan Trung', CAST(N'1993-07-17' AS Date), N'0982725726  ', N'Nam Định', N'Nam', N'Tày', N'PB0003    ', N'CV0003    ', N'TDHV02    ', N'BL03      ', NULL, NULL, 1, N'123456023           ', N'unknow3@gmail.com')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [NgaySinh], [SDT], [QueQuan], [GioiTinh], [DanToc], [MaPB], [MaCV], [MaTDHV], [BacLuong], [Anh], [MatKhau], [TrangThai], [CMND], [Email]) VALUES (N'NV0014    ', N'Lâm Ngọc Linh', CAST(N'1991-01-01' AS Date), N'0937303282  ', N'Hà Nội', N'Nữ', N'Kinh', N'PB0003    ', N'CV0003    ', N'TDHV03    ', N'BL03      ', NULL, NULL, 1, N'123456872           ', N'unknow4@gmail.com')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [NgaySinh], [SDT], [QueQuan], [GioiTinh], [DanToc], [MaPB], [MaCV], [MaTDHV], [BacLuong], [Anh], [MatKhau], [TrangThai], [CMND], [Email]) VALUES (N'NV0015    ', N'Nguyễn Minh Châu', CAST(N'1992-04-26' AS Date), N'0974131489  ', N'Nam Định', N'Nam', N'Kinh', N'PB0003    ', N'CV0003    ', N'TDHV03    ', N'BL03      ', NULL, NULL, 1, N'123456300           ', N'unknow5@gmail.com')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [NgaySinh], [SDT], [QueQuan], [GioiTinh], [DanToc], [MaPB], [MaCV], [MaTDHV], [BacLuong], [Anh], [MatKhau], [TrangThai], [CMND], [Email]) VALUES (N'NV0016    ', N'Nguyễn Thạch Giang', CAST(N'1984-10-06' AS Date), N'0984084034  ', N'Nam Định', N'Nam', N'Kinh', N'PB0004    ', N'CV0004    ', N'TDHV03    ', N'BL04      ', NULL, NULL, 1, N'123456893           ', N'unknow6@gmail.com')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [NgaySinh], [SDT], [QueQuan], [GioiTinh], [DanToc], [MaPB], [MaCV], [MaTDHV], [BacLuong], [Anh], [MatKhau], [TrangThai], [CMND], [Email]) VALUES (N'NV0017    ', N'Võ Tường Duy', CAST(N'1991-10-16' AS Date), N'0977557349  ', N'Hà Nội', N'Nam', N'Kinh', N'PB0004    ', N'CV0004    ', N'TDHV03    ', N'BL04      ', NULL, NULL, 1, N'123456678           ', N'NULL1@gmail.com')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [NgaySinh], [SDT], [QueQuan], [GioiTinh], [DanToc], [MaPB], [MaCV], [MaTDHV], [BacLuong], [Anh], [MatKhau], [TrangThai], [CMND], [Email]) VALUES (N'NV0018    ', N'Trần Thị Kim Ngân', CAST(N'1992-08-08' AS Date), N'01649616718 ', N'Hải Dương', N'Nữ', N'Kinh', N'PB0004    ', N'CV0004    ', N'TDHV04    ', N'BL04      ', NULL, NULL, 1, N'123456870           ', N'NULL2@gmail.com')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [NgaySinh], [SDT], [QueQuan], [GioiTinh], [DanToc], [MaPB], [MaCV], [MaTDHV], [BacLuong], [Anh], [MatKhau], [TrangThai], [CMND], [Email]) VALUES (N'NV0020    ', N'admin', CAST(N'2017-03-07' AS Date), N'23          ', N'123', N'Nam', N'123', N'PB0001    ', N'CV0001    ', N'TDHV01    ', N'BL01      ', N'D:\wallpaper\1.png                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  ', N'123', NULL, N'3                   ', N'23')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [NgaySinh], [SDT], [QueQuan], [GioiTinh], [DanToc], [MaPB], [MaCV], [MaTDHV], [BacLuong], [Anh], [MatKhau], [TrangThai], [CMND], [Email]) VALUES (N'NV0021    ', N'Lê Khánh', CAST(N'1991-04-08' AS Date), N'0164768912  ', N'Hà Nam', N'Nam', N'Kinh', N'PB0002    ', N'CV0001    ', N'TDHV03    ', N'BL01      ', N'D:\wallpaper\1.png                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  ', N'12345 ', NULL, N'168549898           ', N'khanhle@gmail.com')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [NgaySinh], [SDT], [QueQuan], [GioiTinh], [DanToc], [MaPB], [MaCV], [MaTDHV], [BacLuong], [Anh], [MatKhau], [TrangThai], [CMND], [Email]) VALUES (N'NV0022    ', N'Thuan nguyen', CAST(N'2017-05-09' AS Date), N'21314       ', N'Ha No', N'Nam', N'kinh', N'PB0001    ', N'CV0001    ', N'TDHV01    ', N'BL01      ', N'D:\Workspace\HumanResource\HumanResource\Resource\noimage.png                                                                                                                                                                                                                                                                                                                                                                                                                                                       ', N'1234', NULL, N'12332464            ', N'thuan@gmail')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [NgaySinh], [SDT], [QueQuan], [GioiTinh], [DanToc], [MaPB], [MaCV], [MaTDHV], [BacLuong], [Anh], [MatKhau], [TrangThai], [CMND], [Email]) VALUES (N'NV0024    ', N'Nguyễn Văn A', CAST(N'2017-05-18' AS Date), N'016524      ', N'Hải Phòng', N'Nam', N'kinh', N'PB0001    ', N'CV0001    ', N'TDHV01    ', N'BL01      ', N'D:\Workspace\HumanResource\HumanResource/Resource/noimage.png                                                                                                                                                                                                                                                                                                                                                                                                                                                       ', N'                    ', NULL, N'02365489165         ', N'hung@gail,com')
INSERT [dbo].[PHONGBAN] ([MaPB], [TenPB], [MaTP], [DiaChi], [SDT], [TongNV]) VALUES (N'PB0001    ', N'Hành chính', N'NV0001    ', N'Tầng 10, A1', N'043.7655121 ', 7)
INSERT [dbo].[PHONGBAN] ([MaPB], [TenPB], [MaTP], [DiaChi], [SDT], [TongNV]) VALUES (N'PB0002    ', N'Nhân sự', N'NV0008    ', N'Tầng 10, A2', N'043.7655121 ', 5)
INSERT [dbo].[PHONGBAN] ([MaPB], [TenPB], [MaTP], [DiaChi], [SDT], [TongNV]) VALUES (N'PB0003    ', N'Truyền thông', N'NV0010    ', N'Tầng 10, A3', N'043.7655121 ', 6)
INSERT [dbo].[PHONGBAN] ([MaPB], [TenPB], [MaTP], [DiaChi], [SDT], [TongNV]) VALUES (N'PB0004    ', N'Kinh doanh', N'NV0003    ', N'Tầng 10, A4', N'043.7655121 ', 0)
INSERT [dbo].[PHONGBAN] ([MaPB], [TenPB], [MaTP], [DiaChi], [SDT], [TongNV]) VALUES (N'PB0006    ', N'Quản lý', N'NV0011    ', N'Tầng 9, A9', N'043.7655121 ', 0)
INSERT [dbo].[THANNHAN] ([MaTN], [MaNV], [HoTen], [GioiTinh], [QuanHe]) VALUES (N'TN0001    ', N'NV0001    ', N'Lê Minh Vương ', N'Nam', N'con')
INSERT [dbo].[THANNHAN] ([MaTN], [MaNV], [HoTen], [GioiTinh], [QuanHe]) VALUES (N'TN0002    ', N'NV0001    ', N'Nguyễn Thiện Toàn', N'Nam', N'Con')
INSERT [dbo].[THANNHAN] ([MaTN], [MaNV], [HoTen], [GioiTinh], [QuanHe]) VALUES (N'TN0003    ', N'NV0009    ', N'Trương Gia Mẫn', N'Nam', N'Con')
INSERT [dbo].[THANNHAN] ([MaTN], [MaNV], [HoTen], [GioiTinh], [QuanHe]) VALUES (N'TN0005    ', N'NV0006    ', N'Châu Thị Kim Anh', N'Nữ', N'Con')
INSERT [dbo].[THANNHAN] ([MaTN], [MaNV], [HoTen], [GioiTinh], [QuanHe]) VALUES (N'TN0006    ', N'NV0010    ', N'abc', N'Nam', N'rộng')
INSERT [dbo].[THANNHAN] ([MaTN], [MaNV], [HoTen], [GioiTinh], [QuanHe]) VALUES (N'TN0007    ', N'NV0022    ', N'sdfg', N'Nữ', N'gfdsg')
INSERT [dbo].[THANNHAN] ([MaTN], [MaNV], [HoTen], [GioiTinh], [QuanHe]) VALUES (N'TN0008    ', N'NV0007    ', N'thuan', N'Nam', N'con')
INSERT [dbo].[THANNHAN] ([MaTN], [MaNV], [HoTen], [GioiTinh], [QuanHe]) VALUES (N'TN0009    ', N'NV0002    ', N'd', N'Nam', N'd')
INSERT [dbo].[THANNHAN] ([MaTN], [MaNV], [HoTen], [GioiTinh], [QuanHe]) VALUES (N'TN0010    ', N'NV0005    ', N'af', N'Nam', N'dad')
INSERT [dbo].[THANNHAN] ([MaTN], [MaNV], [HoTen], [GioiTinh], [QuanHe]) VALUES (N'TN0011    ', N'NV0006    ', N'gf', N'Nam', N'fdgsdg')
INSERT [dbo].[THEODOI] ([MaSoTD], [MaNV], [ThoiGian], [SuKien]) VALUES (N'0001      ', N'NV0001    ', CAST(N'2017-03-08' AS Date), N'Đạt huân chương lao động hạng 1')
INSERT [dbo].[THEODOI] ([MaSoTD], [MaNV], [ThoiGian], [SuKien]) VALUES (N'0003      ', N'NV0008    ', CAST(N'2017-02-08' AS Date), N'Đạt huân chương lao động hạng 3')
INSERT [dbo].[THEODOI] ([MaSoTD], [MaNV], [ThoiGian], [SuKien]) VALUES (N'0004      ', N'NV0010    ', CAST(N'2017-01-08' AS Date), N'Đạt huân chương lao động hạng 4')
INSERT [dbo].[THEODOI] ([MaSoTD], [MaNV], [ThoiGian], [SuKien]) VALUES (N'0005      ', N'NV0001    ', CAST(N'2017-01-09' AS Date), N'Đạt huân chương lao động hạng 5')
INSERT [dbo].[THEODOI] ([MaSoTD], [MaNV], [ThoiGian], [SuKien]) VALUES (N'0006      ', N'NV0001    ', CAST(N'2017-02-25' AS Date), N'')
INSERT [dbo].[THEODOI] ([MaSoTD], [MaNV], [ThoiGian], [SuKien]) VALUES (N'0007      ', N'NV0001    ', CAST(N'2017-02-25' AS Date), N'sssssssssss')
INSERT [dbo].[THEODOI] ([MaSoTD], [MaNV], [ThoiGian], [SuKien]) VALUES (N'0008      ', N'NV0016    ', CAST(N'2017-05-22' AS Date), N'test 2')
INSERT [dbo].[TRINHDOHOCVAN] ([MaTDHV], [TenTDHV], [ChuyenNganh], [SoLuong]) VALUES (N'TDHV01    ', N'Trung cấp', N'Tiếng Hàn', 8)
INSERT [dbo].[TRINHDOHOCVAN] ([MaTDHV], [TenTDHV], [ChuyenNganh], [SoLuong]) VALUES (N'TDHV02    ', N'Cao đẳng', N'Tiếng Nhật', 6)
INSERT [dbo].[TRINHDOHOCVAN] ([MaTDHV], [TenTDHV], [ChuyenNganh], [SoLuong]) VALUES (N'TDHV03    ', N'Đại học', N'Công nghệ thông tin', 5)
INSERT [dbo].[TRINHDOHOCVAN] ([MaTDHV], [TenTDHV], [ChuyenNganh], [SoLuong]) VALUES (N'TDHV04    ', N'Đại học', N'Marketing', 1)
INSERT [dbo].[TRINHDOHOCVAN] ([MaTDHV], [TenTDHV], [ChuyenNganh], [SoLuong]) VALUES (N'TDHV05    ', N'Thạc sĩ', N'Công nghệ thông tin', 0)
INSERT [dbo].[TRINHDOHOCVAN] ([MaTDHV], [TenTDHV], [ChuyenNganh], [SoLuong]) VALUES (N'TDHV06    ', N'Cao đẳng', N'Công nghệ thông tin', 0)
INSERT [dbo].[TRINHDOHOCVAN] ([MaTDHV], [TenTDHV], [ChuyenNganh], [SoLuong]) VALUES (N'TDHV07    ', N'Đại học', N'Điện tử viễn thông', 0)
INSERT [dbo].[TRINHDOHOCVAN] ([MaTDHV], [TenTDHV], [ChuyenNganh], [SoLuong]) VALUES (N'TDHV08    ', N'Đại học', N'Kế toán', 0)
INSERT [dbo].[TRINHDOHOCVAN] ([MaTDHV], [TenTDHV], [ChuyenNganh], [SoLuong]) VALUES (N'TDHV09    ', N'Thạc sĩ', N'Kinh tế đối ngoại', 0)
INSERT [dbo].[TRINHDOHOCVAN] ([MaTDHV], [TenTDHV], [ChuyenNganh], [SoLuong]) VALUES (N'TDHV10    ', N'Đại học', N'Kinh tế doanh nghiệp', 0)
INSERT [dbo].[TRINHDOHOCVAN] ([MaTDHV], [TenTDHV], [ChuyenNganh], [SoLuong]) VALUES (N'TDHV11    ', N'fsadf', N'fadsfas', 0)
INSERT [dbo].[TRINHDOHOCVAN] ([MaTDHV], [TenTDHV], [ChuyenNganh], [SoLuong]) VALUES (N'TDHV12    ', N'', N'', 0)
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_CHUCVU] FOREIGN KEY([MaCV])
REFERENCES [dbo].[CHUCVU] ([MaCV])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_CHUCVU]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_LUONG] FOREIGN KEY([BacLuong])
REFERENCES [dbo].[LUONG] ([BacLuong])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_LUONG]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_PHONGBAN] FOREIGN KEY([MaPB])
REFERENCES [dbo].[PHONGBAN] ([MaPB])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_PHONGBAN]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_TRINHDOHOCVAN] FOREIGN KEY([MaTDHV])
REFERENCES [dbo].[TRINHDOHOCVAN] ([MaTDHV])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_TRINHDOHOCVAN]
GO
ALTER TABLE [dbo].[PHONGBAN]  WITH CHECK ADD  CONSTRAINT [FK_PHONGBAN_NHANVIEN] FOREIGN KEY([MaTP])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[PHONGBAN] CHECK CONSTRAINT [FK_PHONGBAN_NHANVIEN]
GO
ALTER TABLE [dbo].[THANNHAN]  WITH CHECK ADD  CONSTRAINT [FK_THANNHAN_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[THANNHAN] CHECK CONSTRAINT [FK_THANNHAN_NHANVIEN]
GO
ALTER TABLE [dbo].[THEODOI]  WITH CHECK ADD  CONSTRAINT [FK_THEODOI_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[THEODOI] CHECK CONSTRAINT [FK_THEODOI_NHANVIEN]
GO
/****** Object:  StoredProcedure [dbo].[DeleteChucVu]    Script Date: 5/25/2017 4:32:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteChucVu] (@maCV char(10))
as 
begin 
	Delete CHUCVU
	where MaCV=@maCV
end


GO
/****** Object:  StoredProcedure [dbo].[DeleteLuong]    Script Date: 5/25/2017 4:32:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteLuong](@bacLuong char(10))
as
begin
	delete from LUONG
	where BacLuong=@bacLuong
end


GO
/****** Object:  StoredProcedure [dbo].[DeleteNhanVien]    Script Date: 5/25/2017 4:32:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteNhanVien](@maNV char(10))
as 
begin 
	Delete NHANVIEN
	where MaNV=@maNV
end


GO
/****** Object:  StoredProcedure [dbo].[DeletePhongBan]    Script Date: 5/25/2017 4:32:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[DeletePhongBan](@maPB char(10))
as
begin
	delete from PHONGBAN
	where MaPB=@MaPB
end


GO
/****** Object:  StoredProcedure [dbo].[DeleteTDHV]    Script Date: 5/25/2017 4:32:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteTDHV] (@maTDHV char(10))
as 
begin
	Delete TRINHDOHOCVAN
	where MaTDHV=@MaTDHV
end


GO
/****** Object:  StoredProcedure [dbo].[DeleteThanNhan]    Script Date: 5/25/2017 4:32:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteThanNhan] (@maTN char(10))
as
begin
	delete from THANNHAN
	where MaTN=@MaTN
end



GO
/****** Object:  StoredProcedure [dbo].[DeleteTheoDoi]    Script Date: 5/25/2017 4:32:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[DeleteTheoDoi](@maTD char(10))
as
begin
	delete from THEODOI
	where MaSoTD=@maTD
end


GO
/****** Object:  StoredProcedure [dbo].[GetBacLuongNext]    Script Date: 5/25/2017 4:32:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[GetBacLuongNext]
as 
begin 
	select dbo.func_ma_next((select top 1 BacLuong from LUONG order by BacLuong desc),'BL',4) as BacLuong
end


GO
/****** Object:  StoredProcedure [dbo].[GetListChucVu]    Script Date: 5/25/2017 4:32:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetListChucVu]
as 
begin 
	select *from CHUCVU
end


GO
/****** Object:  StoredProcedure [dbo].[GetListLuong]    Script Date: 5/25/2017 4:32:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetListLuong]
as
begin
	select *from LUONG
end	


GO
/****** Object:  StoredProcedure [dbo].[GetListNhanVien]    Script Date: 5/25/2017 4:32:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetListNhanVien]
as 
begin 
	select *from NHANVIEN
end



GO
/****** Object:  StoredProcedure [dbo].[GetListNhanVienHienTai]    Script Date: 5/25/2017 4:32:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetListNhanVienHienTai]
as 
begin 
	select *from NHANVIEN
	where TrangThai=1
end


GO
/****** Object:  StoredProcedure [dbo].[GetListPhongBan]    Script Date: 5/25/2017 4:32:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetListPhongBan]
as
begin
	select *from PHONGBAN
end	



GO
/****** Object:  StoredProcedure [dbo].[GetListThanNhan]    Script Date: 5/25/2017 4:32:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetListThanNhan]
as
begin
	select *from THANNHAN
end


GO
/****** Object:  StoredProcedure [dbo].[GetListThanNhanHienTai]    Script Date: 5/25/2017 4:32:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetListThanNhanHienTai]
as 
begin 
select *from THANNHAN
where MaNV in (select MaNV from NHANVIEN where TrangThai=1)
end





GO
/****** Object:  StoredProcedure [dbo].[GetListThanNhanNV]    Script Date: 5/25/2017 4:32:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetListThanNhanNV](@maNV char(10)) 
as
begin
	select *from THANNHAN
	where MaNV=@maNV
end


GO
/****** Object:  StoredProcedure [dbo].[GetListTheoDoi]    Script Date: 5/25/2017 4:32:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetListTheoDoi]
as
begin
	select *from THEODOI
end	



GO
/****** Object:  StoredProcedure [dbo].[GetListTheoDoiHienTai]    Script Date: 5/25/2017 4:32:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetListTheoDoiHienTai]
as 
begin 
select *from THEODOI
where MaNV in (select MaNV from NHANVIEN where TrangThai=1)
end




GO
/****** Object:  StoredProcedure [dbo].[GetListTrinhDoHocVan]    Script Date: 5/25/2017 4:32:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetListTrinhDoHocVan]
as 
begin 
	select *from TRINHDOHOCVAN
end


GO
/****** Object:  StoredProcedure [dbo].[GetMaChucVuNext]    Script Date: 5/25/2017 4:32:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetMaChucVuNext]
as 
begin 
	select dbo.func_ma_next((select top 1 MaCV from CHUCVU order by MaCV desc),'CV',6) as MaCV
end


GO
/****** Object:  StoredProcedure [dbo].[GetMaNVNext]    Script Date: 5/25/2017 4:32:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetMaNVNext]
as
begin 
	select dbo.func_ma_next((select Top 1 MaNV from NHANVIEN order by MaNV desc),'NV','6') as MaNV
end


GO
/****** Object:  StoredProcedure [dbo].[GetMaPBNext]    Script Date: 5/25/2017 4:32:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetMaPBNext]
as 
begin 
	select dbo.func_ma_next((select top 1 MaPB from PHONGBAN order by MaPB desc),'PB',6) as MaPB
end



GO
/****** Object:  StoredProcedure [dbo].[GetMaTDHVNext]    Script Date: 5/25/2017 4:32:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetMaTDHVNext]
as 
begin 
	select dbo.func_ma_next((select top 1 MaTDHV from TRINHDOHOCVAN order by MaTDHV desc),'TDHV',6) as MaTDHV
end


GO
/****** Object:  StoredProcedure [dbo].[GetMaTheoDoiNext]    Script Date: 5/25/2017 4:32:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--------- Proc get ma theo doi next
create proc [dbo].[GetMaTheoDoiNext]
as
begin 
	select dbo.func_ma_next((select top 1 MaSoTD from THEODOI order by MaSoTD desc),'',4) as MaSoTD
end



GO
/****** Object:  StoredProcedure [dbo].[GetMaTNNext]    Script Date: 5/25/2017 4:32:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetMaTNNext] 
as
begin
	select dbo.func_ma_next((select top 1 MaTN from THANNHAN order by MaTN desc),'TN',6) as MaTN
end


GO
/****** Object:  StoredProcedure [dbo].[getNamNhanVien]    Script Date: 5/25/2017 4:32:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getNamNhanVien] 
as
begin 
	select *from NHANVIEN
	where GioiTinh= N'nam'
end

GO
/****** Object:  StoredProcedure [dbo].[getNuNhanVien]    Script Date: 5/25/2017 4:32:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getNuNhanVien] 
as
begin 
	select *from NHANVIEN
	where GioiTinh= N'nữ'
end

GO
/****** Object:  StoredProcedure [dbo].[InsertChucVu]    Script Date: 5/25/2017 4:32:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InsertChucVu](@maCV char(10),@tenCV nvarchar(20))
as
begin 
	insert into CHUCVU(MaCV,TenCV) values (@maCV,@tenCV)
end


GO
/****** Object:  StoredProcedure [dbo].[InsertLuong]    Script Date: 5/25/2017 4:32:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InsertLuong](@bacLuong char(10) , @luongCoBan decimal(9,0) , @heSoLuong int , @heSoPhuCap  float)
as
begin
	insert into LUONG
	values (@bacLuong, @luongCoBan,@heSoLuong,@heSoPhuCap)
end



GO
/****** Object:  StoredProcedure [dbo].[InsertNhanVien]    Script Date: 5/25/2017 4:32:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertNhanVien] (@maNV char(10) , @hoTen nvarchar(50) , @ngaySinh date,@SDT char(10), @queQuan	nvarchar(500)
								,@gioiTinh nvarchar(10), @danToc nvarchar(50),@maPB char(10), @maCV char(10), @maTDHV char(10), @bacLuong char(10) , @Anh nchar(500),@matKhau char(20),@CMND char(20),@Email varchar(50))
as
begin
	insert into NHANVIEN(MaNV,HoTen,NgaySinh,SDT,QueQuan,GioiTinh,DanToc,MaPB,MaCV,MaTDHV,BacLuong,Anh,MatKhau,CMND,Email) 
	values(@maNV,@hoTen,@ngaySinh,@SDT,@queQuan,@gioiTinh,@danToc,@maPB,@maCV,@maTDHV,@bacLuong,@Anh,@matKhau,@CMND,@Email)
end


GO
/****** Object:  StoredProcedure [dbo].[InsertPhongBan]    Script Date: 5/25/2017 4:32:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[InsertPhongBan](@maPB char(10),@tenPB nvarchar(50), @maTP char(10), @diaChi nvarchar (50) , @sdt char(12))
as
begin
	declare @tongNV int
	set @tongNV=0
	insert into PHONGBAN
	values (@maPB,@tenPB,@maTP,@diaChi,@sdt,@tongNV)
end



GO
/****** Object:  StoredProcedure [dbo].[InsertTDHV]    Script Date: 5/25/2017 4:32:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[InsertTDHV](@maTDHV char(10),@tenTDHV nvarchar(20),@chuyenNganh nvarchar(20) ,@soLuong int)
as
begin 
	insert into TRINHDOHOCVAN(MaTDHV,TenTDHV,ChuyenNganh ,SoLuong) values (@MaTDHV,@tenTDHV,@chuyenNganh,@soLuong)
end


GO
/****** Object:  StoredProcedure [dbo].[InsertThanNhan]    Script Date: 5/25/2017 4:32:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[InsertThanNhan](@maNV  char(10) , @maTN char(10), @hoTen nvarchar(50) , @gioiTinh nvarchar(10),  @quanHe nvarchar(50))
as 
begin
	insert into THANNHAN(MaTN,MaNV,HoTen,GioiTinh,QuanHe)
	values (@maTN, @maNV, @hoTen,@gioiTinh,@quanHe)
end



GO
/****** Object:  StoredProcedure [dbo].[InsertTheoDoi]    Script Date: 5/25/2017 4:32:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InsertTheoDoi](@maTD char(10),  @maNV char(10) ,  @ngayThang date , @suKien  nvarchar(1000))
as
begin
	insert into THEODOI
	values (@maTD,@maNV,@ngayThang,@suKien)
end


GO
/****** Object:  StoredProcedure [dbo].[SearchNhanVienByHoTen]    Script Date: 5/25/2017 4:32:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SearchNhanVienByHoTen] (@key nvarchar(50))
as 
begin 
	select *from NHANVIEN where HoTen LIKE @key 
end
GO
/****** Object:  StoredProcedure [dbo].[SearchNhanVienByMaNV]    Script Date: 5/25/2017 4:32:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SearchNhanVienByMaNV] (@key char(10))
as 
begin 
	select *from NHANVIEN where MaNV LIKE @key 
end
GO
/****** Object:  StoredProcedure [dbo].[SearchNhanVienByQueQuan]    Script Date: 5/25/2017 4:32:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SearchNhanVienByQueQuan] (@key nvarchar(500))
as 
begin 
	select *from NHANVIEN where QueQuan LIKE @key 
end


GO
/****** Object:  StoredProcedure [dbo].[SearchNhanVienTheoBacLuong]    Script Date: 5/25/2017 4:32:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SearchNhanVienTheoBacLuong](@bacLuong int)
as
begin 
	select *from NHANVIEN
	where BacLuong=@bacLuong
end


GO
/****** Object:  StoredProcedure [dbo].[SearchNhanVienTheoCV]    Script Date: 5/25/2017 4:32:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SearchNhanVienTheoCV] (@maCV char(10))
as
begin 
	select *from CHUCVU
	where MaCV =@maCV
end



GO
/****** Object:  StoredProcedure [dbo].[SearchNhanVienTheoGT]    Script Date: 5/25/2017 4:32:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SearchNhanVienTheoGT] (@key nvarchar(10))
as
begin 
	select *from NHANVIEN
	where GioiTinh= 'N'+@key
end

GO
/****** Object:  StoredProcedure [dbo].[SearchNhanVienTheoMaNV]    Script Date: 5/25/2017 4:32:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SearchNhanVienTheoMaNV](@maNV char (10))
as
begin
	select *from NHANVIEN
	where MaNV=@maNV
end


GO
/****** Object:  StoredProcedure [dbo].[SearchNhanVienTheoPB]    Script Date: 5/25/2017 4:32:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SearchNhanVienTheoPB] (@key char(10))
as
begin 
	select *from NHANVIEN
	where MaPB=@key
end

GO
/****** Object:  StoredProcedure [dbo].[SearchNhanVienTheoQueQuann]    Script Date: 5/25/2017 4:32:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SearchNhanVienTheoQueQuann](@queQuan nvarchar(50))
as
begin 
	select *from NHANVIEN
	where QueQuan=@queQuan
end


GO
/****** Object:  StoredProcedure [dbo].[SearchNhanVienTheoTDHV]    Script Date: 5/25/2017 4:32:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SearchNhanVienTheoTDHV](@maTDHV char(10))
as
begin 
	select *from NHANVIEN
	where MaTDHV=@maTDHV
end


GO
/****** Object:  StoredProcedure [dbo].[SearchNhanVienTheoTrangThai]    Script Date: 5/25/2017 4:32:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SearchNhanVienTheoTrangThai](@trangThai int )
as 
begin 
	select *from NHANVIEN
	where TrangThai=@trangThai
end


GO
/****** Object:  StoredProcedure [dbo].[SearchPhongBanByTenPhongBan]    Script Date: 5/25/2017 4:32:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SearchPhongBanByTenPhongBan] (@key nvarchar(50))
as 
begin 
	select *from PHONGBAN where TenPB LIKE @key 
end

GO
/****** Object:  StoredProcedure [dbo].[SearchThanNhan]    Script Date: 5/25/2017 4:32:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SearchThanNhan] (@maTN char(10))
as
begin
	select * from THANNHAN where MaTN = @maTN
end


GO
/****** Object:  StoredProcedure [dbo].[UpdateChucVu]    Script Date: 5/25/2017 4:32:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdateChucVu](@maCV char(10),@tenCV nvarchar(20))
as
begin 
	Update CHUCVU
	set TenCV=@tenCV
	where MaCV=@maCV
end


GO
/****** Object:  StoredProcedure [dbo].[UpdateLuong]    Script Date: 5/25/2017 4:32:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdateLuong](@bacLuong char(10) , @luongCoBan decimal(9,0) , @heSoLuong int , @heSoPhuCap  float)
as
begin
	Update LUONG
	set LuongCoBan=@luongCoBan, HeSoLuong=@heSoLuong,HeSoPhuCap=@heSoPhuCap
	where BacLuong=@bacLuong
end


GO
/****** Object:  StoredProcedure [dbo].[UpdateNhanVien]    Script Date: 5/25/2017 4:32:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[UpdateNhanVien](@maNV char(10) , @hoTen nvarchar(50) , @ngaySinh date,@SDT char(10), @queQuan	nvarchar(500)
								,@gioiTinh nvarchar(10), @danToc nvarchar(50),@maPB char(10), @maCV char(10), @maTDHV char(10), @bacLuong char(10) , @Anh nchar(500),@matKhau varchar(50),@CMND char(20),@Email varchar(50))
as
begin
	Update NHANVIEN
	set HoTen=@hoTen,NgaySinh=@ngaySinh,SDT=@SDT,QueQuan=@queQuan,GioiTinh=@gioiTinh,DanToc=@danToc,MaPB=@maPB,MaCV=@maCV,MaTDHV=@maTDHV,BacLuong=@bacLuong,Anh=@Anh,MatKhau=@matKhau,CMND=@CMND,Email=@Email

	where MaNV=@maNV
end

GO
/****** Object:  StoredProcedure [dbo].[UpdatePhongBan]    Script Date: 5/25/2017 4:32:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdatePhongBan](@maPB char(10),@tenPB nvarchar(50), @maTP char(10), @diaChi nvarchar (50) , @sdt char(12))
as
begin
	declare @tongNV int
	set @tongNV=0
	Update PHONGBAN
	set MaPB=@maPB, TenPB=@tenPB, MaTP=@maTP, DiaChi=@diaChi, SDT=@sdt, TongNV=@tongNV 
	where MaPB=@maPB 
end


GO
/****** Object:  StoredProcedure [dbo].[UpdateTDHV]    Script Date: 5/25/2017 4:32:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdateTDHV](@maTDHV char(10),@tenTDHV nvarchar(20),@chuyenNganh nvarchar(20))
as
begin 
	Update TRINHDOHOCVAN
	set TenTDHV=@tenTDHV,ChuyenNganh=@chuyenNganh
	where MaTDHV=@maTDHV
end


GO
/****** Object:  StoredProcedure [dbo].[UpdateThanNhan]    Script Date: 5/25/2017 4:32:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdateThanNhan](@maNV  char(10) ,   @maTN char(10) , @hoTen nvarchar(50) , @gioiTinh nvarchar(10),  @quanHe nvarchar(50))
as
begin
	Update THANNHAN
	set MaNV=@maNV, HoTen=@hoTen, GioiTinh=@gioiTinh, QuanHe=@quanHe
	where MaTN=@maTN 
end


GO
/****** Object:  StoredProcedure [dbo].[UpdateTheoDoi]    Script Date: 5/25/2017 4:32:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdateTheoDoi](@maTD char(10),  @maNV char(10) ,  @ngayThang date , @suKien  nvarchar(1000))
as
begin
	Update THEODOI
	set MaNV=@maNV, ThoiGian=@ngayThang, SuKien=@suKien
	where MaSoTD=@maTD
end


GO
/****** Object:  Trigger [dbo].[trigger_UpdateCVNhanVien]    Script Date: 5/25/2017 4:32:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[trigger_UpdateCVNhanVien] on [dbo].[CHUCVU] instead of delete 
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
GO
/****** Object:  Trigger [dbo].[trigger_UpdateSoNhanVien]    Script Date: 5/25/2017 4:32:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[trigger_UpdateSoNhanVien] on [dbo].[NHANVIEN] for insert,update, delete 
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

GO
/****** Object:  Trigger [dbo].[trigger_UpdateTheoDoi]    Script Date: 5/25/2017 4:32:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[trigger_UpdateTheoDoi] on [dbo].[NHANVIEN] instead of delete
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

GO
/****** Object:  Trigger [dbo].[trigger_UpdateTDHVNhanVien]    Script Date: 5/25/2017 4:32:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[trigger_UpdateTDHVNhanVien] on [dbo].[TRINHDOHOCVAN] instead of delete 
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
GO
USE [master]
GO
ALTER DATABASE [HumanResource] SET  READ_WRITE 
GO
