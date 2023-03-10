USE [EANDERBENEV]
GO
/****** Object:  Table [dbo].[Barcode]    Script Date: 09.02.2023 8:55:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Barcode](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Number] [nvarchar](50) NULL,
 CONSTRAINT [PK_Barcode] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Barcode] ON 

INSERT [dbo].[Barcode] ([Id], [Number]) VALUES (1, N'1231314565311')
INSERT [dbo].[Barcode] ([Id], [Number]) VALUES (2, N'4890238742878')
INSERT [dbo].[Barcode] ([Id], [Number]) VALUES (3, N'8723857298573')
INSERT [dbo].[Barcode] ([Id], [Number]) VALUES (4, N'8000000002222')
INSERT [dbo].[Barcode] ([Id], [Number]) VALUES (5, N'2362356555555')
INSERT [dbo].[Barcode] ([Id], [Number]) VALUES (6, N'4640017590383')
SET IDENTITY_INSERT [dbo].[Barcode] OFF
