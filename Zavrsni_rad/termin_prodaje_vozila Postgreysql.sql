-- Database: termin_prodaje_vozila
SET search_path TO postgres;
-- prikaz trenutne aktivne baze
SELECT current_database();



-- za brisanje u odnosu na mssql trebamo dodati with(force)
-- DROP DATABASE IF EXISTS termin_prodaje_vozila with(force);

-- ovako se brise database
-- DROP DATABASE termin_prodaje_vozila;


CREATE DATABASE termin_prodaje_vozila
    WITH
    OWNER = postgres
    ENCODING = 'UTF8'
    LC_COLLATE = 'English_United States.1252'
    LC_CTYPE = 'English_United States.1252'
    LOCALE_PROVIDER = 'libc'
    TABLESPACE = pg_default
    CONNECTION LIMIT = -1
    IS_TEMPLATE = False;


-- kod kreiranja tablica vise ne pisemo sifra int primary key identity(1,1)
create table Osobe(
Sifraosoba serial primary key not null ,
Ime varchar(30) not null,
Prezime varchar(30) not null,
Email varchar(50) not null
);
drop table if exists vozila;

--SELECT current_database();

create table Vozila(
Sifravozila serial primary key not null ,
Marka varchar(100) not null,
Opisvozila varchar(100),
Cijena decimal(10,3)
);

-- kada unosimo datetime u sqlu u Postgresqlu je to timestamp
create table Termini(
Sifratermina serial primary key not null ,
Osobe int not null,
Vozila int not null,
Termin timestamp
);

alter table termini add constraint fk_sifraosoba foreign key (Osobe) references Osobe(sifraosoba);
alter table termini add constraint fk_sifravozila foreign key (Vozila) references Vozila(sifravozila);

-- dodavanje podataka u tablicu Osobe
insert into Osobe (Ime,Prezime,Email) values
('Tomislav','Rogic','tomislav.rogic@gmail.com'),
('Kristina','Andric','kristinaadric13@gmail.com'),
('Hans', 'Grubner','hans.grubner@siol.at'),
('Markus','Walter','markus13@gmail.com'),
('Pierce','Brosnan','pierce.brosnan@gmail.com'),
('Milan','Prodanovic','milan.prodanovic@gmail.com');
select * from Osobe;

--dodavanje podataka u tablicu Vozila



insert into Vozila (Marka,Opisvozila,Cijena) values
('Opel Mokka','2.2, dizel, 2017. godina, crna, 113.000 km, 5 sjedala, R17, prvi vlasnik',20.200),
('Bmw X4','3.0, dizel, 2021.godina, bijela, 32.000 km, 5 sjedala, R 19, prvi vlasnik', 30.800),
('Audi A4','2.2, dizel, 2020. godina, plava, 100.000 km, 5 sjedala, R 17, prvi vlasnik', 25.000),
('Mazda CX5','2.2, benzin, 2021. godina, bijela, 54.000 km, 5 sjedala, R 19, prvi vlasnik',30.500);
select * from Vozila;

-- dodavanje podataka u tablicu Termini

drop table if exists osobe;


insert into Termini (Osobe,Vozila,Termin) values
(1,1,'2024-06-10 10:00'),
(2,4,'2024-06-10 12:00'),
(3,1,'2024-06-11 13:00'),
(6,3,'2024-06-10 15:00'),
(5,2,'2024-06-11 09:30'),
(4,2,'2024-06-11 11:30');  
select * from Termini;