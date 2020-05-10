CREATE TABLE [dbo].[Races]
(
	[id] [int] IDENTITY(1,1) NOT NULL,
	[grandPrixName] [varchar](128) NOT NULL,
	[extCircuit] [int] NOT NULL,
	[nLaps] [int] NOT NULL,
	[grandPrixDate] [date] NOT NULL,
	[extCountry] [char](2) NOT NULL,
	PRIMARY KEY CLUSTERED ([id] ASC)
);
SET IDENTITY_INSERT [dbo].[Races] ON;