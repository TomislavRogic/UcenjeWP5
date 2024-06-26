select * from grupe;

select * from smjerovi where sifra=1;

-- inner join naredba
-- kuharica prema materijalima


-- spajamo naziv grupe i naziv smjera
-- pokazuje samo smjerove koji imaju grupu
select a.naziv as smjer, b.naziv as grupa
from smjerovi a inner join grupe b
on a.sifra = b.smjer;

-- pokazuje smjerove i onda kad smjer nema odabranu grupu
select a.naziv as smjer, 
b.naziv as grupa,

from smjerovi a left join grupe b
on a.sifra = b.smjer


-- sada spajamo grupe s clanovima da bi dosli do polaznika
select 
a.naziv as smjer,
b.naziv as grupa,
d.ime, d.prezime
from smjerovi a inner join grupe b
on a.sifra = b.smjer
inner join clanovi c on b.sifra=c.grupa
inner join polaznici d on c.polaznik=d.sifra
where d.ime like 'P%'
order by 4

-- broj clanova po grupi
select a.naziv, count(b.polaznik) as polaznika
from grupa a inner join clanovi b
on a.sifra=b.grupa
group by a.naziv

-- ako nas zanimaju samo grupe gdje ima vise od 5 polaznika
having count(b.polaznik)>5;

use svastara;


-- zelim vidjeti sve nazive mjesta u Osjecko-Baranjskoj zupaniji
select a.naziv, b.naziv as opcina, c.naziv as zupanija
from mjesta a inner join opcine b
on a.opcina = b.sifra
inner join zupanije c on b.zupanija=c.sifra
where c.naziv like '%baranj%'
order by 1;

-- koja opcina u osjecko-baranjskoj ima najveci broj mjesta?
select  b.naziv as opcina, count(a.sifra) as mjesta
from mjesta a inner join opcine b
on a.opcina = b.sifra
inner join zupanije c on b.zupanija=c.sifra
where c.naziv like '%split%'
group by b.naziv
order by 2 desc;


-- Uprava tvtke Svastara d.o.o. je odlucila 2018
-- 5 direktora svojih dobavljaca odvesti
-- na krstarenje. Koga ce povesti?

select top 5 a.naziv, 
sum(c.kolicina*c.cijena) as ukupno,
min(c.kolicina*c.cijena) as minimalno,
max(c.kolicina*c.cijena) as maksimalno
from Dobavljaci a inner join Primke b
on a.sifra=b.dobavljac
inner join ArtikliNaPrimci c on b.sifra=c.primka
where b.datum between '2017-01-01' and '2017-12-31'
group by a.naziv
having min(c.kolicina*c.cijena)>0
order by 3 desc, 2 desc;

-- izlistajte imena i prezimena kupaca koji dolaze iz mjesta u kojem vi zivite
select b.*
from mjesta a inner join kupci b
on a.sifra = b.mjesto
where a.naziv  in ('Osijek','Punitovci');

-- idete svatove i planirate kupiti poklon
-- u rasponu 1000-1100 eura, koliko artikala mozete kupiti?

select * from artikli where cijena between 1000 and 1100
order by 6 desc;

select count(*) from artikli;

select distinct artikl from artiklinaprimci;


-- razlika izmedu ukuonog broja artikla i artikla na primci je 2, kako to pronaci
select * from artikli where
sifra not in (select distinct artikl from artiklinaprimci);

-- obrisite ih
delete from artikli where
sifra not in (select distinct artikl from artiklinaprimci);

-- unesite sebe kao kupca s mjestom u kojem zivite

select * from kupci;
select * from kupci where prezime like 'Andri%' and ime like 'Kristina%';
insert into kupci (ime,jmbg,prezime,adresa,mjesto) values
('Tomislav','003256565898','Rogic','Gustava Krkleca 34',10000);



select naziv, count(*)
from mjesta group by naziv
having count(*)>1
order by 2 desc;
