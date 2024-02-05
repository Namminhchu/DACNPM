
CREATE DATABASE SQL_QuanLyKhoHangXuatNhapKhau
GO
USE SQL_QuanLyKhoHangXuatNhapKhau
GO
CREATE TABLE TaiKhoan_NhanVien
(
	MaTK_NV VARCHAR(32) PRIMARY KEY NOT NULL,
	TenTK_NV NVARCHAR(128) NOT NULL,
	MatKhau VARCHAR(256) NOT NULL,
	DienThoai VARCHAR(10),
	DiaChi NVARCHAR(128)
)
GO

CREATE TABLE HangHoa
(
	MaHH VARCHAR(32) PRIMARY KEY NOT NULL,
	TenHH NVARCHAR(128) NOT NULL,
	SoLuongTon NUMERIC(14,0),
	PhanLoai NVARCHAR(128),
	GiaNhap NUMERIC(14,2) NOT NULL,
	GiaXuat NUMERIC(14,2) NOT NULL
)
GO
CREATE TABLE PhieuNhap
(
	MaHD VARCHAR(32) PRIMARY KEY NOT NULL,
	NgayHD DATETIME NOT NULL,
	MaTK_NV VARCHAR(32) FOREIGN KEY REFERENCES TaiKhoan_NhanVien(MaTK_NV) NOT NULL,
	QuocGia NVARCHAR(128) NOT NULL,
	TongTien NUMERIC(14,2) NOT NULL,
	TongSoLuong NUMERIC(14,0) NOT NULL,
)
GO

CREATE TABLE ChiTietPhieuNhap
(
	MaHD VARCHAR(32) FOREIGN KEY REFERENCES PhieuNhap(MaHD) NOT NULL,
	MaHH VARCHAR(32) FOREIGN KEY REFERENCES HangHoa(MaHH) NOT NULL,
	DonGia NUMERIC(14,2) NOT NULL,
	SoLuong NUMERIC(14,0) NOT NULL,
	ThanhTien NUMERIC(14,2) NOT NULL
)
GO
CREATE TABLE PhieuXuat
(
	MaHD VARCHAR(32) PRIMARY KEY NOT NULL,
	NgayHD DATETIME NOT NULL,
	MaTK_NV VARCHAR(32) FOREIGN KEY REFERENCES TaiKhoan_NhanVien(MaTK_NV) NOT NULL,
	QuocGia NVARCHAR(128) NOT NULL,
	TongTien NUMERIC(14,2) NOT NULL,
	TongSoLuong NUMERIC(14,0) NOT NULL,
)
GO
CREATE TABLE ChiTietPhieuXuat
(
	MaHD VARCHAR(32) FOREIGN KEY REFERENCES PhieuXuat(MaHD) NOT NULL,
	MaHH VARCHAR(32) FOREIGN KEY REFERENCES HangHoa(MaHH) NOT NULL,
	DonGia NUMERIC(14,2) NOT NULL,
	SoLuong NUMERIC(14,0) NOT NULL,
	ThanhTien NUMERIC(14,2) NOT NULL
)
Go
CREATE VIEW [dbo].[vThongKeTonKho] 
AS 
	select MaHH,TenHH,SoLuongTon from HangHoa
GO
--CREATE VIEW [dbo].[vPhieuNhap] 
--AS 
--	SELECT '' as id,a.MaHH, b.TenHH,DonGia,0 AS SoLuong,0 AS ThanhTien FROM GiaNhap a LEFT JOIN HangHoa b ON a.MaHH = b.MaHH
--GO
INSERT INTO TaiKhoan_NhanVien VALUES(N'AD',N'Hoàng Nam',N'123456',N'0971132155',N'TPHCM')
INSERT INTO TaiKhoan_NhanVien VALUES(N'NV1',N'Huệ Mẫn',N'123456',N'0976584258',N'TPHCM')

INSERT INTO HangHoa VALUES('C1', N'Cá', 50, N'Hàng tươi sống','12000','20000')
INSERT INTO HangHoa VALUES('C2', N'Cá mú', 50, N'Hàng tươi sống','17000','25000')
INSERT INTO HangHoa VALUES('H1', N'Thịt heo', 50, N'Hàng đông lạnh','50000','120000')
INSERT INTO HangHoa VALUES('M1', N'Mực ống', 20, N'Hàng đông lạnh','100000','200000') 



UPDATE HangHoa
SET MaHH = PN.MaHH, GiaNhap = PN.DonGia, GiaXuat = PX.DonGia
FROM HangHoa HH
INNER JOIN ChiTietPhieuNhap PN ON HH.MaHH = PN.MaHH
INNER JOIN ChiTietPhieuXuat PX ON HH.MaHH = PX.MaHH
WHERE HH.MaHH='C1'


SELECT HH.MaHH, HH.TenHH, HH.GiaNhap, HH.GiaXuat, PN.DonGia, PX.DonGia
FROM HangHoa HH
INNER JOIN ChiTietPhieuNhap PN ON HH.MaHH=PN.MaHH
INNER JOIN ChiTietPhieuXuat PX ON HH.MaHH=PX.MaHH 
UPDATE HangHoa, ChiTietPhieuNhap, ChitietPhieuXuat
SET 
WHERE 


UPDATE HangHoa, ChiTietPhieuNhap, ChiTietPhieuXuat
SET MaHH='C3', ChiTietPhieuNhap.MaHH='C3', ChiTietPhieuXuat.MaHH='C3'
FROM HangHoa 
INNER JOIN ChiTietPhieuNhap ON HangHoa.MaHH = ChiTietPhieuNhap.MaHH
INNER JOIN ChiTietPhieuXuat ON HangHoa.MaHH = ChiTietPhieuXuat.MaHH
WHERE HangHoa.MaHH='C1'


ALTER PROCEDURE UpdateHH
    @oldMaHH VARCHAR(32),
	@newMaHH VARCHAR(32),
	@newGiaNhap numeric (14,2),
	@newGiaXuat numeric (14,2)
AS
BEGIN
	UPDATE HangHoa
	SET MaHH = @newMaHH,
		GiaNhap = @newGiaNhap,
		GiaXuat = @newGiaXuat
	WHERE MaHH = @oldMaHH;

	UPDATE ChiTietPhieuNhap
	SET MaHH = @newMaHH
	WHERE MaHH = @oldMaHH;

	UPDATE ChiTietPhieuXuat
	SET MaHH = @newMaHH
	WHERE MaHH = @oldMaHH;
END


ALTER PROCEDURE UpdateHH
    @oldMaHH VARCHAR(32),
	@newMaHH VARCHAR(32),
	@newGiaNhap numeric (14,2),
	@newGiaXuat numeric (14,2)
AS
BEGIN
	UPDATE HangHoa
	SET HangHoa.MaHH = @newMaHH,
		HangHoa.GiaNhap = @newGiaNhap,
		HangHoa.GiaXuat = @newGiaXuat,
		ChiTietPhieuNhap.MaHH = @newMaHH,
		ChiTietPhieuXuat.MaHH = @newMaHH
	FROM HangHoa
	INNER JOIN ChiTietPhieuNhap ON HangHoa.MaHH = ChiTietPhieuNhap.MaHH
	INNER JOIN ChiTietPhieuXuat ON HangHoa.MaHH = ChiTietPhieuXuat.MaHH
	WHERE HangHoa.MaHH = @oldMaHH

END

EXEC UpdateHH 'C1','C4','10000','20000'




DELETE FROM ChiTietPhieuNhap
WHERE MaHH='H1'

DELETE FROM ChiTietPhieuxuat
WHERE MaHH='H1'

DELETE FROM HangHoa
WHERE MaHH='H1'
