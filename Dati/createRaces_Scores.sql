CREATE TABLE [dbo].[Races_Scores](
	[id] INT NOT NULL,
	[extDriver] INT NOT NULL,
	[extPos] INT NOT NULL,
	[extScore] INT NOT NULL,
	[extRace] INT NOT NULL,
	[fastestLap] VARCHAR(16) NOT NULL,
	CONSTRAINT [PK_Races_Scores] PRIMARY KEY CLUSTERED ([id] ASC)
 );