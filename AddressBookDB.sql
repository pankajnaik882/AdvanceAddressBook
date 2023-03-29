using System.Runtime.Intrinsics.X86;

--Create Address Book Service Database
create database Address_Book_Service;
use Address_Book_Service;

--UC2 create a Address Book table
create Table Address_Book
(First_Name varchar(100), Last_Name varchar(100), Address varchar(300), City varchar(50), State varchar(300), Zip_Code int, Phone_Number bigint, Email_Id varchar(500));
