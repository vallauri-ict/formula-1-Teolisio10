CREATE TABLE [dbo].[Races]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [grandPrixName] VARCHAR(128) NOT NULL, 
    [circuitName] VARCHAR(128) NOT NULL, 
	[nLaps] INT NOT NULL,
    [grandPrixDate] DATE NOT NULL,
    [extCountry] CHAR(2) NOT NULL
);

SET IDENTITY_INSERT [dbo].[Races] ON;

INSERT INTO [dbo].[Races]
(
	id,
	grandPrixName,
	circuitName,
	nLaps,
	grandPrixDate,
	extCountry
)
VALUES
(1, 'FORMULA 1 ROLEX AUSTRALIAN GRAND PRIX 2019', 'Melbourne Grand Prix Circuit', 58, convert(date, '17-03-2019',105), 'AU'),
(2, 'FORMULA 1 GULF AIR BAHRAIN GRAND PRIX 2019', 'Bahrain International Circuit', 57, convert(date, '31-03-2019',105), 'BH'),
(3, 'FORMULA 1 HEINEKEN CHINESE GRAND PRIX 2019', 'Shanghai International Circuit', 56, convert(date, '31-03-2019',105), 'CH'),
(4, 'FORMULA 1 SOCAR AZERBAIJAN GRAND PRIX 2019', 'Baku City Circuit', 51, convert(date, '28-04-2019',105), 'AZ'),
(5, 'FORMULA 1 EMIRATES GRAN PREMIO DE ESPAÑA 2019', 'CIRCUIT DE BARCELONA-CATALUNYA', 66, convert(date, '12-05-2019',105), 'SP'),
(6, 'FORMULA 1 GRAND PRIX DE MONACO 2019', 'Circuit de Monaco', 78, convert(date, '12-05-2019',105), 'MC'),
(7, 'FORMULA 1 PIRELLI GRAND PRIX DU CANADA 2019', 'Circuit Gilles-Villeneuve', 70, convert(date, '09-06-2019', 105), 'CA'),
(8, 'FORMULA 1 PIRELLI GRAND PRIX DE FRANCE 2019', 'Circuit Paul Ricard', 53, convert(date, '23-06-2019', 105), 'FR'),
(9, 'FORMULA 1 MYWORLD GROSSER PREIS VON ÖSTERREICH 2019', 'Red Bull Ring', 71, convert(date, '30-06-2019', 105), 'AT'),
(10, 'FORMULA 1 ROLEX BRITISH GRAND PRIX 2019', 'Silverstone Circuit', 52, convert(date, '12-07-2019', 105), 'GB'),
(11, 'FORMULA 1 MERCEDES-BENZ GROSSER PREIS VON DEUTSCHLAND 2019', 'Hockenheimring', 67, convert(date, '28-07-2019',105), 'DE'),
(12, 'FORMULA 1 ROLEX MAGYAR NAGYDÍJ 2019', 'Hungaroring', 70, convert(date, '04-08-2019', 105), 'HU'),
(13, 'FORMULA 1 JOHNNIE WALKER BELGIAN GRAND PRIX 2019', 'Spa-Francorchamps', 44, convert(date, '01-09-2019',105), 'BE'),
(14, 'FORMULA 1 GRAN PREMIO HEINEKEN DI ITALIA 2019', 'Autodromo Nazionale Monza', 53, convert(date, '08-11-2019',105), 'IT'),
(15, 'FORMULA 1 SINGAPORE AIRLINES SINGAPORE GRAND PRIX 2019', 'Marina Bay Street Circuit', 61, convert(date, '22-09-2019',105), 'SG'),
(16, 'FORMULA 1 VTB RUSSIAN GRAND PRIX 2019', 'Sochi Autodrom', 53, convert(date, '29-09-2019', 105), 'GB'),
(17, 'FORMULA 1 VTB RUSSIAN GRAND PRIX 2019', 'Sochi Autodrom', 53, convert(date, '29-09-2019', 105), 'GB'),
(18, 'FORMULA 1 GRAN PREMIO DE MÉXICO 2019', 'Autódromo Hermanos Rodríguez', 71, convert(date, '25-10-2019', 105), 'MX'),
(19, 'FORMULA 1 HEINEKEN GRANDE PRÊMIO DO BRASIL 2019', 'Autódromo José Carlos Pace', 71, convert(date, '17-11-2019', 105), 'BR'),
(20, 'FORMULA 1 ETIHAD AIRWAYS ABU DHABI GRAND PRIX 2019', 'Yas Marina Circuit', 55, convert(date, '01-12-2019', 105), 'AE');
