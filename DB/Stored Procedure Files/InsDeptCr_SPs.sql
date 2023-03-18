create proc InsertInsDepCrRelation @InsId int ,@DepId int ,@CrId int
as
insert into Ins_Dept_Cr values(@InsId,@DepId,@CrId)

-- InsertInsDepCrRelation 4,4,3
---------------------------------------------------------------------------
create proc SelectInsDepCrRelations
as
select * from Ins_Dept_Cr

-- SelectInsDepCrRelations
-----------------------------------------------------------------------------------------------------------------------
create proc SelectInsDepCrRelationByIns @id int
as
select * from Ins_Dept_Cr where Ins_Id=@id

-- SelectInsDepCrRelationByIns 1
-----------------------------------------------------------------------------------------------------------------------
create proc SelectInsDepCrRelationByDep @id int
as
select * from Ins_Dept_Cr where Dept_Id=@id

-- SelectInsDepCrRelationByDep 3
-----------------------------------------------------------------------------------------------------------------------
create proc SelectInsDepCrRelationByCr @id int
as
select * from Ins_Dept_Cr where Cr_Id=@id

-- SelectInsDepCrRelationByCr 4
-----------------------------------------------------------------------------------------------------------------------
create proc UpdateInsDepCrRelationByIns @InsId int ,@DepId int ,@CrId int
as
update Ins_Dept_Cr set Dept_id=@DepId,Cr_Id=@CrId where Ins_Id=@InsId
-- UpdateInsDepCrRelationByIns 1,2,1
-----------------------------------------------------------------------------------------------------------------------
create proc UpdateInsDepCrRelationByDep @InsId int ,@DepId int ,@CrId int
as
update Ins_Dept_Cr set Cr_Id=@CrId,Ins_Id=@InsId where Dept_id=@DepId

-- UpdateInsDepCrRelationByDep 2,4,2
-----------------------------------------------------------------------------------------------------------------------
create proc UpdateInsDepCrRelationByCr @InsId int ,@DepId int ,@CrId int
as
update Ins_Dept_Cr set Dept_id=@DepId,Ins_Id=@InsId where Cr_Id=@CrId

-- UpdateInsDepCrRelationByCr 2,4,2
-----------------------------------------------------------------------------------------------------------------------
create proc DeleteInsDepCrRelationByIns @InsId int
as
delete from Ins_Dept_Cr where Ins_Id=@InsId

-- DeleteInsDepCrRelationByIns 4
-----------------------------------------------------------------------------------------------------------------------
create proc DeleteInsDepCrRelationByDep @DepId int
as
delete from Ins_Dept_Cr where Dept_id=@DepId

-- DeleteInsDepCrRelationByDep 4
-----------------------------------------------------------------------------------------------------------------------
create proc DeleteInsDepCrRelationByCr @CrId int
as
delete from Ins_Dept_Cr where Cr_Id=@CrId

-- DeleteInsDepCrRelationByCr 3
-----------------------------------------------------------------------------------------------------------------------