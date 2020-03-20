CREATE TABLE [dbo].[Drivers] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [firstname]    VARCHAR (128) NOT NULL,
    [lastname]     VARCHAR (128) NOT NULL,
    [dob]          DATE          NOT NULL,
    [placeOfBirth] VARCHAR (64)  NOT NULL,
    [extCountry]   CHAR (3)      NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

