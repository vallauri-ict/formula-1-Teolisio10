CREATE TABLE [dbo].[Teams]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY,
    [nome] VARCHAR(128) NOT NULL,
    [fullTeamName] VARCHAR(128) NOT NULL, 
    [extCountry] CHAR(2) NOT NULL, 
    [powerUnit] VARCHAR(128) NOT NULL, 
    [technicalChief] VARCHAR(128) NOT NULL,
	[chassis] VARCHAR(128) NOT NULL,
	[extFirstDriver] INT NOT NULL,
	[extSecondDriver] INT NOT NULL
);

SET IDENTITY_INSERT [dbo].[Teams] ON;

INSERT INTO [dbo].[Teams]
(
	id,
	nome,
	fullTeamName,
	extCountry,
	powerUnit,
	technicalChief,
	chassis,
	extFirstDriver,
	extSecondDriver
)
VALUES
(1,'Alfa Romeo', 'Alfa Romeo Racing', 'CH', 'Ferrari', 'Jan Monchaux', 'C38', 20, 10),
(2,'Ferrari', 'Scuderia Ferrari Mission Winnow', 'IT', 'Ferrari', 'Mattia Binotto', 'SF90',20,10),
(3,'Red Bull', 'Aston Martin Red Bull Racing', 'GB', 'Honda', 'Pierre Waché', 'RB15',20,10),
(4,'Haas', 'Haas F1 Team', 'US', 'Ferrari', 'Rob Taylor', 'VF-19', 20, 10),
(5,'McLaren', 'McLaren F1 Team', 'GB', 'Renault', 'James Key', 'MCL34', 20, 10),
(6,'Mercedes', 'Mercedes AMG Petronas Motorsport', 'GB', 'Mercedes', 'James Allison', 'W10',20,10),
(7,'Toro Rosso', 'Red Bull Toro Rosso Honda', 'IT', 'Honda', 'Jody Eggington', 'STR14', 20, 10),
(8,'Racing Point', 'SportPesa Racing Point F1 Team', 'GB', 'BWT Mercedes', 'Andrew Green', 'RP19', 20, 10),
(9,'Williams', 'ROKiT Williams Racing', 'GB', 'Mercedes', 'TBC', 'FW42', 20, 10),
(10,'Renault', 'Renault F1 Team', 'GB', 'Renault', 'Nick Chester', 'R.S.19',20,10);
