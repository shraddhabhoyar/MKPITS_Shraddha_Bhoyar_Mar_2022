create table students2(id int primary key identity,admission_no varchar(30) not null,
first_name varchar(30)not null,last_name varchar(30) not null,age int,city varchar(30)not null)

create table fee2(admission_no varchar(30) not null,course varchar(30) not null,amount_paid int)

insert into students2 (admission_no,first_name,last_name,age,city)
values(3354,'Luisa', 'Evans', 13, 'Texas'),
       (2135, 'Paul', 'Ward', 15, 'Alaska'),       
    (4321, 'Peter', 'Bennett', 14, 'California'),    
    (4213,'Carlos', 'Patterson', 17, 'New York'),       
    (5112, 'Rose', 'Huges', 16, 'Florida'),  
    (6113, 'Marielia', 'Simmons', 15, 'Arizona'),    
    (7555,'Antonio', 'Butler', 14, 'New York'),       
    (8345, 'Diego', 'Cox', 13, 'California')

	insert into fee2(admission_no,course,amount_paid)
	values(3354,'Java', 20000),       
    (7555, 'Android', 22000),       
    (4321, 'Python', 18000),    
    (8345,'SQL', 15000),       
    (5112, 'Machine Learning', 30000)

	select * from students2
	select * from fee2

	

	SELECT students2.admission_no, students2.first_name, students2.last_name, Fee2.course, Fee2.amount_paid  
    FROM students2 
    cross JOIN Fee2 
    where students2.admission_no=fee2.admission_no


