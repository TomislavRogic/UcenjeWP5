
use master;
go
drop database if exists edunovawp5;
go
create database edunovawp5;
go
use edunovawp5;

create table smjerovi(
sifra int not null primary key identity(1,1),
naziv varchar(50) not null,
cijena decimal(18,2) null, --ali se null ne piše, jer se to avtomaski zna
brojsati int,
izvodiseod datetime,
vaucer bit
);

create table grupe(
sifra int not null primary key identity(1,1),
naziv varchar(20) not null,
brojslobodnihmjesta int not null,
datumpocetka datetime,
smjer int not null,
predavac varchar(50)
);

create table polaznici(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
email varchar(100),
oib char(11)
);

create table clanovi(
grupa int not null,
polaznik int not null
);

alter table grupe add foreign key (smjer) references smjerovi (sifra);
alter table clanovi add foreign key (grupa) references grupe (sifra);
alter table clanovi add foreign key (polaznik) references polaznici (sifra);