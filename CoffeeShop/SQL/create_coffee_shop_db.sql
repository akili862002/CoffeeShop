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
	salary BIGINT, CHECK (salary>0 ),
	is_admin  BIT DEFAULT 0,
	[enabled]  BIT DEFAULT 1,
	created_at DATETIME DEFAULT SYSDATETIME(),
	updated_at DATETIME DEFAULT SYSDATETIME(),
)
GO

CREATE TABLE [table](
	table_id INT IDENTITY(1,1) PRIMARY KEY,
	name VARCHAR(50),
	[description] VARCHAR(255),
	is_busy BIT DEFAULT 0,
)
GO

CREATE TABLE [order](
	order_number INT IDENTITY(1,1) PRIMARY KEY,
	[description] VARCHAR(500),
	table_id INT FOREIGN KEY REFERENCES [table](table_id),
	buyer_id INT FOREIGN KEY REFERENCES [user](id),
	-- DEAL ORDER --
	customer_pay BIGINT,
	total_price BIGINT,

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
	[name] NVARCHAR(255) NOT NULL,
	picture VARCHAR(MAX),
	profit BIGINT,CHECK (profit >=0),
	price BIGINT NOT NULL,CHECK (price >= 0),
	stock INT NOT NULL,CHECK (stock >= 0),
	unit NVARCHAR(30) NOT NULL,
	menu_id INT FOREIGN KEY REFERENCES menu(id) NOT NULL,
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
	customer_pay BIGINT NOT NULL,
	total_price BIGINT NOT NULL,
	description VARCHAR(500),
	created_at DATETIME DEFAULT SYSDATETIME(),
	PRIMARY KEY (order_number)
)
GO

-------------------------- FAKE DATA ---------------------------------
-- Fake data USER
INSERT INTO [user] (fullname, phone, password, birthdate, gender, address, salary ) VALUES ('Admin', '0123456789', '123456', '2/2/2002', 1, 'Ho Chi Minh', 12000000)
GO
-- Fake data MENU
INSERT INTO [menu] (menu_name, created_by) VALUES (N'Cà phê pha phin', 1);
INSERT INTO [menu] (menu_name, created_by) VALUES (N'Cà phê Espresso', 1);
INSERT INTO [menu] (menu_name, created_by) VALUES (N'Bánh mì', 1);
INSERT INTO [menu] (menu_name, created_by) VALUES (N'Trà', 1);
INSERT INTO [menu] (menu_name, created_by) VALUES (N'Bánh', 1);
INSERT INTO [menu] (menu_name, created_by) VALUES (N'Freeze', 1);
GO
-- Fake data PRODUCT
INSERT INTO product (name, profit, price, stock, unit, menu_id, created_by) values (N'PHIN sữa đá', 20000, 29000, 100, 'Ly', 1, 1);
INSERT INTO product (name, profit, price, stock, unit, menu_id, created_by) values (N'PHIN đen đá', 18000, 27000, 65, 'Ly', 1, 1);
INSERT INTO product (name, profit, price, stock, unit, menu_id, created_by) values (N'Bạc xỉu đá', 15000, 28000, 110, 'Ly', 1, 1);

INSERT INTO product (name, profit, price, stock, unit, menu_id, created_by) values ('Espreso / Americano', 2000, 35000, 100, 'Ly', 2, 1);
INSERT INTO product (name, profit, price, stock, unit, menu_id, created_by) values ('Cappuccino / Latte', 20000, 55000, 120, 'Ly', 2, 1);
INSERT INTO product (name, profit, price, stock, unit, menu_id, created_by) values ('Mocha/ Caramel', 23000, 59000, 0, 'Ly', 2, 1);

INSERT INTO product (name, profit, price, stock, unit, menu_id, created_by) values (N'Bánh mì gà xé', 10000, 19000, 33, N'Cái', 3, 1);
INSERT INTO product (name, profit, price, stock, unit, menu_id, created_by) values (N'Bánh mì cà ri gà', 10000, 19000, 33, N'Cái', 3, 1);
INSERT INTO product (name, profit, price, stock, unit, menu_id, created_by) values (N'Bánh mì nấm', 10000, 19000, 0, N'Cái', 3, 1);

INSERT INTO product (name, profit, price, stock, unit, menu_id, created_by) values (N'Trà sen vàng', 14000, 39000, 32, N'Cốc', 4, 1);
INSERT INTO product (name, profit, price, stock, unit, menu_id, created_by) values (N'Trà thạch đào', 14000, 39000, 0, N'Cốc', 4, 1);
INSERT INTO product (name, profit, price, stock, unit, menu_id, created_by) values (N'Trà thanh đào', 14000, 39000, 0, N'Cốc', 4, 1);
INSERT INTO product (name, profit, price, stock, unit, menu_id, created_by) values (N'Trà thạch vải', 14000, 39000, 68, N'Cốc', 4, 1);

-- FAKE data TABLE
INSERT INTO [table] (name, description, is_busy) values ('Bàn 1', '', 0)
INSERT INTO [table] (name, description, is_busy) values ('Bàn 2', '', 0)
INSERT INTO [table] (name, description, is_busy) values ('Bàn 3', '', 0)
INSERT INTO [table] (name, description, is_busy) values ('Bàn 4', '', 0)
INSERT INTO [table] (name, description, is_busy) values ('Bàn 5', '', 0)
INSERT INTO [table] (name, description, is_busy) values ('Bàn 6', '', 0)
INSERT INTO [table] (name, description, is_busy) values ('Bàn 7', '', 0)
INSERT INTO [table] (name, description, is_busy) values ('Bàn 8', '', 0)
INSERT INTO [table] (name, description, is_busy) values ('Bàn 9', '', 0)
INSERT INTO [table] (name, description, is_busy) values ('Bàn 10', '', 0)
INSERT INTO [table] (name, description, is_busy) values ('Bàn 11', '', 0)
INSERT INTO [table] (name, description, is_busy) values ('Bàn 12', '', 0)
INSERT INTO [table] (name, description, is_busy) values ('Bàn 13', '', 0)
INSERT INTO [table] (name, description, is_busy) values ('Bàn 14', '', 0)
INSERT INTO [table] (name, description, is_busy) values ('Bàn 15', '', 0)
INSERT INTO [table] (name, description, is_busy) values ('Bàn 16', '', 0)
INSERT INTO [table] (name, description, is_busy) values ('Bàn 17', '', 0)
INSERT INTO [table] (name, description, is_busy) values ('Bàn 18', '', 0)
INSERT INTO [table] (name, description, is_busy) values ('Bàn 19', '', 0)
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

