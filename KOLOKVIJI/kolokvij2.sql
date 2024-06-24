use master;
go

drop database if exists kolokvij_vjezba_2;
go

create database kolokvij_vjezba_2 collate Croatian_CI_AS;
go

use kolokvij_vjezba_2;
go

create table prijatelj (
sifra int primary key not null identity (1,1),
modelnaocala varchar(37),
treciputa datetime not null,
ekstroventno bit not null,
prviputa datetime,
svekar int not null);

create table svekar (
sifra int primary key not null identity(1,1),
stilfrizura varchar(48),
ogrlica int not null,
asocijalno bit not null);

create table decko (
sifra int primary key not null identity (1,1),
indiferentno bit,
vesta varchar(34),
asocijalno bit not null);

create table decko_zarucnica (
sifra int primary key not null identity(1,1),
decko int not null,
zarucnica int not null);

create table zarucnica (
sifra int primary key not null identity(1,1),
narukvica int,
bojakose varchar(37) not null,
novcica decimal(15,9),
lipa decimal(15,8) not null,
indiferentno bit not null);

create table cura (
sifra int primary key not null identity(1,1),
haljina varchar(33) not null,
drugiputa datetime not null,
suknja varchar(38),
narukvica int,
introvertno bit,
majica varchar(40) not null,
decko int
);

create table neprijatelj (
sifra int primary key not null identity(1,1),
majica varchar(32),
haljina varchar(32) not null,
lipa decimal(16,8),
modelnaocala varchar(49) not null,
kuna decimal(12,6) not null,
jmbag char(11),
cura int not null
);

create table brat (
sifra int primary key not null identity(1,1),
suknja varchar (47),
ogrlica int not null,
asocijalno bit not null,
neprijatelj int not null);




alter table prijatelj add foreign key(svekar) references svekar(sifra);
alter table decko_zarucnica add foreign key (decko) references decko(sifra);
alter table decko_zarucnica add foreign key (zarucnica) references zarucnica(sifra);
alter table cura add foreign key (decko) references decko(sifra);
alter table neprijatelj add foreign key (cura) references cura(sifra);
alter table brat add foreign key (neprijatelj) references neprijatelj(sifra);


-- unos u 3 atblice po 3 unosa
insert into decko(indiferentno, vesta,asocijalno) values
(1,'bijela',0),
(1,'zuta',1),
(0,'plava',0);
select* from decko;


insert into cura (haljina, drugiputa,suknja,narukvica,introvertno,majica,decko) values
('kratkabijela','2018-11-25 18:00','babsaduga',25,1,'kakibijela',1),
('zutosmeda','2019-10-25 16:00','poderana',12,0,'golublja',2),
('suncanoplava','2024-11-25 17:00','nikakva',10,1,'svakakva',3);

insert into decko_zarucnica (decko,zarucnica) values
(1,1),
(2,2),
(3,3);

insert into zarucnica (narukvica, bojakose,novcica,lipa,indiferentno) values
(20,'tamnoplava', 25.65, 85.90,0),
(1,'ljubicasta', 45.60, 30.20,1),
(3,'zelena', 87.30, 105.40,1);
select*from zarucnica;


insert into neprijatelj (majica, haljina,lipa,modelnaocala,kuna,jmbag,cura) values
('polo','kratkabijela',16.20,'rayban', 15100.45,'00123456987',2),
('nabretele','zutosmeda',100.20,'okulisticke', 20.50,'00124567897',4),
('otvorodostraga','suncanoplava',56.40,'crnekul', 56.45,'10105698745',3);
select * from cura;
select * from decko;
select*from neprijatelj;

--  U tablici prijatelj postavite svim zapisima kolonu treciputa na
-- vrijednost 30. travnja 2020. select * from prijatelj;update prijatelj set treciputa = '2020-04-3';-- U tablici brat obrišite sve zapise čija je vrijednost kolone ogrlica
-- različito od 14. delete from brat where ogrlica !=14;--  Izlistajte suknja iz tablice cura uz uvjet da vrijednost kolone
-- drugiputa nepoznate. (6)select suknja from cura where suknja is null;-- Prikažite novcica iz tablice zarucnica, neprijatelj iz tablice brat te
-- haljina iz tablice neprijatelj uz uvjet da su vrijednosti kolone
-- drugiputa iz tablice cura poznate te da su vrijednosti kolone vesta iz
-- tablice decko sadrže niz znakova ba. Podatke posložite po haljina iz
-- tablice neprijatelj silazno. select f.novcica, a.neprijateljfrom brat a inner join neprijatelj b on a.neprijatelj = b.sifrainner join cura c on b.cura = c.sifrainner join decko d on c.decko = d.sifrainner join decko_zarucnica e on d.sifra = e.deckoinner join zarucnica f on e.zarucnica = f.sifrawhere c.drugiputa is not null and d.vesta like '%ba%'order by b.haljina desc;-- Prikažite kolone vesta i asocijalno iz tablice decko čiji se primarni
-- ključ ne nalaze u tablici decko_zarucnica. select*from decko;select*from decko_zarucnica;select a.vesta, a.asocijalnofrom decko a left join decko_zarucnica b on a.sifra = b.deckowhere b.decko  != a.sifra 