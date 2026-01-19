CREATE DATABASE daraz;

USE daraz;

create table product (
product_id INT,
product_name VARCHAR (50),
product_price INT
);

SELECT * FROM product;

INSERT INTO product (product_id, product_name, product_price) 
VALUES (1, "Marker", 150);

INSERT INTO product (product_id, product_name, product_price) 
VALUES (2, "Pen", 250),
(3, "Geomatery", 450),
(4, "Bag", 2400);

 -- -------------------  Day 2 ----------------------- 

-- delete table
drop table product;

-- database delete
drop database daraz;

-- remove all recods of a table
truncate table product;
delete from product;

-- Off/On Update Mode
SET SQL_SAFE_UPDATES = 0; 

SELECT * FROM product;

-- rename
RENAME TABLE product TO products;
ALTER TABLE products RENAME TO pro;

-- ALTER QUERIRS

-- Add Column
ALTER TABLE product ADD COLUMN product_qty VARCHAR(50);

-- Change dataType
ALTER TABLE product MODIFY COLUMN product_qty INT;

-- Rename Column Name
ALTER TABLE product CHANGE product_qty product_quantity INT;

-- Delete Column
ALTER TABLE product DROP COLUMN product_qty;


-- CONSTRAINTS

create table customer (
id INT PRIMARY KEY AUTO_INCREMENT,
name VARCHAR (50) NOT NULL,
city VARCHAR(50) DEFAULT "Karachi",
email VARCHAR(100) UNIQUE,
age INT CHECK (age >= 18)
);

INSERT INTO customer (name, email, age) 
VALUES ("Ahmed", "ahmed123@gmail.com", 28);

SELECT * FROM customer;














