--	Report that returns the students information according to Department No parameter
CREATE Proc SelectStudentsByDeptId @DeptId INT 
AS
	BEGIN
		BEGIN TRY
			IF EXISTS(SELECT * FROM	[dbo].[Student] WHERE [Dept_Id] = @DeptId)
			BEGIN
				SELECT	[St_Id]		AS [Student ID]
					   ,[St_Name]	AS [Student Name]
					   ,[Email]		AS [Student Email]
				FROM	[dbo].[Student]
				WHERE	[Dept_Id] = @DeptId
			END
			ELSE
			BEGIN
				SELECT 'No students found!'
			END
		END TRY	
		BEGIN CATCH
			SELECT 'No students found!'
		END CATCH
	END
GO

--	Report that takes the student ID and returns the grades of the student in all courses "%"
create proc GetGradePer @StId int
as
select sum(Cr_grade)/(COUNT(*)*10) as [Grade Percentage] from Stu_Courses
where St_Id = @StId

go

--	Report that takes the instructor ID and returns the name of the courses that he teaches and the number of student per course
create proc GetCoursesAndCount @InsId int
as
select Cr_Name as [Course Name],COUNT(St_Id) as [Student Count] from Ins_Dept_Cr as i ,Course as c,Stu_Courses as s
where
c.Cr_Id=i.Cr_Id and
c.Cr_Id=s.Cr_Id and
i.Ins_Id=@InsId
group by(Cr_Name)

go

--	Report that takes course ID and returns its topics  
CREATE Proc SelectCourseTopics @CourseID INT
AS
	BEGIN
		BEGIN TRY
			IF EXISTS(SELECT * FROM [dbo].[Topic] WHERE [Cr_Id] = @CourseID)
			BEGIN
				SELECT	[Topic_Name]
				FROM	[dbo].[Topic]
				WHERE	[Cr_Id] = @CourseID
			END
			ELSE
			BEGIN
				SELECT	'No topics found!'
			END
		END TRY	
		BEGIN CATCH
			SELECT 'No topics found!'
		END CATCH
	END
GO

--	Report that takes exam number and returns the Questions in it and chocies [freeform report]

CREATE Proc [dbo].[GetExamQuestionsAndChoices] @Exam_Num int
AS
	DECLARE @QID int, @QContent varchar(1000),@QType varchar(10) ,@choice1 varchar(150),@choice2 varchar(150),@choice3 varchar(150),@choice4 varchar(150)
	DECLARE Question_cursor CURSOR FOR
		select q.Q_Id,Q_Content,[type] from Exam_Questions as eq , Question as q
		where
		eq.Q_Id = q.Q_Id and
		Exam_Num = @Exam_Num

	OPEN Question_cursor
	FETCH Question_cursor INTO @QID,@QContent,@QType

	while @@FETCH_STATUS=0
		begin
		
			if (@QType='MCQ')
				begin
					
					DECLARE choice_cursor CURSOR FOR
					select Choice_Content from Choice where Q_Id=@QID

					declare @choice varchar(150)
					open choice_cursor
					
					FETCH NEXT FROM choice_cursor INTO @choice

					IF @@FETCH_STATUS = 0
						SET @choice1 = @choice;

					FETCH NEXT FROM choice_cursor INTO @choice

					IF @@FETCH_STATUS = 0
						SET @choice2 = @choice;

					FETCH NEXT FROM choice_cursor INTO @choice

					IF @@FETCH_STATUS = 0
						SET @choice3 = @choice;

					FETCH NEXT FROM choice_cursor INTO @choice

					IF @@FETCH_STATUS = 0
						SET @choice4 = @choice;

					close choice_cursor
					deallocate choice_cursor

					select @QContent,@choice1,@choice2,@choice3,@choice4
				end

			else if(@QType='TF')
				begin
					set @choice1='True'
					set @choice2='False'

					select @QContent,@choice1,@choice2
				end

			FETCH Question_cursor INTO @QID,@QContent,@QType
		end

	close Question_cursor
	deallocate Question_cursor

--	Report that takes exam number and the student ID then returns the Questions in this exam with the student answers

 create proc Select_Student_Answer @Student_Id varchar(4) , @Exam_Num varchar(3)
 as 
 declare @Exam_Ansewrs table (answer varchar(700))
 insert into @Exam_Ansewrs (answer) select  Answer from Stu_Exam_Question where St_Id = @Student_Id and Exam_Num = @Exam_Num
 select * from  @Exam_Ansewrs