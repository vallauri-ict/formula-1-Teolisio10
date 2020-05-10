CREATE TABLE [dbo].[Countries]
(
	[countryCode] [char](2) NOT NULL,
	[countryName] [varchar](100) NOT NULL,
	[flag] [varchar](200) NOT NULL,
	PRIMARY KEY CLUSTERED ([countryCode] ASC)
);
