create table orders(orderid int primary key,orddate date,custid int)
create table orderdetails(orderid int,product_name varchar(100),quantity int,constraint mk1 foreign key (orderid) references orders(orderid))
insert into orders values(1,'2022-9-7',110)
select * from orders
insert into orderdetails values(1,'mouse',12)
select * from orderdetails


