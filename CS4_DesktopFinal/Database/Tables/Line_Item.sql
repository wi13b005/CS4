CREATE TABLE [dbo].[Line_Item]
(
	[D_line_item] INT NOT NULL PRIMARY KEY, 
    [F_line_item] INT NULL, 
    [B_line_item] INT NULL, 
    [D_product_id] INT NULL, 
    [D_order_id] INT NULL, 
    [quantity] INT NULL
)
