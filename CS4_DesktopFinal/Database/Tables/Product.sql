CREATE TABLE [dbo].[Product]
(
	[D_product_id] INT NOT NULL PRIMARY KEY, 
    [F_product_id] INT NULL, 
    [B_product_id] INT NULL, 
    [sku] VARCHAR(255) NULL, 
    [title] VARCHAR(255) NULL, 
    [type] VARCHAR(255) NULL, 
    [price] INT NULL, 
    [stock] INT NULL
)
