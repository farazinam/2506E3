 -- -------------------  Day 1 ----------------------- 

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

INSERT INTO customer (name, city, email, age)
VALUES ("Farzan","Karachi", "farzan123@gmail.com", 28);

SELECT * FROM customer;

 -- -------------------  Day 3 ----------------------- 

-- Upadte

UPDATE customer SET city = "Lahore";
UPDATE customer SET city = "Karachi" WHERE id = 6;
UPDATE product SET product_quantity = 3 WHERE product_id = 3;
UPDATE product SET product_quantity = 5 WHERE product_price < 1000;

DELETE FROM product WHERE product_id = 1;
DELETE FROM customer WHERE age > 25 AND city = "Lahore";

SELECT * FROM product;
SELECT * FROM customer;
SELECT * FROM customer WHERE name = "Ali";
SELECT * FROM customer WHERE city = "Lahore";
SELECT * FROM customer WHERE age > 20;
SELECT * FROM customer WHERE NOT age > 20;
SELECT * FROM customer WHERE age < 20;

SELECT name, email FROM customer WHERE city = "Lahore";
SELECT name FROM customer WHERE age > 20;

SELECT * FROM customer LIMIT 2;
SELECT * FROM customer WHERE city = "Lahore" LIMIT 2;

SELECT * FROM customer WHERE city = "Lahore" LIMIT 1, 3;
SELECT TOP(2) FROM customer;

SELECT * FROM product;
SELECT * FROM product WHERE product_name IS NULL;
SELECT * FROM product WHERE product_name IS NOT NULL;


 -- -------------------  Day 4 ----------------------- 

SELECT * FROM product;
SELECT * FROM customer;

-- Transaction
START TRANSACTION;
DELETE FROM customer WHERE id = 5;

COMMIT;
ROLLBACK;

-- CLAUSES

-- Distinct
SELECT DISTINCT * FROM product;
SELECT DISTINCT product_name FROM product;
SELECT DISTINCT product_price FROM product;

-- order by
SELECT * FROM product ORDER BY product_name;
SELECT * FROM product ORDER BY product_name ASC;
SELECT * FROM product ORDER BY product_name DESC;

-- operator
DELETE FROM product WHERE product_price > 500 AND product_quantity = 10;
DELETE FROM product WHERE product_price > 500 OR product_quantity = 10;

SELECT * FROM product WHERE product_price BETWEEN 200 AND 300;
SELECT * FROM product WHERE product_price NOT BETWEEN 200 AND 300;
SELECT * FROM product WHERE NOT product_price BETWEEN 200 AND 300;

INSERT INTO customer (name, email, age) 
VALUES ("Feroz", "ahmed@gmail.com", 28),
("Faiz", "faiz@gmail.com", 24),
("Mudassir", "mudassir@gmail.com", 26),
("Furqan", "danish@gmail.com", 28),
("Faheem", "faheem@gmail.com", 23),
("Farhan", "farhan@gmail.com", 24),
("Muntazir", "muntazir@gmail.com", 27),
("Haris", "haris@gmail.com", 28),
("hasnain", "hasnain@gmail.com", 23);

SELECT * FROM customer;

SELECT * FROM customer WHERE age = 23 OR age = 26 OR age = 28;

SELECT * FROM customer WHERE age IN (23, 26, 28);
SELECT * FROM customer WHERE age NOT IN (23, 26, 28);

-- LIKE

SELECT * FROM customer WHERE name LIKE 'F%';
SELECT * FROM customer WHERE name LIKE '%n';
SELECT * FROM customer WHERE name LIKE '%a%';


 -- -------------------  Day 5 ----------------------- 


CREATE TABLE employee1 (
    id INT PRIMARY KEY,
    name VARCHAR(100),
    city VARCHAR(50),
    department VARCHAR(50),
    salary DECIMAL(10,2)
);

INSERT INTO employee1 (id, name, city, department, salary) VALUES
(1, 'Amit Sharma', 'Delhi', 'HR', 45000),
(2, 'Neha Verma', 'Mumbai', 'Finance', 60000),
(3, 'Ravi Kumar', 'Bangalore', 'IT', 75000),
(4, 'Pooja Singh', 'Pune', 'Marketing', 52000),
(5, 'Ankit Patel', 'Ahmedabad', 'Sales', 48000),
(6, 'Sunita Rao', 'Chennai', 'HR', 50000),
(7, 'Vikas Mehta', 'Jaipur', 'Finance', 58000),
(8, 'Kiran Joshi', 'Indore', 'IT', 72000),
(9, 'Rahul Malhotra', 'Delhi', 'Sales', 47000),
(10, 'Sneha Kulkarni', 'Pune', 'Marketing', 54000),
(11, 'Deepak Yadav', 'Lucknow', 'HR', 43000),
(12, 'Anjali Nair', 'Kochi', 'Finance', 62000),
(13, 'Manoj Das', 'Kolkata', 'IT', 70000),
(14, 'Ritu Saxena', 'Noida', 'Marketing', 56000),
(15, 'Suresh Reddy', 'Hyderabad', 'Sales', 49000),
(16, 'Priya Iyer', 'Chennai', 'HR', 51000),
(17, 'Nitin Agarwal', 'Agra', 'Finance', 59000),
(18, 'Swati Mishra', 'Bhopal', 'IT', 68000),
(19, 'Arjun Kapoor', 'Mumbai', 'Marketing', 57000),
(20, 'Kavita Jain', 'Udaipur', 'Sales', 46000),
(21, 'Rohit Choudhary', 'Faridabad', 'HR', 44000),
(22, 'Meenal Gupta', 'Gurgaon', 'Finance', 61000),
(23, 'Sanjay Verma', 'Patna', 'IT', 73000),
(24, 'Ayesha Khan', 'Bangalore', 'Marketing', 55000),
(25, 'Vinod Mishra', 'Kanpur', 'Sales', 48000),
(26, 'Pallavi Deshmukh', 'Nagpur', 'HR', 49500),
(27, 'Ashok Pillai', 'Trivandrum', 'Finance', 64000),
(28, 'Naveen Shetty', 'Mangalore', 'IT', 76000),
(29, 'Isha Bansal', 'Chandigarh', 'Marketing', 53000),
(30, 'Harsh Vardhan', 'Meerut', 'Sales', 47000);


SELECT * FROM employee1;

-- Functions
-- Built-In Functions

SELECT ABS(-2.56);
SELECT CEIL(2.3);
SELECT FLOOR(2.9);

SELECT MOD(10,3);

SELECT CONCAT('I ', 'Love ', 'Programming') AS Concatination;
SELECT UPPER('faraz inam') AS MyName;

SELECT * FROM customer;

SELECT count(*) AS EmployeesCount FROM employee1;
SELECT count(name) AS EmployeesCount FROM employee1;

SELECT SUM(id) AS SUMofID FROM employee1;
SELECT SUM(salary) AS SUMofSalary FROM employee1;

SELECT MIN(salary) AS MinSalary FROM employee1;

SELECT MAX(salary) AS MaxSalary FROM employee1;

SELECT AVG(salary) AS AverageSalary FROM employee1;

-- Group By (Clause)

SELECT SUM(salary), city FROM employee1 GROUP BY city;
SELECT SUM(salary), department FROM employee1 GROUP BY department;

-- Having

SELECT SUM(salary), department FROM employee1 GROUP BY department HAVING SUM(salary) > 300000;

-- Like Opr
 SELECT * FROM employee1 WHERE name LIKE '%t%';
 
 -- Subquery/NestedQuery/InnerQuery
SELECT name, salary FROM employee1 WHERE salary = (SELECT MAX(salary) from employee1);
SELECT * FROM employee1 WHERE salary = (SELECT MAX(salary) from employee1);

SELECT * FROM employee1 WHERE salary = (SELECT MIN(salary) from employee1);

 -- -------------------  Day 6 ----------------------- 

CREATE TABLE employee3 (
    id INT PRIMARY KEY,
    name VARCHAR(100),
    city VARCHAR(50),
    department VARCHAR(50),
    salary DECIMAL(10,2)
);

SELECT * FROM employee2;

INSERT INTO employee2 (id, name, city, department, salary)
SELECT * FROM employee1 WHERE salary IN
(SELECT salary FROM employee1 WHERE salary BETWEEN 50000 AND 60000);

SELECT * FROM employee3;

INSERT INTO employee3 (id, name, city, department, salary)
SELECT id, name, city, department, salary FROM employee1 WHERE salary >
(SELECT AVG(salary) FROM employee1);

SELECT AVG(salary) FROM employee1;

 -- -------------------  Day 7 ----------------------- 
create table department (
dept_id INT PRIMARY KEY AUTO_INCREMENT, 
dept_name VARCHAR(100)
);

INSERT INTO department (dept_name)
VALUES ('HR'),
('Marketing'),
('Engineering');
 
SELECT * FROM department;
 
create table employee (
id INT PRIMARY KEY auto_increment,
name VARCHAR(255),
d_id INT,
FOREIGN KEY (d_id) REFERENCES department (dept_id)
);

INSERT INTO employee (name, d_id)
VALUES ('Ali', 3),
('Ahmed', 1),
('Ayan', 3),
('Hassan', 2),
('Daniyal', 2),
('Yasir', 3);

SELECT * FROM employee;

-- JOIN 

-- INNER JOIN

SELECT * FROM employee
INNER JOIN department
ON department.dept_id = employee.d_id;

SELECT employee.name, department.dept_name FROM employee
INNER JOIN department
ON department.dept_id = employee.d_id;
 
 -- OUTER JOIN
 
 INSERT INTO department (dept_name)
 VALUES ("Account");
 
INSERT INTO employee (name, d_id)
VALUES ('Muzammil', null),
('Feroz', null);
 
SELECT * FROM department;
SELECT * FROM employee;
 
 -- Left Join
SELECT * FROM employee AS e
LEFT JOIN department AS d
ON d.dept_id = e.d_id;

SELECT * FROM employee
LEFT JOIN department
ON department.dept_id = employee.d_id
WHERE department.dept_name = "Marketing";

-- right join
SELECT * FROM employee
RIGHT JOIN department
ON department.dept_id = employee.d_id
UNION
SELECT * FROM employee
LEFT JOIN department
ON department.dept_id = employee.d_id;

-- full join
SELECT e.name, d.dept_name FROM employee AS e
RIGHT JOIN department AS d
ON d.dept_id = e.d_id
UNION
SELECT e.name, d.dept_name FROM employee AS e
LEFT JOIN department AS d
ON d.dept_id = e.d_id;

-- cross join
SELECT e.name, d.dept_name FROM employee AS e
CROSS JOIN department AS d
ON d.dept_id = e.d_id;

-- self join
CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    EmployeeName VARCHAR(100),
    ManagerID INT,
    FOREIGN KEY (ManagerID) REFERENCES Employees(EmployeeID)
);

INSERT INTO Employees (EmployeeID, EmployeeName, ManagerID)
VALUES (1, "Hamza", null),
(2, "Shahzaib", null),
(3, "Owais", null),
(4, "Tehreem", null),
(5, "Hassan", null),
(6, "Atif", null);

SELECT * FROM Employees;

UPDATE Employees SET ManagerID = 3 WHERE EmployeeID = 1;
UPDATE Employees SET ManagerID = 4 WHERE EmployeeID = 2;
UPDATE Employees SET ManagerID = 5 WHERE EmployeeID = 3;
UPDATE Employees SET ManagerID = 5 WHERE EmployeeID = 4;
UPDATE Employees SET ManagerID = 6 WHERE EmployeeID = 5;

SELECT e1.EmployeeName AS Employee, e2.EmployeeName AS Manager
FROM Employees e1
LEFT JOIN Employees e2
ON e1.ManagerID = e2.EmployeeID;


 