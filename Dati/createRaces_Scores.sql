CREATE TABLE [dbo].[Races_Scores]
(
	[id] [int] NOT NULL,
	[extDriver] [int] NOT NULL,
	[extScore] [int] NOT NULL,
	[extRace] [int] NOT NULL,
	[fastestLap] [varchar](16) NOT NULL,
	CONSTRAINT [PK_Races_Scores] PRIMARY KEY CLUSTERED ([id] ASC)
);