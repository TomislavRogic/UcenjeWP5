create database bazaopcine;
use bazaopcine;

create table Načelnici(
sifra int primary key not null identity(1,1),
Ime varchar(50) not null,
Prezime varchar (50) not null,
Datumrodenja date
);