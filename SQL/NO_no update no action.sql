create table vendor1234_group(group_id int identity primary key,group_name varchar(100)not null)

   CREATE TABLE vendors (
        vendor_id INT IDENTITY PRIMARY KEY,
        vendor_name VARCHAR(100) NOT NULL,
        group_id INT ,
        constraint mk1234  foreign key(group_id)
        references vendor1234_group(group_id)
        on update no action
        
        )
        insert into vendor1234_group values('raisonic')
        select * from vendor1234_group
        select * from vendors
        insert into vendors values('amit',4)
         select * from vendors
	
   select * from vendor1234_group
   update vendor1234_group set group_id=5 where group_id=4
