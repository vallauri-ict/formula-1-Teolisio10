INSERT INTO [dbo].[Drivers]
(
    id,
	number,
	firstName,
	lastName,
	dob,
	placeOfBirth,
	image,
	extCountry
)
VALUES
(1, 44, 'Lewis', 'Hamilton',convert(date, '07-01-1985',105), 'Stevenage', 'https://www.formula1.com/content/fom-website/en/drivers/lewis-hamilton/_jcr_content/image.img.640.medium.jpg/1584013371803.jpg', 'GB'),
(2, 77, 'Valtteri', 'Bottas',convert(date, '28-08-1989',105), 'Nastola', 'https://www.formula1.com/content/fom-website/en/drivers/valtteri-bottas/_jcr_content/image.img.640.medium.jpg/1584013243241.jpg', 'FI'),
(3, 5, 'Sebastian', 'Vettel',convert(date, '03-07-1987',105), 'Heppenheim', 'https://www.formula1.com/content/fom-website/en/drivers/sebastian-vettel/_jcr_content/image.img.640.medium.jpg/1584013014200.jpg', 'DE'),
(4, 10, 'Pierre', 'Gasly',convert(date, '07-02-1996',105), 'Rouen', 'https://www.formula1.com/content/fom-website/en/drivers/pierre-gasly/_jcr_content/image.img.640.medium.jpg/1584013791271.jpg', 'FR'),
(5, 16, 'Charles', 'Leclerc',convert(date, '16-10-1997',105), 'Monte Carlo', 'https://www.formula1.com/content/fom-website/en/drivers/charles-leclerc/_jcr_content/image.img.640.medium.jpg/1584013824254.jpg', 'MC'),
(6, 3, 'Daniel', 'Ricciardo',convert(date, '01-07-1989',105), 'Perth', 'https://www.formula1.com/content/fom-website/en/drivers/daniel-ricciardo/_jcr_content/image.img.640.medium.jpg/1584012376585.jpg', 'AU'),
(7, 33, 'Max', 'Verstappen',convert(date, '30-09-1997',105), 'Hasselt', 'https://www.formula1.com/content/fom-website/en/drivers/max-verstappen/_jcr_content/image.img.640.medium.jpg/1584012927837.jpg', 'NL'),
(8, 23, 'Alexander', 'Albon',convert(date, '23-03-1996',105), 'London', 'https://www.formula1.com/content/fom-website/en/drivers/alexander-albon/_jcr_content/image.img.640.medium.jpg/1584013953467.jpg', 'TH'),
(9, 55, 'Carlos', 'Sainz',convert(date, '01-09-1994',105), 'Madrid', 'https://www.formula1.com/content/fom-website/en/drivers/carlos-sainz/_jcr_content/image.img.1920.medium.jpg/1554819107766.jpg', 'ES'),
(10, 4, 'Lando', 'Norris',convert(date, '13-11-1999',105), 'Bristol', 'https://www.formula1.com/content/fom-website/en/drivers/lando-norris/_jcr_content/image.img.640.medium.jpg/1584013897913.jpg', 'GB'),
(11, 27, 'Nico', 'Hulkenberg',convert(date, '19-08-1987',105), 'Emmerich am Rhein', 'https://image-cdn.essentiallysports.com/wp-content/uploads/20200321105223/Nico-1.jpg', 'DE'),
(12, 11, 'Sergio', 'Perez',convert(date, '26-01-1990',105), 'Guadalajara', 'https://www.formula1.com/content/fom-website/en/drivers/sergio-perez/_jcr_content/image.img.640.medium.jpg/1584013058541.jpg', 'MX'),
(13, 40, 'Robert', 'Kubica',convert(date, '07-12-1984',105), 'Krakow', 'https://www.corriere.it/methode_image/2019/07/29/Sport/Foto%20Sport%20-%20Trattate/15MOT10G10_01_01-k6OH-U31301125627982tyD-656x492@Corriere-Web-Sezioni.jpg', 'PL'),
(14, 7, 'Kimi', 'Räikkönen',convert(date, '17-10-1979',105), 'Espoo', 'https://www.formula1.com/content/fom-website/en/drivers/kimi-raikkonen/_jcr_content/image.img.640.medium.jpg/1584012751723.jpg', 'FI'),
(15, 18, 'Lance', 'Stroll',convert(date, '29-10-1998',105), 'Montreal', 'https://www.formula1.com/content/fom-website/en/drivers/lance-stroll/_jcr_content/image.img.640.medium.jpg/1584013460046.jpg', 'CA'),
(16, 99, 'Antonio', 'Giovinazzi',convert(date, '14-12-1993',105), 'Martina Franca', 'https://www.formula1.com/content/fom-website/en/drivers/antonio-giovinazzi/_jcr_content/image.img.640.medium.jpg/1584013739535.jpg', 'IT'),
(17, 20, 'Kevin', 'Magnussen',convert(date, '05-10-1992',105), 'Roskilde', 'https://www.formula1.com/content/fom-website/en/drivers/kevin-magnussen/_jcr_content/image.img.640.medium.jpg/1584012829634.jpg', 'DK'),
(18, 8, 'Romain', 'Grosjean',convert(date, '17-04-1986',105), 'Geneva', 'https://www.formula1.com/content/fom-website/en/drivers/romain-grosjean/_jcr_content/image.img.640.medium.jpg/1584012955838.jpg', 'FR'),
(19, 63, 'George', 'Russell',convert(date, '15-02-1998',105), 'Kings Lynn', 'https://www.formula1.com/content/fom-website/en/drivers/george-russell/_jcr_content/image.img.640.medium.jpg/1584013858126.jpg', 'GB'),
(20, 26, 'Daniil', 'Kvyat',convert(date, '26-04-1994',105), 'Ufa', 'https://www.formula1.com/content/fom-website/en/drivers/daniil-kvyat/_jcr_content/image.img.640.medium.jpg/1584012653479.jpg', 'RU');