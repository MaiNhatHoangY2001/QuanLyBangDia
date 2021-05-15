create database QuanLyBangDia
use QuanLyBangDia
create table KhachHang
(
	maKH char(5) primary key,
	hoTenKH nvarchar(60) not null,
	gioiTinh nvarchar(10),
	SDT char(10),
	diaChi nvarchar(100)
)
create table NhanVien 
(
	maNV char(5) primary key,
	hoTenNV nvarchar(60) not null,
	SDT char(10),
	gioiTinh nvarchar(10),
	diaChi nvarchar(100),
	luong money,
	caLamViec int
)
create table PhieuThue 
(
	maPhieu char(5) primary key,
	
	maKH char(5) foreign key references KhachHang(maKH)
					on update cascade on delete cascade,
	maNV char(5) foreign key references NhanVien(maNV)
					on update cascade on delete cascade,
	ngayMuon Date ,
	ngayTra Date 
)

create table ChiTietPhieuThue
(
	maCTPT char(5) primary key,
	maPhieu char(5) foreign key references PhieuThue(maPhieu)
					on update cascade on delete cascade,
	soLuong int
)
create table CongTy 
(
	maCongTy char(5) primary key,
	tenCongTy nvarchar(60),
	diaChi nvarchar(100),
	soDienThoai char(12)
)
create table LoaiBangDia
(
	maLoai char(5) primary key,
	tenLoai nvarchar(50) 
)
create table ThongTinBangDia
(
	maBangDia char(5) primary key,
	maLoai char(5) foreign key references LoaiBangDia(maLoai)
			on update cascade on delete cascade,
	maCongTy char(5) foreign key references CongTy(maCongTy)
			on update cascade on delete cascade,
	maCTPT char(5) foreign key references ChiTietPhieuThue(maCTPT)
			on update cascade on delete cascade,
	tenBangDia nvarchar(60),
	theLoai nvarchar(60),
	tinhTrang nvarchar(10),
	ngaySX Date,
	ghiChu nvarchar(100),
	gia money		 
)	
go
insert into LoaiBangDia values 
('ML001', 'CD'),
('ML002', 'VCD'),
('ML003', 'DVD'),
('ML004', 'CD-ROM'),
('ML005', 'CD')
insert into CongTy values
('CT001', N'Kim Đồng', N'Nguyễn Tri Phương, quận 10, TPHCM', '0987654321'),
('CT002', N'Á Châu', N'Lê Văn Sỹ, Quận 3, TPHCM', '0987213221'),
('CT003', N'Phương Châu', N'14 Đống Đa, Phường 3, Thành phố Đà Lạt', '0917654321'),
('CT004', N'Dương Châu', N'Trần Quốc Toản, Phường 1, Thành phố Đà Lạt', '0987621321'),
('CT005', N'Dương Phát', N'số 258 Mai Anh Đào, phường 9, Đà Lạt', '0987636321')
insert into NhanVien values
('NV001', N'Mai Kim Hà','0954512123',N'Nữ', N'33B, Đường Hà Bá Tường, Phường 12, Tân Bình, Hồ Chí Minh',3000000, 1),
('NV002', N'Nguyễn Thế Hoàng','0954512123',N'Nam', N'66/68, Đường Phổ Quang, Phường 2, Tân Bình, Hồ Chí Minh',2500000, 2),
('NV003', N'Nguyễn Như Thế','0954523189',N'Nữ', N'34 đường 36 P. Tân Quy, Q7, Hồ Chí Minh',2700000, 1),
('NV004', N'Nguyễn Thị Đức','0954182161',N'Nữ', N'84 Nguyễn tất thành Q4, Hồ Chí Minh',2800000, 3),
('NV005', N'Nguyễn Văn Long','0954535478',N'Nam', N'102/81 Lê Văn Thọ, P11,Gò Vấp, Hồ Chí Minh',3800000, 2)
insert into KhachHang values
('KH001', N'Thu Hà', N'Nữ','0975631241' ,N'36/99 Lê Thị Hồng, Phường 17, Quận Gò Vấp, Hồ Chí Minh'),
('KH002', N'Nguyễn Văn Hoàng', N'Nam','0975631241', N'713/18 LÊ ĐỨC THỌ, PHƯỜNG 16, QUẬN GÒ VẤP, Hồ Chí Minh'),
('KH003', N'Nguyễn Thế Bảo', N'Nữ', '0961631249',N'Phường 7, Quận Phú Nhuận, TP Hồ Chí Minh'),
('KH004', N'Nguyễn Thị Lượng', N'Nữ', '0915621587',N'Phường 5, Quận Phú Nhuận, TP Hồ Chí Minh'),
('KH005', N'Nguyễn Thế Như', N'Nữ', '0981231213',N'Phường 8, Quận Phú Nhuận, TP Hồ Chí Minh')
insert into PhieuThue values
('MP001', 'KH001', 'NV002', '2021-05-04','2021-05-15'),
('MP002', 'KH002', 'NV003', '2021-05-01','2021-05-03'),
('MP003', 'KH003', 'NV001', '2021-05-20','2021-05-30'),
('MP004', 'KH004', 'NV005', '2021-05-23','2021-05-28'),
('MP005', 'KH005', 'NV004', '2021-05-12','2021-05-20')
insert into ChiTietPhieuThue values
('CT001', 'MP001', 2),
('CT002', 'MP002', 5),
('CT003', 'MP003', 3),
('CT004', 'MP004', 8),
('CT005', 'MP005', 2)
insert into ThongTinBangDia values
('BD001', 'ML001', 'CT001', 'CT001', N'Tây Du ký', N'Hành động', N'Trễ hạn', '2020-05-06',N'Không', 10000),
('BD002', 'ML002', 'CT002', 'CT002', N'The House', N'Kinh dị', N'Đúng hạn', '2018-07-20',N'bị xước', 15000),
('BD003', 'ML003', 'CT003', 'CT003', N'Kong 2012', N'Viễn tưởng', N'Trễ hạn', '2020-05-15',N'Không', 20000),
('BD004', 'ML004', 'CT004', 'CT004', N'Diệp Vấn', N'Hành động', N'Đúng hạn', '2021-01-01',N'Không', 30000),
('BD005', 'ML005', 'CT005', 'CT005', N'Vì sao anh đến', N'Tình cảm', N'Đúng hạn', '2019-02-04',N'Không', 18000)
go
