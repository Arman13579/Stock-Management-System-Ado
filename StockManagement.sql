USE master
GO

DROP DATABASE IF EXISTS DBStockManagement
GO
CREATE DATABASE DBStockManagement
GO

USE DBStockManagement
GO

CREATE TABLE tblCategory
(
	CategoryId INT IDENTITY PRIMARY KEY,
	CategoryName NVARCHAR(100) NOT NULL
)
GO
--test
INSERT INTO tblCategory VALUES('Mobile Phone')
GO

CREATE TABLE tblSuppliers
(
	SupplierId INT IDENTITY PRIMARY KEY,
	SupplierName NVARCHAR(100) NOT NULL,
	SupplierAddress NVARCHAR(200) NOT NULL
)
GO
--test
INSERT INTO tblSuppliers VALUES('APPLE','America')
GO


CREATE TABLE tblEmployee
(
	EmployeeId INT IDENTITY PRIMARY KEY,
	EmployeeName NVARCHAR(100) NOT NULL,
	EmployeeAddress NVARCHAR(200) NOT NULL,
	EmployeePhone NVARCHAR(20) NOT NULL
)
GO
--test
INSERT INTO tblEmployee VALUES('Md. Arman','Dhaka','0175581974')
GO

CREATE TABLE tblInventory
(
	ProductId INT IDENTITY PRIMARY KEY,
	ProductName NVARCHAR(100) NOT NULL,
	pUnitPrice MONEY NOT NULL,
	pQuantity INT NOT NULL,
	PurchaseDate DATETIME DEFAULT CURRENT_TIMESTAMP,
	Category INT REFERENCES tblCategory(CategoryId) ON DELETE CASCADE ON UPDATE CASCADE,
	Supplier INT REFERENCES tblSuppliers(SupplierId) ON DELETE CASCADE ON UPDATE CASCADE,
	
)
GO

INSERT INTO tblInventory(ProductName,pUnitPrice,pQuantity,PurchaseDate,Category,Supplier)
VALUES('APPLE 6',50000,20,DEFAULT,1,1)
go

CREATE TABLE tblSales
(
	SalesId INT IDENTITY PRIMARY KEY,
	ProductName NVARCHAR(100) NOT NULL,
	sUnitPrice MONEY NOT NULL,
	sQuantity INT NOT NULL,
	Discount FLOAT NULL,
	TotalAmount AS(sUnitPrice*sQuantity*(1-Discount)),
	CustomerName NVARCHAR(100) NOT NULL,
	CusAddress NVARCHAR(200) NULL,
	CusPhone NVARCHAR(20) NULL,
	ProductPicture VARBINARY(MAX) NULL,
	ProductId INT REFERENCES tblInventory(ProductId) ON DELETE CASCADE ON UPDATE CASCADE,  
)
GO
--test
INSERT INTO tblSales(ProductName,sUnitPrice,sQuantity,Discount,CustomerName,CusAddress,CusPhone,ProductPicture,ProductId) Values
('APPLE 6','50000',1,.10,'Razu','Dhaka','017xxxxxxxxxxx',null,1)
go

INSERT INTO tblSales(ProductName,sUnitPrice,sQuantity,Discount,)


CREATE TABLE tblCustomers
(
	CustomerId INT IDENTITY PRIMARY KEY,
	CustomerName NVARCHAR(100) NOT NULL,
	CustomerAddress NVARCHAR(200) NOT NULL,
	Phone NVARCHAR(20) NOT NULL,
	SalesId INT REFERENCES tblSales(SalesId) ON DELETE CASCADE ON UPDATE CASCADE
)
GO




CREATE TRIGGER tr_AdjustInventory
ON tblSales
FOR INSERT
AS
	BEGIN
			DECLARE @pid INT,
					@quantity INT								
			SELECT @pid = inserted.ProductId, @quantity = inserted.sQuantity FROM inserted

			update tblInventory set pQuantity = pQuantity-@quantity WHERE ProductId = @pid		
	END
GO

CREATE TRIGGER tr_CustomerInsert
ON tblSales
FOR INSERT
AS 
	BEGIN
			INSERT INTO tblCustomers(CustomerName,CustomerAddress,Phone,SalesId)
			SELECT CustomerName,CusAddress,CusPhone,SalesId FROM inserted
	END
GO



select * from tblCategory
select * from tblCustomers
select * from tblEmployee
select * from tblSuppliers
select * from tblInventory
select * from tblSales



