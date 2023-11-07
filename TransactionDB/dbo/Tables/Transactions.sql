CREATE TABLE [dbo].[Transactions]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Amount] DECIMAL NOT NULL, 
    [Currency] NVARCHAR(3) NOT NULL, 
    [CardholderNumber] NVARCHAR(16) NOT NULL, 
    [HolderName] NVARCHAR(50) NOT NULL, 
    [ExpMonth] INT NOT NULL, 
    [ExpYear] INT NOT NULL, 
    [CVV] INT NOT NULL, 
    [OrderRef] NVARCHAR(50) NOT NULL, 
    [Status] INT NOT NULL
)
