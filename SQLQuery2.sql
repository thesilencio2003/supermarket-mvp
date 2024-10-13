use Supermarket
drop table Product
create table Product
(
Product_Id int identity (100000,1) primary key,
Product_Name nvarchar (50) not null,
Product_Price int not null,
Product_Stock int not null,
)
go
insert into Product values('soap',100,100)

drop table Categories
create table Categories
(
Categories_Id int identity (100000,1) primary key,
Categories_Name nvarchar (50) not null,
Categories_Description nvarchar (50) not null,
)
go
insert into Categories values('Cleaning','This cleaning personal')

drop table Customers
create table Customers
(
Customers_Id int identity (10000,1) primary key,
Customers_Document int not null unique,
Customers_FirstName nvarchar (50) not null,
Customers_LastName nvarchar (50) not null,
Customers_Address nvarchar (50) not null,
Customers_Birthday date,
Customers_Phone int,
Customers_Email nvarchar (100) not null
)
go
insert Customers values(1004563221,'Juan','Pablo','Calle olvido','1990-02-28',1234567890,'juanpablo@example.com')

create table Invoice 
(
Invoice_Id int identity (10000,1) primary key,
Invoice_Number int not null unique,
Invoice_Date Date
)
go 
insert Invoice values(112,'1990-02-22')