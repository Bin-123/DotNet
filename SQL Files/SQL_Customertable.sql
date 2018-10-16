create table Bindhu.Customer
(
Cust_Id int identity(10,1) primary key,
Cust_Name varchar(20),
Cust_DOB datetime,
Cust_Address varchar(30),
Cust_Region varchar(20),
Cust_Ph bigint
)

insert into Bindhu.Customer values('Bindhu', '11/09/1997', 'Near Sipcot', 'Chennai', '9966097578')

select * from Bindhu.Customer

insert into Bindhu.Customer values('Alex', '11/10/1997', 'Near Charminar', 'Hyderabad', '8889990007')
insert into Bindhu.Customer values('Clay', '11/11/1997', 'Near ags', 'Chennai', '9966078906')

select * from Bindhu.Customer
