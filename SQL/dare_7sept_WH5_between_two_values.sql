create table orddate(ordid int,cname varchar(20),prodname varchar(20),quantity int,orddate date)
insert into orddate values(1,'lalit','pen',200,'2022-1-5')
insert into orddate values(2,'palit','pensil',200,'2022-9-7')
insert into orddate values(3,'yalit','paintbrush',200,'2022-6-4')
insert into orddate values(4,'talit','scale',200,'2022-7-3')
insert into orddate values(5,'galit','eraser',200,'2022-4-2')
select * from orddate where orddate between '2022-6-4' and '2022-9-7'

