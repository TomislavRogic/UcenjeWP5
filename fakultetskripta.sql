-- create database fakultet;

-- use fakultet;

-- izrada tablice Ispitni rok

create table Ispitnirok(
sifra int primary key not null,
predmet varchar(50) not null,
vrstaispita varchar(50) not null,
datum date,
pristupio varchar(50) not null
);

-- izrada tablice Pristupnici

create table Pristupnici (
Ispitnirok int not null,
Student varchar(50) not null,
Brojbodova varchar(3) not null,
Ocjena char(1) not null
);

