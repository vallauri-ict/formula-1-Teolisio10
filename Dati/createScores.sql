CREATE TABLE [dbo].[Scores]
(
	[id] [int] NOT NULL,
	[points] [int] NOT NULL,
	[details] [varchar](254) NOT NULL,
	CONSTRAINT [PK_Scores] PRIMARY KEY CLUSTERED ([id] ASC)
);
