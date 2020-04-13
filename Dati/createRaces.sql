CREATE TABLE [dbo].[Races] (
    [id]            INT           IDENTITY (1, 1) NOT NULL,
    [grandPrixName] VARCHAR (128) NOT NULL,
    [circuitName]   INT			  NOT NULL,
    [nLaps]         INT           NOT NULL,
    [grandPrixDate] DATE          NOT NULL,
    [extCountry]    CHAR (2)      NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

