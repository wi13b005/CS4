CREATE TABLE [dbo].[Record]
(
	[record_id] INT NOT NULL PRIMARY KEY, 
    [D_customer_id] NCHAR(10) NULL, 
    [patient_history] NCHAR(10) NULL, 
    [Allergies] NCHAR(10) NULL, 
    [Medications] NCHAR(10) NULL
)
