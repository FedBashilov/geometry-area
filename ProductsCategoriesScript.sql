select [Products].[Name], [Categories].[Name]
from [Products] 
left JOIN [ProductsCategories] ON [Products].[Id]=[ProductsCategories].[ProductID]
left JOIN [Categories] ON [Categories].[Id]=[ProductsCategories].[CategoryID]