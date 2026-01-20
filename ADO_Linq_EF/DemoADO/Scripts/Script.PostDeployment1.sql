/*
Modèle de script de post-déploiement							
--------------------------------------------------------------------------------------
 Ce fichier contient des instructions SQL qui seront ajoutées au script de compilation.		
 Utilisez la syntaxe SQLCMD pour inclure un fichier dans le script de post-déploiement.			
 Exemple :      :r .\monfichier.sql								
 Utilisez la syntaxe SQLCMD pour référencer une variable dans le script de post-déploiement.		
 Exemple :      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
use ADO

INSERT INTO section VALUES (1010, 'Informatique de Gestion');
INSERT INTO section VALUES (1020, 'Comptabilité');
INSERT INTO section VALUES (1110, 'Tourisme');
INSERT INTO section VALUES (1120, 'Dessin 3D');
INSERT INTO section VALUES (1310, 'Administrateurs Systéme');
INSERT INTO section VALUES (1320, 'Secrétariat');

INSERT INTO student (ID, FirstName, LastName, BirthDate, SectionID, YearResult) VALUES
('Georges', 'Lucas', '1944-05-17 00:00:00', 1320, 10),
('Clint', 'Eastwood', '1930-05-31 00:00:00', 1010, 4),
('Sean', 'Connery', '1930-08-25 00:00:00', 1020, 12),
('Robert', 'De Niro', '1943-08-17 00:00:00', 1110, 3),
('Kevin', 'Bacon', '1958-07-08 00:00:00', 1120, 16),
('Kim', 'Basinger', '1953-12-08 00:00:00', 1310, 19),
('Johnny', 'Depp', '1963-06-09 00:00:00', 1110, 11),
('Julia', 'Roberts', '1967-10-28 00:00:00', 1120, 17),
('Natalie', 'Portman', '1981-06-09 00:00:00', 1010, 4),
('Georges', 'Clooney', '1961-05-06 00:00:00', 1020, 4),
('Andy', 'Garcia', '1956-04-12 00:00:00', 1110, 19),
('Bruce', 'Willis', '1955-03-19 00:00:00', 1010, 6),
('Tom', 'Cruise', '1962-07-03 00:00:00', 1020, 4),
('Reese', 'Witherspoon', '1976-03-22 00:00:00', 1020, 7),
('Sophie', 'Marceau', '1966-11-17 00:00:00', 1110, 6),
('Sarah', 'Michelle Gellar', '1977-04-14 00:00:00', 1020, 7),
('Alyssa', 'Milano', '1972-12-19 00:00:00', 1110, 7),
('Jennifer', 'Garner', '1972-04-17 00:00:00', 1120, 18),
('Michael J.', 'Fox', '1969-06-20 00:00:00', 1310, 3),
('Tom', 'Hanks', '1956-07-09 00:00:00', 1020, 8),
('David', 'Morse', '1953-10-11 00:00:00', 1110, 2),
('Sandra', 'Bullock', '1964-07-26 00:00:00', 1010, 2),
('Keanu', 'Reeves', '1964-09-02 00:00:00', 1020, 10),
('Shannen', 'Doherty', '1971-04-12 00:00:00', 1320, 2),
('Halle', 'Berry', '1966-08-14 00:00:00', 1320, 18)
