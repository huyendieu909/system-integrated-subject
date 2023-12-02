use master
go

if (exists (select * from sys.databases where name = 'QLLuong')) drop database QLLuong
go

create database QLLuong
go
use QLLuong
go

create table DonVi(
	MaDonVi varchar(50) primary key,
	TenDonVi nvarchar(50)
)
create table NhanVien(
	Ma varchar(50) primary key,
	HoTen nvarchar(50),
	NgaySinh date,
	GioiTinh nvarchar(5),
	HSLuong decimal, 
	MaDonVi varchar(50),
	constraint fk1 foreign key (MaDonVi) references DonVi
)
insert into DonVi values ('dv01', N'Sản xuất'), ('dv02', N'Lắp rắp')
insert into NhanVien values ('nv01', N'Dương Bảo Huy', '2002-11-11', 'Nam', 1.5, 'dv01'), 
							('nv02', N'Tạ Duy Vũ', '2002-1-11', 'Nam', 1, 'dv02') 