CREATE TABLE [dbo].[Teams]
(
	[id] [int] IDENTITY(1,1) NOT NULL,
	[logo] [varchar](200) NOT NULL,
	[name] [varchar](128) NOT NULL,
	[fullTeamName] [varchar](128) NOT NULL,
	[extCountry] [char](2) NOT NULL,
	[powerUnit] [varchar](128) NOT NULL,
	[technicalChief] [varchar](128) NOT NULL,
	[chassis] [varchar](128) NOT NULL,
	[extFirstDriver] [int] NOT NULL,
	[extSecondDriver] [int] NOT NULL,
	PRIMARY KEY CLUSTERED ([id] ASC)
);
SET IDENTITY_INSERT [dbo].[Teams] ON;