CREATE DATABASE personal;

USE personal;

CREATE TABLE contact (
contact_id INT PRIMARY KEY IDENTITY(101,2),
first_name VARCHAR (50),
last_name VARCHAR (50),
email VARCHAR (100),
phone_number INT,
address VARCHAR(200)
);

SELECT * FROM contact;

INSERT INTO contact (first_name, last_name, email, phone_number, address)
VALUES ('Muhammad', 'Ali', 'muhammadali@gmail.com', 3102, 'abc Street');

INSERT INTO contact
VALUES ('Muhammad', 'Bilal', 'muhammadbilal@gmail.com', 3102, 'abc Street', 'Lahore');

INSERT INTO contact
VALUES ('Muhammad', 'Ibrahim', 'muhammadibrahim@gmail.com', 3102, 'abc Street'),
('Muhammad', 'Hassan', 'muhammadhassan@gmail.com', 3103, 'abc Street'),
('Muhammad', 'Hussain', 'muhammadhussain@gmail.com', 3104, 'abc Street');

--INSERT INTO contact (first_name, email, address)
--VALUES ('Muhammad', 'muhammadali@gmail.com', 'abc Street');


--DDL

ALTER TABLE contact 
ADD city VARCHAR(100);

ALTER TABLE contact 
ALTER COLUMN contact_number VARCHAR(100);

ALTER TABLE contact 
DROP COLUMN city;

EXEC sp_rename 'contact.phone_number', 'contact_number', 'COLUMN';


 -- ------------------ Day 2 ---------------

SELECT * FROM contact;

 -- Drop

DROP TABLE contact;
DROP DATABASE lab1;

TRUNCATE TABLE contact;
DELETE FROM contact;

-- Rename
EXEC sp_rename 'contact', 'rabta';


-- Constraints

CREATE TABLE customer (
id INT PRIMARY KEY IDENTITY(1,1),
name VARCHAR(50) NOT NULL,
age INT NOT NULL check(age >= 18),
city VARCHAR(50) DEFAULT 'Karachi',
email VARCHAR(100) UNIQUE,
contact VARCHAR (100) NOT NULL
);

INSERT INTO customer (name, age, city, email, contact)
VALUES ('Ali', 23, 'Lahore', 'ali@gmail.com', '0310-1234567');

INSERT INTO customer (name, age, city, email, contact)
VALUES ('Ahmed', 18, 'Lahore', 'ahmed@gmail.com', '0310-1234567');

INSERT INTO customer (name, age, city, contact)
VALUES ('Ahmed', 18, 'Lahore', '0310-1234567');

INSERT INTO customer (name, age, email, contact)
VALUES ('Ahmed', 18, 'ahmed123@gmail.com', '0310-1234567');

SELECT * FROM customer;

-- DML Queries

INSERT INTO customer (name, age, city, email, contact)
VALUES ('Ali', 23, 'Lahore', 'ali@gmail.com', '0310-1234567');

UPDATE customer set name = 'Haris' WHERE name = 'Ahmed';
UPDATE customer set name = 'Danish' WHERE id = 5;

UPDATE customer 
set age = 19, city = 'Multan', email = 'danish@gmail.com' 
WHERE id = 5;

DELETE FROM customer WHERE  id = 8;


 -- ------------------ Day 3 ---------------
SELECT * FROM rabta;

SELECT * FROM contact;
SELECT first_name, last_name FROM contact;

SELECT * FROM contact WHERE last_name = 'Hassan';
SELECT * FROM contact WHERE contact_id = 105;
SELECT first_name, last_name FROM contact WHERE last_name = 'Hassan';

SELECT TOP 3 * FROM contact;
SELECT TOP 30 PERCENT * FROM contact;
SELECT TOP 50 PERCENT * FROM contact;

-- Distinct
SELECT DISTINCT * FROM contact;
SELECT DISTINCT first_name, last_name, email FROM contact;
SELECT COUNT(DISTINCT first_name) AS ColumnCount FROM contact;

-- Operators

SELECT * FROM contact WHERE contact_id >= 109;
SELECT * FROM contact WHERE contact_id < 109;

SELECT * FROM customer;
SELECT * FROM customer WHERE age > 20;
SELECT * FROM customer WHERE age <> 23;
SELECT * FROM customer WHERE NOT age = 23;
SELECT * FROM customer WHERE age = 23;

--Logical Opr
SELECT * FROM customer WHERE age = 23 AND city = 'Karachi';
SELECT * FROM customer WHERE age = 23 OR city = 'Karachi';

SELECT * FROM customer WHERE age = 20 AND city = 'Karachi' OR name = 'Mubashir';
SELECT * FROM customer WHERE (age = 20 AND city = 'Karachi') OR name = 'Mubashir';
SELECT * FROM customer WHERE age = 20 AND (city = 'Karachi' OR name = 'Mubashir');

SELECT * FROM customer WHERE age BETWEEN 20 AND 25;
SELECT * FROM customer WHERE age IN (16, 18, 21, 23);
SELECT * FROM customer WHERE age = 16 OR age = 18 OR age = 21 OR age = 23;

SELECT * FROM customer WHERE name LIKE 'd%';
SELECT * FROM customer WHERE name LIKE '_a%';
SELECT * FROM customer WHERE name LIKE '_a%';
SELECT * FROM customer WHERE name LIKE '__n%';
SELECT * FROM customer WHERE name LIKE '__r__';



 -- ------------------ Day 4 ---------------

 CREATE TABLE Products
(
    ProductID INT PRIMARY KEY IDENTITY(1,1),
    ProductName VARCHAR(100),
    Category VARCHAR(50),
    Brand VARCHAR(50),
    Price DECIMAL(10,2),
    Stock INT,
    QuantitySold INT,
    Rating DECIMAL(2,1)
);

INSERT INTO Products VALUES
('Laptop','Electronics','Dell',85000,20,35,4.5),
('Laptop','Electronics','HP',78000,15,30,4.3),
('Laptop','Electronics','Lenovo',72000,18,28,4.4),
('Mobile','Electronics','Samsung',65000,40,80,4.6),
('Mobile','Electronics','Apple',180000,12,25,4.9),
('Mobile','Electronics','Xiaomi',45000,35,70,4.2),
('Tablet','Electronics','Samsung',55000,18,22,4.3),
('Tablet','Electronics','Apple',120000,10,18,4.8),
('Keyboard','Accessories','Logitech',3500,80,120,4.5),
('Mouse','Accessories','Logitech',2500,90,150,4.6),

('Monitor','Electronics','Dell',32000,20,35,4.4),
('Monitor','Electronics','HP',30000,18,30,4.2),
('Printer','Office','Canon',28000,15,20,4.3),
('Printer','Office','HP',25000,12,18,4.2),
('Scanner','Office','Canon',22000,10,15,4.1),
('Chair','Furniture','Interwood',15000,25,40,4.4),
('Table','Furniture','Interwood',18000,20,32,4.3),
('Cupboard','Furniture','Master',35000,8,10,4.5),
('Sofa','Furniture','Master',70000,5,8,4.7),
('Bed','Furniture','Interwood',85000,6,9,4.8),

('Pen','Stationery','Dollar',50,500,700,4.0),
('Notebook','Stationery','Oxford',250,300,500,4.3),
('Marker','Stationery','Dollar',120,250,450,4.1),
('Bag','Accessories','Nike',4500,60,90,4.6),
('Shoes','Fashion','Nike',12000,40,75,4.7),
('Shoes','Fashion','Adidas',14000,35,60,4.6),
('T-Shirt','Fashion','Nike',3500,70,100,4.4),
('Jeans','Fashion','Levis',5000,50,80,4.5),
('Jacket','Fashion','Levis',9000,30,45,4.6),
('Watch','Accessories','Casio',8500,25,38,4.7),

('Camera','Electronics','Canon',95000,8,12,4.8),
('Speaker','Electronics','Sony',18000,20,40,4.5),
('Headphones','Electronics','Sony',12000,35,65,4.6),
('Power Bank','Accessories','Anker',4500,50,90,4.5),
('USB Drive','Accessories','Kingston',1800,120,200,4.4),
('Hard Drive','Electronics','Seagate',8500,30,55,4.5),
('SSD','Electronics','Samsung',15000,25,48,4.8),
('Router','Networking','TP-Link',6500,30,50,4.4),
('Switch','Networking','Cisco',22000,12,18,4.6),
('Projector','Office','Epson',68000,6,10,4.7),

('Water Bottle','Home','Tupperware',1200,90,160,4.3),
('Vacuum Cleaner','Home','Philips',28000,15,22,4.5),
('Iron','Home','Philips',6500,18,35,4.4),
('Blender','Home','Kenwood',8500,20,32,4.5),
('Microwave','Home','Samsung',32000,10,15,4.6),
('Refrigerator','Home','LG',145000,5,7,4.8),
('Air Conditioner','Home','Gree',120000,8,12,4.7),
('Fan','Home','Pak Fan',7500,30,55,4.3),
('LED TV','Electronics','Sony',98000,10,16,4.8),
('Smart Watch','Electronics','Samsung',38000,22,45,4.6);

SELECT * FROM products;

-- Functions

-- Built-In

--String Fn
SELECT * , CONCAT(ProductName, ' ', Category) AS ProductAndCategory FROM products;

-- Math Fn
SELECT * FROM products;
SELECT ABS(-5) AS AbsoluteValue;
SELECT FLOOR(rating) FROM products;
SELECT ROUND(rating, 0) FROM products;

-- Date Fn
SELECT GETDATE();
SELECT GETDATE() AS GetDate;
SELECT GETDATE() AS GetDate, CURRENT_TIMESTAMP AS Timestamp;
SELECT GETDATE() AS GetDate, CURRENT_TIMESTAMP AS Timestamp, SYSDATETIME() AS SysDateTime;

-- Aggregate Fn
SELECT MIN(Price) FROM products;
SELECT MAX(Price) FROM products;
SELECT SUM(Price) FROM products;
SELECT COUNT(Price) FROM products;
SELECT COUNT(*) FROM products;
SELECT COUNT(*) FROM contact;
SELECT COUNT(city) FROM contact;

-- SELECT ProductID, ProductName, MIN(Price) FROM products;

-- ORDER BY
SELECT * FROM products ORDER BY productname;
SELECT * FROM products ORDER BY productname ASC;
SELECT * FROM products ORDER BY productname DESC;
SELECT * FROM products ORDER BY category;
SELECT * FROM products ORDER BY price;
SELECT * FROM products ORDER BY price DESC;

-- GROUP BY
SELECT category, SUM(price) FROM products GROUP BY category;

-- GROUP BY WITH WHERE
SELECT category, SUM(price) AS ProductPriceSUM FROM products WHERE price > 123456 GROUP BY category;