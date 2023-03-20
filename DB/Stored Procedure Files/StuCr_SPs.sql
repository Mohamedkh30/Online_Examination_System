create proc InsertStuCrRelation @StuId int,@CrId int,@grade int = null
as

if (exists(select * from Student where St_Id=@StuId))and(exists(select * from Course where Cr_Id=@CrId))
	begin
	if not exists(select * from Stu_Courses where St_Id=@StuId and Cr_Id=@CrId)
		insert into Stu_Courses values(@StuId,@CrId,@grade)
	else
		select 'duplicate data'
	end
else
	select 'not valid data' 

go
-- InsertStuCrRelation 31,7
---------------------------------------------------------------------------
create proc SelectStuCrRelations
as
select * from Stu_Courses

go
-- SelectStuCrRelations
-----------------------------------------------------------------------------------------------------------------------
create proc SelectStuCrRelationByStu @id int
as
if exists(select * from Stu_Courses where St_Id=@id)
	select * from Stu_Courses where St_Id=@id
else
	select 'data does not exist'

go
-- SelectStuCrRelationByStu 10
-----------------------------------------------------------------------------------------------------------------------
create proc SelectStuCrRelationByCr @id int
as
if exists(select * from Stu_Courses where Cr_Id=@id)
	select * from Stu_Courses where Cr_Id=@id
else
	select 'data does not exist'
go
-- SelectStuCrRelationByCr 9
-----------------------------------------------------------------------------------------------------------------------
create proc UpdateStuCrRelationByStu @StuId int ,@CrId1 int,@CrId2 int
as
if exists(select * from Course where Cr_Id=@CrId2)
	begin
	if exists(select * from Stu_Courses where St_Id=@StuId and Cr_Id=@CrId1)
		update Stu_Courses set Cr_Id=@CrId2 where St_Id=@StuId and Cr_Id=@CrId1
	else
		select 'data does not exist in Stu_Courses'
	end
else
	select 'invalid course ID'
go
-- UpdateStuCrRelationByStu 31,77,5
-----------------------------------------------------------------------------------------------------------------------
create proc UpdateStuCrRelationByCr @StuId1 int ,@CrId int ,@StuId2 int
as
if exists(select * from Student where St_Id=@StuId2)
	begin
	if exists(select * from Stu_Courses where St_Id=@StuId1 and Cr_Id=@CrId)
		update Stu_Courses set St_Id=@StuId2 where Cr_Id=@CrId and St_Id=@StuId1
	else
		select 'data does not exist in Stu_Courses'
	end
else
	select 'invalid Student ID'

go
-- UpdateInsDepCrRelationByCr 2,4,2
-----------------------------------------------------------------------------------------------------------------------
create proc UpdateGrade @StuId int ,@CrId int ,@grade int
as
if exists(select * from Stu_Courses where St_Id=@StuId and Cr_Id=@CrId)
		update Stu_Courses set Cr_grade=@grade where St_Id=@StuId and Cr_Id=@CrId
else
	select 'data does not exist in Stu_Courses'

go
-- UpdateGrade 8,5,2
-----------------------------------------------------------------------------------------------------------------------
create proc DeleteStuCrRelationByStu @StuId int
as
if exists(select * from Stu_Courses where St_Id=@StuId)
	delete from Stu_Courses where St_Id=@StuId
else
	select'Invalid student id'

go
-- DeleteInsDepCrRelationByIns 4
-----------------------------------------------------------------------------------------------------------------------
create proc DeleteStuCrRelationByCr @CrId int
as
if exists(select * from Stu_Courses where Cr_Id=@CrId)
	delete from Stu_Courses where Cr_Id=@CrId
else
	select'Invalid student id'
go
-- DeleteInsDepCrRelationByCr 3
-----------------------------------------------------------------------------------------------------------------------
create proc DeleteStuCrRelation @StuId int,@CrId int
as
if exists(select * from Stu_Courses where Cr_Id=@CrId and St_Id=@StuId)
	delete from Stu_Courses where Cr_Id=@CrId and St_Id=@StuId
else
	select'Invalid data'

-- DeleteInsDepCrRelationByCr 3
-----------------------------------------------------------------------------------------------------------------------