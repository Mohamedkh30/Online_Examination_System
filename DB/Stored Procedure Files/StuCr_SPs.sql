create proc InsertStuCrRelation @StuId int,@CrId int
as
insert into Stu_Courses values(@StuId,@CrId)

-- InsertStuCrRelation 1,1
---------------------------------------------------------------------------
create proc SelectStuCrRelations
as
select * from Stu_Courses

-- SelectStuCrRelations
-----------------------------------------------------------------------------------------------------------------------
create proc SelectStuCrRelationByStu @id int
as
select * from Stu_Courses where St_Id=@id

-- SelectStuCrRelationByStu 4
-----------------------------------------------------------------------------------------------------------------------
create proc SelectStuCrRelationByCr @id int
as
select * from Stu_Courses where Cr_Id=@id

-- SelectStuCrRelationByCr 4
-----------------------------------------------------------------------------------------------------------------------
create proc UpdateStuCrRelationByStu @StuId int ,@CrId1 int,@CrId2 int
as
update Stu_Courses set Cr_Id=@CrId2 where St_Id=@StuId and Cr_Id=@CrId1
-- UpdateStuCrRelationByStu 1,7,3
-----------------------------------------------------------------------------------------------------------------------
create proc UpdateStuCrRelationByCr @StuId int ,@DepId int ,@CrId int
as
update Stu_Courses set Dept_id=@DepId,Ins_Id=@StuId where Cr_Id=@CrId

-- UpdateInsDepCrRelationByCr 2,4,2
-----------------------------------------------------------------------------------------------------------------------
create proc DeleteStuCrRelationByIns @StuId int
as
delete from Stu_Courses where Ins_Id=@StuId

-- DeleteInsDepCrRelationByIns 4
-----------------------------------------------------------------------------------------------------------------------
create proc DeleteStuCrRelationByCr @CrId int
as
delete from Stu_Courses where Cr_Id=@CrId

-- DeleteInsDepCrRelationByCr 3
-----------------------------------------------------------------------------------------------------------------------