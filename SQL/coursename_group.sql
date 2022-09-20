create table mas(id int primary key,sname varchar(20),coursename varchar(20), city varchar(20))
insert into mas values(1,'rohit','dotnet','nagpur')
insert into mas values(2,'rohite','dotnet','nagpur')
insert into mas values(3,'rohito','dotnet','mumbai')
insert into mas values(4,'rohi','java','nagpur')
select * from mas
select coursename,count(*) from mas where city='nagpur' group by coursename

