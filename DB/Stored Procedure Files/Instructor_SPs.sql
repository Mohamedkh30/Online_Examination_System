create proc InsertInstructor  @name varchar(50), @email varchar(50),@pass varchar(50)
as
insert into Instructor values(@name,@email,@pass)

--InsertInstructor  555,888,999
-----------------------------------------------------------------------------------------------------------------------
create proc DeleteInstructorById @id int
as
declare @MId int
	select @MId=Manager_ID from Department where @id=Manager_ID

	if(@MId is not null)
		begin
			update Department set Manager_Id = null where Manager_Id = @id
		end
	delete from Ins_Dept_Cr where Ins_Id = @id
	delete from Instructor where Ins_Id=@id


-- DeleteInstructorById 101
-----------------------------------------------------------------------------------------------------------------------
create proc DeleteInstructorByName @name varchar(50)
as
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


-- DeleteInstructorByName 555
-----------------------------------------------------------------------------------------------------------------------
create proc SelectInstructors 
as
select * from Instructor

-- SelectInstructors
-----------------------------------------------------------------------------------------------------------------------
create proc SelectInstructorById @id int
as
select * from Instructor where Ins_Id=@id

-- SelectInstructorById 6
-----------------------------------------------------------------------------------------------------------------------
create proc SelectInstructorByName @name varchar(50)
as
select * from Instructor where Ins_Name=@name

-- SelectInstructorByName 'Ali Abdullah'
-----------------------------------------------------------------------------------------------------------------------
create proc UpdateInstructorById @id int, @name varchar(50), @email varchar(50),@pass varchar(50) 
as
update Instructor set Ins_Name=@name,Ins_Email=@email,Ins_Password=@pass where Ins_Id=@id

-- UpdateInstructorById 101,555,555,555
-----------------------------------------------------------------------------------------------------------------------
create proc UpdateInstructorByName @name varchar(50), @email varchar(50),@pass varchar(50) 
as
update Instructor set Ins_Email=@email,Ins_Password=@pass where Ins_Name=@name

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

-- AuthInstructor 'tarek.mahmoud@example.com','password10'
-- AuthInstructor 'tarek.mahmoud@example.com','dfgdgf'
-- AuthInstructor 'dfgdfg','dfgdgf'