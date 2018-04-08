CREATE TABLE [dbo].[Meal]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NCHAR(50) NOT NULL, 
    [IngredientId] INT NOT NULL, 
    CONSTRAINT [FK_Meal_ToIngredient] FOREIGN KEY ([IngredientId]) REFERENCES [Ingredient]([Id])
)
