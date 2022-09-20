create table students1(id int primary key identity,admission_no varchar(30) not null,
first_name varchar(30)not null,last_name varchar(30) not null,age int,city varchar(30)not null)

create table fee1(admission_no varchar(30) not null,course varchar(30) not null,amount_paid int)

insert into students1 (admission_no,first_name,last_name,age,city)
values(3354,'Luisa', 'Evans', 13, 'Texas'),
       (2135, 'Paul', 'Ward', 15, 'Alaska'),       
    (4321, 'Peter', 'Bennett', 14, 'California'),    
    (4213,'Carlos', 'Patterson', 17, 'New York'),       
    (5112, 'Rose', 'Huges', 16, 'Florida'),  
    (6113, 'Marielia', 'Simmons', 15, 'Arizona'),    
    (7555,'Antonio', 'Butler', 14, 'New York'),       
    (8345, 'Diego', 'Cox', 13, 'California')

	insert into fee1(admission_no,course,amount_paid)
	values(3354,'Java', 20000),       
    (7555, 'Android', 22000),       
    (4321, 'Python', 18000),    
    (8345,'SQL', 15000),       
    (5112, 'Machine Learning', 30000)

	select * from students1
	select * from fee1

	SELECT students1.admission_no, students1.first_name, students1.last_name, Fee1.course, Fee1.amount_paid  
    FROM students1  
    INNER JOIN Fee1  
    ON students1.admission_no = Fee1.admission_no;  



