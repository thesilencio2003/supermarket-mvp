use Supermarket
drop table product
create table Product
(
Product_Id int identity (100000,1) primary key,
Product_Name nvarchar (50) not null,
Product_Price int not null,
Product_Stock int not null,
)
go
insert into Product values('soap',100,100)