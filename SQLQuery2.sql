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

create table Categories
(
Categories_Id int identity (100000,1) primary key,
Categories_Name nvarchar (50) not null,
Categories_Description nvarchar (50) not null,
)
go
insert into Categories values('Cleaning','This cleaning personal')