use master;
go
drop database if exists kolokvij_vjezba_1;
go
create database kolokvij_vjezba_1  collate Croatian_CI_AS;
go
use kolokvij_vjezba_1;
go

create table sestra (
sifra int not null primary key identity (1,1),
introvertno bit,
haljina varchar(31) not null,
maraka decimal (16,6),
hlace varchar(46) not null,
narukvica int not null);

create table zena (
sifra int primary key not null identity (1,1),
treciputa datetime,
hlace varchar (46),
kratkamajica varchar(31) not null,
jmbag char(11) not null,
bojaociju varchar(39) not null,
haljina varchar(44),
sestra int not null);

create table muskarac(
sifra int not null primary key identity(1,1),
bojaociju varchar(50) not null,
hlace varchar (30),
modelnaocala varchar(43),
maraka decimal(14,5) not null,
zena int not null);

create table mladic(
sifra int primary key not null identity(1,1),
suknja varchar(50) not null,
kuna decimal(16,8) not null,
drugiputa datetime,
asocijalno bit,
ekstroventno bit not null,
dukserica varchar(48) not null,
muskarac int);

create table punac (
sifra int primary key not null identity (1,1),
ogrlica int,
gustoca decimal (14,9),
hlace varchar (41) not null);



create table cura (
sifra int primary key not null identity (1,1),
novcica decimal(16,5) not null,
gustoca decimal (18,6) not null,
lipa decimal(13,10),
ogrlica int not null,
bojakose varchar(38),
suknja varchar(36),
punac int not null);

create table sestra_svekar (
sifra int primary key not null identity(1,1),
sestra int not null,
svekar int not null);

create table svekar (
sifra int not null primary key identity(1,1),
bojaociju varchar(40) not null,
prstena int,
dukserica varchar(41),
lipa decimal(13,8),
eura decimal(12,7),
majica varchar(38));


alter table cura add foreign key (punac) references punac(sifra);
alter table zena add foreign key (sestra) references sestra(sifra);
alter table muskarac add foreign key (zena) references zena(sifra);
alter table mladic add foreign key (muskarac) references muskarac (sifra);
alter table sestra_svekar add foreign key (sestra) references sestra(sifra);
alter table sestra_svekar add foreign key (svekar) references svekar(sifra);

insert into sestra (introvertno, haljina, maraka, hlace, narukvica) values
(1,'plava',200.00,'siroke',10),
(0,'crna',500.00,'ljubicasta',20),
(1,'roza',100.00, 'lila',15),
(1,'zuta',130.00, 'bakrena',15);
select * from sestra;

insert into zena (treciputa,hlace,kratkamajica,jmbag, bojaociju,sestra) values
('2024-06-15', 'plave', 'zelena', '00111222333','zelena',2),
('2024-06-16', 'zelena', 'plava', '00111222334','siva',1),
('2024-06-17', 'crne', 'plave', '00111222333','smeda',3),
('2024-06-17', 'antracit', 'plave', '00111222335','smeda',4);
select * from zena;

insert into muskarac( bojaociju,hlace,modelnaocala, maraka, zena) values 
('plava','bijele','chanel',14.500,1),
('bijela','plave','rayban',2000,2),
('zelena','plave','plac',13.200,3);
select * from muskarac;

insert into mladic (suknja,kuna,drugiputa, asocijalno,ekstroventno,dukserica,muskarac) values
('plava', 16.20, '2024-11-03', 1, 1, 'plava',2),
('zuta', 20.50, '2024-06-15', 1, 0, 'zelena',1),
('lila', 50.20, '2024-06-22', 0, 0, 'bijela',3);
select* from mladic;

insert into punac (ogrlica, gustoca,hlace) values
(2, 20.80, 'zelenoplave'),
(13, 100.50, 'ljubicasta'),
(1, 5.2, 'bijela');
select * from punac;

insert into cura (novcica, gustoca, lipa, ogrlica, bojakose, suknja, punac) values
(50.50, 80.45, 15.60, 1, 'plava', 'zelena',1),
(20.40, 60.30, 15.70, 1, 'smeda', 'zuta',2),
(20.40, 70.90, 60.30, 1, 'lila', 'plava',3);
select*from cura;

insert into svekar (bojaociju, prstena, dukserica, lipa, eura, majica) values
('zelena', 2, 'zelena', 10.20, 2.40, 'plava'),
('plava', 26, 'siva', 60.40, 50.30, 'bijela'),
('narancasta', 2, 'zutozelena', 60.30, 1000.40, 'zuta');
select * from svekar;

insert into sestra_svekar(sestra,svekar) values
(1,1),
(4,2),
(3,3);
select * from sestra_svekar;



-- tablica cura gustoca na 15,77
select gustoca from cura;
update cura set gustoca = 15.77; 
--rijeseno

-- mladic obrisati sve zapise cija vrijednost kolone kuna veca od 15,78
-- unio sam jedan podatak za probu
select * from mladic;

delete mladic where kuna > 15.78;
-- rijeseno

-- iz tablice zena izlistajte kratka majica uz uvjte da hlace sadrze ana
select * from zena;
select kratkamajica from zena where hlace like '%ana%';

-- prikazati dukserica iz tablice svekar, socijalno iu tablice mladic te hlace iz tablice muskarac -- uvjet hlace u zena pocinje a, haljina u sestra sadrze ba
--posloziti po hlace muskarac silazno


select f.dukserica, d.asocijalno, c.hlace
from sestra a inner join zena b on a.sifra = b.sestra
inner join muskarac c on b.sifra = c.zena
inner join mladic d on c.sifra = d.muskarac
inner join sestra_svekar e on a.sifra = e.sestra
inner join svekar f on f.sifra = e.svekar
where b.hlace like 'a%' and a.haljina like '%ba%'
order by c.hlace;
-- ovo nisam rijesio



-- prikazati kolone haljina i maraka iz sestra ciji primarni kljuc se ne nalazi u tablici sestra_svekar
select a.haljina, a.maraka
from sestra a left join sestra_svekar b on a.sifra = b.sestra
