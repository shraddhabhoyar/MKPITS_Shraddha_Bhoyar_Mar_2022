create table idn(firstname varchar(20),lastname varchar(20),coursename varchar(20), city varchar(20),sta varchar(20))
insert into idn values('rohit','kumar','dotnet','nagpur','mah')
insert into idn values('laxmi','rai','dotnet','nagpur','mah')
insert into idn values('chetan','shastri','dotnet','mumbai','mah')
insert into idn values('hema','naidu','java','nagpur','mah')
select * from idn
select firstname,lastname,coursename,city,sta from idn order by firstname
select firstname,lastname from idn order by firstname,lastname
select firstname,lastname from idn order by firstname desc
select firstname,lastname from idn order by firstname asc
select firstname from idn order by LEN(firstname)desc;

