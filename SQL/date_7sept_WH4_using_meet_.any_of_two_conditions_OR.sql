create table stu1(cid int,cname varchar(20),cadd varchar(40))
insert into stu1 values(1,'vipin','nandanvan')
insert into stu1 values(2,'kumar','wadi')
insert into stu1 values(3,'shrwan','shantinagar')
insert into stu1 values(4,'lucky','bharat nagar')
insert into stu1 values(5,'ganesha','manish nagar')

select * from stu1 where cid>3 or cname='ganesha'
