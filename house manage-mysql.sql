create database house;
use house;
show tables;
create table admin_logs(
ID int auto_increment primary key,
NAME varchar(100),
UNAME varchar(100),
UPASS varchar(100)
);

create table Family_Details(
LID int auto_increment primary key,
NAME varchar(30),
ROLE varchar(30),
AGE varchar(5),
WORK varchar(30),
INCOME varchar(30)
);

create table Shopping_Details(
TID int auto_increment primary key,
LID int,
NAME varchar(30),
TDATE date,
DETAILS text,
PTYPE varchar(20),
ITEM varchar(30),
QUANTITY decimal(10,2),
RATE decimal(10,4)
);

select * from admin_logs;
insert into admin_logs (NAME,UNAME,UPASS) values ("Rasu","admin","admin");
