USE PROJECTADIS
GO

DROP TABLE ChiTietDangTuyen; 
DROP TABLE DanhSachDangKyUngTuyen;
DROP TABLE DanhSachChungTu; 
DROP TABLE HoaDon;
DROP TABLE DanhSachDangTuyen; 
DROP TABLE NhanVien;
DROP TABLE UngVien;
DROP TABLE CongTy;

CREATE TABLE CongTy (
    MaCongTy nvarchar(10) PRIMARY KEY,
    TenCongTy nvarchar(100),
    MaSoThue nvarchar(15),
    NguoiDaiDien nvarchar(100),
    DiaChi nvarchar(100),
    Email nvarchar(100)
)
GO

CREATE TABLE NhanVien (
    MaNhanVien nvarchar(10) PRIMARY KEY,
    HoTen nvarchar(100),
    ChucVu nvarchar(100)
)
GO

CREATE TABLE UngVien (
    MaUngVien nvarchar(10) PRIMARY KEY,
    HoTen nvarchar(100),
    DiaChi nvarchar(100),
    Email nvarchar(100),
    NgaySinh date,
    CCCD nvarchar(10)
)
GO

CREATE TABLE DanhSachDangTuyen (
    MaDangTuyen nvarchar(10) PRIMARY KEY,
    ThoiGianDangTuyen date,
    HinhThucDangTuyen nvarchar(100),
    NhanVienLapPhieu nvarchar(10),
    CongTyDangTuyen nvarchar(10),
    FOREIGN KEY (NhanVienLapPhieu) REFERENCES NhanVien(MaNhanVien),
    FOREIGN KEY (CongTyDangTuyen) REFERENCES CongTy(MaCongTy)
)
GO

CREATE TABLE ChiTietDangTuyen (
    MaChiTietDangTuyen nvarchar(10) PRIMARY KEY,
    MaDangTuyen nvarchar(10),
    ViTri nvarchar(100),
    SoLuong int,
    MoTa nvarchar(100),
    FOREIGN KEY (MaDangTuyen) REFERENCES DanhSachDangTuyen(MaDangTuyen)
)
GO

CREATE TABLE DanhSachDangKyUngTuyen (
    MaChiTietDangTuyen nvarchar(10),
    MaUngVien nvarchar(10),
    PRIMARY KEY (MaChiTietDangTuyen, MaUngVien),
    FOREIGN KEY (MaChiTietDangTuyen) REFERENCES ChiTietDangTuyen(MaChiTietDangTuyen),
    FOREIGN KEY (MaUngVien) REFERENCES UngVien(MaUngVien)
)
GO

CREATE TABLE DanhSachChungTu (
    MaChungTu nvarchar(10) PRIMARY KEY,
    MaUngVien nvarchar(10),
    LoaiChungTu nvarchar(100),
    TinhTrangNop bit,
    NgayNop date,
    FOREIGN KEY (MaUngVien) REFERENCES UngVien(MaUngVien)
)
GO

CREATE TABLE HoaDon (
    MaHoaDon nvarchar(10) PRIMARY KEY,
    MaDangTuyen nvarchar(10),
    GiaTriHoaDon int,
    HinhThucThanhToan nvarchar(100),
	CachThucThanhToan nvarchar(100),
    NgayThanhToan date,
    FOREIGN KEY (MaDangTuyen) REFERENCES DanhSachDangTuyen(MaDangTuyen)
)
GO

INSERT INTO CongTy (MaCongTy, TenCongTy, MaSoThue, NguoiDaiDien, DiaChi, Email)
VALUES
  (N'CTY001', N'ABC', N'332893541199846', NULL, N'Ho Chi Minh', N'abc@gmail.com'),
  (N'CTY002', N'DigitalOcean', N'359513848770720', NULL, N'Ho Chi Minh', N'DigitalOcean@gmail.com'),
  (N'CTY003', N'BrightBytes', N'057228052724291', NULL, N'Ho Chi Minh', N'BrightBytes@gmail.com'),
  (N'CTY004', N'Itility', N'087776493832706', NULL, N'Ho Chi Minh', N'Itility@gmail.com'),
  (N'CTY005', N'DataLab', N'583054271837287', NULL, N'Ho Chi Minh', N'DataLab@gmail.com'),
  (N'CTY006', N'SoftIT', N'332633782173836', NULL, N'Ho Chi Minh', N'SoftIT@gmail.com'),
  (N'CTY007', N'Cybertec', N'548943135439128', NULL, N'Ho Chi Minh', N'Cybertec@gmail.com'),
  (N'CTY008', N'DataCharm', N'536747663168470', NULL, N'Ho Chi Minh', N'DataCharm@gmail.com'),
  (N'CTY009', N'BitDATA', N'741972665128594', NULL, N'Ho Chi Minh', N'BitDATA@gmail.com'),
  (N'CTY010', N'ByteTree', N'741446400684522', NULL, N'Ho Chi Minh', N'ByteTree@gmail.com');

INSERT INTO NhanVien (MaNhanVien, HoTen, ChucVu)
VALUES
  (N'NV001', N'Nguyen Tuan An', N'Nhan vien'),
  (N'NV002', N'Tran Van Binh', N'Nhan vien'),
  (N'NV003', N'Le Quoc Khanh', N'Nhan vien'),
  (N'NV004', N'Pham Minh Cuong', N'Nhan vien'),
  (N'NV005', N'Vo Thanh Dat', N'Nhan vien'),
  (N'NV006', N'Do Thi Huong', N'Nhan vien'),
  (N'NV007', N'Nguyen Hai Yen', N'Nhan vien'),
  (N'NV008', N'Pham Tuan Anh', N'Nhan vien'),
  (N'NV009', N'Tran Ngoc Linh', N'Nhan vien'),
  (N'NV010', N'Le Van Tien', N'Quan ly');

INSERT INTO UngVien (MaUngVien, HoTen, DiaChi, Email, NgaySinh, CCCD)
VALUES
  (N'UV001', N'Tran Quang Thien', N'Ho Chi Minh', N'tqthien@gmail.com', CAST(N'2000-05-05' AS Date), N'5718917719'),
  (N'UV002', N'Le Hoang Son', N'Ho Chi Minh', N'lhson@gmail.com', CAST(N'2001-07-15' AS Date), N'6842535722'),
  (N'UV003', N'Nguyen Thi Mai', N'Ho Chi Minh', N'ntmai@gmail.com', CAST(N'2003-09-20' AS Date), N'1383006923'),
  (N'UV004', N'Pham Dinh Long', N'Ho Chi Minh', N'pdlong@gmail.com', CAST(N'2005-11-30' AS Date), N'0366723400'),
  (N'UV005', N'Vo Van Lam', N'Ho Chi Minh', N'vvlam@gmail.com', CAST(N'2002-03-25' AS Date), N'6953385262'),
  (N'UV006', N'Do Thu Hang', N'Ho Chi Minh', N'dthang@gmail.com', CAST(N'2000-06-10' AS Date), N'3035773793'),
  (N'UV007', N'Nguyen Quoc Huy', N'Ho Chi Minh', N'nqhuy@gmail.com', CAST(N'2006-04-28' AS Date), N'0458397186'),
  (N'UV008', N'Pham Ngoc Diep', N'Ho Chi Minh', N'pndiep@gmail.com', CAST(N'2009-12-05' AS Date), N'7642797075'),
  (N'UV009', N'Tran Van Toan', N'Ho Chi Minh', N'tvtoan@gmail.com', CAST(N'2008-01-15' AS Date), N'7554771410'),
  (N'UV010', N'Le Van Dung', N'Ho Chi Minh', N'lvdung@gmail.com', NULL, N'7559900232'); 

INSERT INTO DanhSachDangTuyen (MaDangTuyen, ThoiGianDangTuyen, HinhThucDangTuyen, NhanVienLapPhieu, CongTyDangTuyen)
VALUES
  (N'DT001', CAST(N'2024-05-01' AS Date), N'Bao giay', N'NV001', N'CTY001'),
  (N'DT002', CAST(N'2024-05-01' AS Date), N'Banner quang cao', N'NV002', N'CTY003'),
  (N'DT003', CAST(N'2024-05-01' AS Date), N'Bao giay', N'NV001', N'CTY001'),
  (N'DT004', CAST(N'2024-05-01' AS Date), N'Bao giay', N'NV002', N'CTY001'),
  (N'DT005', CAST(N'2024-05-01' AS Date), N'Trang mang', N'NV001', N'CTY003');

INSERT INTO ChiTietDangTuyen (MaChiTietDangTuyen, MaDangTuyen, ViTri, SoLuong, MoTa)
VALUES
  (N'CTDT001', N'DT001', N'Dev', 5, N'be a dev'),
  (N'CTDT002', N'DT001', N'Intern', 20, N'be a inter'),
  (N'CTDT003', N'DT001', N'HR', 1, N'be a HR'),
  (N'CTDT004', N'DT002', N'Dev', 5, N'be a dev'),
  (N'CTDT005', N'DT002', N'Intern', 10, N'be a inter'),
  (N'CTDT006', N'DT003', N'Dev', 5, N'be a dev'),
  (N'CTDT007', N'DT003', N'Intern', 10, N'be a inter'); 

INSERT INTO DanhSachDangKyUngTuyen (MaChiTietDangTuyen, MaUngVien)
VALUES
  (N'CTDT001', N'UV002'),
  (N'CTDT001', N'UV003'),
  (N'CTDT002', N'UV001'),
  (N'CTDT002', N'UV002'),
  (N'CTDT002', N'UV003'),
  (N'CTDT002', N'UV004');

INSERT INTO DanhSachChungTu (MaChungTu, MaUngVien, LoaiChungTu, TinhTrangNop, NgayNop)
VALUES
  (N'CT001', N'UV001', N'Bằng đại học', 1, CAST(N'2024-05-05' AS Date)),
  (N'CT002', N'UV001', N'Bang thạc sĩ', 0, NULL),
  (N'CT003', N'UV002', N'Bằng đại học', 1, CAST(N'2024-05-05' AS Date)),
  (N'CT004', N'UV002', N'Bằng đại học', 0, NULL),
  (N'CT005', N'UV002', N'Bằng đại học', 1, CAST(N'2024-05-05' AS Date)),
  (N'CT006', N'UV003', N'Bằng đại học', 0, NULL),
  (N'CT007', N'UV003', N'Bằng đại học', 1, CAST(N'2024-05-05' AS Date)),
  (N'CT008', N'UV003', N'Bằng đại học', 0, NULL),
  (N'CT009', N'UV004', N'Bằng đại học', 1, CAST(N'2024-05-05' AS Date)),
  (N'CT010', N'UV004', N'Bằng đại học', 0, NULL); 

INSERT INTO HoaDon (MaHoaDon, MaDangTuyen, GiaTriHoaDon, HinhThucThanhToan,CachThucThanhToan, NgayThanhToan)
VALUES
  (N'HD001', N'DT001', 500000, N'Tiền mặt',N'Toàn bộ', CAST(N'2024-05-05' AS Date)),
  (N'HD002', N'DT002', 500000, N'Thẻ',N'Trả góp', CAST(N'2024-05-05' AS Date)),
  (N'HD003', N'DT003', 500000, N'Tiền mặt',N'Toàn bộ', CAST(N'2024-05-05' AS Date)),
  (N'HD004', N'DT004', 500000, N'Thẻ',N'Toàn bộ', CAST(N'2024-05-05' AS Date)),
  (N'HD005', N'DT005', 500000, N'Tiền mặt',N'Trả góp', CAST(N'2024-05-05' AS Date));
