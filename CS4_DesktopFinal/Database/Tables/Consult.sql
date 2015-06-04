CREATE TABLE [dbo].[Consult]
(
	[consult_id] INT NOT NULL PRIMARY KEY, 
    [record_id] NCHAR(10) NULL, 
    [physical_examination] TEXT NULL, 
    [care_plan] TEXT NULL
)
