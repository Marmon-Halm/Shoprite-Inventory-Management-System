CREATE TABLE [dbo].[tbReports_Table]
(
	[Product_Number] INT NOT NULL PRIMARY KEY, 
    [Product_Name] VARCHAR(50) NOT NULL, 
    [Product_Description] VARCHAR(50) NOT NULL, 
    [Price] INT NOT NULL, 
    [Quantity_Sold] INT NOT NULL, 
    [Quantity_Remaining] INT NOT NULL, 
    [Amount] INT NOT NULL
)
