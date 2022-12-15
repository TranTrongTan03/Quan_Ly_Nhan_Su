USE [QuanLyCongTyDB]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 12/15/2022 1:14:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [varchar](10) NOT NULL,
	[TenNV] [nvarchar](50) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[DienThoai] [varchar](10) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[MaPhong] [varchar](10) NOT NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [Email], [DienThoai], [DiaChi], [MaPhong]) VALUES (N'NV001', N'a', CAST(N'2000-11-11' AS Date), N'a@gmail.co', N'654321', N'CuChi', N'P002')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [Email], [DienThoai], [DiaChi], [MaPhong]) VALUES (N'NV002', N'b', CAST(N'2001-01-01' AS Date), N'b@gmail.co', N'0321', N'hn', N'P002')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [Email], [DienThoai], [DiaChi], [MaPhong]) VALUES (N'NV003', N'c', CAST(N'2001-01-02' AS Date), N'0123', N'c', N'hcm', N'P001')
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_Phong1] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[Phong] ([MaPhong])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_Phong1]
GO
/****** Object:  StoredProcedure [dbo].[sp_SuaNhanVien]    Script Date: 12/15/2022 1:14:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_SuaNhanVien]
	@MaNV varchar(10),
	@TenNV nvarchar(50),
	@NgaySinh varchar(50),
	@Email nvarchar(50),
	@DienThoai varchar(10),
	@DiaChi nvarchar(50),
	@MaPhong varchar(10)
AS 
	UPDATE NhanVien 
	SET TenNV = @tenNV, NgaySinh = @ngaySinh,Email=@Email, DienThoai = @dienThoai,DiaChi = @diaChi,MaPhong =@maPhong
	WHERE MaNV = @MaNV
GO
/****** Object:  StoredProcedure [dbo].[sp_SuaNhanVienQL]    Script Date: 12/15/2022 1:14:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[sp_SuaNhanVienQL]
	@MaQL varchar(10),
	@TenQL nvarchar(50),
	@NgaySinh varchar(50),
	@GioiTinh nvarchar(10),
	@DienThoai varchar(10),
	@Email nvarchar(50),
	@Diachi nvarchar(50)
AS 
	UPDATE QuanLy 
	SET TenQL = @tenQL, NgaySinh = @ngaySinh,GioiTinh = @gioiTinh, DienThoai = @dienThoai,Email = @email ,DiaChi = @diaChi
	WHERE MaQL = @MaQL
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemNhanVien]    Script Date: 12/15/2022 1:14:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ThemNhanVien]
	@MaNV varchar(10),
	@TenNV nvarchar(50),
	@NgaySinh varchar(50),
	@Email nvarchar(50),
	@DienThoai varchar(10),
	@DiaChi nvarchar(50),
	@MaPhong varchar(10)
AS
	INSERT INTO NhanVien VALUES (@MaNV,@TenNV,@NgaySinh,@Email,@DienThoai,@DiaChi,@MaPhong)
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemNhanVienQL]    Script Date: 12/15/2022 1:14:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ThemNhanVienQL]
	@MaQL varchar(10),
	@TenQL nvarchar(50),
	@NgaySinh varchar(50),
	@GioiTinh nvarchar(10),
	@DienThoai varchar(10),
	@Email nvarchar(50),
	@Diachi nvarchar(50)
AS
	INSERT INTO QuanLy VALUES (@MaQL,@TenQL,@NgaySinh,@GioiTinh,@DienThoai,@Email,@Diachi)
GO
/****** Object:  StoredProcedure [dbo].[sp_TimNhanVien]    Script Date: 12/15/2022 1:14:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	CREATE PROC [dbo].[sp_TimNhanVien]
	@TenNV varchar(50)
AS
	SELECT * FROM NhanVien WHERE TenNV LIKE CONCAT('%',  @tenNV,'%')
GO
/****** Object:  StoredProcedure [dbo].[sp_TimNhanVienQL]    Script Date: 12/15/2022 1:14:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_TimNhanVienQL]
	@TenQL varchar(50)
AS
	SELECT * FROM QuanLy WHERE TenQL LIKE CONCAT('%',  @tenQL,'%')
GO
/****** Object:  StoredProcedure [dbo].[sp_XoaNhanVien]    Script Date: 12/15/2022 1:14:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_XoaNhanVien]
	@maNV varchar(10)
AS 
	DELETE FROM NhanVien WHERE MaNV = @maNV
GO
/****** Object:  StoredProcedure [dbo].[sp_XoaNhanVienQL]    Script Date: 12/15/2022 1:14:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_XoaNhanVienQL]
	@tenQL varchar(50)
AS 
	DELETE FROM QuanLy WHERE TenQL = @tenQL
GO
