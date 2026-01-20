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

INSERT INTO Patients VALUES
('98052698723', 'Doe', 'John', '0486325698', '1998-05-26'),
('97032245321', 'Doe', 'Tata', '0487592635', '1997-03-22'),
('99041823614', 'Doe', 'Titi', '0422415369', '1999-04-18'),
('98062278965', 'Doe', 'Tutu', '0455236841', '1998-06-22'),
('99082645163', 'Doe', 'Toto', '0498652147', '1999-08-26');
