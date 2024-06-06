 create database fakultet;

 use fakultet;

-- izrada tablice Ispitni rok

create table Ispitnirok(
sifra int primary key not null identity(1,1),
predmet varchar(50) not null,
vrstaispita varchar(50) not null,
datum date,
pristupio varchar(50) not null
);

--drop table if exists Ispitnirok;

-- izrada tablice Pristupnici

create table Pristupnici (
Ispitnirok int not null,
Student varchar(50) not null,
Brojbodova varchar(3) not null,
Ocjena char(1) not null
);
--drop table if exists Pristupnici;

alter table Pristupnici add foreign key (Ispitnirok) references Ispitnirok(sifra);

select * from Ispitnirok;

insert into Ispitnirok (Predmet, Vrstaispita,Datum,Pristupio) values
('Matematika','pismeno','2024-06-05 9:00','Tomislav Rogic'),
('Matematika','usmeno','2024-06-06 12:00','Tomislav Rogic'),
('Fizika','pismeno','2023-09-15 8:00','Tomislav Rogic'),
('Fizika','usmeno','2023-09-15 18:00','Tomislav Rogic');

select * from Pristupnici;

insert into Pristupnici (Ispitnirok,Student,Brojbodova,Ocjena) values
(1,'Tomislav Rogic',80,4),
(2,'Tomislav Rogic',50,2),
(3,'Tomislav Rogic',60,3),
(4,'Tomislav Rogic',55,3);




