USE [master]
USE NW
CREATE TABLE [dbo].[Test](
	[ID] [numeric](18, 0) NULL,
	[Name] [varchar](50) NULL,
	[Age] [int] NULL
) ON [PRIMARY]
INSERT [dbo].[Test] ([ID], [Name], [Age]) VALUES (1, N'Ivo', 16)
INSERT [dbo].[Test] ([ID], [Name], [Age]) VALUES (2, N'Samuil', 25)
INSERT [dbo].[Test] ([ID], [Name], [Age]) VALUES (3, N'Pesho', 56)
INSERT [dbo].[Test] ([ID], [Name], [Age]) VALUES (4, N'Ignat', 25)
INSERT [dbo].[Test] ([ID], [Name], [Age]) VALUES (5, N'Marina', 25)

