create table Student 
(
id int identity (1,1) primary key,
StudentName nvarchar (50)
);

create table Courses
(
CourseId int primary key ,
CourseName nvarchar(50)
);

create table Professors
(
professor nvarchar(50),
CourseId int,
Foreign key (CourseId) references Courses(CourseId),
)

create table StudentEnrollment
(
StudentId int ,
CourseId int,
Foreign key (StudentId) references Student (id),
Foreign key (CourseId) references Courses (CourseId)
);

insert into Student values ('A')
insert into Student values ('B')
insert into Student values ('C')
insert into Student values ('D')
insert into Student values ('E')
insert into Student values ('F')
insert into Student values ('G')
insert into Student values ('H')
insert into Student values ('I')
insert into Student values ('J')



INSERT INTO Courses	 VALUES (101 ,	'English')
INSERT INTO Courses	 VALUES (102 ,	'Mathematics')
INSERT INTO Courses	 VALUES (103 ,	'Physics')
INSERT INTO Courses	 VALUES (104 ,	'Chemistry')
INSERT INTO Courses	 VALUES (105 ,	'Political Science')
INSERT INTO Courses	 VALUES (106 ,	'History')
INSERT INTO Courses	 VALUES (107 ,	'Computer Administration')
INSERT INTO Courses	 VALUES (108 ,	'Geography')




insert into Professors values ('Anil', 101)
insert into Professors values ('Anil', 106)
insert into Professors values ('Anil' , 105)
insert into Professors values ('Suresh' , 103)
insert into Professors values ('Suresh' , 102)
insert into Professors values ('Mohan' , 107)
insert into Professors values ('Mohan' , 104)
insert into Professors values ('Abhay' , 108)

insert into	StudentEnrollment values (1, 101)
insert into	StudentEnrollment values (2, 101)
insert into	StudentEnrollment values (2, 104)
insert into	StudentEnrollment values (3, 103)
insert into	StudentEnrollment values (3, 101)
insert into	StudentEnrollment values (3, 107)
insert into	StudentEnrollment values (4, 105)
insert into	StudentEnrollment values (4, 106)
insert into	StudentEnrollment values (4, 102)
insert into	StudentEnrollment values (5, 103)
insert into	StudentEnrollment values (5, 107)
insert into	StudentEnrollment values (6, 108)
insert into	StudentEnrollment values (7, 108)
insert into	StudentEnrollment values (7, 103)
insert into	StudentEnrollment values (7, 105)
insert into	StudentEnrollment values (8, 104)
insert into	StudentEnrollment values (9, 104)
insert into	StudentEnrollment values (9, 101)
insert into	StudentEnrollment values (10, 102)

create table AuditTable
(
ActionType nvarchar(30),
ActionTable nvarchar(30),
StudentId int ,
StudentName nvarchar(30),
CourseId int,
StudentEnrollment int
)