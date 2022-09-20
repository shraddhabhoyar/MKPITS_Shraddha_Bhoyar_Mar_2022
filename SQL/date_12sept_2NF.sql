create table teacher_detail(teacher_id int primary key,teacher_age int)
create table teacher_subject(teacher_id int, subject varchar(20),
constraint t1 foreign key(teacher_id) references teacher_detail (teacher_id))
insert into teacher_detail values (111,30)
insert into teacher_detail values (112,31)
insert into teacher_detail values (113,32)
insert into teacher_detail values (114,33)
insert into teacher_detail values (115,34)
insert into teacher_subject values(111,'physics')
insert into teacher_subject values(112,'chemistry')
insert into teacher_subject values(113,'maths')
insert into teacher_subject values(114,'geo')
insert into teacher_subject values(115,'history')


select * from teacher_detail
select * from teacher_subject
