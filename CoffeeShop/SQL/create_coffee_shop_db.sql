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
	fullname NVARCHAR(255) NOT NULL,
	phone VARCHAR(12) NOT NULL  CHECK( LEN(phone) >= 10 ),
	avatar VARCHAR(MAX),
	[password] VARCHAR(255) NOT NULL, CHECK( LEN(password) >= 6 ),
	birthdate DATETIME NOT NULL,
	gender  BIT DEFAULT 1, -- 1 is Male, 0 is Famale
	[address] NVARCHAR(1000),
	salary BIGINT, CHECK (salary > 0 ),
	is_admin  BIT DEFAULT 0,
	[enabled]  BIT DEFAULT 1,
	created_at DATETIME DEFAULT SYSDATETIME(),
	updated_at DATETIME DEFAULT SYSDATETIME(),
)
GO

CREATE TABLE [table](
	table_id INT IDENTITY(1,1) PRIMARY KEY,
	[name] VARCHAR(50) NOT NULL, CHECK (LEN([name]) > 1),
	[description] VARCHAR(255),
	--is_busy BIT DEFAULT 0,
)
GO

CREATE TABLE [order](
	order_number INT IDENTITY(1,1) PRIMARY KEY,
	[description] VARCHAR(500),
	table_id INT FOREIGN KEY REFERENCES [table](table_id),
	buyer_id INT FOREIGN KEY REFERENCES [user](id),
	created_at DATETIME DEFAULT SYSDATETIME()
)
GO


CREATE TABLE menu(
	id INT IDENTITY(1,1) PRIMARY KEY,
	menu_name NVARCHAR(30) NOT NULL, CHECK (LEN(menu_name) > 1),
	created_by INT FOREIGN KEY REFERENCES [user](id) NOT NULL,
	created_at DATETIME DEFAULT SYSDATETIME(),
	updated_at DATETIME DEFAULT SYSDATETIME(),
)
GO

CREATE TABLE product(
	id INT IDENTITY(1,1) PRIMARY KEY,
	[name] NVARCHAR(255) NOT NULL,
	picture VARCHAR(MAX),
	profit BIGINT,CHECK (profit >=0),
	price BIGINT NOT NULL,CHECK (price >= 0),
	stock INT NOT NULL,
	unit NVARCHAR(30) NOT NULL,
	menu_id INT FOREIGN KEY REFERENCES menu(id) NOT NULL,
	created_by INT FOREIGN KEY REFERENCES [user](id) NOT NULL,
	created_at DATETIME DEFAULT SYSDATETIME(),
	updated_at DATETIME DEFAULT SYSDATETIME()
)
GO

CREATE TABLE order_item(
	id INT IDENTITY(1,1) PRIMARY KEY ,
	order_number INT FOREIGN KEY REFERENCES [order](order_number) NOT NULL,
	product_id INT FOREIGN KEY REFERENCES product(id) NOT NULL,
	quantity VARCHAR(10) NOT NULL, CHECK (quantity > 0),
	created_at DATETIME DEFAULT SYSDATETIME(),
	updated_at DATETIME DEFAULT SYSDATETIME(),
)
GO

CREATE TABLE bill(
	order_number INT FOREIGN KEY REFERENCES [order](order_number) NOT NULL,
	customer_pay BIGINT NOT NULL,
	total_price BIGINT NOT NULL,
	description VARCHAR(500),
	created_at DATETIME DEFAULT SYSDATETIME(),
	PRIMARY KEY (order_number)
)
GO

-------------------------- FAKE DATA ---------------------------------
-- Fake data USER
INSERT INTO [user] (fullname, phone, password, birthdate, gender, address, salary, is_admin ) VALUES ('Admin', '0123456789', '123456', '2/2/2002', 1, 'Ho Chi Minh', 20000000, 1);
INSERT INTO [user] (fullname, phone, password, birthdate, gender, address, salary, is_admin ) VALUES ('Nguyen Tien Dung', '0204629164', '123456', '2/4/2004', 1, 'Ha Tinh', 13000000,0);
INSERT INTO [user] (fullname, phone, password, birthdate, gender, address, salary, is_admin ) VALUES ('Nguyen Viet Quang', '0914274685', '654321', '5/7/2001', 1, 'Nghe An', 13500000,0);
INSERT INTO [user] (fullname, phone, password, birthdate, gender, address, salary, is_admin ) VALUES ('Ha Van Nhan', '0285683286', '123123', '1/12/2002', 1, 'Dong Thap', 15000000,0);
INSERT INTO [user] (fullname, phone, password, birthdate, gender, address, salary, is_admin ) VALUES ('Nguyen Tuan Kiet', '0973944762', '987654', '1/2/2001', 1, 'Ca Mau', 17000000,0);
INSERT INTO [user] (fullname, phone, password, birthdate, gender, address, salary, is_admin ) VALUES ('Ho Kim Tien', '0987462814', '230403', '3/4/2003', 1, 'Dong Nai', 18500000,0);
INSERT INTO [user] (fullname, phone, password, birthdate, gender, address, salary, is_admin ) VALUES ('Truong Pham Ly Huong', '0391742917', '130702', '1/7/2002', 1, 'Dong Thap', 15000000,0);
INSERT INTO [user] (fullname, phone, password, birthdate, gender, address, salary, is_admin ) VALUES ('Dang Mai Huong', '0973644853', '040501', '4/5/2001', 1, 'Cao Bang', 13000000,0);
INSERT INTO [user] (fullname, phone, password, birthdate, gender, address, salary, is_admin ) VALUES ('Ha Nhat Venh', '0321456346', '111204', '1/12/2004', 1, 'Dong Thap', 13500000,0);
INSERT INTO [user] (fullname, phone, password, birthdate, gender, address, salary, is_admin ) VALUES ('Do Thi Bich Ngoc', '0965755843', '250302', '2/3/2002', 1, 'Thai Nguyen', 18000000,0);
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
INSERT INTO [table] (name, description) values ('Bàn 1', '')
INSERT INTO [table] (name, description) values ('Bàn 2', '')
INSERT INTO [table] (name, description) values ('Bàn 3', '')
INSERT INTO [table] (name, description) values ('Bàn 4', '')
INSERT INTO [table] (name, description) values ('Bàn 5', '')
INSERT INTO [table] (name, description) values ('Bàn 6', '')
INSERT INTO [table] (name, description) values ('Bàn 7', '')
INSERT INTO [table] (name, description) values ('Bàn 8', '')
INSERT INTO [table] (name, description) values ('Bàn 9', '')
INSERT INTO [table] (name, description) values ('Bàn 10', '')
INSERT INTO [table] (name, description) values ('Bàn 11', '')
INSERT INTO [table] (name, description) values ('Bàn 12', '')
INSERT INTO [table] (name, description) values ('Bàn 13', '')
INSERT INTO [table] (name, description) values ('Bàn 14', '')
INSERT INTO [table] (name, description) values ('Bàn 15', '')
INSERT INTO [table] (name, description) values ('Bàn 16', '')
INSERT INTO [table] (name, description) values ('Bàn 17', '')
INSERT INTO [table] (name, description) values ('Bàn 18', '')
INSERT INTO [table] (name, description) values ('Bàn 19', '')

-- FAKE data ORDER
INSERT INTO [order] (description, table_id, buyer_id) VALUES ('', 1, 1)
INSERT INTO [order] (description, table_id, buyer_id) VALUES ('', 4, 1)
INSERT INTO [order] (description, table_id, buyer_id) VALUES ('', 2, 1)

INSERT INTO [order_item] (order_number, product_id, quantity) VALUES (2, 1, 1)
INSERT INTO [order_item] (order_number, product_id, quantity) VALUES (2, 4, 2)
INSERT INTO [order_item] (order_number, product_id, quantity) VALUES (2, 9, 2)

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

CREATE OR ALTER TRIGGER check_stock_product
ON [product]
FOR INSERT, UPDATE
AS
BEGIN
     DECLARE @error_counts INT;
	 SET @error_counts = 0;
	 SELECT @error_counts = COUNT(*)
	 FROM inserted
	 WHERE inserted.stock < 0

	 IF (@error_counts > 0)
	 BEGIN
		RAISERROR(N'Hàng tồn bắt buộc phát lớn hơn hoặc bằng 0!', 16, 1)
		ROLLBACK;
	 END
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

CREATE OR ALTER TRIGGER update_modified_order_item
ON [order_item]
FOR UPDATE
AS
BEGIN
     UPDATE [order_item] 
	 SET updated_at = SYSDATETIME()
	 FROM Inserted as ins
	 WHERE order_item.id = ins.id
END
GO

CREATE OR ALTER TRIGGER create_order_item
ON [order_item]
FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @quantity INT;
	SELECT * FROM inserted JOIN product ON inserted.product_id = product.id AND quantity;

	RAISERROR('Error!!!', 10, 1)
END
GO

-- Select toàn bộ table
-- 
CREATE OR ALTER PROCEDURE get_all_table 
AS
	SELECT 
		[table].table_id,
		[name], 
		CASE WHEN [order].order_number IS NULL THEN 0 ELSE 1 END AS is_busy, 
		[table].description,
		[order].order_number
		-- 3. JOIN với bảng table để cuối cùng GROUP BY theo table_id
	FROM [table] LEFT JOIN 
		(
			-- 1. LEFT JOIN bảng order với bill trước --> để lấy những order nào chưa hoàn thành
			[order] LEFT JOIN bill ON [order].order_number = bill.order_number
			-- 2. Sau đó JOIN với bảng Order_item để chắc rằng có ít nhất 1 item trong order
			JOIN order_item ON [order].order_number = [order_item].order_number
		)
		ON [table].table_id = [order].table_id AND bill.order_number IS NULL
	WHERE 1 = 1
	GROUP BY [table].table_id, [name], [order].order_number, [table].description
GO

CREATE OR ALTER FUNCTION get_total_price_of_order(@order_number INT)
RETURNS INT
AS
BEGIN
	DECLARE @total INT;
		SELECT @total = SUM(price * quantity)
		FROM order_item JOIN product ON order_item.product_id = product.id
		WHERE order_item.order_number = @order_number
	RETURN @total
END
GO
