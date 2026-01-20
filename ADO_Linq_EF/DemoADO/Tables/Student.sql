CREATE TABLE [dbo].[Student]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[FirstName] VARCHAR(50) NOT NULL,
	[LastName] VARCHAR(50) NOT NULL,
	[BirthDate] DATETIME2(7) NOT NULL,
	[YearResult] INT NOT NULL,
	[SectionID] INT NOT NULL,
	[Active] BIT NOT NULL DEFAULT 1,

    CONSTRAINT [FK_Student_Section] FOREIGN KEY ([SectionID]) REFERENCES [Section]([Id])
)
