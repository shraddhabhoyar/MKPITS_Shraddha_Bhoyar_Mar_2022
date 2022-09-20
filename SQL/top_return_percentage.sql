create table product2(productid int,prodname varchar(20),price int,qty int)
insert into product2 values(1,'pen',12,10)
insert into product2 values(2,'book',80,10)
insert into product2 values(3,'pencil',10,100)
insert into product2 values(4,'docket',100,20)
insert into product2 values(5,'markar',50,10)

select top 80 percent prodname,price from product2 order by price desc;