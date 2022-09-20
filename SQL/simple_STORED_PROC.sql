
create table product(productid int,prodname varchar(20),price int,qty int)
insert into product values(1,'pen',12,10)
insert into product values(2,'pencil',12,10)
insert into product values(3,'marker',12,10)
insert into product values(4,'notebook',12,10)

select*from product

create procedure prod1
as
 begin
 select * from product
 end

 exec prod1
