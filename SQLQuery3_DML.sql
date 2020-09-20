--create table
CREATE TABLE Orders(
	OrderId int,
	Amount decimal(7,2),
	CustomerId varchar(100)
	);

INSERT INTO Orders(OrderId, Amount, CustomerId) 
			VALUES 
			(1, 1000.00, 1),
			(2, 300.00, 1),
			(3, 650.00, 1),
			(4, 789.00, 1),
			(5, 186.00, 1),
			(6, 33.00, 1);

--Fetch only 3 records
SELECT TOP 3 * FROM Orders;

--Fetch top 50 records
SELECT TOP 50 PERCENT * FROM Orders;

SELECT TOP 3 * FROM Orders
ORDER BY Amount DESC;

SELECT MIN(Amount)
FROM Orders;

SELECT MAX(Amount)
FROM Orders;

SELECT COUNT(*)
FROM Orders;

--if you want to get a range use between keyword
SELECT * FROM Orders
	WHERE Amount BETWEEN 300 AND 700;

--ALias
SELECT * FROM Orders O

SELECT O.OrderId as [OrderNumber], O.Amount as [Order Total], O.CustomerId as [Customer]
FROM Orders O;

SELECT * FROM Customers;

--UPDATE Records
UPDATE Orders
SET CustomerId=4
WHERE OrderId = 2;

UPDATE Orders
SET CustomerId=3
WHERE OrderId = 3;

UPDATE Orders
SET CustomerId=7
WHERE OrderId = 4;

UPDATE Orders
SET CustomerId=9
WHERE OrderId = 6;


--INNER JOIN
SELECT O.OrderId, O.Amount, C.CustomerName, C.City
FROM Orders O
JOIN Customers C on O.CustomerId = C.CustomerId;

--left outer join
SELECT C.CustomerId, C.CustomerName,
O.OrderId, O.Amount
FROM Customers C
LEFT JOIN Orders O  on O.CustomerId = C.CustomerId;

--Right outer join
SELECT C.CustomerId, C.CustomerName,
O.OrderId, O.Amount
FROM Orders O
LEFT JOIN Customers C  on O.CustomerId = C.CustomerId;

--Full outer join
SELECT C.CustomerId, C.CustomerName,
O.OrderId, O.Amount
FROM Customers C
FULL JOIN Orders O  on O.CustomerId = C.CustomerId;