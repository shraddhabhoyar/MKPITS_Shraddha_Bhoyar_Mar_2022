create table students3(id int primary key identity,admission_no varchar(30) not null,
first_name varchar(30)not null,last_name varchar(30) not null,age int,city varchar(30)not null)

create table fee3(admission_no varchar(30) not null,course varchar(30) not null,amount_paid varchar(30))

insert into students3 (admission_no,first_name,last_name,age,city)
values(3354,'Luisa', 'Evans', 13, 'Texas'),
       (2135, 'Paul', 'Ward', 15, 'Alaska'),       
    (4321, 'Peter', 'Bennett', 14, 'California'),    
    (4213,'Carlos', 'Patterson', 17, 'New York'),       
    (5112, 'Rose', 'Huges', 16, 'Florida'),  
    (6113, 'Marielia', 'Simmons', 15, 'Arizona'),    
    (7555,'Antonio', 'Butler', 14, 'New York'),       
    (8345, 'Diego', 'Cox', 13, 'California')

	insert into fee3(admission_no,course,amount_paid)
	values(3354,'Java', 20000),       
    (7555, 'Android', 22000),       
    (4321, 'Python', 18000),    
    (8345,'SQL', 15000),       
    (5112, 'Machine Learning', 30000)

	select * from students3
	select * from fee3

	

	SELECT students3.admission_no, students3.first_name, students3.last_name, Fee3.course, Fee3.amount_paid  
    FROM students3
    left outer join fee3 
    on students3.admission_no=fee3.admission_no


