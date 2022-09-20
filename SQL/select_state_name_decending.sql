create database usp1
create table school1 (userid int,username varchar(20),userpass varchar(20),emailid varchar(20),gender varchar(20),country varchar(20))
insert into school1 values(1,'ankita','aaaa','ankita@gmail.com','female','india')
insert into school1 values(2,'aniket','bbbb','aniket1@gmail.com','male','china')
insert into school1 values(3,'reva','cccc','reva123@gmail.com','female','japan')
insert into school1 values(4,'kirti','dddd','kirti675@gmail.com','female','india')
insert into school1 values(5,'akshay','brtbb','akshay21@gmail.com','male','india')
insert into school1 values(6,'bhushan','retb','bhushan23@gmail.com','male','india')
insert into school1 values(7,'ankur','eeee','ankur341@gmail.com','male','indonesia')
insert into school1 values(8,'lax','gggg','laxb123@gmail.com','male','brazil')
insert into school1 values(9,'ravina','xyzz','ravina1234@gmail.com','female','india')
insert into school1 values(10,'sanjivani','ssss','sanju678@gmail.com','female','pakistan')
select * from school1 where country='india'
select * from school1 where country='india' order by username
select * from school1 where country='india' order by username desc


