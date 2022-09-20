create table product1(productid int,prodname varchar(20),price int,qty int)
insert into product1 values(1,'pen',12,10)
insert into product1 values(2,'book',80,10)
insert into product1 values(3,'pencil',10,100)
insert into product1 values(4,'docket',100,20)
insert into product1 values(5,'markar',50,10)

select top 3 prodname,price from product1 order by price desc;