use Sep19CHN

create table Bindhu.Employee_Arch
(
EmpId int identity(1000,1) primary key,
EmpName varchar(20),
EmpLocation varchar(20),
EmpContact bigint,
DeptId int foreign key references Bindhu.Department_Arch(DeptId)
)

create table Bindhu.Department_Arch
(
DeptId int identity(10,1) primary key,
DeptName varchar(20),
)
select * from Bindhu.Employee_Arch,Bindhu.Department_Arch

drop Bindhu.Employee_Labtasks


