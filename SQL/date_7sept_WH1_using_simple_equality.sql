create table cu(cid int,cname varchar(20),cadd varchar(40))
insert into cu values(112,'vipin','nandanvan')
insert into cu values(113,'kumar','wadi')
insert into cu values(114,'shrwan','shantinagar')
insert into cu values(115,'lucky','bharat nagar')
insert into cu values(116,'ganesha','manish nagar')
insert into cu values(117,'khushal','besa')
insert into cu values(118,'shakib','beltarodi')
insert into cu values(119,'rahim','saoner')
insert into cu values(120,'pintukumar','itwari')
insert into cu values(121,'kiran','mahal')
select *from cu where cid=112
select * from cu where cid>112
select * from cu where cname='lucky'
select * from cu where cadd='mahal' order by cid


