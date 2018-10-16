
--created tables for usage in layered architecture
--if cfreate is not working then drop(delete) table and then create again

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
DeptId int primary key,
DeptName varchar(20),
)
select * from Bindhu.Employee_Arch,Bindhu.Department_Arch
insert into Bindhu.Department_Arch values('10', 'Analyst')
insert into Bindhu.Department_Arch values('20', 'Executive')
insert into Bindhu.Department_Arch values('30', 'Administrator')
insert into Bindhu.Department_Arch values('40', 'Finance')
insert into Bindhu.Department_Arch values('50', 'HR')



-----------STORED PROCEDURES----------------

--add procedure
ALTER proc [Bindhu].[usp_AddEmployee]   
@eName varchar(20),
@eLoc varchar(20),
@ePh bigint,
@eDeptId int
As
BEGIN
insert into Bindhu.Employee_Arch values(@eName,@eLoc,@ePh,@eDeptId)
END

--if procedures are not previously there, then create shd be
-- written instead of modify


--display procedure
ALTER proc [Bindhu].[usp_DisplayEmployee]
AS
BEGIN
select * from Bindhu.Employee_Arch
END


--edit or update procedure
ALTER proc [Bindhu].[usp_EditEmployee]
@eName varchar(20),
@eLoc varchar(20),@ePh bigint, @eDeptId int,@eId int
AS
BEGIN
Update Bindhu.Employee_Arch set EmpName=@eName, EmpLocation=@eLoc,EmpContact=@ePh, DeptId=@eDeptId
where EmpId= @eId
END


--get department procedure
alter proc [Bindhu].[usp_GetDepartment]
AS
Begin
select * from Bindhu.Department_Arch
End


--next employee id autogeneration procedure
ALTER proc [Bindhu].[usp_NextEmpId]
@newEmpId int out
AS
BEGIN
set @newEmpId=(select IDENT_CURRENT('Bindhu.Employee_Arch')+ident_incr('Bindhu.Employee_Arch'))
END


--search employee procedure
ALTER proc [Bindhu].[usp_SearchEmployee]
 @eId int
AS
BEGIN
select * from Bindhu.Employee_Arch where EmpId=@eId
END