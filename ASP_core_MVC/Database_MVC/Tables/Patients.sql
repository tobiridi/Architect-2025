CREATE TABLE [dbo].[Patients]
(
	[Reg_nat] CHAR(11) NOT NULL PRIMARY KEY,
	[Lastname] VARCHAR(100) NOT NULL,
	[Firstname] VARCHAR(100) NOT NULL,
	[Phone] VARCHAR(20) NOT NULL,
	[BirthDate] DATE NOT NULL,
)
