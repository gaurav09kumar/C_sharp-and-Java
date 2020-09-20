--DCL Queries

--create login
CREATE LOGIN ABC
WITH PASSWORD = 'test';

--create a user
CREATE USER ABC FOR LOGIN ABC

--delete a user
DROP USER ABC

--delete login
DROP LOGIN ABC

--create database
create database WebStore;

--specify database which is to be used every time
use [WebStore];

--create table
create table Persons (
		PersonID int,
		FirstName varchar(225),
		LastName varchar(225),
		Address varchar(225),
		City varchar(225));

SELECT * FROM Persons;

--alter table - alter column
ALTER TABLE Persons
ALTER COLUMN Address varchar(500);

--ater table - add column
ALTER TABLE Persons
ADD Email varchar(225);

--alter table -delete column
ALTER TABLE Persons
DROP COLUMN City;

--rename table using Execute
EXEC sp_rename 'Persons','Customers';

--drop table
DROP TABLE Customers;

