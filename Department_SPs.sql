create proc InsertDepartment  @name varchar(50), @MngrId int
as
if not exists (select * from Department where Dept_Name=@name)
	begin
		declare @MId int
		select @MId=Ins_Id from Instructor where @MngrId=Ins_Id

		if(@MId is not null)
	
			begin
				insert into Department values(@name,@MngrId)
			end
		else
			select 'Invalid Manager ID'
	end
else
	select 'the department already exists'
	go
-- InsertDepartment  555,3
-----------------------------------------------------------------------------------------------------------------------
create proc DeleteDepartmentById @id int
as
if exists (select * from Department where Dept_Id=@id)
	delete from Department where Dept_Id=@id
else
	select 'Invalid department ID'
go
-- DeleteDepartmentById 4
-----------------------------------------------------------------------------------------------------------------------
create proc DeleteDepartmentByName @name varchar(50)			
as
if exists (select * from Department where Dept_Name=@name)
	delete from Department where Dept_Name=@name
else
	select 'Invalid department Name'
go
-- DeleteDepartmentByName 555
-----------------------------------------------------------------------------------------------------------------------
create proc SelectDepartments 
as
select * from Department

-- SelectDepartments
-----------------------------------------------------------------------------------------------------------------------
create proc SelectDepartmentById @id int
as
if exists (select * from Department where Dept_Id=@id)
	select * from Department where Dept_Id=@id
else
	select 'Invalid department ID'
go

-- SelectDepartmentById 9
-----------------------------------------------------------------------------------------------------------------------
create proc SelectDepartmentByName @name varchar(50)
as
if exists (select * from Department where Dept_Name=@name)
	select * from Department where Dept_Name=@name
else
	select 'Invalid department Name'
go

-- SelectDepartmentByName 'Professional Web Development'
-----------------------------------------------------------------------------------------------------------------------
create proc UpdateDepartmentById @id int, @name varchar(50), @MngrId int
as
if exists (select * from Department where Dept_Id=@id)
	begin
		declare @MId int
		select @MId=Ins_Id from Instructor where @MngrId=Ins_Id

		if(@MId is not null)
			begin
				update Department set Dept_Name=@name,Manager_Id=@MngrId where Dept_Id=@id
			end
		else
			select 'Invalid Manager ID'
	end
else
	select 'Invalid department ID'
go
	

-- UpdateDepartmentById 6,666,5
-----------------------------------------------------------------------------------------------------------------------
create proc UpdateDepartmentByName @name varchar(50), @MngrId int
as
if exists (select * from Department where Dept_Name=@name)
	begin
		declare @MId int
		select @MId=Ins_Id from Instructor where @MngrId=Ins_Id

		if(@MId is not null)
			begin
				update Department set Manager_Id=@MngrId where Dept_Name=@name
			end
		else
			select 'Invalid Manager ID'
	end
else
	select 'Invalid department Name'
go
	

-- UpdateDepartmentById 6,666,5
-----------------------------------------------------------------------------------------------------------------------
