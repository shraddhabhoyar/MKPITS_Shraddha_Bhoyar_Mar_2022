create table vend_group(group_id int identity primary key,group_name varchar(100)not null)
CREATE TABLE vend1 (
        vendor_id INT IDENTITY PRIMARY KEY,
        vendor_name VARCHAR(100) NOT NULL,
        group_id INT NOT NULL,
        constraint cs  foreign key(group_id)
        references vend_group(group_id)
        on delete no action
        
        )
insert into vend values('amit',4)
delete from vend_group where group_id=1
drop table vend 
create table vend (vendor_id INT IDENTITY PRIMARY KEY,
        vendor_name VARCHAR(100) NOT NULL,
        group_id INT NOT NULL,
        constraint fk2  foreign key(group_id)
        references vend_group(group_id)
        on delete cascade
        
        )
		insert into vend values('amit',1)
        select * from vend_group
        select * from vend
        delete from vend_group where group_id=1
            select * from vend_group
             select * from vend


