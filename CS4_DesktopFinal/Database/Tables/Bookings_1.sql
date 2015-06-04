CREATE TABLE [dbo].[Bookings]
(
	[booking_id] INT NOT NULL PRIMARY KEY, 
    [date] DATE NULL, 
    [time] TIME NULL, 
    [description] TEXT NULL, 
    [expert_id] INT NULL, 
    [D_customer_id] INT NULL
)
