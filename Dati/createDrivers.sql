CREATE TABLE [dbo].[Drivers]
(
	[id] [int] IDENTITY(1,1) NOT NULL,
	[number] [int] NOT NULL,
	[firstname] [varchar](128) NOT NULL,
	[lastname] [varchar](128) NOT NULL,
	[dob] [date] NOT NULL,
	[placeOfBirth] [varchar](64) NOT NULL,
	[image] [varchar](200) NOT NULL,
	[extCountry] [char](2) NOT NULL,
	PRIMARY KEY CLUSTERED ([id] ASC)
);
SET IDENTITY_INSERT [dbo].[Drivers] ON;