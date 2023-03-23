ExamCorrection 7 , 3
alter proc ExamCorrection @StId int , @ExNum int
as

declare c1 cursor
for
select Q_Id,Answer from Stu_Exam_Question where St_Id=@StId and Exam_Num=@ExNum
for update

declare @QId int,@Ans varchar(400)
open c1
fetch c1 into @QId,@Ans
while @@FETCH_STATUS=0
	begin
		DECLARE @QType varchar(10) = (select [type] from Question where Q_Id = @QId)

		if(@QType='TF')
			begin
				DECLARE @Correct bit = (select Correct_Ans from TF where Q_Id = @QId)
				if((@Ans='1' and @Correct = 1) or (@Ans='0' and @Correct = 0))
					update Stu_Exam_Question set Grade = 1 where St_Id=@StId and Exam_Num=@ExNum and Q_Id = @QId and Answer = @Ans

				else 
					update Stu_Exam_Question set Grade = 0 where St_Id=@StId and Exam_Num=@ExNum and Q_Id = @QId and Answer = @Ans
			
			end

		else if (@QType='MCQ')
			begin
				DECLARE @Corect bit = 0
				if exists (select Correct_Ans from Choice where Q_Id = @QId and Choice_Content = @Ans)
						set @Corect = 1
				update Stu_Exam_Question set Grade = @Corect where St_Id=@StId and Exam_Num=@ExNum and Q_Id = @QId and Answer = @Ans
			end

	fetch c1 into @QId,@Ans
	end
close c1
deallocate c1

DECLARE @TotGrade int = (select sum(grade) from Stu_Exam_Question where St_Id=@StId and Exam_Num=@ExNum)
DECLARE @CrNum int = (select Cr_Id from Exam where Ex_Num=@ExNum)

--insert into Stu_Courses values(@StId,@CrNum,@TotGrade)


update Stu_Courses set Cr_grade=@TotGrade where St_Id=@StId and Cr_Id=@CrNum