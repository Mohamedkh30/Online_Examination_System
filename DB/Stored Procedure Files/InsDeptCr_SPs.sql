create proc InsertInsDepCrRelation @InsId int ,@DepId int ,@CrId int
as
if (exists(select * from Instructor where Ins_Id=@InsId) and exists(select * from Department where Dept_Id=@DepId) and exists(select * from Course where Cr_Id=@CrId) )
	begin
		if not exists(select * from Ins_Dept_Cr where Ins_Id=@InsId and Cr_Id=@CrId and Dept_Id=@DepId)
			insert into Ins_Dept_Cr values(@InsId,@DepId,@CrId)
		else
			select 'duplicate data'
	end
else
	select 'not valid data' 

go
-- InsertInsDepCrRelation 4,4,3
---------------------------------------------------------------------------
create proc SelectInsDepCrRelations
as
select * from Ins_Dept_Cr

go
-- SelectInsDepCrRelations
-----------------------------------------------------------------------------------------------------------------------
create proc SelectInsDepCrRelationByIns @id int
as
if exists(select * from Ins_Dept_Cr where Ins_Id=@id)
	select * from Ins_Dept_Cr where Ins_Id=@id
else
	select 'data does not exist'

go
-- SelectInsDepCrRelationByIns 1
-----------------------------------------------------------------------------------------------------------------------
create proc SelectInsDepCrRelationByDep @id int
as
if exists(select * from Ins_Dept_Cr where Dept_Id=@id)
	select * from Ins_Dept_Cr where Dept_Id=@id
else
	select 'data does not exist'

go
-- SelectInsDepCrRelationByDep 3
-----------------------------------------------------------------------------------------------------------------------
create proc SelectInsDepCrRelationByCr @id int
as
if exists(select * from Ins_Dept_Cr where Cr_Id=@id)
	select * from Ins_Dept_Cr where Cr_Id=@id
else
	select 'data does not exist'

go
-- SelectInsDepCrRelationByCr 4
-----------------------------------------------------------------------------------------------------------------------
create proc UpdateInsDepCrRelationByIns @InsId int ,@DepId int ,@CrId int
as
if (exists(select * from Instructor where Ins_Id=@InsId) and exists(select * from Department where Dept_Id=@DepId) and exists(select * from Course where Cr_Id=@CrId) )
	begin
		if exists(select * from Ins_Dept_Cr where Ins_Id=@InsId)
			update Ins_Dept_Cr set Dept_id=@DepId,Cr_Id=@CrId where Ins_Id=@InsId
		else
			select 'Instructor ID not in Ins_Dept_Cr record'
	end
else
	select 'invalid data'
go
-- UpdateInsDepCrRelationByIns 1,2,1
-----------------------------------------------------------------------------------------------------------------------
create proc UpdateInsDepCrRelationByDep @InsId int ,@DepId int ,@CrId int
as

if (exists(select * from Instructor where Ins_Id=@InsId) and exists(select * from Department where Dept_Id=@DepId) and exists(select * from Course where Cr_Id=@CrId) )
	begin
		if exists(select * from Ins_Dept_Cr where Dept_id=@DepId)
			update Ins_Dept_Cr set Cr_Id=@CrId,Ins_Id=@InsId where Dept_id=@DepId
		else
			select 'Department ID not in Ins_Dept_Cr record'
	end
else
	select 'invalid data'

go


-- UpdateInsDepCrRelationByDep 2,4,2
-----------------------------------------------------------------------------------------------------------------------
create proc UpdateInsDepCrRelationByCr @InsId int ,@DepId int ,@CrId int
as

if (exists(select * from Instructor where Ins_Id=@InsId) and exists(select * from Department where Dept_Id=@DepId) and exists(select * from Course where Cr_Id=@CrId) )
	begin
		if exists(select * from Ins_Dept_Cr where Cr_Id=@CrId)
			update Ins_Dept_Cr set Dept_id=@DepId,Ins_Id=@InsId where Cr_Id=@CrId
		else
			select 'Course ID not in Ins_Dept_Cr record'
	end
else
	select 'invalid data'

go
-- UpdateInsDepCrRelationByCr 2,4,2
-----------------------------------------------------------------------------------------------------------------------
create proc DeleteInsDepCrRelationByIns @InsId int
as
if exists(select * from Ins_Dept_Cr where Ins_Id=@InsId)
	delete from Ins_Dept_Cr where Ins_Id=@InsId
else
	select 'no instructor with this id in the record'
go
-- DeleteInsDepCrRelationByIns 4
-----------------------------------------------------------------------------------------------------------------------
create proc DeleteInsDepCrRelationByDep @DepId int
as
if exists(select * from Ins_Dept_Cr where Dept_id=@DepId)
	delete from Ins_Dept_Cr where Dept_id=@DepId
else
	select 'no department with this id in the record'
go
-- DeleteInsDepCrRelationByDep 4
-----------------------------------------------------------------------------------------------------------------------
create proc DeleteInsDepCrRelationByCr @CrId int
as
if exists(select * from Ins_Dept_Cr where Cr_Id=@CrId)
	delete from Ins_Dept_Cr where Cr_Id=@CrId
else
	select 'no course with this id in the record'

-- DeleteInsDepCrRelationByCr 3
-----------------------------------------------------------------------------------------------------------------------