-- CREATE DATABASE CoffeeShop
-- GO

USE CoffeeShop
GO

DROP TABLE order_item
DROP TABLE [bill]
DROP TABLE [order]
DROP TABLE product
DROP TABLE [menu]
DROP TABLE [table]
DROP TABLE [user]
GO


CREATE TABLE [user](
	id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	fullname NVARCHAR(50) NOT NULL,
	phone VARCHAR(12) NOT NULL  CHECK( LEN(phone) >= 10 ),
	avatar VARCHAR(MAX),
	[password] VARCHAR(10) NOT NULL, CHECK( LEN(password) >= 6 ),
	birthdate DATE,
	gender  BIT DEFAULT 1, -- 1 is Male, 0 is Famale
	[address] NVARCHAR(1000),
	salary MONEY, CHECK (salary>0 ),
	is_admin  BIT DEFAULT 0,
	[enabled]  BIT DEFAULT 1,
	created_at DATETIME DEFAULT SYSDATETIME(),
	updated_at DATETIME DEFAULT SYSDATETIME(),
)
GO

INSERT INTO [user] (fullname, phone, password, birthdate, gender, address, salary ) VALUES ('Admin', '0123456789', '123456', '2/2/2002', 1, 'Ho Chi Minh', 12000000)

CREATE TABLE [table](
	table_id INT IDENTITY(1,1) PRIMARY KEY,
	is_busy BIT DEFAULT 1,
	name INT,
	[description] CHAR(30),
)
GO

CREATE TABLE [order](
	order_number INT IDENTITY(1,1) PRIMARY KEY,
	[description] VARCHAR(500),
	table_id INT FOREIGN KEY REFERENCES [table](table_id),
	buyer_id INT FOREIGN KEY REFERENCES [user](id),
	-- DEAL ORDER --
	customer_pay MONEY,
	total_price MONEY,

	created_at DATETIME DEFAULT SYSDATETIME(),
	updated_at DATETIME DEFAULT SYSDATETIME(),
)
GO


CREATE TABLE menu(
	id INT IDENTITY(1,1) PRIMARY KEY,
	menu_name NVARCHAR(30),
	created_by INT FOREIGN KEY REFERENCES [user](id) NOT NULL,
	created_at DATETIME DEFAULT SYSDATETIME(),
	updated_at DATETIME DEFAULT SYSDATETIME(),
)
GO

CREATE TABLE product(
	id INT IDENTITY(1,1) PRIMARY KEY ,
	drink_name NVARCHAR(30) NOT NULL,
	picture VARCHAR(MAX),
	benefit MONEY,CHECK (benefit >=0),
	price MONEY NOT NULL,CHECK (price >= 0),
	stock INT NOT NULL,CHECK (stock >= 0),
	unit NVARCHAR(30) NOT NULL,
	menu_id INT FOREIGN KEY REFERENCES menu(id),
	created_by INT FOREIGN KEY REFERENCES [user](id) NOT NULL,
	created_at DATETIME DEFAULT SYSDATETIME(),
	updated_at DATETIME DEFAULT SYSDATETIME()
)
GO

CREATE TABLE order_item(
	id INT IDENTITY(1,1) PRIMARY KEY ,
	order_number INT FOREIGN KEY REFERENCES [order](order_number),
	product_id INT FOREIGN KEY REFERENCES product(id),
	quantity VARCHAR(10)
)
GO

CREATE TABLE bill(
	order_number INT NOT NULL FOREIGN KEY REFERENCES [order](order_number),
	customer_pay MONEY NOT NULL,
	total_price MONEY NOT NULL,
	description VARCHAR(500),
	created_at DATETIME DEFAULT SYSDATETIME(),
	PRIMARY KEY (order_number)
)
GO

--------------------------- TRIGGERS ----------------------------------

CREATE OR ALTER TRIGGER update_modified_user
ON [user]
FOR UPDATE
AS
BEGIN
     UPDATE [user] 
	 SET updated_at = SYSDATETIME()
	 FROM Inserted as ins
	 WHERE [user].id = ins.id
END
GO

CREATE OR ALTER TRIGGER update_modified_order
ON [order]
FOR UPDATE
AS
BEGIN
     UPDATE [order] 
	 SET updated_at = SYSDATETIME()
	 FROM Inserted as ins
	 WHERE [order].order_number = ins.order_number
END
GO

CREATE OR ALTER TRIGGER update_modified_menu
ON [menu]
FOR UPDATE
AS
BEGIN
     UPDATE [menu] 
	 SET updated_at = SYSDATETIME()
	 FROM Inserted as ins
	 WHERE [menu].id = ins.id
END
GO

CREATE OR ALTER TRIGGER update_modified_product
ON [product]
FOR UPDATE
AS
BEGIN
     UPDATE [product] 
	 SET updated_at = SYSDATETIME()
	 FROM Inserted as ins
	 WHERE [product].id = ins.id
END
GO

