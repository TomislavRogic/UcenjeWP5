-- spajanje na bazu phpadmin
# komentar

-- naredba use ne smije se izvoditi u kombinaciji s drugim naredbama jer nece funkcionirati, mora se koristiti zasebno
use phpmyadmin;

drop database if exists termin_prodaje_vozila;

-- za razliku od sqla u mysqlu za dobivanje hrvatskih dijaktickih znakova ne koristimo collate Croatian_CI_AS nego character set utf8mb4
--  collate utf8mb4_croatian_ci;

create database termin_prodaje_vozila
    character set utf8mb4
    collate utf8mb4_croatian_ci;

   -- popis svih collate za hrvatski jezik
   show collation like '%croatian%';

use termin_prodaje_vozila;

-- umjesto identity (1,1) pisemo auto_increment
create table Osobe(
Sifraosoba int primary key auto_increment,
Ime varchar(30) not null,
Prezime varchar(30) not null,
Email varchar(50) not null
);

-- drop database if exists osobe;

create table Vozila(
Sifravozila int primary key not null auto_increment,
Marka varchar(100) not null,
Opisvozila varchar(100),
Cijena decimal (10,3) 
);

-- drop database if exists vozila;

create table Termini(
Sifratermina int primary key not null auto_increment,
Osobe int not null,
Vozila int not null,
Termin datetime
);

-- dodavanje vanjskih kljuceva
alter table Termini add foreign key (Osobe) references Osobe(sifraosoba);
alter table Termini  add foreign key (Vozila) references Vozila(sifravozila);

insert into Osobe (Ime,Prezime,Email) values
('Tomislav','Rogić','tomislav.rogic@gmail.com'),
('Kristina','Andrić','kristinaadric13@gmail.com'),
('Hans', 'Grubner','hans.grubner@siol.at'),
('Markus','Walter','markus13@gmail.com'),
('Pierce','Brosnan','pierce.brosnan@gmail.com'),
('Milan','Prodanović','milan.prodanovic@gmail.com');
select * from Osobe;


-- kod unosenja cijene ne smijemo stavljati tocku izmedu
insert into Vozila (Marka,Opisvozila,Cijena) values
('Opel Mokka','2.2, dizel, 2017. godina, crna, 113.000 km, 5 sjedala, R17, prvi vlasnik',20200),
('Bmw X4','3.0, dizel, 2021.godina, bijela, 32.000 km, 5 sjedala, R 19, prvi vlasnik', 30800),
('Audi A4','2.2, dizel, 2020. godina, plava, 100.000 km, 5 sjedala, R 17, prvi vlasnik', 25000),
('Mazda CX5','2.2, benzin, 2021. godina, bijela, 54.000 km, 5 sjedala, R 19, prvi vlasnik',30500);

-- nije mi cijenu htjelo pokazati na 3 decimale

-- SELECT Sifravozila, Marka, Opisvozila, FORMAT(Cijena, 3) AS Cijena FROM Vozila;
select * from Vozila;
-- dodavanje podataka u tablicu Termini



insert into Termini (Osobe,Vozila,Termin) values
(1,1,'2024-06-10 10:00'),
(2,4,'2024-06-10 12:00'),
(3,1,'2024-06-11 13:00'),
(6,3,'2024-06-10 15:00'),
(5,2,'2024-06-11 09:30'),
(4,2,'2024-06-11 11:30');  
select * from Termini;
