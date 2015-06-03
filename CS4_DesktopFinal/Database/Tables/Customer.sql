CREATE TABLE [dbo].[Customer]
(
	[D_customer_id] INT NOT NULL PRIMARY KEY, 
    [F_user_id] INT NULL, 
    [B_user_id] INT NULL, 
    [expert_id] INT NULL, 
    [salutory_address] VARCHAR(255) NULL, 
    [first_name] VARCHAR(255) NULL, 
    [last_name] VARCHAR(255) NULL, 
    [mail] VARCHAR(255) NULL, 
    [street] VARCHAR(255) NULL, 
    [number] VARCHAR(255) NULL, 
    [city] VARCHAR(255) NULL, 
    [post_code] VARCHAR(255) NULL, 
    [country] VARCHAR(255) NULL
)
