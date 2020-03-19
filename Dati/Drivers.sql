CREATE TABLE [dbo].[Drivers]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [firstname] VARCHAR(128) NOT NULL, 
    [lastname] VARCHAR(128) NOT NULL, 
    [dob] DATE NOT NULL, 
    [placeOfBirth] VARCHAR(64) NOT NULL, 
    [extCountry] CHAR(2) NOT NULL
);

SET IDENTITY_INSERT [dbo].[Drivers] ON;

INSERT INTO [dbo].[Drivers]
(
    id,
	firstName,
	lastName,
	dob,
	placeOfBirth,
	extCountry
)
VALUES
(1, 'Lewis', 'Hamilton',convert(date, '07-01-1985',105), 'Stevenage', 'GB'),
(2, 'Valtteri', 'Bottas',convert(date, '28-08-1989',105), 'Nastola', 'FI'),
(3, 'Sebastian', 'Vettel',convert(date, '03-07-1987',105), 'Heppenheim', 'DE'),
(4, 'Pierre', 'Gasly',convert(date, '07-02-1996',105), 'Rouen', 'FR'),
(5, 'Charles', 'Leclerc',convert(date, '16-10-1997',105), 'Monte Carlo', 'MC'),
(6, 'Daniel', 'Ricciardo',convert(date, '01-07-1989',105), 'Perth', 'AU'),
(7, 'Max', 'Verstappen',convert(date, '30-09-1997',105), 'Hasselt', 'NL'),
(8, 'Alexander', 'Albon',convert(date, '23-03-1996',105), 'London', 'TH'),
(9, 'Carlos', 'Sainz',convert(date, '01-09-1994',105), 'Madrid', 'ES'),
(10, 'Lando', 'Norris',convert(date, '13-11-1999',105), 'Bristol', 'GB'),
(11, 'Nico', 'Hulkenberg',convert(date, '19-08-1987',105), 'Emmerich am Rhein', 'DE'),
(12, 'Sergio', 'Perez',convert(date, '26-01-1990',105), 'Guadalajara', 'MX'),
(13, 'Robert', 'Kubica',convert(date, '07-12-1984',105), 'Krakow', 'PL'),
(14, 'Kimi', 'Räikkönen',convert(date, '17-10-1979',105), 'Espoo', 'FI'),
(15, 'Lance', 'Stroll',convert(date, '29-10-1998',105), 'Montreal', 'CA'),
(16, 'Antonio', 'Giovinazzi',convert(date, '14-12-1993',105), 'Martina Franca', 'IT'),
(17, 'Kevin', 'Magnussen',convert(date, '05-10-1992',105), 'Roskilde', 'DK'),
(18, 'Romain', 'Grosjean',convert(date, '17-04-1986',105), 'Geneva', 'CH'),
(19, 'George', 'Russell',convert(date, '15-02-1998',105), 'Kings Lynn', 'GB'),
(20, 'Daniil', 'Kvyat',convert(date, '26-04-1994',105), 'Ufa', 'RU');