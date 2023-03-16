create proc InsertInstructor @id int, @name varchar(50), @email varchar(50),@pass varchar(50)
as
insert into Instructor values(@id,@name,@email,@pass)

--InsertInstructor  101,555,888,999
-----------------------------------------------------------------------------------------------------------------------
create proc DeleteInstructorById @id int
as
delete from Instructor where Ins_Id=@id

-- DeleteInstructorById 99
-----------------------------------------------------------------------------------------------------------------------
create proc DeleteInstructorByName @name varchar(50)
as
delete from Instructor where Ins_Name=@name

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
create proc UpdateInstructorById @id int, @name varchar(50), @email varchar(50),@pass varchar(50) 
as
update Instructor set Ins_Name=@name where Ins_Id=@id

-- UpdateInstructorById 101,555,555,555
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