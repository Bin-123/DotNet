ALTER proc [Geetha].[usp_AddEmployee]   
@eName varchar(20),
@eLoc varchar(20),
@ePh bigint,
@eDeptId int
As
BEGIN
insert into Geetha.Employee values(@eName,@eLoc,@ePh,@eDeptId)
END

--if procedures are not previously there, then create shd be
-- written instead of modify



ALTER proc [Geetha].[usp_DisplayEmployee]
AS
BEGIN
select * from Geetha.Employee 
END


ALTER proc [Geetha].[usp_EditEmployee]
@eName varchar(20),
@eLoc varchar(20),@ePh bigint, @eDeptId int,@eId int
AS
BEGIN
Update Geetha.Employee set EmpName=@eName, EmpLocation=@eLoc,EmpContact=@ePh, DeptId=@eDeptId
where EmpId= @eId
END



ALTER proc [Geetha].[usp_GetDepartment]
AS
Begin
select * from Geetha.Department
End


ALTER proc [Geetha].[usp_NextEmpId]
@newEmpId int out
AS
BEGIN
set @newEmpId=(select IDENT_CURRENT('Geetha.Employee')+ident_incr('Geetha.Employee'))
END



ALTER proc [Geetha].[usp_SearchEmployee]
 @eId int
AS
BEGIN
select * from Geetha.Employee where EmpId=@eId
END