use master
go

create database DB_QLBVXK
go

use DB_QLBVXK
go

create table NhanVien (
	MaNhanVien int identity(1, 1) not null,
	MaChucVu int,
	TenDangNhap varchar(255),
	MatKhau varchar(255),
	TenNhanVien nvarchar(255),
	CCCD varchar(20),
	SoDienThoai varchar(20),
	DiaChi nvarchar(255)
)

create table ChucVu (
	MaChucVu int identity(1, 1) not null,
	TenChucVu nvarchar(255)
)

create table Xe (
	MaXe int identity(1, 1) not null,
	MaLoaiXe int,
	MauSac nvarchar(255),
	BienSo varchar(50),
	SoChoNgoi int
)

create table LoaiXe (
	MaLoaiXe int identity(1, 1) not null,
	TenLoaiXe nvarchar(255),
	GiaLoaiXe decimal
)

create table Tuyen (
	MaTuyen int identity(1, 1) not null,
	TenTuyen nvarchar(255),
	MaDDKhoiHanh int,
	MaDDKetThuc int,
	GiaTuyen decimal,
	SoKM int
)

create table ChuyenXe (
	MaChuyenXe int identity(1, 1) not null,
	MaXe int,
	MaTuyen int,
	MaTaiXe int,
	ThoiGianKhoiHanh datetime,
	SoGheDaDat int
)

create table DiaDiem (
	MaDiaDiem int identity(1, 1) not null,
	TenDiaDiem nvarchar(255)
)

create table TaiXe (
	MaTaiXe int identity(1, 1) not null,
	TenTaiXe nvarchar(255),
	NgaySinh date,
	SoDienThoai varchar(20),
	CCCD varchar(20),
	DiaChi nvarchar(255)
)

create table VeXe (
	MaVeXe int identity(1, 1) not null,
	MaChuyenXe int,
	MaLoaiVe int,
	MaNhanVien int,
	TenKhachHang nvarchar(255),
	GiaVe decimal
)

create table LoaiVe (
	MaLoaiVe int identity(1, 1) not null,
	TenLoaiVe nvarchar(255),
	GiaLoaiVe decimal
)

-- Primary key constraint

alter table NhanVien
	add constraint PK_NhanVien primary key (MaNhanVien)

alter table ChucVu
	add constraint PK_ChucVu primary key (MaChucVu)

alter table Xe
	add constraint PK_Xe primary key (MaXe)

alter table LoaiXe
	add constraint PK_LoaiXe primary key (MaLoaiXe)

alter table Tuyen
	add constraint PK_Tuyen primary key (MaTuyen)

alter table ChuyenXe
	add constraint PK_ChuyenXe primary key (MaChuyenXe)

alter table DiaDiem
	add constraint PK_DiaDiem primary key (MaDiaDiem)

alter table TaiXe
	add constraint PK_TaiXe primary key (MaTaiXe)

alter table VeXe
	add constraint PK_VeXe primary key (MaVeXe)

alter table LoaiVe
	add constraint PK_LoaiVe primary key (MaLoaiVe)

-- Foreign key constraint

alter table NhanVien
	add constraint FK_NhanVien_ChucVu foreign key (MaChucVu) references ChucVu(MaChucVu)

alter table Xe
	add constraint FK_Xe_LoaiXe foreign key (MaLoaiXe) references LoaiXe(MaLoaiXe)

alter table VeXe
	add constraint FK_VeXe_ChuyenXe foreign key (MaChuyenXe) references ChuyenXe(MaChuyenXe)

alter table VeXe
	add constraint FK_VeXe_LoaiVe foreign key (MaLoaiVe) references LoaiVe(MaLoaiVe)

alter table VeXe
	add constraint FK_VeXe_NhanVien foreign key (MaNhanVien) references NhanVien(MaNhanVien)

alter table ChuyenXe
	add constraint FK_ChuyenXe_MaXe foreign key (MaXe) references Xe(MaXe)

alter table ChuyenXe
	add constraint FK_ChuyenXe_Tuyen foreign key (MaTuyen) references Tuyen(MaTuyen)

alter table ChuyenXe
	add constraint FK_ChuyenXe_TaiXe foreign key (MaTaiXe) references TaiXe(MaTaiXe)

alter table Tuyen
	add constraint FK_Tuyen_DiaDiemKhoiHanh foreign key (MaDDKhoiHanh) references DiaDiem(MaDiaDiem)
	
alter table Tuyen
	add constraint FK_Tuyen_DiaDiemKetThuc foreign key (MaDDKetThuc) references DiaDiem(MaDiaDiem)

--use master
--drop database DB_QLBVXK

set dateformat dmy

insert into DiaDiem
values
(N'An Giang'), 
(N'Bà Rịa - Vũng Tàu'), 
(N'Bắc Giang'), 
(N'Bắc Kạn'), 
(N'Bạc Liêu'), 
(N'Bắc Ninh'), 
(N'Bến Tre'), 
(N'Bình Định'), 
(N'Bình Dương'), 
(N'Bình Phước'), 
(N'Bình Thuận'), 
(N'Cà Mau'), 
(N'Cao Bằng'), 
(N'Cần Thơ'), 
(N'Đà Nẵng'), 
(N'Đắk Lắk'), 
(N'Đắk Nông'), 
(N'Điện Biên'), 
(N'Đồng Nai'), 
(N'Đồng Tháp'), 
(N'Gia Lai'), 
(N'Hà Giang'), 
(N'Hà Nam'), 
(N'Hà Nội'), 
(N'Hà Tĩnh'), 
(N'Hải Dương'), 
(N'Hải Phòng'), 
(N'Hậu Giang'), 
(N'Hòa Bình'), 
(N'Hồ Chí Minh'), 
(N'Hưng Yên'), 
(N'Khánh Hòa'), 
(N'Kiên Giang'), 
(N'Kon Tum'), 
(N'Lai Châu'), 
(N'Lạng Sơn'), 
(N'Lào Cai'), 
(N'Lâm Đồng'), 
(N'Long An'), 
(N'Nam Định'), 
(N'Nghệ An'), 
(N'Ninh Bình'), 
(N'Ninh Thuận'), 
(N'Phú Thọ'), 
(N'Phú Yên'), 
(N'Quảng Bình'), 
(N'Quảng Nam'), 
(N'Quảng Ngãi'), 
(N'Quảng Ninh'), 
(N'Quảng Trị'), 
(N'Sóc Trăng'), 
(N'Sơn La'), 
(N'Tây Ninh'), 
(N'Thái Bình'), 
(N'Thái Nguyên'), 
(N'Thanh Hóa'), 
(N'Thừa Thiên Huế'), 
(N'Tiền Giang'), 
(N'Trà Vinh'), 
(N'Tuyên Quang'), 
(N'Vĩnh Long'), 
(N'Vĩnh Phúc'), 
(N'Yên Bái')

insert into ChucVu
values
('Quản trị viên'),
('Quản lý'),
('Nhân viên')

insert into LoaiVe
values
(N'Vé thường', 25000),
(N'Vé giường nằm', 45000),
(N'Vé VIP', 65000)

insert into LoaiXe
values
(N'Xe khách giường nằm', 15000),
(N'Xe du lịch', 12000),
(N'Xe khách ghế thường', 10000)

insert into Xe
values
(1, N'Tím', '93A-56121', 45),
(2, N'Vàng', '51K-25555', 16),
(3, N'Đen', '93A-37152', 46),
(2, N'Đỏ', '93A-31613', 16),
(1, N'Trắng', '93A-88582', 24)

insert into Tuyen
values
(N'Bình Phước - Cà Mau', 10, 12, 10000, 241)

insert into TaiXe
values
(N'Nguyễn Thập Phong', '21-11-1991', '0377551166', '070809101112', N'12/34 Đ. Nguyễn Trãi,...')

insert into ChuyenXe
values
(1, 1, 5, '24-11-2023 16:30:00', 0)

insert into NhanVien
values
(1, 'vtduong0912', '09122002', N'Vũ Thanh Dương', '070203003868', '0366035415', N'36/13 Đ.160 Lã Xuân Oai, Tăng Nhơn Phú A, TP. Thủ Đức')

go
create trigger CheckOnVeXe on VeXe
after insert, update
as
begin
	if (select cx.SoGheDaDat from ChuyenXe cx join inserted i on i.MaChuyenXe = cx.MaChuyenXe) < (select x.SoChoNgoi from Xe x join ChuyenXe cx on cx.MaXe = x.MaXe join inserted i on i.MaChuyenXe = cx.MaChuyenXe)
	begin
		update ChuyenXe
		set SoGheDaDat = SoGheDaDat + 1
		where MaChuyenXe = (select i.MaChuyenXe from inserted i)

		update VeXe
		set GiaVe = (select lx.GiaLoaiXe from LoaiXe lx join Xe x on lx.MaLoaiXe = x.MaLoaiXe join ChuyenXe cx on cx.MaXe = x.MaXe join inserted i on i.MaChuyenXe = cx.MaChuyenXe)
					+
					(select lv.GiaLoaiVe from LoaiVe lv join inserted i on i.MaLoaiVe = lv.MaLoaiVe)
					+
					(select t.GiaTuyen from Tuyen t join ChuyenXe cx on t.MaTuyen = cx.MaTuyen join inserted i on i.MaChuyenXe = cx.MaChuyenXe)
	end
end
go

insert into VeXe
values
(4, 2, 1, N'Nguyễn Hữu Long', 0)