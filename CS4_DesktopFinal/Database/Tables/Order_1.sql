CREATE TABLE [dbo].[Order]
(
	[D_order_id] INT NOT NULL PRIMARY KEY, 
    [F_order_id] INT NULL, 
    [B_order_id] INT NULL, 
    [D_customer_id] INT NULL, 
    [status] VARCHAR(255) NULL, 
    [total] INT NULL, 
    [created] INT NULL, 
    [changed] INT NULL
)
