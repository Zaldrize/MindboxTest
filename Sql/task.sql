-- в задаче нет схемы БД, будем считать, что она в нормальной форме, тогда связь многое-ко-многим делается через третью таблицу

CREATE TABLE tblProduct(
 [Id] INT PRIMARY KEY IDENTITY(1,1),
 [Name] NVARCHAR(255) NOT NULL
)

INSERT INTO tblProduct(Name) VALUES (N'Сырники'), (N'Борщ'), (N'Колбаса')

CREATE TABLE tblCategory(
 [Id] INT PRIMARY KEY IDENTITY(1,1),
 [Name] NVARCHAR(255) NOT NULL
)

INSERT INTO tblCategory(Name) VALUES(N'Горячее'), (N'Завтрак')

CREATE TABLE tblProductCategories(
 [ProductId] INT,
 [CategoryId] INT,
 CONSTRAINT [ProductId_tblProduct] FOREIGN KEY([ProductId]) REFERENCES [tblProduct] ([Id]),
 CONSTRAINT [CategoryId_tblCategory] FOREIGN KEY([CategoryId]) REFERENCES [tblCategory] ([Id])
)

INSERT INTO tblProductCategories(ProductId, CategoryId) VALUES (1,2), (1,1), (2,1)

-- сам запрос
SELECT p.Name, c.Name FROM tblProduct p
LEFT JOIN tblProductCategories pc on pc.ProductId = p.Id
LEFT JOIN tblCategory c on pc.CategoryId = c.Id