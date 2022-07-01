INSERT INTO dbo.Categories (Id, Name) VALUES
	(1, 'продукты'),
	(2, 'хоз. товары'),
	(3, 'товары для дома');

INSERT INTO BookDB.DBO.Products (Id, Name, Category_id) VALUES
	(1, 'Хлеб', 1),
	(2,'Шампунь', 2),
	(3,'Печенье',1),
	(4,'Газировка',2),
	(5,'Хлеб', 0),
	(6,'Печенье',3);

SELECT Products.Name as ProductName, Categories.Name as CategoryName
FROM Products LEFT JOIN Categories ON Products.Category_id = Categories.Id
