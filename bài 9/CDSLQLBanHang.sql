use master
go

if (exists (select * from sys.databases where name = 'CSDLQLBanHang')) drop database CSDLQLBanHang
go

create database CSDLQLBanHang
go
use CSDLQLBanHang
go

create table DanhMuc(
	MaDanhMuc varchar(50) primary key,
	TenDanhMuc nvarchar(50)
)
create table SanPham(
	Ma varchar(50) primary key,
	Ten nvarchar(50),
	DonGia int,
	MaDanhMuc varchar(50),
	constraint fk1 foreign key (MaDanhMuc) references DanhMuc
)
insert into DanhMuc values ('dm01', N'Điện thoại'), ('dm02', N'Laptop')
insert into SanPham values ('sp01', N'SamSung galaxy z fold 5', 15000000, 'dm01'), 
						   ('sp02', N'Acer Aspire 5', 30000000, 'dm02')