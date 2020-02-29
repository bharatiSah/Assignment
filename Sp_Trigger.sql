--To get All the Detail 1st Time
CREATE procedure Sp_SelectAll  
as  
begin  
delete from audittable  
Select  StudentName,CourseName,  Professor from Student    
Full join StudentEnrollment  
on Student.id = StudentEnrollment.StudentId  
full join Courses  
on Courses.CourseId = StudentEnrollment.CourseId  
full join Professors  
on Professors.CourseId = StudentEnrollment.CourseId  
end

---To get the change data 
CREATE proc Sp_Get_Change_Data  
as   
begin  
Select  a.StudentName , a.ActionType , a.ActionTable , professor  
from AuditTable a   
left join AuditTable b  
on a.StudentId = b.StudentEnrollment  
left outer join Professors   
on b.CourseId = Professors.CourseId  
end

--Trigger on table StudentEnrollment
CREATE trigger Tr_StudentEnrollment_Table  
on StudentEnrollment  
after insert,update,delete  
as   
begin  
--select * from inserted  
declare @studentid int,  
@CourseId  int  
  
Select @studentid = StudentId , @CourseId = CourseId from inserted  
Select @studentid  = StudentId , @CourseId = CourseId from deleted  
  
if exists(select * from inserted ) and not exists(Select * from deleted)  
exec Sp_AuditTable_For_StudentEnrollment 'StudentEnrollment' , 'Insert' , @studentid , @CourseId  
if exists(Select * from inserted) and exists (Select * from deleted)  
exec Sp_AuditTable_For_StudentEnrollment 'StudentEnrollment' , 'Update' , @studentid , @CourseId  
if exists(select * from deleted)  
exec Sp_AuditTable_For_StudentEnrollment 'StudentEnrollment', 'Delete' , @studentid , @CourseId  
end  
  
  
--trigger on table Student
 CREATE trigger Tr_Student_Table  
on Student   
after insert,update,delete  
as   
begin  
--select * from inserted  
declare @id int,  
@studentName nvarchar(30)  
  
Select @id = id , @studentName = StudentName from inserted  
Select @id  = id , @studentName = StudentName from deleted  
  
if exists(select * from inserted ) and not exists(Select * from deleted)  
exec Sp_AuditTable_For_Student 'Student' , 'Insert' , @id , @studentName  
if exists(Select * from inserted) and exists (Select * from deleted)  
exec Sp_AuditTable_For_Student 'Student' , 'Update' , @id , @studentName  
if exists(select * from deleted)  
exec Sp_AuditTable_For_Student 'Student', 'Delete' , @id , @studentName  
end


--Sp for AuditTable -- will execute in a trigger Tr_Student_Table  ---
CREATE proc Sp_AuditTable_For_Student  
@tableName nvarchar(30),  
@ActionType nvarchar (30),  
@Studentid int,  
@StudentName nvarchar(30)  
as   
begin  
insert into AuditTable (ActionTable,ActionType,StudentId,StudentName) values(@tableName,@ActionType,@Studentid,@StudentName)  
end


--Sp for AuditTable -- will execute in a trigger Tr_StudentEnrollment_Table  ---
create proc Sp_AuditTable_For_StudentEnrollment  
@tableName nvarchar(30),  
@ActionType nvarchar (30),  
@Studentid int,  
@CourseId int  
as   
begin  
insert into audittable (ActionType,ActionTable,StudentEnrollment,CourseId) values(@ActionType,@tableName,@Studentid,@CourseId)  
end