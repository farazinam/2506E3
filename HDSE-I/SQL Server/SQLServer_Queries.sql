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

--INSERT INTO contact
--VALUES ('Muhammad', 'Ibrahim', 'muhammadibrahim@gmail.com', 3102, 'abc Street'),
--('Muhammad', 'Hassan', 'muhammadhassan@gmail.com', 3103, 'abc Street'),
--('Muhammad', 'Hussain', 'muhammadhussain@gmail.com', 3104, 'abc Street');

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


