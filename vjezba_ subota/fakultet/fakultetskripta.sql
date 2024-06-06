-- create database fakultet;

 use fakultet;

-- izrada tablice Ispitni rok

create table Ispitnirok(
sifra int primary key not null identity(1,1),
predmet varchar(50) not null,
vrstaispita varchar(50) not null,
datum date,
pristupio varchar(50) not null
);

drop table if exists Ispitnirok;

-- izrada tablice Pristupnici

create table Pristupnici (
Ispitnirok int not null,
Student varchar(50) not null,
Brojbodova varchar(3) not null,
Ocjena char(1) not null
);
drop table if exists Pristupnici;

alter table Pristupnici add foreign key (Ispitnirok) references Ispitnirok(sifra);


