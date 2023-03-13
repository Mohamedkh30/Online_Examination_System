create table Department (Dept_Id int primary key  , Dept_Name varchar(50) ,  Manager_Id int   ) 
create table Instructor (Ins_Id int primary key , Ins_Name varchar(50) , Ins_Email varchar(50) , Ins_Password varchar(50))
alter table Department add constraint Fk_dept_Ins  foreign key(Manager_Id) references Instructor(Ins_Id)
create table Student(St_Id int primary key , St_Name varchar(50) , Email varchar(50) , [Password] varchar(50) , Dept_Id int foreign key references Department (Dept_Id) )
create table Course (Cr_Id int primary key , Cr_Name varchar(50) )
create table Topic (Cr_Id int foreign key references Course(Cr_Id) , Topic_Name varchar(50) )
alter table Topic alter column Topic_Name varchar(100) not null 
alter table Topic alter column Topic_Name varchar(100) not null 
alter table Topic add constraint PK_Cr_Id_Topic_Name primary key (Cr_Id,Topic_Name)
create table Exam (Ex_Num int primary key , Cr_Id int foreign key references Course(Cr_Id) )
create table Question (Q_Id int primary key , Q_Content varchar(1000)  , [type] varchar(10) , Correct_Ans varchar (300) , Topic_Name varchar(100) , Cr_Id int )
alter table Question add constraint FK_Top_Name_Cr_Id foreign key (Cr_Id , Topic_Name)  references Topic(Cr_Id,Topic_Name)
create table Choice (Q_Id int foreign key references Question(Q_Id) , Choice_Content varchar (150) , primary key(Q_id, Choice_Content))
alter table Department add constraint Dept_manager foreign key(dept_Id) references instructor (ins_id)
create table Stu_Courses (St_Id int foreign key references Student(St_Id) , Cr_Id int foreign key references Course(Cr_Id) , primary key (St_Id , Cr_Id ) )
create table Ins_Dept_Cr(Ins_Id int foreign key references Instructor (Ins_Id) , Dept_id int foreign key references Department (Dept_Id) , Cr_Id int foreign key references Course (Cr_Id) , primary key (Ins_Id , Dept_Id , Cr_Id ))
create table Stu_Exam_Question (St_Id int foreign key references Student (St_Id) , Exam_Num int foreign key references Exam(Ex_Num) , Q_Id int  foreign key references Question (Q_Id), Answer varchar (400) , Grade float  )