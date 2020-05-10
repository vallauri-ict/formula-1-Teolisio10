CREATE TABLE [dbo].[Scores]
(
	[id] [int] NOT NULL,
	[score] [int] NOT NULL,
	[details] [varchar](254) NOT NULL,
	CONSTRAINT [PK_Scores] PRIMARY KEY CLUSTERED ([id] ASC)
);
