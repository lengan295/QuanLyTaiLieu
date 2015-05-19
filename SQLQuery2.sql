USE [QLTL]
GO
/****** Object:  Table [dbo].[TrangWeb]    Script Date: 05/10/2015 10:48:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrangWeb](
	[MaTL] [int] NOT NULL,
	[ToChuc] [nvarchar](150) NULL,
	[Ngay] [numeric](2, 0) NULL,
	[Thang] [numeric](2, 0) NULL,
	[NgayTruyCap] [date] NULL,
 CONSTRAINT [PK_TrangWeb] PRIMARY KEY CLUSTERED 
(
	[MaTL] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiLieu]    Script Date: 05/10/2015 10:48:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiLieu](
	[MaTL] [int] NOT NULL IDENTITY(1,1),
	[LoaiTaiLieu] [nchar](15) NOT NULL,
	[TacGia] [nvarchar](500) NULL,
	[TieuDe] [nvarchar](250) NOT NULL,
	[Nam] [numeric](4, 0) NULL,
	[TomTat] [nvarchar](max) NULL,
	[GhiChu] [nvarchar](max) NULL,
	[File] [nvarchar](250) NULL,
	[URL] [nvarchar](250) NULL,
	[DOI] [nvarchar](50) NULL,
 CONSTRAINT [PK_TaiLieu] PRIMARY KEY CLUSTERED 
(
	[MaTL] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sach]    Script Date: 05/10/2015 10:48:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sach](
	[MaTL] [int] NOT NULL,
	[NhaXB] [nvarchar](100) NULL,
	[TaiBan] [nchar](10) NULL,
	[ThanhPho] [nvarchar](50) NULL,
 CONSTRAINT [PK_Sach] PRIMARY KEY CLUSTERED 
(
	[MaTL] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proceeding]    Script Date: 05/10/2015 10:48:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proceeding](
	[MaTL] [int] NOT NULL,
	[TenHoiNghi] [nvarchar](150) NULL,
	[ThanhPho] [nvarchar](50) NULL,
 CONSTRAINT [PK_Proceeding] PRIMARY KEY CLUSTERED 
(
	[MaTL] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DMTL]    Script Date: 05/10/2015 10:48:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DMTL](
	[MaDM] [int] NOT NULL,
	[MaTL] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanhMuc]    Script Date: 05/10/2015 10:48:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhMuc](
	[MaDM] [int] NOT NULL IDENTITY(1,1),
	[TenDanhMuc] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_DanhMuc] PRIMARY KEY CLUSTERED 
(
	[MaDM] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CayDanhMuc]    Script Date: 05/10/2015 10:48:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CayDanhMuc](
	[MaDMCha] [int] NOT NULL,
	[MaDMCon] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BaiBao]    Script Date: 05/10/2015 10:48:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BaiBao](
	[MaTL] [int] NOT NULL,
	[TapChi] [nvarchar](150) NULL,
	[Trang] [nvarchar](20) NULL,
	[Volume] [nchar](10) NULL,
	[Issue] [nchar](10) NULL,
 CONSTRAINT [PK_BaiBao] PRIMARY KEY CLUSTERED 
(
	[MaTL] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
