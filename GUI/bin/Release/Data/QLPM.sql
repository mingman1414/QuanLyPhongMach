CREATE DATABASE QLPM
GO

USE QLPM
GO

--Account
CREATE TABLE Account
(
	TenDangNhap CHAR(255) PRIMARY KEY,
	TenHienThi NVARCHAR(255) NOT NULL,
	MatKhau CHAR(1000) NOT NULL,
	Loai INT --0:nhân viên || 1: admin
)
GO

--Bệnh nhân
CREATE TABLE BenhNhan
(
	IdBenhNhan INT IDENTITY (1,1) PRIMARY KEY,
	MaBenhNhan AS 'BN' + RIGHT('000'+ CAST(IdBenhNhan AS varchar),4) ,
	HoLot NVARCHAR(255) NOT NULL,
	TenBN NVARCHAR(255) NOT NULL,
	GioiTinh NVARCHAR(3) NOT NULL,
	NgaySinh DATE NOT NULL,
	DiaChi NVARCHAR(255),
	LienHe NVARCHAR(255),
	GhiChu NVARCHAR(1000)
)
GO

--Bác sĩ
CREATE TABLE BacSi
(
	IdBacSi INT IDENTITY (1,1) PRIMARY KEY,
	MaBacSi AS 'BS' + RIGHT('000'+ CAST(IdBacSi AS varchar),4),
	HoLot NVARCHAR(255) NOT NULL,
	TenBS NVARCHAR(255) NOT NULL,
	GioiTinh NVARCHAR(3) NOT NULL,
	NgaySinh DATE,
	DiaChi NVARCHAR(255),
	SDT VARCHAR(10) NOT NULL,
	Email VARCHAR(255) NOT NULL,
	HeSoLuong FLOAT NOT NULL
)
GO

--Thuốc
CREATE TABLE Thuoc
(
	MaThuoc CHAR(11) PRIMARY KEY,
	TenThuoc NVARCHAR(255) NOT NULL,
	DonVi NVARCHAR(10) NOT NULL, --1: Viên ||2: Gói||3: ống
	SoLuong int DEFAULT 0,
	NSX DATE NOT NULL,
	HSD DATE NOT NULL,
	GiaThuoc INT NOT NULL
)
GO
--Phiếu khám
CREATE TABLE PhieuKham
(
	IdPhieuKham INT IDENTITY (1,1) PRIMARY KEY,
	MaPhieuKham AS 'PH' + RIGHT('000'+ CAST(IdPhieuKham AS varchar),4) ,
	IdBenhNhan int NOT NULL,
	NgayKham DATETIME NOT NULL,
	TrieuChung NVARCHAR(255) NOT NULL,
	ChuanDoan NVARCHAR(255) NOT NULL,
	IdBacSi int NOT NULL,
	GhiChu NVARCHAR(255) NOT NULL,
	ThanhTien INT NOT NULL DEFAULT 0,

	FOREIGN KEY(IdBenhNhan) REFERENCES dbo.BenhNhan(IdBenhNhan),
	FOREIGN KEY(IdBacSi) REFERENCES dbo.BacSi(IdBacSi)
)
GO

--Chi tiết đơn thuốc
CREATE TABLE DonThuoc
(
	IdDonThuoc INT NOT NULL,
	MaThuoc CHAR(11) NOT NULL,
	CachDung NVARCHAR(30) NOT NULL,
	SLSang INT DEFAULT 0,
	SLTrua INT DEFAULT 0,
	SLChieu INT DEFAULT 0,
	SLToi INT DEFAULT 0

	PRIMARY KEY(IdDonThuoc,MaThuoc),
	FOREIGN KEY(MaThuoc) REFERENCES dbo.Thuoc(MaThuoc),
	FOREIGN KEY(IdDonThuoc) REFERENCES dbo.PhieuKham(IdPhieuKham)
)
GO




INSERT INTO dbo.Thuoc VALUES ('VD-32663-19',N'Đại tràng hoàn',N'Viên',30,'05-05-2019','03-30-2022',5000);
INSERT INTO dbo.Thuoc VALUES ('VD-24479-16',N'Atorvastatin 20 mg',N'Viên',20,'05-25-2019','06-17-2022',5150);
INSERT INTO dbo.Thuoc VALUES ('VD-27875-17',N'Acemetin',N'Gói',20,'09-01-2020','08-02-2023',1650);
INSERT INTO dbo.Thuoc VALUES ('VD-28936-18',N'Ezeytine',N'Chai',20,'09-01-2020','08-02-2023',20000);
GO

INSERT INTO dbo.Account VALUES('admin', N'Nguyễn Minh Mẫn', 'admin',  1 );
INSERT INTO dbo.Account VALUES('test1', N'Nguyễn Minh Mẫn', 'e99a18c428cb38d5f260853678922e03',  1 );
INSERT INTO dbo.Account VALUES('test2', N'Nguyễn Minh Mẫn', '30e229876358062f5d83bc824c81a99e',  1 );
INSERT INTO dbo.Account VALUES('thaingoc', N'Phương Thái Ngọc', 'e99a18c428cb38d5f260853678922e03',  1 );
INSERT INTO dbo.Account VALUES('nguyenvana', N'Nguyễn Văn A', '123',  0 );

GO

INSERT INTO dbo.BenhNhan VALUES(N'Nguyễn Minh', N'Mẫn', N'Nam', '11-21-2000', N'Long Xuyên, An Giang', N'0907713520', N'thường xuyên sốt');
INSERT INTO dbo.BenhNhan VALUES(N'Trần Minh', N'Minh', N'Nam', '08-06-1988', N'Quận 1,HCM', N'ming@gmail.com', null);
GO



INSERT INTO dbo.BacSi VALUES (N'Trần Văn',N'Nam',N'Nam','06-30-1989',N'Long Xuyên-An Giang','0906632542','namtran@gmail.com',1.25);
INSERT INTO dbo.BacSi VALUES (N'Nguyễn Thị',N'Chi',N'Nữ','05-20-1990',N'Châu Thành-An Giang','0906632236','chichi@gmail.com',1.5);
INSERT INTO dbo.BacSi VALUES (N'Nguyễn Minh',N'Mẫn',N'Nam','06-30-1989',N'Long Xuyên-An Giang','0907713520','chichi@gmail.com',1);
INSERT INTO dbo.BacSi VALUES (N'Phương Thái',N'Ngọc',N'Nam','06-30-1989',N'Long Xuyên-An Giang','0907713520','chichi@gmail.com',1);
GO

INSERT INTO dbo.PhieuKham VALUES (1,'06-29-2021',N'Nóng, nhức đầu, ói',N'Sốt',1,N' ',30000);
	INSERT INTO dbo.PhieuKham VALUES (2,'06-29-2021',N'Nóng, nhức đầu, ói',N'Sốt',2,N' ',30000);
	INSERT INTO dbo.PhieuKham VALUES (2,'06-29-2021 15:06:20',N'Nóng, nhức đầu, ói',N'Sốt',2,N'fqwfqwefdsfew',5000);
GO
UPDATE dbo.PhieuKham SET ThanhTien+=1000 WHERE IdPhieuKham=6


INSERT INTO dbo.DonThuoc(IdDonThuoc,MaThuoc,CachDung,SLSang,SLTrua,SLChieu,SLToi)VALUES(1,'VD-24479-16',N'Uong',2,3,1,2)
INSERT INTO dbo.DonThuoc(IdDonThuoc,MaThuoc,CachDung,SLSang,SLTrua,SLChieu,SLToi)VALUES(1,'VD-27875-17',N'Nuot',2,2,2,2)
INSERT INTO dbo.DonThuoc(IdDonThuoc,MaThuoc,CachDung,SLSang,SLTrua,SLChieu,SLToi)VALUES(1,'VD-28936-18',N'Ngam',1,2,3,4)
INSERT INTO dbo.DonThuoc(IdDonThuoc,MaThuoc,CachDung,SLSang,SLTrua,SLChieu,SLToi)VALUES(2,'VD-28936-18',N'Ngam',1,2,3,4)




--thong ke hoa don
CREATE PROCEDURE ThongKeHoaDon(@tuNgay date,@denNgay date)
AS
BEGIN	
	SELECT p.MaPhieuKham,bn.HoLot+' '+bn.TenBN AS BenhNhan, p.NgayKham, bs.HoLot+' '+bs.TenBS AS BacSi, p.ThanhTien 
	FROM dbo.PhieuKham p, dbo.BenhNhan bn, dbo.BacSi bs
	WHERE NgayKham>=@tuNgay AND NgayKham<=@denNgay AND p.IdBenhNhan=bn.IdBenhNhan AND p.IdBacSi=bs.IdBacSi
END
EXEC ThongKeHoaDon '06-20-2021' ,'06-30-2021'

--thong ke theo bac si
CREATE PROCEDURE QuanLiBacSi(@Hoten nvarchar(255),@TuNgay date,@DenNgay date)
AS
BEGIN	
	SELECT p.MaPhieuKham,bn.HoLot+' '+bn.TenBN AS BenhNhan, p.NgayKham, p.ThanhTien
	FROM dbo.PhieuKham p, dbo.BacSi bs, dbo.BenhNhan bn
	WHERE p.IdBacSi=bs.IdBacSi AND p.IdBenhNhan=bn.IdBenhNhan AND bs.HoLot+' '+bs.TenBS=@Hoten AND p.NgayKham>=@TuNgay AND p.NgayKham<=@DenNgay
END
DROP PROC QuanLiBacSi
	EXEC QuanLiBacSi N'Trần Văn Nam','05-01-2021','06-28-2021'
 --TẠO HÓA Đơn
 CREATE PROCEDURE HoaDon (@idDon int)
 AS 
 BEGIN
	SELECT t.TenThuoc,(d.SLSang+d.SLTrua+d.SLChieu+d.SLToi) AS SoLuong,t.GiaThuoc,  (d.SLSang+d.SLTrua+d.SLChieu+d.SLToi)*t.GiaThuoc AS Tien
	FROM dbo.DonThuoc d, dbo.Thuoc t, dbo.PhieuKham p
	WHERE d.MaThuoc=t.MaThuoc AND d.IdDonThuoc=p.IdPhieuKham AND d.IdDonThuoc=@idDon
END
EXEC HoaDon 1

--Tong tien
CREATE PROCEDURE TongTien(@idDon int)
AS
BEGIN
	SELECT SUM((d.SLSang+d.SLTrua+d.SLChieu+d.SLToi)*t.GiaThuoc) AS Tong
	FROM dbo.DonThuoc d, dbo.Thuoc t, dbo.PhieuKham p
	WHERE d.MaThuoc=t.MaThuoc AND d.IdDonThuoc=p.IdPhieuKham AND d.IdDonThuoc=@idDon
END
EXEC TongTien 1

--Lap don thuoc
CREATE PROCEDURE LapDonThuoc (@idDon int)
AS 
BEGIN	
	SELECT bn.HoLot+' '+bn.TenBN AS BenhNhan, p.NgayKham, p.TrieuChung,p.ChuanDoan,t.TenThuoc, d.CachDung,d.SLSang,d.SLTrua,d.SLChieu,d.SLToi,(d.SLSang+d.SLTrua+d.SLChieu+d.SLToi) AS Tong,p.GhiChu,bs.HoLot+' '+bs.TenBS AS BacSi
	FROM dbo.PhieuKham p, dbo.DonThuoc d, dbo.BacSi bs, dbo.BenhNhan bn,dbo.Thuoc t
	WHERE p.IdPhieuKham=d.IdDonThuoc AND p.IdBacSi=bs.IdBacSi AND p.IdBenhNhan=bn.IdBenhNhan AND d.MaThuoc=t.MaThuoc AND d.IdDonThuoc=@idDon
END


CREATE VIEW LuongBS
AS
	SELECT MaBacSi,HoLot,TenBS,GioiTinh,HeSoLuong,HeSoLuong*5000000 AS Luong FROM dbo.BacSi

	SELECT * FROM dbo.BenhNhan
CREATE VIEW	DSBenhNhan
AS
	SELECT * FROM dbo.BenhNhan

	select * from BenhNhan where HoLot+' '+TenBN LIKE N'%n%'
	SELECT*FROM dbo.BacSi
	select * from BenhNhan where HoLot+' '+TenBN LIKE N'%m%'
	select * from BacSi where HoLot+' '+TenBS like N'%m%'

	SELECT p.*,bn.HoLot+' '+bn.TenBN AS BenhNhan, bs.HoLot+' '+bs.TenBS AS BacSi
	FROM dbo.PhieuKham p, dbo.BenhNhan bn, dbo.BacSi bs
	WHERE p.IdBenhNhan=bn.IdBenhNhan AND p.IdBacSi=bs.IdBacSi	