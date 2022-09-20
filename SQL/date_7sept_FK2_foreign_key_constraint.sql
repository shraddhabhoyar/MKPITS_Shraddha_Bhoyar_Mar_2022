create table v_g(group_id int identity primary key,group_name varchar(100)not null)
create table v(vendor_id int identity primary key,vendor_name varchar(100)not null,group_id int not null,constraint mk_group foreign key( group_id) references v_g(group_id))
select * from v_g
insert into v(vendor_name,group_id) values('amita',1)
select * from v
insert into v_g values('mkpits')
select * from v_g
insert into v(vendor_name,group_id) values('amit',1)
select * from v
insert into v(vendor_name,group_id) values('arjun',2)
insert into v_g values('niit')
select * from v_g
insert into v(vendor_name,group_id) values('arjun',2)
select * from v
insert into v(vendor_name,group_id) values('arpita',2)
select * from v
