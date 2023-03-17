USE Examination_DB

ALTER TABLE [dbo].[Student] ALTER COLUMN [St_Name] VARCHAR(50) NOT NULL
ALTER TABLE [dbo].[Student] ALTER COLUMN [Email] VARCHAR(50) NOT NULL
ALTER TABLE [dbo].[Student] ALTER COLUMN [Password] VARCHAR(50) NOT NULL

ALTER TABLE [dbo].[Student] ADD CONSTRAINT UnqStuEmail UNIQUE([Email]) 
--------------------------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------- Student SPs --------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------------------------
-- Get students:
-----------------------------
CREATE Proc SelectAllStudents 
AS
	BEGIN
		BEGIN TRY
			IF EXISTS(SELECT * FROM [dbo].[Student])
			BEGIN
				SELECT *
				FROM   [dbo].[Student]
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
-- testing
SelectAllStudents -- works well
-----------------------------
-- Get student according to their ID:
-----------------------------
CREATE Proc SelectStudentById @StudentId INT 
AS
	BEGIN
		BEGIN TRY
			IF EXISTS(SELECT * FROM	[dbo].[Student] WHERE	[St_Id]=@StudentId)
			BEGIN
				SELECT	*
				FROM	[dbo].[Student]
				WHERE	[St_Id]=@StudentId
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
-- testing
SelectStudentById 1 -- works well
-----------------------------
-- Get student according to their Email and Password:
-----------------------------
CREATE Proc SelectStudentByEmPass @StudentEmail VARCHAR(50), @StudentPassword VARCHAR(50)
AS
	BEGIN
		BEGIN TRY
			IF EXISTS(SELECT * FROM	[dbo].[Student] WHERE [Email] = @StudentEmail AND	[Password] = @StudentPassword)
			BEGIN
				SELECT	*
				FROM	[dbo].[Student]
				WHERE	[Email] = @StudentEmail
					AND	[Password] = @StudentPassword
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
-- testing
SelectStudentByEmPass 'ahmad.ali@example.com', 'password123' -- works well
SelectStudentByEmPass 'ahmad.ali@example.com', 'password' -- works well
-----------------------------
-- Update student information according to their ID:
-----------------------------
CREATE Proc [dbo].[UpdateStudentByID] @StudentId INT, @Name VARCHAR(50), @DepartmentID INT, @Email VARCHAR(50), @Password VARCHAR(50)
AS
	BEGIN
		BEGIN TRY
			IF NOT EXISTS(SELECT * FROM [dbo].[Student] WHERE [St_Id] = @StudentId)
			BEGIN
				SELECT 'Not Available'
			END
			ELSE
			BEGIN
				UPDATE [dbo].[Student]
				SET [St_Name] = ISNULL(@Name,'No Data!'),
					[Dept_Id] = ISNULL(@DepartmentID,'No Data!'),
					[Email] = ISNULL(@Email,'No Data!'),
					[Password] = ISNULL(@Password,'No Data!')
				WHERE [St_Id] = @StudentId;
			END
		END TRY
		BEGIN CATCH
			SELECT 'Update Failed .. Make sure its valid information, Please!'
		END CATCH
	END
-- testing
UpdateStudentByID 30, 'Mohamed Zalta', 2, 'mo_zalta@exmple.com', 'password123' -- works(must fill all parameters in UI) 
UpdateStudentByID 30, 'Mohamed Zalta', 5, 'mo_zalta@exmple.com', 'password123' -- works
-----------------------------
-- Update student information according to their Name:
-----------------------------
CREATE Proc UpdateStudentByName @OldStudentName VARCHAR(50), @NewStudentName VARCHAR(50), @DepartmentID INT, @Email VARCHAR(50), @Password VARCHAR(50)
AS
	BEGIN
		BEGIN TRY
			IF NOT EXISTS(SELECT * FROM [dbo].[Student] WHERE [St_Name] = @OldStudentName)
			BEGIN
				SELECT 'Not Available'
			END
			ELSE
			BEGIN
				UPDATE	[dbo].[Student]
				SET		[St_Name] = ISNULL(@NewStudentName,'No Data!'),
						[Dept_Id] = ISNULL(@DepartmentID,'No Data!'),
						[Email] = ISNULL(@Email,'No Data!'),
						[Password] = ISNULL(@Password,'No Data!')
				WHERE	[St_Name] = @OldStudentName;
			END
		END TRY
		BEGIN CATCH
			SELECT 'Update Failed .. Make sure its valid information, Please!'
		END CATCH
	END
-- testing
UpdateStudentByName 'Mohamed Zalta', 'Zalta Basha', 1, 'mo_zalta123@exmple.com', 'password123' -- works well
-----------------------------
-- Insert new student:
-----------------------------
CREATE Proc InsertNewStudent @Name VARCHAR(50)=NULL, @DepartmentID INT=NULL, @Email VARCHAR(50)=NULL, @Password VARCHAR(50)=NULL
AS
	BEGIN
		BEGIN TRY
			INSERT INTO [dbo].[Student] ([St_Name], [Email], [Password], [Dept_Id]) 
			VALUES(@Name, @Email, @Password, @DepartmentID)
		END TRY
		BEGIN CATCH
			SELECT 'Insert failed .. Make sure its valid information, Please!'
		END CATCH
	END
-- testing
InsertNewStudent -- works well
InsertNewStudent 'Naruto Uzumaki', 1, 'naruto.uzumaki@example.com', 'password123' -- works well
InsertNewStudent 'Hinata Hyuga', 2, 'hinata.hyuga@example.com', 'password123' -- works well
InsertNewStudent 'Hinata Hyuga', 7, 'hinata.hyuga@example.com', 'password123' -- works well
-----------------------------
-- Delete student according to their ID:
-----------------------------
CREATE Proc DeleteStudentByID @StudentID INT
AS
	BEGIN
		BEGIN TRY
			IF NOT EXISTS(SELECT * FROM [dbo].[Student] WHERE [St_Id] = @StudentId)
			BEGIN
				SELECT 'Not Available'
			END
			ELSE
			BEGIN
				DELETE FROM [dbo].[Student] WHERE [St_Id] = @StudentID
			END
		END TRY
		BEGIN CATCH
			SELECT 'Delete Failed!'
		END CATCH
	END
-- testing
DeleteStudentByID 39 -- works well
DeleteStudentByID 30 -- works well
-----------------------------
-- Delete student according to their Name:
-----------------------------
CREATE Proc DeleteStudentByName @StudentName VARCHAR(50)
AS
	BEGIN
		BEGIN TRY
			IF NOT EXISTS(SELECT * FROM [dbo].[Student] WHERE [St_Name] = @StudentName)
			BEGIN
				SELECT 'Not Available'
			END
			ELSE
			BEGIN
				DELETE FROM [dbo].[Student] WHERE [St_Name] = @StudentName
			END
		END TRY
		BEGIN CATCH
			SELECT 'Delete Failed!'
		END CATCH
	END
-- testing
DeleteStudentByName 'Naruto Uzumaki' -- works well
DeleteStudentByName 'Naruto Uzumaki' -- works well
--------------------------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------- Course SPs ---------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------------------------
-- Get Courses:
-----------------------------
CREATE Proc SelectAllCourses
AS
	BEGIN
		BEGIN TRY
			IF EXISTS(SELECT * FROM   [dbo].[Course])
			BEGIN
				SELECT *
				FROM   [dbo].[Course]
			END
			ELSE
			BEGIN
				SELECT 'No courses found!'
			END
		END TRY
		BEGIN CATCH
			SELECT 'No courses found!'
		END CATCH
	END
-- testing
SelectAllCourses -- works well
-----------------------------
-- Get Course by ID:
-----------------------------
CREATE Proc SelectCourseById @CourseID INT 
AS
	BEGIN
		BEGIN TRY
			IF EXISTS(SELECT * FROM   [dbo].[Course] WHERE [Cr_Id] = @CourseID)
			BEGIN
				SELECT *
				FROM [dbo].[Course]
				WHERE [Cr_Id] = @CourseID
			END
			ELSE
			BEGIN
				SELECT 'No course found!'
			END
		END TRY	
		BEGIN CATCH
			SELECT 'No course found!'
		END CATCH
	END
-- testing
SelectCourseById 4  -- works well
SelectCourseById 40 -- works well
-----------------------------
-- Get Course by Name:
-----------------------------
CREATE Proc SelectCourseByName @CourseName VARCHAR(50)
AS
	BEGIN
		BEGIN TRY
			IF EXISTS(SELECT * FROM   [dbo].[Course] WHERE [Cr_Name] = @CourseName)
			BEGIN
				SELECT *
				FROM [dbo].[Course]
				WHERE [Cr_Name] = @CourseName
			END
			ELSE
			BEGIN
				SELECT 'No course found!'
			END
		END TRY	
		BEGIN CATCH
			SELECT 'No course found!'
		END CATCH
	END
-- testing
SelectCourseByName 'Linux Essentials' -- works well
SelectCourseByName 'XML' -- works well
-----------------------------
-- Update Course name by ID:
-----------------------------
CREATE Proc UpdateCourseNameByID @CourseID INT, @Name VARCHAR(50)
AS
	BEGIN
		BEGIN TRY
			IF NOT EXISTS(SELECT * FROM [dbo].[Course] WHERE [Cr_Id] = @CourseID)
			BEGIN
				SELECT 'Not Available'
			END
			ELSE
			BEGIN
				UPDATE [dbo].[Course]
				SET [Cr_Name] = ISNULL(@Name,'No Data!')
				WHERE [Cr_Id] = @CourseID;
			END
		END TRY
		BEGIN CATCH
			SELECT 'Update Failed!'
		END CATCH
	END
-- testing
UpdateCourseNameByID 4, 'Linux Essentials' -- works well
UpdateCourseNameByID 40, 'XML' -- works well
-----------------------------
-- Update Course name by Name:
-----------------------------
CREATE Proc UpdateCourseNameByName @OldCourseName VARCHAR(50), @NewCourseName VARCHAR(50)
AS
	BEGIN
		BEGIN TRY
			IF NOT EXISTS(SELECT * FROM [dbo].[Course] WHERE [Cr_Name] = @OldCourseName)
			BEGIN
				SELECT 'Not Available'
			END
			ELSE
			BEGIN
				UPDATE [dbo].[Course]
				SET [Cr_Name] = ISNULL(@NewCourseName, 'No Data!')
				WHERE [Cr_Name] = @OldCourseName;
			END
		END TRY
		BEGIN CATCH
			SELECT 'Update Failed!'
		END CATCH
	END
-- testing
UpdateCourseNameByName 'Linux Essentials', 'Linux Essentialss' -- works well
-----------------------------
-- Insert new Course:
-----------------------------
CREATE Proc InsertNewCourse @Name VARCHAR(50)=NULL
AS
	BEGIN
		BEGIN TRY
			INSERT INTO [dbo].[Course] ([Cr_Name]) 
			VALUES(@Name)
		END TRY
		BEGIN CATCH
			SELECT 'Insert failed .. Fill all the data, Please!'
		END CATCH
	END
-- testing
InsertNewCourse 'XML' -- works well
-----------------------------
-- Delete Course by ID:
-----------------------------
CREATE Proc DeleteCourseByID @CourseID INT
AS
	BEGIN
		BEGIN TRY
			IF NOT EXISTS(SELECT * FROM [dbo].[Course] WHERE [Cr_Id] = @CourseID)
			BEGIN
				SELECT 'Not Available'
			END
			ELSE
			BEGIN
				DELETE FROM [dbo].[Course] WHERE [Cr_Id] = @CourseID
			END
		END TRY
		BEGIN CATCH
			SELECT 'Delete Failed!'
		END CATCH
	END
-- testing
DeleteCourseByID 7 -- works well
-----------------------------
-- Delete Course by Name:
-----------------------------
CREATE Proc DeleteCourseByName @CourseName VARCHAR(50)
AS
	BEGIN
		BEGIN TRY
			IF NOT EXISTS(SELECT * FROM [dbo].[Course] WHERE [Cr_Name] = @CourseName)
			BEGIN
				SELECT 'Not Available'
			END
			ELSE
			BEGIN
				DELETE FROM [dbo].[Course] WHERE [Cr_Name] = @CourseName
			END
		END TRY
		BEGIN CATCH
			SELECT 'Delete Failed!'
		END CATCH
	END
-- testing
DeleteCourseByName 'XML' -- works well
--------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------------------------ Topic SPs: --------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------------------------
-- Get Topics:
-----------------------------
CREATE Proc SelectAllTopics
AS
	BEGIN
		BEGIN TRY
			IF EXISTS(SELECT * FROM [dbo].[Topic])
			BEGIN
				SELECT *
				FROM   [dbo].[Topic]
			END
			ELSE
			BEGIN
				SELECT 'No topics found!'
			END 
		END TRY
		BEGIN CATCH
			SELECT 'No topics found!'
		END CATCH
	END
-- testing
SelectAllTopics -- works well
-----------------------------
-- Get Topics of specific course:
-----------------------------
CREATE Proc SelectCourseTopics @CourseID INT
AS
	BEGIN
		BEGIN TRY
			IF EXISTS(SELECT * FROM [dbo].[Topic] WHERE [Cr_Id] = @CourseID)
			BEGIN
				SELECT	*
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
-- testing
SelectCourseTopics 1   -- works well
SelectCourseTopics 100 -- works well
-----------------------------
-- Get Course ID of Topic by Topic Name:
-----------------------------
CREATE Proc SelectCourseIDByTopicName @TopicName VARCHAR(50)
AS
	BEGIN
		BEGIN TRY
			IF EXISTS(SELECT * FROM [dbo].[Topic] WHERE [Topic_Name] = @TopicName)
			BEGIN
				SELECT	[Cr_Id]
				FROM	[dbo].[Topic]
				WHERE	[Topic_Name] = @TopicName
			END
			ELSE
			BEGIN
				SELECT	'No course found!'
			END
		END TRY	
		BEGIN CATCH
			SELECT 'No course found!'
		END CATCH
	END
-- testing
SelectCourseIDByTopicName 'CSS Styling'   -- works well
SelectCourseIDByTopicName 'XML'   -- works well
-----------------------------
-- Update Topic name by Topic name:
-----------------------------
CREATE Proc UpdateTopicNameByName @NewTopicName VARCHAR(50), @OldTopicName VARCHAR(50)
AS
	BEGIN
		BEGIN TRY
			IF NOT EXISTS(SELECT * FROM [dbo].[Topic] WHERE [Topic_Name] = @OldTopicName)
			BEGIN
				SELECT 'Not Available'
			END
			ELSE
			BEGIN
				UPDATE [dbo].[Topic]
				SET [Topic_Name] = ISNULL(@NewTopicName,'No Data!')
				WHERE [Topic_Name] = @OldTopicName;
			END
		END TRY
		BEGIN CATCH
			SELECT 'Update Failed!'
		END CATCH
	END
-- testing
UpdateTopicNameByName 'CSS', 'CSS Styling'   -- works well
-----------------------------
-- Update Course ID of specific topic:
-----------------------------
CREATE Proc UpdateTopicCourseID @CourseID INT, @TopicName VARCHAR(50)
AS
	BEGIN
		BEGIN TRY
			IF NOT EXISTS(SELECT * FROM [dbo].[Topic] WHERE [Topic_Name] = @TopicName)
			BEGIN
				SELECT 'Not Available'
			END
			ELSE
			BEGIN
				UPDATE [dbo].[Topic]
				SET [Cr_Id] = ISNULL(@CourseID,'No Data!')
				WHERE [Topic_Name] = @TopicName;
			END
		END TRY
		BEGIN CATCH
			SELECT 'Update Failed!'
		END CATCH
	END
-- testing
UpdateTopicCourseID 2, 'CSS Styling'   -- works well
UpdateTopicCourseID 7, 'CSS Styling'   -- works well
-----------------------------
-- Insert new Topic to Course:
-----------------------------
CREATE Proc InsertNewTopic @TopicName VARCHAR(50)=NULL, @CourseID INT=NULL
AS
	BEGIN
		BEGIN TRY
			INSERT INTO [dbo].[Topic] 
			VALUES(@CourseID, @TopicName)
		END TRY
		BEGIN CATCH
			SELECT 'Insert failed .. Fill all the data, Please!'
		END CATCH
	END
-- testing
InsertNewTopic 'XML', 1   -- works well
-----------------------------
-- Delete Topic from Course:
-----------------------------
CREATE Proc DeleteTopicByCrIDTopName @CourseID INT, @TopicName VARCHAR(50)
AS
	BEGIN
		BEGIN TRY
			IF NOT EXISTS(SELECT * FROM [dbo].[Topic] WHERE [Cr_Id] = @CourseID AND [Topic_Name] = @TopicName)
			BEGIN
				SELECT 'Not Available'
			END
			ELSE
			BEGIN
				DELETE FROM [dbo].[Topic] WHERE [Cr_Id] = @CourseID AND [Topic_Name] = @TopicName
			END
		END TRY
		BEGIN CATCH
			SELECT 'Delete Failed!'
		END CATCH
	END
-- testing
DeleteTopicByCrIDTopName 1, 'XML'   -- works well
-----------------------------
-- Delete Topic By Name:
-----------------------------
CREATE Proc DeleteTopicByName @TopicName VARCHAR(50)
AS
	BEGIN
		BEGIN TRY
			IF NOT EXISTS(SELECT * FROM [dbo].[Topic] WHERE [Topic_Name] = @TopicName)
			BEGIN
				SELECT 'Not Available'
			END
			ELSE
			BEGIN
				DELETE FROM [dbo].[Topic] WHERE [Topic_Name] = @TopicName
			END
		END TRY
		BEGIN CATCH
			SELECT 'Delete Failed!'
		END CATCH
	END
-- testing
DeleteTopicByName 'XML'   -- works well
--------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------------------------ Exam SPs ----------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------------------------
-- Get Exams:
-----------------------------
CREATE Proc SelectAllExams
AS
	BEGIN
		BEGIN TRY
			IF EXISTS(SELECT * FROM [dbo].[Exam])
			BEGIN
				SELECT *
				FROM   [dbo].[Exam]
			END
			ELSE
			BEGIN
				SELECT 'No exams found!'
			END  
		END TRY
		BEGIN CATCH
			SELECT 'No exams found!'
		END CATCH
	END
-- testing
SelectAllExams   -- works well
-----------------------------
-- Get Exam by ID:
-----------------------------
CREATE Proc SelectExamById @ExamID INT 
AS
	BEGIN
		BEGIN TRY
			IF EXISTS(SELECT * FROM [dbo].[Exam] WHERE [Ex_Num] = @ExamID)
			BEGIN
				SELECT *
				FROM   [dbo].[Exam]
				WHERE [Ex_Num] = @ExamID
			END
			ELSE
			BEGIN
				SELECT 'No exams found!'
			END
		END TRY	
		BEGIN CATCH
			SELECT 'Exam not found!'
		END CATCH
	END
-- testing
SelectExamById 1   -- works well
-----------------------------
-- Get Exams of specific course:
-----------------------------
CREATE Proc SelectCourseExams @CourseID INT 
AS
	BEGIN
		BEGIN TRY
			IF EXISTS(SELECT * FROM [dbo].[Exam] WHERE [Cr_Id] = @CourseID)
			BEGIN
				SELECT *
				FROM   [dbo].[Exam]
				WHERE [Cr_Id] = @CourseID
			END
			ELSE
			BEGIN
				SELECT 'No exams found!'
			END
		END TRY	
		BEGIN CATCH
			SELECT 'Exam not found!'
		END CATCH
	END
-- testing
SelectCourseExams 1   -- works well
-----------------------------
-- Update Exam's Course ID:
-----------------------------
CREATE Proc UpdateCourseIdOfExamByExamID @NewCourseID INT, @ExamID INT
AS
	BEGIN
		BEGIN TRY
			IF NOT EXISTS(SELECT * FROM [dbo].[Exam] WHERE [Ex_Num] = @ExamID)
			BEGIN
				SELECT 'Not Available'
			END
			ELSE
			BEGIN
				UPDATE [dbo].[Exam]
				SET [Cr_Id] = ISNULL(@NewCourseID,'No Data!')
				WHERE [Ex_Num] = @ExamID;
			END
		END TRY
		BEGIN CATCH
			SELECT 'Update Failed!'
		END CATCH
	END
-- testing
UpdateCourseIdOfExamByExamID 1, 1   -- works well
-----------------------------
-- Insert new Exam of specific Course:
-----------------------------
CREATE Proc InsertNewExamToCourse @CourseID INT=NULL
AS
	BEGIN
		BEGIN TRY
			INSERT INTO [dbo].[Exam] ([Cr_Id]) 
			VALUES(@CourseID)
		END TRY
		BEGIN CATCH
			SELECT 'Insert failed .. Fill all the data, Please!'
		END CATCH
	END
-- testing
InsertNewExamToCourse 1   -- works well
-----------------------------
-- Delete Course by ID:
-----------------------------
CREATE Proc DeleteExam @ExamID INT
AS
	BEGIN
		BEGIN TRY
			IF NOT EXISTS(SELECT * FROM [dbo].[Exam] WHERE [Ex_Num] = @ExamID)
			BEGIN
				SELECT 'Not Available'
			END
			ELSE
			BEGIN
				DELETE FROM [dbo].[Exam] WHERE [Ex_Num] = @ExamID
			END
		END TRY
		BEGIN CATCH
			SELECT 'Delete Failed!'
		END CATCH
	END
-- testing
DeleteExam 1   -- works well
--------------------------------------------------------------------------------------------------------------------------------------------------
---------------------------------------------------------- Student's Exam Answers SP: ------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------------------------
CREATE Proc StudentExamAnswers @examID INT, @StudentID INT, @QuestionID INT, @StudendAnswer1 VARCHAR(400),
						 @StudendAnswer2 VARCHAR(400), @StudendAnswer3 VARCHAR(400), @StudendAnswer4 VARCHAR(400),
						 @StudendAnswer5 VARCHAR(400), @StudendAnswer6 VARCHAR(400), @StudendAnswer7 VARCHAR(400),
						 @StudendAnswer8 VARCHAR(400), @StudendAnswer9 VARCHAR(400), @StudendAnswer10 VARCHAR(400)
AS
	BEGIN
		DECLARE @StudentName varchar(50) = (select [St_Name] from [dbo].[Student] where [St_Id] = @StudentID)

		BEGIN TRY
			IF	(NOT EXISTS(SELECT * FROM [dbo].[Exam] WHERE [Ex_Num] = @examID) 
					OR NOT EXISTS(SELECT * FROM [dbo].[Student] WHERE [St_Id] = @StudentID) 
					OR NOT EXISTS(SELECT * FROM [dbo].[Question] WHERE [Q_Id] = @QuestionID))
			BEGIN
				SELECT 'Wrong information!'
			END
			ELSE
			BEGIN
				DECLARE @counter INT = 1
				WHILE @counter < 11
				BEGIN
					IF @counter = 1
						INSERT INTO [dbo].[Stu_Exam_Question]([Exam_Num], [St_Id], [Q_Id], [Answer])
						VALUES (@examID, @StudentID, @QuestionID, @StudendAnswer1)
					ELSE IF @counter = 2
						INSERT INTO [dbo].[Stu_Exam_Question]([Exam_Num], [St_Id], [Q_Id], [Answer])
						VALUES (@examID, @StudentID, @QuestionID, @StudendAnswer2)
					ELSE IF @counter = 3
						INSERT INTO [dbo].[Stu_Exam_Question]([Exam_Num], [St_Id], [Q_Id], [Answer])
						VALUES (@examID, @StudentID, @QuestionID, @StudendAnswer3)
					ELSE IF @counter = 4
						INSERT INTO [dbo].[Stu_Exam_Question]([Exam_Num], [St_Id], [Q_Id], [Answer])
						VALUES (@examID, @StudentID, @QuestionID, @StudendAnswer4)
					ELSE IF @counter = 5
						INSERT INTO [dbo].[Stu_Exam_Question]([Exam_Num], [St_Id], [Q_Id], [Answer])
						VALUES (@examID, @StudentID, @QuestionID, @StudendAnswer5)
					ELSE IF @counter = 6
						INSERT INTO [dbo].[Stu_Exam_Question]([Exam_Num], [St_Id], [Q_Id], [Answer])
						VALUES (@examID, @StudentID, @QuestionID, @StudendAnswer6)
					ELSE IF @counter = 7
						INSERT INTO [dbo].[Stu_Exam_Question]([Exam_Num], [St_Id], [Q_Id], [Answer])
						VALUES (@examID, @StudentID, @QuestionID, @StudendAnswer7)
					ELSE IF @counter = 8
						INSERT INTO [dbo].[Stu_Exam_Question]([Exam_Num], [St_Id], [Q_Id], [Answer])
						VALUES (@examID, @StudentID, @QuestionID, @StudendAnswer8)
					ELSE IF @counter = 9
						INSERT INTO [dbo].[Stu_Exam_Question]([Exam_Num], [St_Id], [Q_Id], [Answer])
						VALUES (@examID, @StudentID, @QuestionID, @StudendAnswer9)
					ELSE IF @counter = 10
						INSERT INTO [dbo].[Stu_Exam_Question]([Exam_Num], [St_Id], [Q_Id], [Answer])
						VALUES (@examID, @StudentID, @QuestionID, @StudendAnswer10)
    
					SET @counter = @counter + 1
				END
			END
			SELECT @StudentName + ' finished the exam ' + CAST(@examID AS VARCHAR) + ' and registration done, Good luck :)'
		END TRY
		BEGIN CATCH
			SELECT 'Failed to get your answers!'
		END CATCH
	END