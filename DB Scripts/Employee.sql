USE [EmployeeDB]
GO

/****** Object:  Table [dbo].[Employees]    Script Date: 16/10/2019 10:26:33 PM ******/
DROP TABLE [dbo].[Employees]
GO

/****** Object:  Table [dbo].[Employees]    Script Date: 16/10/2019 10:26:33 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Employees](
	[EmployeeID] [int] NOT NULL PRIMARY KEY IDENTITY(100,1),
	[FirstName] [nvarchar](30) NOT NULL,
	[LastName] [nvarchar](30) NOT NULL,
	[Age] [int] NULL,
	[JobTitle] [nvarchar](50) NULL,
	[EmploymentStartDate] [datetime] NOT NULL,
	[EmploymentEndDate] [datetime] NULL
) ON [PRIMARY]

GO


INSERT INTO dbo.Employees
    (
        FirstName,
        LastName,
        Age,
        JobTitle,
        EmploymentStartDate,
        EmploymentEndDate
    )
VALUES
    (
        N'Shivendra',       -- FirstName - nvarchar(30)
        N'Pratik',       -- LastName - nvarchar(30)
        30,         -- Age - int
        N'Software Developer',       -- JobTitle - nvarchar(50)
        GETDATE(), -- EmploymentStartDate - datetime
        NULL  -- EmploymentEndDate - datetime
    )