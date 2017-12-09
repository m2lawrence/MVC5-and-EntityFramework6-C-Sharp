USE [mike]
GO

/****** Object:  Table [dbo].[EmployeeViewModel]    Script Date: 09/12/2017 18:39:30 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[EmployeeViewModel](
	[EmployeeID] [int] NOT NULL,
	[Name] [nchar](10) NULL,
	[DepartmentID] [int] NULL,
	[Address] [nchar](10) NULL,
	[DepartmentName] [nchar](10) NULL,
	[Remember] [nchar](10) NULL,
 CONSTRAINT [PK_EmployeeViewModel] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

Insert into dbo.EmployeeViewModel values (1,'Mike', 1, 'Gloucester', 'Developers', 0)
Insert into dbo.EmployeeViewModel values (2,'Mike', 1, 'Gloucester', 'Developers', 0)
Insert into dbo.EmployeeViewModel values (3,'Mike', 1, 'Gloucester', 'Developers', 0)
Insert into dbo.EmployeeViewModel values (4,'Mike', 1, 'Gloucester', 'Developers', 0)
Insert into dbo.EmployeeViewModel values (5,'Mike', 1, 'Gloucester', 'Developers', 0)
Go
