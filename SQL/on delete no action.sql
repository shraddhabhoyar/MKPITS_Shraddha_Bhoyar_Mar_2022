create table vend_group11(group_id int identity primary key,group_name varchar(100)not null)

CREATE TABLE vend22 (
        vendor_id INT IDENTITY PRIMARY KEY,
        vendor_name VARCHAR(100) NOT NULL,
        group_id INT NOT NULL,
        constraint csp  foreign key(group_id)
        references vend_group11(group_id)
        on delete no action
        
        )
		insert into vend_group11(group_name) values('amita')
		select * from vend_group11
        insert into vend22(vendor_name,group_id) values('amit',1)
		select * from vend22

delete from vend_group11 where group_id=1
