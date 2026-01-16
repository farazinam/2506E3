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





