create table v_g10(group_id int identity primary key,group_name varchar(100)not null)
create table v10(vendor_id int identity primary key,vendor_name varchar(100)not null,group_id int not null,constraint mk10_group foreign key( group_id) references v_g10(group_id))
select * from v_g10
insert into v10(vendor_name,group_id) values('amita',1)
select * from v10
insert into v_g10 values('mkpits')
select * from v_g10
insert into v10(vendor_name,group_id) values('amit',1)
select * from v10
insert into v10(vendor_name,group_id) values('arjun',2)
insert into v_g10 values('niit')
select * from v_g10
insert into v10(vendor_name,group_id) values('arjun',2)
select * from v10
insert into v10(vendor_name,group_id) values('arpita',2)
select * from v10

create table orders10(orderid int primary key,orddate date,custid int)
create table orderdetails12(orderid int,product_name varchar(100),quantity int,constraint mk10 foreign key (orderid) references orders10(orderid))
insert into orders10 values(1,'2022-9-7',110)
select * from orders10
insert into orderdetails12 values(1,'mouse',12)
select * from orderdetails12



select * from v_g10
delete from v_g10 where group_id=2
insert into v_g10 values('aptech')
select * from v_g10
select * from v10
delete from v_g10 where group_id=3
delete from orders10 where orderid=1

insert into orders10 values(2,'2022-9-7',102)
select * from orders10
insert into orderdetails12 values(2,'mouse',2)
select * from orderdetails12
delete from orders10 where orderid=2
delete from orderdetails12 where orderid=2
delete from orders10 where orderid=2




