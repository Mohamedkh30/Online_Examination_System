create proc InsertInstructor  @name varchar(50), @email varchar(50),@pass varchar(50)
as
if((@name is not NULL)and(@email is not NULL)and(@pass is not NULL))
	begin
		insert into Instructor values(@name,@email,@pass)
	end
else 
	select 'empty parameter'
	
go
-- InsertInstructor  555,888,9
-----------------------------------------------------------------------------------------------------------------------
create proc DeleteInstructorById @id int
as
if exists (select * from Instructor where Ins_Id=@id)
	begin
		declare @MId int
		select @MId=Manager_ID from Department where @id=Manager_ID

		if(@MId is not null)
			begin
				update Department set Manager_Id = null where Manager_Id = @id
			end
		delete from Ins_Dept_Cr where Ins_Id = @id
		delete from Instructor where Ins_Id=@id
	end
else
	select 'ID does not exist'

go
-- DeleteInstructorById 10
-----------------------------------------------------------------------------------------------------------------------
create proc DeleteInstructorByName @name varchar(50)
as
if exists (select * from Instructor where Ins_Name=@name)
	begin
		declare @MId int,@ID int
		select @MId=Manager_ID from Department join Instructor on Ins_Id=Manager_ID
		where  Ins_Name=@name

		select @ID=Ins_Id from Instructor where Ins_Name=@name

		if(@MId is not null)
			begin
				update Department set Manager_Id = null where Manager_Id = @MId
			end
		delete from Ins_Dept_Cr where Ins_Id = @ID
		delete from Instructor where Ins_Id = @ID
	end
else
	select 'Name does not exist'

go
-- DeleteInstructorByName 555
-----------------------------------------------------------------------------------------------------------------------
create proc SelectInstructors 
as
select * from Instructor
go
-- SelectInstructors
-----------------------------------------------------------------------------------------------------------------------
create proc SelectInstructorById @id int
as
if exists (select * from Instructor where Ins_Id=@id)
	select * from Instructor where Ins_Id=@id
else 
	select 'ID does not exist'
	
go
-- SelectInstructorById 66
-----------------------------------------------------------------------------------------------------------------------
create proc SelectInstructorByName @name varchar(50)
as
if exists (select * from Instructor where Ins_Name=@name)
	select * from Instructor where Ins_Name=@name
else 
	select 'Name does not exist'
go
-- SelectInstructorByName 'Ali Abdullah'
-----------------------------------------------------------------------------------------------------------------------
create proc UpdateInstructorById @id int, @name varchar(50), @email varchar(50),@pass varchar(50) 
as
if exists (select * from Instructor where Ins_Id=@id)
	update Instructor set Ins_Name=@name,Ins_Email=@email,Ins_Password=@pass where Ins_Id=@id
else 
	select 'ID does not exist'

go
-- UpdateInstructorById 101,555,555,555
-----------------------------------------------------------------------------------------------------------------------
create proc UpdateInstructorByName @name varchar(50), @email varchar(50),@pass varchar(50) 
as
if exists (select * from Instructor where Ins_Name=@name)
	update Instructor set Ins_Email=@email,Ins_Password=@pass where Ins_Name=@name
else 
	select 'Name does not exist'

go
-- UpdateInstructorByName 555,555,555
-----------------------------------------------------------------------------------------------------------------------
create proc AuthInstructor @email varchar(50),@pass varchar(50) 
as
declare @InsEmail varchar(50),@InsPass varchar(50)
		select @InsEmail=Ins_Email,@InsPass=Ins_Password from Instructor
		where Ins_Email=@email

if(@InsEmail is null)
	begin
		select 'Email not registered'
	end
else
	begin
		if(@InsPass = @pass)
			begin
				select 'Login Successful'					--replace with 1?
			end
		else
			begin
				select 'Login Failed'						--replace with 0?
			end
	end

-- AuthInstructor 'fatima.ahmed@example.com','password2'
-- AuthInstructor 'fatima.ahmed@example.com','dfgdgf'
-- AuthInstructor 'dfgdfg','dfgdgf'
