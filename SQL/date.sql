create table stu3(sturno int,stuname varchar(20))
insert into stu3 values(1,'lalit')
insert into stu3 values(2,'palit')
insert into stu3 values(3,'yalit')
insert into stu3 values(4,'talit')
insert into stu3 values(5,'galit')
insert into stu3 values(6,'akshat')
insert into stu3 values(7,'swamya')

select * from stu3 where stuname like '%lit%'
