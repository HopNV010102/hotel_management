Create database QuanLyKhachSan
go
use QuanLyKhachSan
go
Create table TAIKHOAN
(
	[id_TK] Varchar(10) primary key,
	[ten_TK] Nvarchar(30),
	[matkhau_TK] Varchar(30),
	[tenhienthi_TK] Nvarchar(50),
	[gioitinh] Nvarchar(20),
	[sdt] Varchar(11) ,
	[diachi] Nvarchar(50),
	[email] Nvarchar(50),
	[trangthai] Nvarchar(1),
) 
go
Create table KHACHHANG
(
	[id_KH] Varchar(10)primary key,
	[ten] Nvarchar(50),
	[ngaysinh] Varchar(30),
	[gioitinh] Nvarchar(20),
	[cmnd] Varchar(10) unique,
	[quoctich] Nvarchar(30),
) 
go
Create table [LOAIPHONG]
(
	[ten_LP] Nvarchar(30) primary key ,
	[succhua] Int,
	[giaphong] int,

) 

Create table PHONG 
(
	[id_P] Varchar(10) primary key,
	[ten_P] Nvarchar(30),
	[tinhtrang] Nvarchar(30),
	[ten_LP] nvarchar(30) REFERENCES DBO.LOAIPHONG(ten_LP),
)
go

Create table DICHVU
(
	[id_DV] Varchar(10) PRIMARY KEY,
	[ten_DV] Nvarchar(30),
	[gia_DV] int,
) 
go

Create table [HOADON]
(
	[id_HD] int  PRIMARY KEY,
	[id_KH] Varchar(10) REFERENCES DBO.KHACHHANG(id_KH),
	[ngayvao] DATE ,
	[ngaytra] date,
	[tinhtrang] int, 
	[id_P] Varchar(10) REFERENCES DBO.PHONG(id_P)
) 
go
Create table CHITIETHOADON
(
	[id_CTHD] int primary key identity(1,1) ,
	[id_HD] int REFERENCES DBO.HOADON(id_HD),
	[id_DV] Varchar(10) REFERENCES DBO.DICHVU(id_DV),
	[soluong] int,
	[ngaysudung] DATE ,
) 

INSERT [dbo].[TAIKHOAN] ([id_TK], [ten_TK], [matkhau_TK], [tenhienthi_TK], [gioitinh], [sdt], [diachi], [email], [trangthai]) VALUES (N'01TK', N'nguyenvanhop', N'nguyenvanhop', N'Nguyễn Văn Hợp', N'Nam', N'348938553', N'Ninh Bình', N'hopnguyen@gmail.com', N'0')
INSERT [dbo].[TAIKHOAN] ([id_TK], [ten_TK], [matkhau_TK], [tenhienthi_TK], [gioitinh], [sdt], [diachi], [email], [trangthai]) VALUES (N'02TK', N'dotukien', N'dotukien', N'Đỗ Tú Kiên', N'Nam', N'834438476', N'Hà Nội', N'kiendo@gmail.com', N'0')
INSERT [dbo].[TAIKHOAN] ([id_TK], [ten_TK], [matkhau_TK], [tenhienthi_TK], [gioitinh], [sdt], [diachi], [email], [trangthai]) VALUES (N'03TK', N'nguyenquanghung', N'nguyenquanghung', N'Nguyễn Quang Hưng', N'Nam', N'963482741', N'Hà Nội', N'hung363@gmail.com', N'0')

GO

GO
INSERT [dbo].[KHACHHANG] ([id_KH], [ten], [ngaysinh], [gioitinh], [cmnd], [quoctich]) VALUES (N'01KH', N'Cao Minh Thắng', N'25/06/2002', N'Nam', N'215494361', N'Việt Nam')
INSERT [dbo].[KHACHHANG] ([id_KH], [ten], [ngaysinh], [gioitinh], [cmnd], [quoctich]) VALUES (N'02KH', N'Trần Nguyễn Nhật Nam', N'20/11/2002', N'Nam', N'541915652', N'Việt Nam')
INSERT [dbo].[KHACHHANG] ([id_KH], [ten], [ngaysinh], [gioitinh], [cmnd], [quoctich]) VALUES (N'03KH', N'Nguyễn Thị Kim Ngân', N'30/10/2002', N'Nữ', N'515619565', N'Việt Nam')
INSERT [dbo].[KHACHHANG] ([id_KH], [ten], [ngaysinh], [gioitinh], [cmnd], [quoctich]) VALUES (N'04KH', N'Nguyễn Văn Cương', N'04/12/2002', N'Nam', N'651516598', N'Việt Nam')
INSERT [dbo].[KHACHHANG] ([id_KH], [ten], [ngaysinh], [gioitinh], [cmnd], [quoctich]) VALUES (N'05KH', N'Đinh Tuấn Thành', N'01/01/2002', N'Nam', N'262952625', N'Việt Nam')
INSERT [dbo].[KHACHHANG] ([id_KH], [ten], [ngaysinh], [gioitinh], [cmnd], [quoctich]) VALUES (N'06KH', N'Nguyễn Trung Tuyến', N'12/05/2002', N'Nam', N'651265165', N'Việt Nam')
INSERT [dbo].[KHACHHANG] ([id_KH], [ten], [ngaysinh], [gioitinh], [cmnd], [quoctich]) VALUES (N'07KH', N'Nguyễn Phạm Kiệt', N'09/02/2002', N'Nam', N'252511851', N'Việt Nam')
go

GO
INSERT [dbo].[LOAIPHONG] ( [ten_LP], [succhua], [giaphong]) VALUES ( N'Thường', 2, 200000)
INSERT [dbo].[LOAIPHONG] ( [ten_LP], [succhua], [giaphong]) VALUES ( N'Vip 1', 2, 400000)
INSERT [dbo].[LOAIPHONG] ( [ten_LP], [succhua], [giaphong]) VALUES ( N'Vip 2', 4, 500000)
INSERT [dbo].[LOAIPHONG] ( [ten_LP], [succhua], [giaphong]) VALUES ( N'Vip 3', 4, 700000)
GO

GO
INSERT [dbo].[DICHVU] ([id_DV], [ten_DV], [gia_DV]) VALUES (N'01DV', N'Xe ô tô', 200000)
INSERT [dbo].[DICHVU] ([id_DV], [ten_DV], [gia_DV]) VALUES (N'02DV', N'Xe mô tô', 100000)
INSERT [dbo].[DICHVU] ([id_DV], [ten_DV], [gia_DV]) VALUES (N'03DV', N'Karaoke', 50000)
INSERT [dbo].[DICHVU] ([id_DV], [ten_DV], [gia_DV]) VALUES (N'04DV', N'Tắm hơi', 80000)
INSERT [dbo].[DICHVU] ([id_DV], [ten_DV], [gia_DV]) VALUES (N'05DV', N'Cơm phần', 45000)
INSERT [dbo].[DICHVU] ([id_DV], [ten_DV], [gia_DV]) VALUES (N'06DV', N'Giặt ủi', 70000)
INSERT [dbo].[DICHVU] ([id_DV], [ten_DV], [gia_DV]) VALUES (N'07DV', N'Spa', 450000)
INSERT [dbo].[DICHVU] ([id_DV], [ten_DV], [gia_DV]) VALUES (N'08DV', N'Sân tenis', 800000)
INSERT [dbo].[DICHVU] ([id_DV], [ten_DV], [gia_DV]) VALUES (N'09DV', N'BiA', 1200000)
INSERT [dbo].[DICHVU] ([id_DV], [ten_DV], [gia_DV]) VALUES (N'12DV', N'Golf', 200000)
INSERT [dbo].[DICHVU] ([id_DV], [ten_DV], [gia_DV]) VALUES (N'13DV', N'Bóng', 120000)
GO

GO
INSERT [dbo].[PHONG] ([id_P], [ten_P], [tinhtrang], [ten_LP]) VALUES (N'01P', N'Phòng 1', N'Sẵn sàng', N'Thường')
INSERT [dbo].[PHONG] ([id_P], [ten_P], [tinhtrang], [ten_LP]) VALUES (N'02P', N'Phòng 2', N'Sẵn sàng', N'Thường')
INSERT [dbo].[PHONG] ([id_P], [ten_P], [tinhtrang], [ten_LP]) VALUES (N'03P', N'Phòng 3', N'Sẵn sàng', N'Thường')
INSERT [dbo].[PHONG] ([id_P], [ten_P], [tinhtrang], [ten_LP]) VALUES (N'04P', N'Phòng 4', N'Sẵn sàng', N'Thường')
INSERT [dbo].[PHONG] ([id_P], [ten_P], [tinhtrang], [ten_LP]) VALUES (N'05P', N'Phòng 5', N'Sẵn sàng', N'Thường')
INSERT [dbo].[PHONG] ([id_P], [ten_P], [tinhtrang], [ten_LP]) VALUES (N'06P', N'Phòng 6', N'Sẵn sàng', N'Vip 1')
INSERT [dbo].[PHONG] ([id_P], [ten_P], [tinhtrang], [ten_LP]) VALUES (N'07P', N'Phòng 7', N'Sẵn sàng', N'Vip 1')
INSERT [dbo].[PHONG] ([id_P], [ten_P], [tinhtrang], [ten_LP]) VALUES (N'08P', N'Phòng 8', N'Sẵn sàng', N'Vip 2')
INSERT [dbo].[PHONG] ([id_P], [ten_P], [tinhtrang], [ten_LP]) VALUES (N'09P', N'Phòng 9', N'Sẵn sàng', N'Vip 2')
INSERT [dbo].[PHONG] ([id_P], [ten_P], [tinhtrang], [ten_LP]) VALUES (N'10P', N'Phòng 10', N'Sẵn sàng', N'Vip 3')

GO
GO
INSERT [dbo].[HOADON] ([id_HD], [id_KH], [ngayvao], [ngaytra], [tinhtrang], [id_P]) VALUES (1, N'01KH', '2023-05-20' , '2023-06-20' , 1, N'03P')
INSERT [dbo].[HOADON] ([id_HD], [id_KH], [ngayvao], [ngaytra], [tinhtrang], [id_P]) VALUES (2, N'01KH', '2023-01-17', '2023-01-19', 1, N'01P')
INSERT [dbo].[HOADON] ([id_HD], [id_KH], [ngayvao], [ngaytra], [tinhtrang], [id_P]) VALUES (3, N'01KH', '2023-01-17', '2021-01-20', 1, N'07P')
INSERT [dbo].[HOADON] ([id_HD], [id_KH], [ngayvao], [ngaytra], [tinhtrang], [id_P]) VALUES (4, N'02KH', '2023-01-07' , '2023-02-17' , 1, N'04P')
INSERT [dbo].[HOADON] ([id_HD], [id_KH], [ngayvao], [ngaytra], [tinhtrang], [id_P]) VALUES (5, N'03KH', '2023-02-17', '2023-03-01' , 1, N'01P')
INSERT [dbo].[HOADON] ([id_HD], [id_KH], [ngayvao], [ngaytra], [tinhtrang], [id_P]) VALUES (6, N'04KH', '2023-02-18' , '2023-02-19' , 1, N'04P')
INSERT [dbo].[HOADON] ([id_HD], [id_KH], [ngayvao], [ngaytra], [tinhtrang], [id_P]) VALUES (7, N'05KH', '2023-03-10' ,'2023-03-17' , 1, N'01P')
INSERT [dbo].[HOADON] ([id_HD], [id_KH], [ngayvao], [ngaytra], [tinhtrang], [id_P]) VALUES (8, N'06KH', '2023-04-01' , '2023-04-15' , 1, N'01P')
INSERT [dbo].[HOADON] ([id_HD], [id_KH], [ngayvao], [ngaytra], [tinhtrang], [id_P]) VALUES (9, N'07KH', '2023-04-17' , '2021-04-19' , 1, N'01P')
INSERT [dbo].[HOADON] ([id_HD], [id_KH], [ngayvao], [ngaytra], [tinhtrang], [id_P]) VALUES (10, N'07KH', '2023-05-20' , '2023-06-20' , 1, N'02P')


GO
INSERT [dbo].[CHITIETHOADON] ( [id_HD], [id_DV], [soluong], [ngaysudung]) VALUES ( 1, N'01DV', 1,'2023-06-17' )
INSERT [dbo].[CHITIETHOADON] ( [id_HD], [id_DV], [soluong], [ngaysudung]) VALUES ( 2, N'03DV', 2, '2023-01-17' )
INSERT [dbo].[CHITIETHOADON] ( [id_HD], [id_DV], [soluong], [ngaysudung]) VALUES ( 4, N'09DV', 1, '2023-01-17' )
INSERT [dbo].[CHITIETHOADON] ( [id_HD], [id_DV], [soluong], [ngaysudung]) VALUES ( 4, N'01DV', 2, '2023-01-17' )
INSERT [dbo].[CHITIETHOADON] ( [id_HD], [id_DV], [soluong], [ngaysudung]) VALUES ( 3, N'01DV', 2,'2023-01-17' )
INSERT [dbo].[CHITIETHOADON] ([id_HD], [id_DV], [soluong], [ngaysudung]) VALUES ( 3, N'04DV', 4, '2023-01-17')
INSERT [dbo].[CHITIETHOADON] ( [id_HD], [id_DV], [soluong], [ngaysudung]) VALUES ( 7, N'02DV', 2, '2023-01-17' )
INSERT [dbo].[CHITIETHOADON] ( [id_HD], [id_DV], [soluong], [ngaysudung]) VALUES ( 10, N'01DV', 1,'2023-01-20' )
INSERT [dbo].[CHITIETHOADON] ([id_HD], [id_DV], [soluong], [ngaysudung]) VALUES ( 10, N'02DV', 2, '2023-01-20')
INSERT [dbo].[CHITIETHOADON] ( [id_HD], [id_DV], [soluong], [ngaysudung]) VALUES ( 10, N'08DV', 2, '2023-01-20')
go

select * from PHONG
select* from HOADON
select * from KHACHHANG
select* from CHITIETHOADON
select * from LOAIPHONG
select* from DICHVU
select * from TAIKHOAN
