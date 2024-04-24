CREATE DATABASE QuanLyQuanCafe
GO

USE QuanLyQuanCafe
Go

CREATE TABLE NguoiDung
(
	maNguoiDung INT IDENTITY PRIMARY KEY,
	tenDangNhap NVARCHAR(100),
	tenHienThi NVARCHAR(100) not null,
	matKhau NVARCHAR(100) not null,
	loaiNguoiDung INT not null default 0		--1: admin, 0: staff
)
GO

CREATE TABLE Ban
(
	maBan INT IDENTITY PRIMARY KEY,
	tenBan NVARCHAR(100) not null,
	maNguoiDung INT not null,
	trangThai NVARCHAR(20) not null default 0,  --0: trong , 1: co nguoi

	foreign key (maNguoiDung) references NguoiDung(maNguoiDung)
)
GO


CREATE TABLE DanhMuc
(
	maLoai INT IDENTITY PRIMARY KEY,
	danhMuc NVARCHAR(50) not null
)
GO

CREATE TABLE Nuoc
(
	maNuoc INT IDENTITY PRIMARY KEY,
	tenNuoc NVARCHAR(50) not null,
	maLoai INT not null,
	gia float not null default 0,

	foreign key (maLoai) references DanhMuc(maLoai) 
)
GO

CREATE TABLE HoaDon
(
	maHoaDon INT IDENTITY PRIMARY KEY,
	ngayMua DATE not null default getdate(),
	maBan INT not null,
	trangThaiHoaDon INT not null default 0 -- 1: da thanh toan, 0: chua thanh toan
)
GO

CREATE TABLE ChiTietHoaDon
(
	maCTHD INT IDENTITY PRIMARY KEY,
	maNuoc INT not null,
	maHoaDon INT not null,
	soLuong int not null default 0,
	maNguoiDung INT not null,

	foreign key (maNuoc) references Nuoc(maNuoc),
	foreign key (maHoaDon) references HoaDon(maHoaDon),
	foreign key (maNguoiDung) references NguoiDung(maNguoiDung)
)
CREATE TABLE ThongTin(
  maThongTin INT IDENTITY PRIMARY KEY,
  tenQuan nvarchar(500) NULL,
  diaChiQuan varchar(500) NULL,
  soDTQuan nvarchar(500) NULL DEFAULT(''), 
  maThue nvarchar(250) NULL,
)
GO