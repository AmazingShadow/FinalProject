USE [master]
GO
/****** Object:  Database [QUANLYSIEUTHI]    Script Date: 12/24/2022 9:17:57 PM ******/
CREATE DATABASE [QUANLYSIEUTHI]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QUANLYSIEUTHI', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\QUANLYSIEUTHI.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QUANLYSIEUTHI_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\QUANLYSIEUTHI_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QUANLYSIEUTHI] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QUANLYSIEUTHI].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QUANLYSIEUTHI] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QUANLYSIEUTHI] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QUANLYSIEUTHI] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QUANLYSIEUTHI] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QUANLYSIEUTHI] SET ARITHABORT OFF 
GO
ALTER DATABASE [QUANLYSIEUTHI] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QUANLYSIEUTHI] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QUANLYSIEUTHI] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QUANLYSIEUTHI] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QUANLYSIEUTHI] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QUANLYSIEUTHI] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QUANLYSIEUTHI] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QUANLYSIEUTHI] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QUANLYSIEUTHI] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QUANLYSIEUTHI] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QUANLYSIEUTHI] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QUANLYSIEUTHI] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QUANLYSIEUTHI] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QUANLYSIEUTHI] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QUANLYSIEUTHI] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QUANLYSIEUTHI] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QUANLYSIEUTHI] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QUANLYSIEUTHI] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QUANLYSIEUTHI] SET  MULTI_USER 
GO
ALTER DATABASE [QUANLYSIEUTHI] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QUANLYSIEUTHI] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QUANLYSIEUTHI] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QUANLYSIEUTHI] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QUANLYSIEUTHI] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QUANLYSIEUTHI] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QUANLYSIEUTHI] SET QUERY_STORE = OFF
GO
USE [QUANLYSIEUTHI]
GO
/****** Object:  User [HUU]    Script Date: 12/24/2022 9:17:57 PM ******/
CREATE USER [HUU] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[HUU]
GO
/****** Object:  Schema [HUU]    Script Date: 12/24/2022 9:17:57 PM ******/
CREATE SCHEMA [HUU]
GO
/****** Object:  Table [dbo].[CHITIETHOADON]    Script Date: 12/24/2022 9:17:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETHOADON](
	[MASANPHAM] [varchar](20) NOT NULL,
	[MAHOADON] [varchar](20) NOT NULL,
	[SOLUONG] [int] NULL,
	[DONGIA] [real] NULL,
PRIMARY KEY CLUSTERED 
(
	[MASANPHAM] ASC,
	[MAHOADON] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HANGHOA]    Script Date: 12/24/2022 9:17:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HANGHOA](
	[MASANPHAM] [varchar](20) NOT NULL,
	[TENSANPHAM] [nvarchar](30) NULL,
	[HANSUDUNG] [date] NULL,
	[DONVITINH] [varchar](20) NULL,
	[MALOAI] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MASANPHAM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 12/24/2022 9:17:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[MAHOADON] [varchar](20) NOT NULL,
	[NGAYTAO] [date] NULL,
	[TONGTIEN] [real] NULL,
	[MAKHACHHANG] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[MAHOADON] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 12/24/2022 9:17:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MAKHACHHANG] [varchar](30) NOT NULL,
	[TENKHACHHANG] [nvarchar](30) NULL,
	[LOAIKHACHHANG] [nvarchar](30) NULL,
	[DIACHI] [nvarchar](40) NULL,
	[SDT] [varchar](20) NULL,
	[NGAYSINH] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[MAKHACHHANG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[SDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAIHANGHOA]    Script Date: 12/24/2022 9:17:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIHANGHOA](
	[MALOAI] [varchar](20) NOT NULL,
	[TENLOAI] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[MALOAI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 12/24/2022 9:17:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MANHANVIEN] [varchar](20) NOT NULL,
	[TENNHANVIEN] [nvarchar](30) NULL,
	[DIACHI] [nvarchar](40) NULL,
	[LUONGCOBAN] [real] NULL,
	[DIEMTHUONG] [int] NULL,
	[NGAYSINH] [date] NULL,
	[SDT] [varchar](20) NULL,
	[GIOITINH] [nvarchar](3) NULL,
	[TILETHUNHAPGIATANG] [real] NULL,
	[MAQUANLY] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MANHANVIEN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[SDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIENBANHANG]    Script Date: 12/24/2022 9:17:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIENBANHANG](
	[MANHANVIEN] [varchar](20) NOT NULL,
	[KHUVUCBAN] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[MANHANVIEN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIENKHO]    Script Date: 12/24/2022 9:17:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIENKHO](
	[MANHANVIEN] [varchar](20) NOT NULL,
	[KHUVUCQUANLY] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[MANHANVIEN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUHANGHOA]    Script Date: 12/24/2022 9:17:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUHANGHOA](
	[MAPHIEUNHAP] [varchar](20) NOT NULL,
	[MASANPHAM] [varchar](20) NOT NULL,
	[SOLUONG] [int] NULL,
	[DONGIA] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MAPHIEUNHAP] ASC,
	[MASANPHAM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUHANGXUAT]    Script Date: 12/24/2022 9:17:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUHANGXUAT](
	[MAPHIEUXUAT] [varchar](20) NOT NULL,
	[MASANPHAM] [varchar](20) NOT NULL,
	[SOLUONG] [int] NULL,
	[DONGIA] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MAPHIEUXUAT] ASC,
	[MASANPHAM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUNHAP]    Script Date: 12/24/2022 9:17:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUNHAP](
	[MAPHIEUNHAP] [varchar](20) NOT NULL,
	[TENNHACUNGCAP] [nvarchar](40) NULL,
	[NGAYNHAP] [date] NULL,
	[TENKHONHAP] [nvarchar](30) NULL,
	[DONVIVANCHUYEN] [nvarchar](30) NULL,
	[HOTENNGUOIGIAOHANG] [nvarchar](30) NULL,
	[DIACHIKHO] [nvarchar](30) NULL,
	[THANHTIEN] [real] NULL,
	[MANHANVIEN] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MAPHIEUNHAP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUXUAT]    Script Date: 12/24/2022 9:17:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUXUAT](
	[MAPHIEUXUAT] [varchar](20) NOT NULL,
	[DIADIEMXUAT] [nvarchar](40) NULL,
	[NGAYXUAT] [date] NULL,
	[LYDOXUAT] [nvarchar](100) NULL,
	[MANHANVIEN] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MAPHIEUXUAT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 12/24/2022 9:17:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[TENDANGNHAP] [varchar](30) NOT NULL,
	[MANHANVIEN] [varchar](20) NOT NULL,
	[MATKHAU] [varchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[TENDANGNHAP] ASC,
	[MANHANVIEN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[TAIKHOAN] ADD  CONSTRAINT [DF_MATKHAU]  DEFAULT ('123456') FOR [MATKHAU]
GO
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETHOADON_MAHOADON] FOREIGN KEY([MAHOADON])
REFERENCES [dbo].[HOADON] ([MAHOADON])
GO
ALTER TABLE [dbo].[CHITIETHOADON] CHECK CONSTRAINT [FK_CHITIETHOADON_MAHOADON]
GO
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETHOADON_MASANPHAM] FOREIGN KEY([MASANPHAM])
REFERENCES [dbo].[HANGHOA] ([MASANPHAM])
GO
ALTER TABLE [dbo].[CHITIETHOADON] CHECK CONSTRAINT [FK_CHITIETHOADON_MASANPHAM]
GO
ALTER TABLE [dbo].[HANGHOA]  WITH CHECK ADD  CONSTRAINT [FK_HANGHOA_MALOAI] FOREIGN KEY([MALOAI])
REFERENCES [dbo].[LOAIHANGHOA] ([MALOAI])
GO
ALTER TABLE [dbo].[HANGHOA] CHECK CONSTRAINT [FK_HANGHOA_MALOAI]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_MAKHACHHANG] FOREIGN KEY([MAKHACHHANG])
REFERENCES [dbo].[KHACHHANG] ([MAKHACHHANG])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_MAKHACHHANG]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_MAQUANLY] FOREIGN KEY([MAQUANLY])
REFERENCES [dbo].[NHANVIEN] ([MANHANVIEN])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_MAQUANLY]
GO
ALTER TABLE [dbo].[NHANVIENBANHANG]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIENBANHANG_MANHANVIEN] FOREIGN KEY([MANHANVIEN])
REFERENCES [dbo].[NHANVIEN] ([MANHANVIEN])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[NHANVIENBANHANG] CHECK CONSTRAINT [FK_NHANVIENBANHANG_MANHANVIEN]
GO
ALTER TABLE [dbo].[NHANVIENKHO]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIENKHO_MANHANVIEN] FOREIGN KEY([MANHANVIEN])
REFERENCES [dbo].[NHANVIEN] ([MANHANVIEN])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[NHANVIENKHO] CHECK CONSTRAINT [FK_NHANVIENKHO_MANHANVIEN]
GO
ALTER TABLE [dbo].[PHIEUHANGHOA]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUHANGHOA_MAPHIEUNHAP] FOREIGN KEY([MAPHIEUNHAP])
REFERENCES [dbo].[PHIEUNHAP] ([MAPHIEUNHAP])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PHIEUHANGHOA] CHECK CONSTRAINT [FK_PHIEUHANGHOA_MAPHIEUNHAP]
GO
ALTER TABLE [dbo].[PHIEUHANGHOA]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUHANGHOA_MASANPHAM] FOREIGN KEY([MASANPHAM])
REFERENCES [dbo].[HANGHOA] ([MASANPHAM])
GO
ALTER TABLE [dbo].[PHIEUHANGHOA] CHECK CONSTRAINT [FK_PHIEUHANGHOA_MASANPHAM]
GO
ALTER TABLE [dbo].[PHIEUHANGXUAT]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUHANGXUAT_MAPHIEUXUAT] FOREIGN KEY([MAPHIEUXUAT])
REFERENCES [dbo].[PHIEUXUAT] ([MAPHIEUXUAT])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PHIEUHANGXUAT] CHECK CONSTRAINT [FK_PHIEUHANGXUAT_MAPHIEUXUAT]
GO
ALTER TABLE [dbo].[PHIEUHANGXUAT]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUHANGXUAT_MASANPHAM] FOREIGN KEY([MASANPHAM])
REFERENCES [dbo].[HANGHOA] ([MASANPHAM])
GO
ALTER TABLE [dbo].[PHIEUHANGXUAT] CHECK CONSTRAINT [FK_PHIEUHANGXUAT_MASANPHAM]
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAP_MANHANVIEN] FOREIGN KEY([MANHANVIEN])
REFERENCES [dbo].[NHANVIEN] ([MANHANVIEN])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PHIEUNHAP] CHECK CONSTRAINT [FK_PHIEUNHAP_MANHANVIEN]
GO
ALTER TABLE [dbo].[PHIEUXUAT]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUXUAT_MANHANVIEN] FOREIGN KEY([MANHANVIEN])
REFERENCES [dbo].[NHANVIEN] ([MANHANVIEN])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PHIEUXUAT] CHECK CONSTRAINT [FK_PHIEUXUAT_MANHANVIEN]
GO
ALTER TABLE [dbo].[TAIKHOAN]  WITH CHECK ADD  CONSTRAINT [FK_TAIKHOAN_MANHANVIEN] FOREIGN KEY([MANHANVIEN])
REFERENCES [dbo].[NHANVIEN] ([MANHANVIEN])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TAIKHOAN] CHECK CONSTRAINT [FK_TAIKHOAN_MANHANVIEN]
GO
/****** Object:  StoredProcedure [dbo].[GETNV]    Script Date: 12/24/2022 9:17:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GETNV]
AS
	BEGIN
		SELECT *FROM NHANVIEN
	END
GO
/****** Object:  StoredProcedure [dbo].[SUANHANVIEN]    Script Date: 12/24/2022 9:17:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SUANHANVIEN] @MANHANVIEN VARCHAR(20), @TENNHANVIEN NVARCHAR(30), @DIACHI NVARCHAR(40), @LUONGCOBAN REAL, @DIEMTHUONG INT, @NGAYSINH DATE, @SDT VARCHAR(20), @GIOITINH NVARCHAR(3), @TILETHUNHAPGIATANG REAL, @MAQUANLY VARCHAR(20)
AS
	IF @MAQUANLY IS NULL
	BEGIN
		SET @MAQUANLY = NULL
	END
	BEGIN
		UPDATE NHANVIEN SET TENNHANVIEN = @TENNHANVIEN,
							DIACHI = @DIACHI,
							LUONGCOBAN = @LUONGCOBAN,
							DIEMTHUONG = @DIEMTHUONG,
							NGAYSINH = @NGAYSINH,
							SDT = @SDT,
							GIOITINH = @GIOITINH,
							TILETHUNHAPGIATANG = @TILETHUNHAPGIATANG,
							MAQUANLY = @MAQUANLY
		WHERE MANHANVIEN = @MANHANVIEN
	END
GO
/****** Object:  StoredProcedure [dbo].[SUAQUANLY]    Script Date: 12/24/2022 9:17:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SUAQUANLY] @MANHANVIEN VARCHAR(20), @TENNHANVIEN NVARCHAR(30), @DIACHI NVARCHAR(40), @LUONGCOBAN REAL, @DIEMTHUONG INT, @NGAYSINH DATE, @SDT VARCHAR(20), @GIOITINH NVARCHAR(3), @TILETHUNHAPGIATANG REAL
AS
	BEGIN
		UPDATE NHANVIEN SET TENNHANVIEN = @TENNHANVIEN,
							DIACHI = @DIACHI,
							LUONGCOBAN = @LUONGCOBAN,
							DIEMTHUONG = @DIEMTHUONG,
							NGAYSINH = @NGAYSINH,
							SDT = @SDT,
							GIOITINH = @GIOITINH,
							TILETHUNHAPGIATANG = @TILETHUNHAPGIATANG
		WHERE MANHANVIEN = @MANHANVIEN
	END
GO
/****** Object:  StoredProcedure [dbo].[THEMNHANVIEN]    Script Date: 12/24/2022 9:17:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[THEMNHANVIEN] @MANHANVIEN VARCHAR(20), @TENNHANVIEN NVARCHAR(30), @DIACHI NVARCHAR(40), @LUONGCOBAN REAL, @DIEMTHUONG INT, @NGAYSINH DATE, @SDT VARCHAR(20), @GIOITINH NVARCHAR(3), @TILETHUNHAPGIATANG REAL, @MAQUANLY VARCHAR(20)
AS
	BEGIN
		INSERT INTO NHANVIEN VALUES(@MANHANVIEN, @TENNHANVIEN, @DIACHI, @LUONGCOBAN, @DIEMTHUONG, @NGAYSINH, @SDT, @GIOITINH, @TILETHUNHAPGIATANG, @MAQUANLY)
	END
GO
/****** Object:  StoredProcedure [dbo].[THEMQUANLY]    Script Date: 12/24/2022 9:17:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[THEMQUANLY] @MANHANVIEN VARCHAR(20), @TENNHANVIEN NVARCHAR(30), @DIACHI NVARCHAR(40), @LUONGCOBAN REAL, @DIEMTHUONG INT, @NGAYSINH DATE, @SDT VARCHAR(20), @GIOITINH NVARCHAR(3), @TILETHUNHAPGIATANG REAL
AS
	BEGIN
		INSERT INTO NHANVIEN(MANHANVIEN, TENNHANVIEN, DIACHI, LUONGCOBAN, DIEMTHUONG, NGAYSINH, SDT, GIOITINH, tilethunhapgiatang) VALUES(@MANHANVIEN, @TENNHANVIEN, @DIACHI, @LUONGCOBAN, @DIEMTHUONG, @NGAYSINH, @SDT, @GIOITINH, @TILETHUNHAPGIATANG)
	END
GO
/****** Object:  StoredProcedure [dbo].[XOANHANVIEN]    Script Date: 12/24/2022 9:17:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XOANHANVIEN] @MANHANVIEN VARCHAR(20)
AS
	DELETE FROM NHANVIEN WHERE MANHANVIEN = @MANHANVIEN
GO
USE [master]
GO
ALTER DATABASE [QUANLYSIEUTHI] SET  READ_WRITE 
GO
