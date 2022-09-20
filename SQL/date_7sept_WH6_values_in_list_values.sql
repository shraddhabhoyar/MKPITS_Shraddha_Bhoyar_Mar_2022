create table stu2(sturno int,stuname varchar(20))
insert into stu2 values(1,'lalit')
insert into stu2 values(2,'palit')
insert into stu2 values(3,'yalit')
insert into stu2 values(4,'talit')
insert into stu2 values(5,'galit')
select * from stu2 where sturno in (1,2,3,5)order by sturno desc