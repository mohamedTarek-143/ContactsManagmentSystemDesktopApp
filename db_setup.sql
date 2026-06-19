USE [master]
GO

-- 1. Create Database Shell Universally
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = N'ContactsDB')
BEGIN
    CREATE DATABASE [ContactsDB]
END
GO

USE [ContactsDB]
GO

-- 2. Create Countries Table
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Countries](
	[CountryID] [int] IDENTITY(1,1) NOT NULL,
	[CountryName] [nvarchar](50) NULL,
	[Code] [nvarchar](3) NULL,
	[PhoneCode] [nvarchar](3) NULL,
PRIMARY KEY CLUSTERED 
(
	[CountryID] ASC
)
) ON [PRIMARY]
GO

-- 3. Create Contacts Table
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contacts](
	[ContactID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Phone] [nvarchar](20) NOT NULL,
	[Address] [nvarchar](200) NOT NULL,
	[DateOfBirth] [datetime] NOT NULL,
	[CountryID] [int] NOT NULL,
	[ImagePath] [nvarchar](500) NULL,
 CONSTRAINT [PK_Contacts] PRIMARY KEY CLUSTERED 
(
	[ContactID] ASC
)
) ON [PRIMARY]
GO

-- 4. Create Details View
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[AllDetailsView] AS 
Select ContactID, FirstName, LastName, Email, Phone, Address, DateOfBirth, Contacts.CountryID, ImagePath, Countries.CountryName, Countries.Code
from Contacts
Inner join Countries on Contacts.CountryID = Countries.CountryID;
GO

-- 5. Add Constraints
ALTER TABLE [dbo].[Contacts] WITH CHECK ADD CONSTRAINT [FK_Contacts_Countries] FOREIGN KEY([CountryID])
REFERENCES [dbo].[Countries] ([CountryID])
GO
ALTER TABLE [dbo].[Contacts] CHECK CONSTRAINT [FK_Contacts_Countries]
GO
