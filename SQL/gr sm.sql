create database lib
create table li(cid int,cname varchar(20),cadd varchar(40))
insert into li values(112,'vipin','nandanvan')
insert into li values(113,'kumar','wadi')
insert into li values(114,'shrwan','shantinagar')
insert into li values(115,'lucky','bharat nagar')
insert into li values(116,'ganesha','manish nagar')
insert into li values(117,'khushal','besa')
insert into li values(118,'shakib','beltarodi')
insert into li values(119,'rahim','saoner')
insert into li values(120,'pintukumar','itwari')
insert into li values(121,'kiran','mahal')
select * from li where cid=112
select * from li where cid>112
select * from li where cid>112 and cid<121



