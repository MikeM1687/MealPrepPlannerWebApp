CREATE TABLE [dbo].[Ingredient]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NCHAR(50) NOT NULL, 
    [Qty] DECIMAL NOT NULL, 
    [UnitId] INT NOT NULL, 
    CONSTRAINT [FK_Ingredient_ToUnit] FOREIGN KEY ([UnitId]) REFERENCES [Unit](Id)
)
