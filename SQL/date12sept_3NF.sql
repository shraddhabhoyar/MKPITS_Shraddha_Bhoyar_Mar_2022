create table teachers11(teacher_id int primary key,teacher_name
varchar(20),country varchar(20),city varchar(20), state_id varchar(20))
insert into teachers11 values(1,'anita','india','nagpur','maharashtra')
insert into teachers11 values(2,'sarika','india','nagpur','maharashtra')
insert into teachers11 values(3,'ravina','india','nagpur','maharashtra')
insert into teachers11 values(4,'bhavika','india','nagpur','maharashtra')
insert into teachers11 values(5,'ambika','india','nagpur','maharashtra')




create table teachersone1(teacher_id int foreign key references teachers(teacher_id),
teacher_name varchar(20), state_id int primary key)
insert into teachersone1 values(1,'gokul',11),(2,'gopi',12)

select * from teachersone1



create table state112(state_id int foreign key references teachersone1 (state_id),
state_name varchar(20),country_id int primary key)
insert into state112 values(11,'maharashtra',100),(12,'mah',101)

select * from state112



create table country5(country_id int foreign key references state112(country_id),country_name varchar(20))
insert into country5 values (100,'india')
insert into country5 values (101,'shrilanka')
select * from country5

select * from teachers11
select * from teachersone1
select * from state112
select * from country5