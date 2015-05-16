CREATE TABLE [dbo].[Booking]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Lastname] NCHAR(20) NULL, 
    [From] INT NULL, 
    [Till] INT NULL, 
    [Treatment] NCHAR(30) NULL, 
    [Date] DATETIME NULL
)
