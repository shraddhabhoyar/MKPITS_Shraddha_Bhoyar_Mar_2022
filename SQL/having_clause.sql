create table uniq(id int primary key,sname varchar(20),coursename varchar(20), city varchar(20),st varchar(20))
insert into uniq values(1,'rohit','dotnet','nagpur','mah')
insert into uniq values(2,'rohite','dotnet','nagpur','mah')
insert into uniq values(3,'rohito','dotnet','mumbai','mah')
insert into uniq values(4,'rohi','java','nagpur','mah')
select * from uniq
select city,count(*) from uniq where st='mah' group by city
select city,count(*) from uniq where st = 'mah' group by city having count(*) > 2

