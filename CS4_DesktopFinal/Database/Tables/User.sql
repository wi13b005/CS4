CREATE TABLE [dbo].[User]
(
	[user_id] INT NOT NULL PRIMARY KEY, 
    [username] NCHAR(10) NULL, 
    [password] NCHAR(10) NULL, 
    [first_name] NCHAR(255) NULL, 
    [last_name] NCHAR(255) NULL
)
