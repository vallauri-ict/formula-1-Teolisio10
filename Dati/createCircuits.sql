CREATE TABLE [dbo].[Circuits]
(
	[id] [int] NOT NULL,
	[name] [varchar](128) NOT NULL,
	[city] [varchar](128) NOT NULL,
	[length] [int] NOT NULL,
	[recordLap] [varchar](16) NOT NULL,
	[img] [varchar] (255) NOT NULL,
	[firstGrandPrix] [int] NOT NULL,
	CONSTRAINT [PK_Circuits] PRIMARY KEY CLUSTERED ([id] ASC)
 );