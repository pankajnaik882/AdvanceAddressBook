using System.Runtime.Intrinsics.X86;

--Create Address Book Service Database
create database Address_Book_Service;
use Address_Book_Service;

--UC2 create a Address Book table
create Table Address_Book
(First_Name varchar(100), Last_Name varchar(100), Address varchar(300), City varchar(50), State varchar(300), Zip_Code int, Phone_Number bigint, Email_Id varchar(500));


--UC3 Ability to insert new Contacts to Address Book
insert into Address_Book values
('Anmol', 'Roy', 'MurariNagar', 'Khurja', 'UP', 203131, 7805982523, 'anmol122@gmail.com'),
('Riya', 'Sharma', 'PreetViharColony', 'Agra','UP', 784512, 9823659825, 'riya25@gmail.com'),
('Piyush', 'Rao', 'VijayNagar', 'Noida', 'UP', 789456, 7502982523, 'piyus2504@gmail.com'),
('Amit', 'Singh', 'ShastriNagar', 'Meerut', 'UP', 258963, 9639026598, 'amit25@gmail.com'),
('Manisha', 'Gupta', 'KalindiKunj', 'Aligarh', 'UP', 357895, 7836152489, 'mahi258@gmail.com');

--View contacts in address book
select * from Address_Book;


--UC4 Ability to edit existing contact person using their name
update Address_Book set City='Ghaziabad' where First_Name='Anmol';
update Address_Book set City='Ghaziabad' where First_Name='Manisha';
update Address_Book set City='Ghaziabad' where First_Name='Piyush';

--UC5 Ability to delete a person using person's name
delete from Address_Book where First_Name='Manisha';