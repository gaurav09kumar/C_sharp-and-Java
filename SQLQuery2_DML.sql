--create table
CREATE TABLE Customers(
	CustomerId int,
	CustomerName varchar(255),
	City varchar(100)
	);

--insert records into each table
INSERT INTO Customers(CustomerId, CustomerName, City) VALUES (12, 'Customer1', 'Hyderabad');

--check data
SELECT * FROM Customers;

--insert records into multiple table
INSERT INTO Customers(CustomerId, CustomerName, City) 
			VALUES 
			(1, 'Customer1', 'Chennai'),
			(2, 'Customer2', 'Mumbai'),
			(3, 'Customer3', 'Delhi'),
			(4, 'Customer4', 'Bangalore'),
			(5, 'Customer5', 'Goa'),
			(6, 'Customer6', 'Lucknow'),
			(7, 'Customer7', 'Srinagar'),
			(8, 'Customer8', 'Delhi'),
			(9, 'Customer9', 'Punjab'),
			(10, 'Customer10', 'Noida'),
			(11, 'Customer11', 'Vizag');

--select all records from table
SELECT * FROM Customers;

--delete data
DELETE FROM Customers;

--truncate data
TRUNCATE Table Customers;

--select single column from table
SELECT City FROM Customers;

--select multiple column from table
SELECT CustomerId, City FROM Customers;

--select distinct records from particular column
SELECT DISTINCT City FROM Customers;

--Number of data in customers
SELECT COUNT(*) FROM Customers;

--Select city count
SELECT COUNT(City) FROM Customers;

--select distinct city count 
SELECT COUNT(DISTINCT City) FROM Customers;

--WHERE
SELECT * FROM Customers
		WHERE CustomerId = 5;

--OR
SELECT * FROM Customers
		WHERE City = 'Goa' and  CustomerId = 5;

--OR
SELECT * FROM Customers
		WHERE City = 'Mumbai' or  City = 'Hyderabad';

--LIKE
SELECT * FROM Customers
		WHERE CustomerName LIKE '%er%';

--LIKE
SELECT * FROM Customers
		WHERE City LIKE '%bad%';

--LIKE city starting with letter M
SELECT * FROM Customers
		WHERE City LIKE 'M%';

--LIKE city ending with letter AI
SELECT * FROM Customers
		WHERE City LIKE '%AI';

--order by ascending
SELECT * FROM Customers
		ORDER BY City, CustomerName ASC

--order by descending
SELECT * FROM Customers
		ORDER BY City DESC;

--in
SELECT * FROM Customers
		WHERE City IN ('Hyderabad', 'Mumbai');

--in with sub query( query within query)
SELECT * FROM Customers
		WHERE City IN (SELECT City FROM Customers WHERE City LIKE '%AI');

