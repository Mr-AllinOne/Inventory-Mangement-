CREATE TABLE [dbo].[AllSalesTable]
(
	[SaleID] INT IDENTITY	(1,1) NOT NULL , 
    [Name] VARCHAR(50) NOT NULL, 
    [Price] INT NOT NULL, 
    [Qty] INT NOT NULL, 
    [Total] VARCHAR(50) NOT NULL, 
    [Data] VARCHAR(100) NOT NULL,
	PRIMARY KEY CLUSTERED ([SaleID] ASC)
)
