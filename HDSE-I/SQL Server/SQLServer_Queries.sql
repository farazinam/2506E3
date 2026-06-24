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
VALUES ('Muhammad', 'Bilal', 'muhammadbilal@gmail.com', 3102, 'abc Street');

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