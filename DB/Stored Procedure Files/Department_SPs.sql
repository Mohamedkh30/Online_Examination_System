create proc InsertDepartment  @name varchar(50), @MngrId int
as
	declare @MId int
	select @MId=Ins_Id from Instructor where @MngrId=Ins_Id

	if(@MId is not null)
		begin
			insert into Department values(@name,@MngrId)
		end
	else
		select 'Invalid Manager ID'

-- InsertDepartment  555,10
-----------------------------------------------------------------------------------------------------------------------
create proc DeleteDepartmentById @id int				--modify it to delete all students,courses,.... within
as
delete from Department where Dept_Id=@id

-- DeleteDepartmentById 101
-----------------------------------------------------------------------------------------------------------------------
create proc DeleteDepartmentByName @name varchar(50)			
as
delete from Department where Dept_Name=@name

-- DeleteDepartmentByName 555
-----------------------------------------------------------------------------------------------------------------------
create proc SelectDepartments 
as
select * from Department

-- SelectDepartments
-----------------------------------------------------------------------------------------------------------------------
create proc SelectDepartmentById @id int
as
select * from Department where Dept_Id=@id

-- SelectDepartmentById 2
-----------------------------------------------------------------------------------------------------------------------
create proc SelectDepartmentByName @name varchar(50)
as
select * from Department where Dept_Name=@name

-- SelectDepartmentByName 'Professional Web Development'
-----------------------------------------------------------------------------------------------------------------------
create proc UpdateDepartmentById @id int, @name varchar(50), @MngrId int
as
	declare @MId int
	select @MId=Ins_Id from Instructor where @MngrId=Ins_Id

	if(@MId is not null)
		begin
			update Department set Dept_Name=@name,Manager_Id=@MngrId where Dept_Id=@id
		end
	else
		select 'Invalid Manager ID'

-- UpdateDepartmentById 101,666,101
-----------------------------------------------------------------------------------------------------------------------
