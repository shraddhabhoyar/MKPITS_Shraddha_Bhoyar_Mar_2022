create table v_group(group_id int identity primary key,group_name varchar(100)not null)
create table vv(vendor_id INT IDENTITY PRIMARY KEY,
        vendor_name VARCHAR(100) NOT NULL,
        group_id INT ,
        constraint cc  foreign key(group_id)
        references v_group(group_id)
        on delete set null
        
        )
		insert into v_group values('tcs')
        insert into vv values('amitabh',1)
        delete from v_group where group_id=2
        select * from v_group
             select * from vv

