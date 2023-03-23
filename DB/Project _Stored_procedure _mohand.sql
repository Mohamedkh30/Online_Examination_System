

--------------------------------------------
      -- Table Question Procedures 
--------------------------------------------

--  (1)  Select ----------

-- (A) Dynamic Select
--Select_Question 'Q_Id' , '10'
CREATE PROC Select_Question 
                    @columnName VARCHAR(50)
	               ,@columnValue VARCHAR(700)
AS
DECLARE @sql NVARCHAR(MAX)

IF (ISNUMERIC(@columnValue) = 1)
BEGIN
	SET @sql = 'SELECT * FROM Question WHERE ' + @columnName + ' = ' + @columnValue
END
ELSE
BEGIN
	SET @sql = 'SELECT * FROM Question WHERE ' + @columnName + ' = ''' + @columnValue + '''';
END

EXEC (@sql)

-- (A)  Select Based ON Primary Key

create PROC Select_Question_By_Id 
     @Q_Id VARCHAR(3)
	
AS
DECLARE @sql NVARCHAR(MAX)

	SET @sql = 'SELECT * FROM Question WHERE Q_Id = '   + @Q_Id

EXEC (@sql)

--  (2)  inseret 
create  PROCEDURE InsertQuestion
	@QuestionContent VARCHAR(500)
	,@Type VARCHAR(20)
	,@TopicName VARCHAR(50)
	,@Course_Id VARCHAR(4)
  
AS
BEGIN
	DECLARE @sql NVARCHAR(MAX)

	SET @sql = 'INSERT INTO Question VALUES (' 
    + QUOTENAME(@QuestionContent, '''') 
    + ', ' + QUOTENAME(@Type, '''') 
    + ', ' + QUOTENAME(@TopicName, '''')
    + ', ' + @Course_Id +')'

	EXEC (@sql)
END
InsertQuestion 	'lkejfl?','MCQ','CSS Styling','1'

--  (3)  Update 

CREATE PROC UpdateQuestionById @SerchedId VARCHAR(4)
	,@columnName VARCHAR(50)
	,@columnValue VARCHAR(700)
AS
DECLARE @sql NVARCHAR(MAX)

IF (ISNUMERIC(@columnValue) = 1)
BEGIN
	SET @sql = 'update  Question set ' + @columnName + ' = ' + @columnValue + '  WHERE Q_Id = ' + @SerchedId;
END
ELSE
BEGIN
	SET @sql = 'update  Question set ' + @columnName + ' =  ''' + @columnValue + '''  WHERE Q_Id = ' + @SerchedId;
END

EXEC (@sql) 

--  UpdateQuestionById '20','Q_Id'	,'10'

	

--  (4) Delete
alter PROC QuestionDelete @ColumnName VARCHAR(50)
	,@ColumnValue VARCHAR(700)
AS
DECLARE @sql VARCHAR(max)


IF (ISNUMERIC(@ColumnValue) = 1)
BEGIN
                      ----------- NOT Completed  Must Select Q_Id 
	SET @sql = 'delete from Question where ' + @ColumnName + ' = ' + @ColumnValue;          ----------- then Delete Choice
   
END
ELSE
BEGIN
	SET @sql = 'delete from Question where ' + @ColumnName + ' =  ''' + @ColumnName + ''' ';   
END
EXEC (@sql) 
select *from Question

BEGIN TRANSACTION;
QuestionDelete 'Topic_Name', 'Command Line Basics'
rollback
-- If you want to roll back the changes, use ROLLBACK instead of COMMIT
commit
QuestionDelete 


QuestionDelete 'Q_Id'
	,'10'


-- Delete By ID 
create PROC QuestionDelete_By_Id @Q_Id  VARCHAR(5)
	
AS
declare @type varchar (10)
DECLARE @sql VARCHAR(max)
select @type = [type] from Question where Q_Id = @Q_Id
if(@type = 'MCQ')
begin
        exec DeleteChoiceByQ_ID @Q_Id
End
else
begin
exec DeleteTF_By_Id @Q_Id
end
	SET @sql = 'delete from Question where Q_Id = ' + @Q_Id;
EXEC (@sql) 

QuestionDelete_By_Id '19'
------------------------------------------------------------------------------------------------------------------
--Table (Choice)
--(1) select 

-- (A) Dynamic Select 
CREATE PROC SelectChoice 
    @columnName VARCHAR(50)
	,@columnValue VARCHAR(700)
AS
DECLARE @sql NVARCHAR(MAX)

IF (ISNUMERIC(@columnName) = 1)
BEGIN
	SET @sql = 'SELECT * FROM Choice WHERE ' + @columnName + ' = ' + @columnValue
END
ELSE
BEGIN
	SET @sql = 'SELECT * FROM Choice WHERE ' + @columnName + ' = ''' + @columnValue + '''';
END

EXEC (@sql) 

SelectChoice 'Correct_ans','1'

-----------------------
-- (B) Select By Q_ID

CREATE PROC SelectChoiceById
    @Q_Id VARCHAR(5)
AS
DECLARE @sql NVARCHAR(MAX)
	SET @sql = 'SELECT * FROM Choice WHERE Q_Id = '+ @Q_Id
EXEC (@sql) 

-------

--  (C) Select By Q_ID _Correct_Answer
CREATE PROC SelectChoiceById_Correct_Ans
    @Q_Id VARCHAR(5)
AS
DECLARE @sql NVARCHAR(MAX)


	SET @sql = 'SELECT * FROM Choice WHERE Q_Id = '+ @Q_Id+' AND Correct_Ans = 1'


EXEC (@sql) 
SelectChoiceById_Correct_Ans '41'

----------------------------------------------------------------------------------------------

--(2) inseret 

CREATE PROC AddChoice @QuestionId VARCHAR(4)
	,@ChoiceContent VARCHAR(800)
	,@IsCorrect VARCHAR(1)
AS
BEGIN
	DECLARE @sql NVARCHAR(MAX)

	SET @sql = 'INSERT INTO Choice VALUES (' + @QuestionId + ', ' + QUOTENAME(@ChoiceContent, '''') + ', ' + @IsCorrect + ')'

	EXEC (@sql)
END 
begin transaction
AddChoice '41'
	,'sdfsdf'
	,'0' 
    select * from Choice where Q_Id= 41
    rollback


--(3) Update 
CREATE PROC UpdateChoice @QuestionId VARCHAR(5)
	,@ChoiceContent VARCHAR(700)
	,@columnName VARCHAR(100)
	,@columnValue VARCHAR(700)
AS
DECLARE @sql NVARCHAR(MAX)

IF (ISNUMERIC(@columnValue) = 1)
BEGIN
	SET @sql = 'update  Choice set ' + @columnName + ' = ' + @columnValue + '  WHERE Q_Id = ' + @QuestionId + ' AND Choice_Content =  ''' + @ChoiceContent + '''';
END
ELSE
BEGIN
	SET @sql = 'update  Choice set ' + @columnName + ' =  ''' + @columnValue + ''' WHERE Q_Id = ' + @QuestionId + ' AND Choice_Content =  ''' + @ChoiceContent + '''';
END

EXEC (@sql) 

    UpdateChoice '41'
	,'0'
	,'Choice_Content'
	,'cd'


SELECT *
FROM Choice


--(4) Delete 

-- (A) Delete Choice By Primary key


CREATE PROC DeleteChoice @QuestionId VARCHAR(100)
	,@ChoiceContent VARCHAR(700)
AS
DECLARE @sql NVARCHAR(MAX)

BEGIN
	SET @sql = 'delete  Choice   WHERE Q_Id = ' + @QuestionId + ' AND Choice_Content =  ''' + @ChoiceContent + '''';
END

EXEC(@sql)

-- (B) Delete Choice By Q_ID
CREATE PROC DeleteChoiceByQ_ID @QuestionId VARCHAR(100)
	
AS
DECLARE @sql NVARCHAR(MAX)

BEGIN
	SET @sql = 'delete  Choice   WHERE Q_Id = ' + @QuestionId 
END

EXEC(@sql)

DeleteChoiceByQ_ID '41'


-------------------------------------------------------------- Table  T,F ------------------------------
-- --------- (1) Select T_F  --------

--(A) Select T_F Dinamic 
CREATE PROC SelectTF @columnName VARCHAR(50)
	,@columnValue VARCHAR(20)
AS
DECLARE @sql NVARCHAR(MAX)

IF (ISNUMERIC(@columnName) = 1)
BEGIN
	SET @sql = 'SELECT * FROM TF WHERE ' + @columnName + ' = ' + @columnValue
END
ELSE
BEGIN
	SET @sql = 'SELECT * FROM TF WHERE ' + @columnName + ' = ''' + @columnValue + '''';
END

EXEC (@sql)


--(A) Select T_F By Q_ID 

CREATE PROC SelectTF_By_Id
        @Q_Id VARCHAR(3)
	
AS
DECLARE @sql NVARCHAR(MAX)


	SET @sql = 'SELECT * FROM TF WHERE Q_Id = ' + @Q_Id

EXEC (@sql)


--  (2)  inseret 

CREATE PROC AddTF @QuestionId VARCHAR(4)
	,@IsCorrect VARCHAR(1)
AS
BEGIN
	DECLARE @sql NVARCHAR(MAX)

	SET @sql = 'INSERT INTO TF VALUES (' + @QuestionId + ', ' + @IsCorrect + ')'

	EXEC (@sql)
END
-----------------------------------------
--  (3)  Update 


---------------------------
CREATE PROC UpdateTF_By_Q_Id @QuestionId VARCHAR(5)
	,@columnName VARCHAR(50)
	,@columnValue VARCHAR(5)
AS
DECLARE @sql NVARCHAR(MAX)

SET @sql = 'update  TF set ' + @columnName + ' = ' + @columnValue + '  WHERE Q_Id = ' + @QuestionId ;

EXEC (@sql) 
selectTF_By_Id '52'
UpdateTF_By_Q_Id '52'
	
	,'Correct_Ans'
	,'1'

--  (4) Delete
CREATE PROC DeleteTF @QuestionId VARCHAR(4)
	
AS
DECLARE @sql NVARCHAR(MAX)

BEGIN
	SET @sql = 'delete  TF   WHERE Q_Id = ' + @QuestionId ;
END
EXEC (@sql)

-- Delete By Question ID
alter PROC DeleteTF_By_Id 
    @QuestionId VARCHAR(4)
	
AS
DECLARE @sql NVARCHAR(MAX)

BEGIN
	SET @sql = 'delete  TF   WHERE Q_Id = ' + @QuestionId ;
END

EXEC (@sql)

DeleteTF_By_Id '4'

-------------------------------------------------- Table STU_EXAM_Question ----------------------------------------------------------------





CREATE PROC Select_Quest_Exam_Stu @columnName VARCHAR(50)
	,@columnValue VARCHAR(24)
AS
DECLARE @sql NVARCHAR(MAX)

IF (ISNUMERIC(@columnValue) = 1)
BEGIN
	SET @sql = 'SELECT * FROM Stu_Exam_Question WHERE ' + @columnName + ' = ' + @columnValue
END
ELSE
BEGIN
	SET @sql = 'SELECT * FROM Stu_Exam_Question WHERE ' + @columnName + ' = ''' + @columnValue + '''';
END

EXEC (@sql) 

-----------------------------------------2 select question  by Student _ Id And Exam Number ----------------------------
create PROC Select_Quest_By_Stu_Exam 
    @Exam_Num VARCHAR(10)
	,@Stu_Id VARCHAR(20)
AS
DECLARE @sql NVARCHAR(MAX)

SET @sql = 'SELECT * FROM Stu_Exam_Question   WHERE St_Id = ' + @Stu_Id + ' AND Exam_Num =  ' + @Exam_Num;

EXEC (@sql) 

Select_Quest_By_Stu_Exam  '1','5'
select * from  Stu_Exam_Question 
-----------------------------------------2 select question  by Student _ Id And Exam Number And Q_Id ----------------------------
create PROC Select_Quest_By_Stu_Exam_Quest
	@Stu_Id VARCHAR(20)
   , @Exam_Num VARCHAR(10)
    ,@Q_Id VARCHAR(20)

AS
DECLARE @sql NVARCHAR(MAX)

SET @sql = 'SELECT * FROM Stu_Exam_Question   WHERE St_Id = ' + @Stu_Id + ' AND Exam_Num =  ' + @Exam_Num +'And Q_Id = ' + @Q_Id

EXEC (@sql) 



-----------------------------------------2 INsert  Quest_Exam_Stu  --------------------------------------------------------
create  PROCEDURE Insert_Answerd_Question 
@student_Id VARCHAR(10)
	,@Exam_Num VARCHAR(10)
	,@Q_Id VARCHAR(10)
	,@Answer VARCHAR(300)
    ,@Grade int 
AS
BEGIN
	DECLARE @sql NVARCHAR(MAX)

	SET @sql = 'INSERT INTO Stu_Exam_Question VALUES (' + @student_Id + ', ' + @Exam_Num + ', ' + @Q_Id + ', ' + QUOTENAME(@Answer, '''') + ', ' +CONVERT(varchar(2),@Grade)  + ')'

	EXEC (@sql)
END Insert_Answerd_Question '5'
	,'1'
	,'10'
	,'lsdkjf'
    ,1
    select * from  Stu_Exam_Question 

-----------------------------------------3 Update   Quest_Exam_Stu  --------------------------------------------------------
create PROC Update_Answerd_Question @Serched_Col VARCHAR(20)
	,@Serched_Val VARCHAR(300)
	,@columnName VARCHAR(50)
	,@columnValue VARCHAR(300)
AS
DECLARE @sql NVARCHAR(MAX)

IF (ISNUMERIC(@columnValue) = 1)
BEGIN
	SET @sql = 'update  Stu_Exam_Question set ' + @columnName + ' = ' + @columnValue + '  WHERE ' + @Serched_Col + ' = ' + @Serched_Val;
END
ELSE
BEGIN
	SET @sql = 'update  Stu_Exam_Question set ' + @columnName + ' =  ''' + @columnValue + '''  WHERE ' + @Serched_Col + ' = ' + @Serched_Val;
END
EXEC (@sql) 


-----------------------------------------------Delete-----------------------------------
create PROC Delete_answered_Question_By_St_Id_Exma_Num @St_Id VARCHAR(4)
	,@Exam_Num VARCHAR(4)
AS
DECLARE @sql NVARCHAR(MAX)

BEGIN
	SET @sql = 'delete  Stu_Exam_Question   WHERE St_Id = ' + @St_Id + ' AND Exam_Num =  ' + @Exam_Num;
END

EXEC (@sql) 
----------------------------------------
create PROC Delete_answered_Question_By_St_Id_Exma_Num_Q_Id @St_Id VARCHAR(4)
	,@Exam_Num VARCHAR(4)
    ,@Q_Id varchar (3)
AS
DECLARE @sql NVARCHAR(MAX)

BEGIN
	SET @sql = 'delete  Stu_Exam_Question   WHERE St_Id = ' + @St_Id + ' AND Exam_Num =  ' + @Exam_Num + ' AND Q_Id =  ' + @Q_Id;
END

EXEC (@sql)


--------------------------------------------Generate -- Exam-------------------------------

-- proc to Generate Questions Use in Generate Exam

create PROC Select_Question_For_Exam @type VARCHAR(5)
	,@Num_Of_Questions VARCHAR(2)
	,@Course_Id VARCHAR(3)
AS
DECLARE @sql NVARCHAR(MAX)

SET @sql = 'SELECT top(' + @Num_Of_Questions + ') * FROM Question WHERE Cr_Id  = ' + @Course_Id + ' AND [type] = ''' + @type + ''' order by NEWID()'

EXEC (@sql)

INSERT INTO Exam_Contain_Questions (
	[Exam_Num]
	,[Q_Id]
	)
SELECT 5
	,Q_Id
FROM Question


------------------------------------GenerateExam proc -------------------------
create PROC GenerateExam
    @MCQ_Num VARCHAR(3)
	,@TF_Num VARCHAR(3)
	,@Course_Name VARCHAR(40)
	,@Exam_Num INT OUTPUT
AS
DECLARE @Counter INT = 0
DECLARE @Course_Id VARCHAR(3)
DECLARE @Exam_Questions TABLE (
	Exam_Num INT
	,Q_Id INT
	)
DECLARE @Return_Exam TABLE (
	Q_Id INT
	,[Q_Content] VARCHAR(500)
	,[type] VARCHAR(7)
	,[Topic_Name] VARCHAR(100)
	,[Cr_Id] INT
	)
DECLARE @Question_Exam_Ids TABLE (Q_Id INT)

------------------------
SELECT @Course_Id = convert(VARCHAR(3), Cr_Id)
FROM Course
WHERE Cr_Name = @Course_Name -- initialize the coure Id 

-------
SELECT @Exam_Num = count(Ex_Num) + 1
FROM Exam

INSERT INTO Exam
VALUES (@Course_Id) -- new Exam in Table Exam
	-------

-----	Add Questions To Exam ---------
INSERT INTO @Return_Exam
EXEC Select_Question_For_Exam 'MCQ'
	,@MCQ_Num
	,@Course_Id

INSERT INTO @Return_Exam
EXEC Select_Question_For_Exam 'TF'
	,@TF_Num
	,@Course_Id

--select  @Question_Exam_Ids = Q_Id from @Return_Exam
INSERT INTO Exam_Questions (
	Exam_Num
	,Q_Id
	)
SELECT @Exam_Num
	,Q_Id
FROM @Return_Exam

SELECT *
FROM @Return_Exam

------------------------------------------- End of Generate Exam -----------------------





	--------------------------------------------

-- stored of last report 

 create proc Select_Student_Answer @Student_Id varchar(4) , @Exam_Num varchar(3)
 as 
 declare @Exam_Ansewrs table (answer varchar(700) , Question_Type varchar (30)) 
 insert into @Exam_Ansewrs (answer,Question_Type) select a.Answer , Q.[type] from  Stu_Exam_Question  a inner join Question Q on Q.Q_Id = a.Q_Id
 where a.St_Id = @Student_Id and a.Exam_Num = @Exam_Num
 -- cursor for Updating the Answer to True or False 
 Declare Answer_Cursor Cursor 
 for select answer , Question_Type from @Exam_Ansewrs 
 declare @ans varchar(300) ,@Q_Type varchar(30)
 open Answer_Cursor
 fetch Next from Answer_Cursor into @ans , @Q_Type
 while @@FETCH_STATUS=0
	begin
 if @ans = '1' and @Q_Type = 'TF'
 begin 
update  @Exam_Ansewrs set answer = 'True' where current of Answer_Cursor
 end
  if @ans = '0' and @Q_Type = 'TF'
 begin 
update  @Exam_Ansewrs set answer = 'False' where current of Answer_Cursor
 end
 fetch Answer_Cursor into  @ans , @Q_Type		
	end
 
close Answer_Cursor
deallocate Answer_Cursor
 select * from @Exam_Ansewrs
---------------------------------End of proc 
