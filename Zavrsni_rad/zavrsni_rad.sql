--use master;
--go

--drop database  if exists zavrsni_rad;
--go

--create database zavrsni_rad;
--go

--use zavrsni_rad;
--go


-- izrada tablice Osobe

--create table Osobe(
--sifraosoba int primary key not null identity(1,1),
--Ime varchar(30) not null,
--Prezime varchar(30) not null,
--Email varchar(50) not null
--);

-- izrada tablice Vozila

--create table Vozila(
--sifravozila int primary key not null identity(1,1),
--Marka varchar(100) not null,
--Opisvozila varchar(100),
--Cijena decimal(10,2)
--);

-- izrada tablice Termini

--create table Termini(
--sifratermina int primary key not null identity(1,1),
--Osobe int not null,
--Vozila int not null
--);


-- dodavanje foreign keya

--alter table Termini add foreign key (Osobe) references Osobe(sifraosoba);
--alter table Termini  add foreign key (Vozila) references Vozila(sifravozila);

