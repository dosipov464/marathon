USE [g284_l009_Khvashchevskii_Pushkarev]
GO
CREATE TABLE Planet (PlanetName nvarchar(50), DistanceFromSun float, Inhabitants nvarchar(50))
INSERT INTO Planet (PlanetName, DistanceFromSun, Inhabitants)VALUES ('Меркурий', 57909, 'Меркуриане')
INSERT INTO Planet (PlanetName, DistanceFromSun, Inhabitants)VALUES ('Венера', 108200, 'Венериане')
INSERT INTO Planet (PlanetName, DistanceFromSun, Inhabitants)VALUES ('Земля', 149600, 'Земляне')