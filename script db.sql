USE [master]
GO
/****** Object:  Database [PROJECTADIS]    Script Date: 10-May-24 9:11:52 PM ******/
CREATE DATABASE [PROJECTADIS]
GO
ALTER DATABASE [PROJECTADIS] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PROJECTADIS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PROJECTADIS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PROJECTADIS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PROJECTADIS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PROJECTADIS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PROJECTADIS] SET ARITHABORT OFF 
GO
ALTER DATABASE [PROJECTADIS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PROJECTADIS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PROJECTADIS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PROJECTADIS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PROJECTADIS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PROJECTADIS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PROJECTADIS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PROJECTADIS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PROJECTADIS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PROJECTADIS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PROJECTADIS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PROJECTADIS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PROJECTADIS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PROJECTADIS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PROJECTADIS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PROJECTADIS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PROJECTADIS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PROJECTADIS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PROJECTADIS] SET  MULTI_USER 
GO
ALTER DATABASE [PROJECTADIS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PROJECTADIS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PROJECTADIS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PROJECTADIS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PROJECTADIS] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PROJECTADIS] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [PROJECTADIS] SET QUERY_STORE = ON
GO
ALTER DATABASE [PROJECTADIS] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [PROJECTADIS]
GO
/****** Object:  Table [dbo].[ChiTietDangTuyen]    Script Date: 10-May-24 9:11:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDangTuyen](
	[MaChiTietDangTuyen] [nvarchar](10) NOT NULL,
	[MaDangTuyen] [nvarchar](10) NULL,
	[ViTri] [nvarchar](100) NULL,
	[SoLuong] [int] NULL,
	[MoTa] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChiTietDangTuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CongTy]    Script Date: 10-May-24 9:11:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CongTy](
	[MaCongTy] [nvarchar](10) NOT NULL,
	[TenCongTy] [nvarchar](100) NULL,
	[MaSoThue] [nvarchar](15) NULL,
	[NguoiDaiDien] [nvarchar](100) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[Email] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCongTy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanhSachChungTu]    Script Date: 10-May-24 9:11:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhSachChungTu](
	[MaChungTu] [nvarchar](10) NOT NULL,
	[MaUngVien] [nvarchar](10) NULL,
	[LoaiChungTu] [nvarchar](100) NULL,
	[TinhTrangNop] [bit] NULL,
	[NgayNop] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChungTu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanhSachDangKyUngTuyen]    Script Date: 10-May-24 9:11:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhSachDangKyUngTuyen](
	[MaChiTietDangTuyen] [nvarchar](10) NOT NULL,
	[MaUngVien] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChiTietDangTuyen] ASC,
	[MaUngVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanhSachDangTuyen]    Script Date: 10-May-24 9:11:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhSachDangTuyen](
	[MaDangTuyen] [nvarchar](10) NOT NULL,
	[ThoiGianDangTuyen] [date] NULL,
	[HinhThucDangTuyen] [nvarchar](100) NULL,
	[NhanVienLapPhieu] [nvarchar](10) NULL,
	[CongTyDangTuyen] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDangTuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 10-May-24 9:11:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHoaDon] [nvarchar](10) NOT NULL,
	[MaDangTuyen] [nvarchar](10) NULL,
	[GiaTriHoaDon] [int] NULL,
	[HinhThucThanhToan] [nvarchar](100) NULL,
	[CachThucThanhToan] [nvarchar](100) NULL,
	[NgayThanhToan] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 10-May-24 9:11:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [nvarchar](10) NOT NULL,
	[HoTen] [nvarchar](100) NULL,
	[ChucVu] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UngVien]    Script Date: 10-May-24 9:11:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UngVien](
	[MaUngVien] [nvarchar](10) NOT NULL,
	[HoTen] [nvarchar](100) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[Email] [nvarchar](100) NULL,
	[NgaySinh] [date] NULL,
	[CCCD] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaUngVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChiTietDangTuyen] ([MaChiTietDangTuyen], [MaDangTuyen], [ViTri], [SoLuong], [MoTa]) VALUES (N'CTDT001', N'DT001', N'Dev', 5, N'be a dev')
INSERT [dbo].[ChiTietDangTuyen] ([MaChiTietDangTuyen], [MaDangTuyen], [ViTri], [SoLuong], [MoTa]) VALUES (N'CTDT002', N'DT001', N'Intern', 20, N'be a inter')
INSERT [dbo].[ChiTietDangTuyen] ([MaChiTietDangTuyen], [MaDangTuyen], [ViTri], [SoLuong], [MoTa]) VALUES (N'CTDT003', N'DT001', N'HR', 1, N'be a HR')
INSERT [dbo].[ChiTietDangTuyen] ([MaChiTietDangTuyen], [MaDangTuyen], [ViTri], [SoLuong], [MoTa]) VALUES (N'CTDT004', N'DT002', N'Dev', 5, N'be a dev')
INSERT [dbo].[ChiTietDangTuyen] ([MaChiTietDangTuyen], [MaDangTuyen], [ViTri], [SoLuong], [MoTa]) VALUES (N'CTDT005', N'DT002', N'Intern', 10, N'be a inter')
INSERT [dbo].[ChiTietDangTuyen] ([MaChiTietDangTuyen], [MaDangTuyen], [ViTri], [SoLuong], [MoTa]) VALUES (N'CTDT006', N'DT003', N'Dev', 5, N'be a dev')
INSERT [dbo].[ChiTietDangTuyen] ([MaChiTietDangTuyen], [MaDangTuyen], [ViTri], [SoLuong], [MoTa]) VALUES (N'CTDT007', N'DT003', N'Intern', 10, N'be a inter')
GO
INSERT [dbo].[CongTy] ([MaCongTy], [TenCongTy], [MaSoThue], [NguoiDaiDien], [DiaChi], [Email]) VALUES (N'CTY001', N'ABC', N'332893541199846', NULL, N'Ho Chi Minh', N'abc@gmail.com')
INSERT [dbo].[CongTy] ([MaCongTy], [TenCongTy], [MaSoThue], [NguoiDaiDien], [DiaChi], [Email]) VALUES (N'CTY002', N'DigitalOcean', N'359513848770720', NULL, N'Ho Chi Minh', N'DigitalOcean@gmail.com')
INSERT [dbo].[CongTy] ([MaCongTy], [TenCongTy], [MaSoThue], [NguoiDaiDien], [DiaChi], [Email]) VALUES (N'CTY003', N'BrightBytes', N'057228052724291', NULL, N'Ho Chi Minh', N'BrightBytes@gmail.com')
INSERT [dbo].[CongTy] ([MaCongTy], [TenCongTy], [MaSoThue], [NguoiDaiDien], [DiaChi], [Email]) VALUES (N'CTY004', N'Itility', N'087776493832706', NULL, N'Ho Chi Minh', N'Itility@gmail.com')
INSERT [dbo].[CongTy] ([MaCongTy], [TenCongTy], [MaSoThue], [NguoiDaiDien], [DiaChi], [Email]) VALUES (N'CTY005', N'DataLab', N'583054271837287', NULL, N'Ho Chi Minh', N'DataLab@gmail.com')
INSERT [dbo].[CongTy] ([MaCongTy], [TenCongTy], [MaSoThue], [NguoiDaiDien], [DiaChi], [Email]) VALUES (N'CTY006', N'SoftIT', N'332633782173836', NULL, N'Ho Chi Minh', N'SoftIT@gmail.com')
INSERT [dbo].[CongTy] ([MaCongTy], [TenCongTy], [MaSoThue], [NguoiDaiDien], [DiaChi], [Email]) VALUES (N'CTY007', N'Cybertec', N'548943135439128', NULL, N'Ho Chi Minh', N'Cybertec@gmail.com')
INSERT [dbo].[CongTy] ([MaCongTy], [TenCongTy], [MaSoThue], [NguoiDaiDien], [DiaChi], [Email]) VALUES (N'CTY008', N'DataCharm', N'536747663168470', NULL, N'Ho Chi Minh', N'DataCharm@gmail.com')
INSERT [dbo].[CongTy] ([MaCongTy], [TenCongTy], [MaSoThue], [NguoiDaiDien], [DiaChi], [Email]) VALUES (N'CTY009', N'BitDATA', N'741972665128594', NULL, N'Ho Chi Minh', N'BitDATA@gmail.com')
INSERT [dbo].[CongTy] ([MaCongTy], [TenCongTy], [MaSoThue], [NguoiDaiDien], [DiaChi], [Email]) VALUES (N'CTY010', N'ByteTree', N'741446400684522', NULL, N'Ho Chi Minh', N'ByteTree@gmail.com')
GO
INSERT [dbo].[DanhSachChungTu] ([MaChungTu], [MaUngVien], [LoaiChungTu], [TinhTrangNop], [NgayNop]) VALUES (N'CT001', N'UV001', N'Bằng đại học', 1, CAST(N'2024-05-05' AS Date))
INSERT [dbo].[DanhSachChungTu] ([MaChungTu], [MaUngVien], [LoaiChungTu], [TinhTrangNop], [NgayNop]) VALUES (N'CT002', N'UV001', N'Bang thạc sĩ', 0, NULL)
INSERT [dbo].[DanhSachChungTu] ([MaChungTu], [MaUngVien], [LoaiChungTu], [TinhTrangNop], [NgayNop]) VALUES (N'CT003', N'UV002', N'Bằng đại học', 1, CAST(N'2024-05-05' AS Date))
INSERT [dbo].[DanhSachChungTu] ([MaChungTu], [MaUngVien], [LoaiChungTu], [TinhTrangNop], [NgayNop]) VALUES (N'CT004', N'UV002', N'Bằng đại học', 0, NULL)
INSERT [dbo].[DanhSachChungTu] ([MaChungTu], [MaUngVien], [LoaiChungTu], [TinhTrangNop], [NgayNop]) VALUES (N'CT005', N'UV002', N'Bằng đại học', 1, CAST(N'2024-05-05' AS Date))
INSERT [dbo].[DanhSachChungTu] ([MaChungTu], [MaUngVien], [LoaiChungTu], [TinhTrangNop], [NgayNop]) VALUES (N'CT006', N'UV003', N'Bằng đại học', 0, NULL)
INSERT [dbo].[DanhSachChungTu] ([MaChungTu], [MaUngVien], [LoaiChungTu], [TinhTrangNop], [NgayNop]) VALUES (N'CT007', N'UV003', N'Bằng đại học', 1, CAST(N'2024-05-05' AS Date))
INSERT [dbo].[DanhSachChungTu] ([MaChungTu], [MaUngVien], [LoaiChungTu], [TinhTrangNop], [NgayNop]) VALUES (N'CT008', N'UV003', N'Bằng đại học', 0, NULL)
INSERT [dbo].[DanhSachChungTu] ([MaChungTu], [MaUngVien], [LoaiChungTu], [TinhTrangNop], [NgayNop]) VALUES (N'CT009', N'UV004', N'Bằng đại học', 1, CAST(N'2024-05-05' AS Date))
INSERT [dbo].[DanhSachChungTu] ([MaChungTu], [MaUngVien], [LoaiChungTu], [TinhTrangNop], [NgayNop]) VALUES (N'CT010', N'UV004', N'Bằng đại học', 0, NULL)
GO
INSERT [dbo].[DanhSachDangKyUngTuyen] ([MaChiTietDangTuyen], [MaUngVien]) VALUES (N'CTDT001', N'UV002')
INSERT [dbo].[DanhSachDangKyUngTuyen] ([MaChiTietDangTuyen], [MaUngVien]) VALUES (N'CTDT001', N'UV003')
INSERT [dbo].[DanhSachDangKyUngTuyen] ([MaChiTietDangTuyen], [MaUngVien]) VALUES (N'CTDT002', N'UV001')
INSERT [dbo].[DanhSachDangKyUngTuyen] ([MaChiTietDangTuyen], [MaUngVien]) VALUES (N'CTDT002', N'UV002')
INSERT [dbo].[DanhSachDangKyUngTuyen] ([MaChiTietDangTuyen], [MaUngVien]) VALUES (N'CTDT002', N'UV003')
INSERT [dbo].[DanhSachDangKyUngTuyen] ([MaChiTietDangTuyen], [MaUngVien]) VALUES (N'CTDT002', N'UV004')
GO
INSERT [dbo].[DanhSachDangTuyen] ([MaDangTuyen], [ThoiGianDangTuyen], [HinhThucDangTuyen], [NhanVienLapPhieu], [CongTyDangTuyen]) VALUES (N'DT001', CAST(N'2024-05-01' AS Date), N'Bao giay', N'NV001', N'CTY001')
INSERT [dbo].[DanhSachDangTuyen] ([MaDangTuyen], [ThoiGianDangTuyen], [HinhThucDangTuyen], [NhanVienLapPhieu], [CongTyDangTuyen]) VALUES (N'DT002', CAST(N'2024-05-01' AS Date), N'Banner quang cao', N'NV002', N'CTY003')
INSERT [dbo].[DanhSachDangTuyen] ([MaDangTuyen], [ThoiGianDangTuyen], [HinhThucDangTuyen], [NhanVienLapPhieu], [CongTyDangTuyen]) VALUES (N'DT003', CAST(N'2024-05-01' AS Date), N'Bao giay', N'NV001', N'CTY001')
INSERT [dbo].[DanhSachDangTuyen] ([MaDangTuyen], [ThoiGianDangTuyen], [HinhThucDangTuyen], [NhanVienLapPhieu], [CongTyDangTuyen]) VALUES (N'DT004', CAST(N'2024-05-01' AS Date), N'Bao giay', N'NV002', N'CTY001')
INSERT [dbo].[DanhSachDangTuyen] ([MaDangTuyen], [ThoiGianDangTuyen], [HinhThucDangTuyen], [NhanVienLapPhieu], [CongTyDangTuyen]) VALUES (N'DT005', CAST(N'2024-05-01' AS Date), N'Trang mang', N'NV001', N'CTY003')
GO
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaDangTuyen], [GiaTriHoaDon], [HinhThucThanhToan], [CachThucThanhToan], [NgayThanhToan]) VALUES (N'HD001', N'DT001', 500000, N'Tiền mặt', N'Toàn bộ', CAST(N'2024-05-05' AS Date))
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaDangTuyen], [GiaTriHoaDon], [HinhThucThanhToan], [CachThucThanhToan], [NgayThanhToan]) VALUES (N'HD002', N'DT002', 50000, N'Thẻ', N'Trả góp', CAST(N'2024-05-05' AS Date))
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaDangTuyen], [GiaTriHoaDon], [HinhThucThanhToan], [CachThucThanhToan], [NgayThanhToan]) VALUES (N'HD003', N'DT003', 500000, N'Tiền mặt', N'Toàn bộ', CAST(N'2024-05-05' AS Date))
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaDangTuyen], [GiaTriHoaDon], [HinhThucThanhToan], [CachThucThanhToan], [NgayThanhToan]) VALUES (N'HD004', N'DT004', 500000, N'Thẻ', N'Toàn bộ', CAST(N'2024-05-05' AS Date))
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaDangTuyen], [GiaTriHoaDon], [HinhThucThanhToan], [CachThucThanhToan], [NgayThanhToan]) VALUES (N'HD005', N'DT005', 500000, N'Tiền mặt', N'Trả góp', CAST(N'2024-05-05' AS Date))
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaDangTuyen], [GiaTriHoaDon], [HinhThucThanhToan], [CachThucThanhToan], [NgayThanhToan]) VALUES (N'HD006', N'DT003', 50000, N'', N'', CAST(N'2024-05-07' AS Date))
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaDangTuyen], [GiaTriHoaDon], [HinhThucThanhToan], [CachThucThanhToan], [NgayThanhToan]) VALUES (N'HD007', N'DT002', 50000, N'Tiền mặt', N'Trả góp', CAST(N'2025-05-07' AS Date))
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaDangTuyen], [GiaTriHoaDon], [HinhThucThanhToan], [CachThucThanhToan], [NgayThanhToan]) VALUES (N'HD008', N'DT001', 50000, N'', N'', CAST(N'2024-05-07' AS Date))
GO
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [ChucVu]) VALUES (N'NV001', N'Nguyen Tuan An', N'Nhan vien')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [ChucVu]) VALUES (N'NV002', N'Tran Van Binh', N'Nhan vien')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [ChucVu]) VALUES (N'NV003', N'Le Quoc Khanh', N'Nhan vien')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [ChucVu]) VALUES (N'NV004', N'Pham Minh Cuong', N'Nhan vien')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [ChucVu]) VALUES (N'NV005', N'Vo Thanh Dat', N'Nhan vien')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [ChucVu]) VALUES (N'NV006', N'Do Thi Huong', N'Nhan vien')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [ChucVu]) VALUES (N'NV007', N'Nguyen Hai Yen', N'Nhan vien')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [ChucVu]) VALUES (N'NV008', N'Pham Tuan Anh', N'Nhan vien')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [ChucVu]) VALUES (N'NV009', N'Tran Ngoc Linh', N'Nhan vien')
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [ChucVu]) VALUES (N'NV010', N'Le Van Tien', N'Quan ly')
GO
INSERT [dbo].[UngVien] ([MaUngVien], [HoTen], [DiaChi], [Email], [NgaySinh], [CCCD]) VALUES (N'UV001', N'Tran Quang Thien', N'Ho Chi Minh', N'tqthien@gmail.com', CAST(N'2000-05-05' AS Date), N'5718917719')
INSERT [dbo].[UngVien] ([MaUngVien], [HoTen], [DiaChi], [Email], [NgaySinh], [CCCD]) VALUES (N'UV002', N'Le Hoang Son', N'Ho Chi Minh', N'lhson@gmail.com', CAST(N'2001-07-15' AS Date), N'6842535722')
INSERT [dbo].[UngVien] ([MaUngVien], [HoTen], [DiaChi], [Email], [NgaySinh], [CCCD]) VALUES (N'UV003', N'Nguyen Thi Mai', N'Ho Chi Minh', N'ntmai@gmail.com', CAST(N'2003-09-20' AS Date), N'1383006923')
INSERT [dbo].[UngVien] ([MaUngVien], [HoTen], [DiaChi], [Email], [NgaySinh], [CCCD]) VALUES (N'UV004', N'Pham Dinh Long', N'Ho Chi Minh', N'pdlong@gmail.com', CAST(N'2005-11-30' AS Date), N'0366723400')
INSERT [dbo].[UngVien] ([MaUngVien], [HoTen], [DiaChi], [Email], [NgaySinh], [CCCD]) VALUES (N'UV005', N'Vo Van Lam', N'Ho Chi Minh', N'vvlam@gmail.com', CAST(N'2002-03-25' AS Date), N'6953385262')
INSERT [dbo].[UngVien] ([MaUngVien], [HoTen], [DiaChi], [Email], [NgaySinh], [CCCD]) VALUES (N'UV006', N'Do Thu Hang', N'Ho Chi Minh', N'dthang@gmail.com', CAST(N'2000-06-10' AS Date), N'3035773793')
INSERT [dbo].[UngVien] ([MaUngVien], [HoTen], [DiaChi], [Email], [NgaySinh], [CCCD]) VALUES (N'UV007', N'Nguyen Quoc Huy', N'Ho Chi Minh', N'nqhuy@gmail.com', CAST(N'2006-04-28' AS Date), N'0458397186')
INSERT [dbo].[UngVien] ([MaUngVien], [HoTen], [DiaChi], [Email], [NgaySinh], [CCCD]) VALUES (N'UV008', N'Pham Ngoc Diep', N'Ho Chi Minh', N'pndiep@gmail.com', CAST(N'2009-12-05' AS Date), N'7642797075')
INSERT [dbo].[UngVien] ([MaUngVien], [HoTen], [DiaChi], [Email], [NgaySinh], [CCCD]) VALUES (N'UV009', N'Tran Van Toan', N'Ho Chi Minh', N'tvtoan@gmail.com', CAST(N'2008-01-15' AS Date), N'7554771410')
INSERT [dbo].[UngVien] ([MaUngVien], [HoTen], [DiaChi], [Email], [NgaySinh], [CCCD]) VALUES (N'UV010', N'Le Van Dung', N'Ho Chi Minh', N'lvdung@gmail.com', NULL, N'7559900232')
GO
ALTER TABLE [dbo].[ChiTietDangTuyen]  WITH CHECK ADD FOREIGN KEY([MaDangTuyen])
REFERENCES [dbo].[DanhSachDangTuyen] ([MaDangTuyen])
GO
ALTER TABLE [dbo].[DanhSachChungTu]  WITH CHECK ADD FOREIGN KEY([MaUngVien])
REFERENCES [dbo].[UngVien] ([MaUngVien])
GO
ALTER TABLE [dbo].[DanhSachDangKyUngTuyen]  WITH CHECK ADD FOREIGN KEY([MaChiTietDangTuyen])
REFERENCES [dbo].[ChiTietDangTuyen] ([MaChiTietDangTuyen])
GO
ALTER TABLE [dbo].[DanhSachDangKyUngTuyen]  WITH CHECK ADD FOREIGN KEY([MaUngVien])
REFERENCES [dbo].[UngVien] ([MaUngVien])
GO
ALTER TABLE [dbo].[DanhSachDangTuyen]  WITH CHECK ADD FOREIGN KEY([CongTyDangTuyen])
REFERENCES [dbo].[CongTy] ([MaCongTy])
GO
ALTER TABLE [dbo].[DanhSachDangTuyen]  WITH CHECK ADD FOREIGN KEY([NhanVienLapPhieu])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([MaDangTuyen])
REFERENCES [dbo].[DanhSachDangTuyen] ([MaDangTuyen])
GO
/****** Object:  StoredProcedure [dbo].[AddHoaDon]    Script Date: 10-May-24 9:11:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddHoaDon]
    @MaHoaDon nvarchar(10),
    @MaDangTuyen nvarchar(10),
    @GiaTriHoaDon int,
    @HinhThucThanhToan nvarchar(100),
	@CachThucThanhToan nvarchar(100),
    @NgayThanhToan date
AS
BEGIN
    BEGIN TRANSACTION
    BEGIN TRY
        INSERT INTO dbo.HoaDon (
            MaHoaDon,
            MaDangTuyen,
            GiaTriHoaDon,
            HinhThucThanhToan,
            CachThucThanhToan,
            NgayThanhToan
        ) VALUES (
            @MaHoaDon,
            @MaDangTuyen,
            @GiaTriHoaDon,
            @HinhThucThanhToan,
			@CachThucThanhToan,
            @NgayThanhToan
        );

        COMMIT TRANSACTION;
    END TRY

    BEGIN CATCH
        ROLLBACK TRANSACTION;

        DECLARE @ErrorMessage nvarchar(4000) = ERROR_MESSAGE();
        RAISERROR(@ErrorMessage, 16, 1);
    END CATCH
END;
GO
/****** Object:  StoredProcedure [dbo].[UpdateHoaDon]    Script Date: 10-May-24 9:11:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UpdateHoaDon]
    @MaHoaDon nvarchar(10),  
    @MaDangTuyen nvarchar(10) = NULL,
    @GiaTriHoaDon int = NULL,         
    @HinhThucThanhToan nvarchar(100) = NULL,  
    @CachThucThanhToan nvarchar(100) = NULL,  
    @NgayThanhToan date = NULL         
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM HoaDon WHERE MaHoaDon = @MaHoaDon)
    BEGIN
        PRINT 'MaHoaDon does not exist.'
        RETURN
    END

    UPDATE HoaDon
    SET 
        MaDangTuyen = COALESCE(@MaDangTuyen, MaDangTuyen), 
        GiaTriHoaDon = COALESCE(@GiaTriHoaDon, GiaTriHoaDon),
        HinhThucThanhToan = COALESCE(@HinhThucThanhToan, HinhThucThanhToan),
        CachThucThanhToan = COALESCE(@CachThucThanhToan, CachThucThanhToan),
        NgayThanhToan = COALESCE(@NgayThanhToan, NgayThanhToan)
    WHERE 
        MaHoaDon = @MaHoaDon

    PRINT 'Record updated successfully.'
END
GO
USE [master]
GO
ALTER DATABASE [PROJECTADIS] SET  READ_WRITE 
GO
