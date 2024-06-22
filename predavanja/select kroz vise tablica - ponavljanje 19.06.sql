use edunovawp5;

select * from grupe;

select * from smjerovi where sifra=1;

-- inner join naredba
-- kuharica prema materijalima
-- zelimo dovuci naziv grupe i naziv smjera u istoj relaciji
-- tablicama dajemo zamjenska imena naredbom as isto kao i kolonama
-- buduci da koristimo inner join svejedno je koju tablicu prvu navodimo
-- tablicama mjenjamo ime prema algoritmu, odnosno abecedeom po redu jer mozemo imati vise tablica
select a.naziv, b.naziv
from smjerovi a inner join grupe b
-- zatim navodimo nacin na koji spajamo tablice, 
-- tj. unutarnji dio a mi sada zelimo spojiti naziv iz smjera s nazivom i grupe
-- veza u tablici smjerovi je sifra, 
-- a u tablici grupe je smjer (int odnosno foreign key tablice smjerovi)
on a.sifra = b.smjer
-- sada se vracamo u red select i kazemo a.naziv, 
--b.naziv (vjerovatno upisuje ono sto zelimo selektirati)
-- naredbom nize izvukli smo sve nazive smjerova i sve nazive grupa
--select a.naziv, b.naziv
--from smjerovi a inner join grupe b
--on a.sifra = b.smjer

-- sada imamo dva puta tekst naziv i zelimo preimenovati a u smjer a b u grupu
select a.naziv as smjer, b.naziv as grupa
from smjerovi a inner join grupe b
on a.sifra = b.smjer
-- sada dodemo do smisla relacijske baze podataka
-- u smjerovima smo imali jos i ovo ('ČŠĆĐŽ čšćđž') 
--ali se ne prikazuje jer ovaj smjer nema grupu

-- ako zelimo selektirati sve smjerove i one koji imaju grupu i one koji nemaju (tada ce nam pisati null) pisemo dalje
-- smjer čžć ima smjer koji je na lijevoj strani a nema grupe koja je na desnoj strani
select a.naziv as smjer, b.naziv as grupa
from smjerovi a left join grupe b
on a.sifra = b.smjer


-- ako nas zanimaju polaznici na grupi WP5 odnosno smjer web programiranje i polaznici grupe WD1 odnosno smjer web dizajn
-- ne mozemo direktno spojiti grupu i polaznike nego moramo ici preko clanova jer clanovi imaju vanjske kljuceve
select a.naziv as smjer, b.naziv as grupa
from smjerovi a inner join grupe b
on a.sifra = b.smjer
inner join clanovi c on b.sifra = c.grupa
-- sada smo spojili tablicu grupe s tablicom clanovi
inner join polaznici d on c.polaznik = d.sifra
-- vracamo se u select listu
select 
a.naziv as smjer, 
b.naziv as grupa,
d.ime, d.prezime
from smjerovi a inner join grupe b
on a.sifra = b.smjer
inner join clanovi c on b.sifra = c.grupa
inner join polaznici d on c.polaznik = d.sifra
-- sada smo dobili popis smjerova,popis grupa i popis polaznika

-- sada mozemo koristiti naredbu where, odnosno selektiramo ime iz tablice d koje pocinje s P
select 
a.naziv as smjer, 
b.naziv as grupa,
d.ime, d.prezime
from smjerovi a inner join grupe b
on a.sifra = b.smjer
inner join clanovi c on b.sifra = c.grupa
inner join polaznici d on c.polaznik = d.sifra
where d.ime like 'P%';


-- sada cemo probat selektirati po 4 koloni uzlazno i selektira nam po prezimenu
select 
a.naziv as smjer, 
b.naziv as grupa,
d.ime, d.prezime
from smjerovi a inner join grupe b
on a.sifra = b.smjer
inner join clanovi c on b.sifra = c.grupa
inner join polaznici d on c.polaznik = d.sifra
where d.ime like 'P%'
order by 4;


-- sada nas zanima koliko ima clanova u grupi wp5 a koliko clanova u grupi wd1
-- broj clanova po grupi
-- koristimo tablicu grupe i kolonu naziv,a u tablici clanovi pise koji pokaznik ide u koju grupu
select a.naziv, count(b.polaznik) as polaznika
from grupe a inner join clanovi b
on a.sifra = b.grupa
group by a.naziv;
-- sada mozemo jos grupirati po grupi i dodajemo da nam grupira prema nazivu i tablice a


-- sada mozemo vidjeti i polaznika po grupi s najmanjom sifrom
select a.naziv, min(b.polaznik) as polaznika
from grupe a inner join clanovi b
on a.sifra = b.grupa
group by a.naziv;

-- naredba where filtrira fizicke podatke
-- ako zelimo izvesti 5 i 30 koji nisu fizicki podaci nego su podaci dobiveni iz selekta tada moramo ici s naredbom having
select a.naziv, count(b.polaznik) as polaznika
from grupe a inner join clanovi b
on a.sifra=b.grupa
group by a.naziv
having count(b.polaznik)>5;
-- odnosno zanimaju me samo one grupe koje imaju vise od 5 polaznika
-- ovo je kao agregirana funkcija

use svastara;

select naziv from zupanije where sifra = 14;

select a.naziv as Naziv_mjesta, c.naziv as Zupanija
from mjesta a inner join Opcine b
on a.opcina = b.sifra
inner join Zupanije c
on b.zupanija = c.sifra
where c.sifra =14
order by 1;

select b.naziv as Naziv_opcine, count (a.sifra) as ukupan_broj_mjesta
from mjesta a inner join Opcine b
on a.opcina = b.sifra
inner join Zupanije c
on b.zupanija = c.sifra
where c.sifra =14
group by b.naziv
order by 2 desc;


-- zelimo vidjeti sve nazive mjesta u osjeckoj baranjskoj zupaniji
-- naziv mjesta se nalazi u tablici mjesta a naziv zupanije u zupanije
-- moramo spojiti tablice zupanije, opcine i mjesta
-- naziv iz tablice b nazivamo opcina s as opcina
-- naziv iz tablice c nazivamo opcije
select a.naziv,b.naziv as opcina, c.naziv as zupanija
from mjesta a inner join opcine b on a.opcina = b.sifra
inner join zupanije c on b.zupanija = c.sifra
where c.naziv like '%baranj%'
order by 1;

-- koja opcina u Osjecko-baranjskoj zupaniji ima najvise mjesta
-- selektirali smo samo naziv opcine i broj mjesta s count iz tablice mjesta
-- poslozili smo po drugoj koloni (mjesta) silazno od veceg prema manjeg
select b.naziv as opcina, count(a.sifra) as mjesta
from mjesta a inner join opcine b on a.opcina = b.sifra
inner join zupanije c on b.zupanija = c.sifra
where c.naziv like '%baranj%'
group by b.naziv
order by 2 desc;

-- ako zelimo vidjeti koja opcina ima najmanje mjesta samo pisemo order by 2
select b.naziv as opcina, count(a.sifra) as mjesta
from mjesta a inner join opcine b on a.opcina = b.sifra
inner join zupanije c on b.zupanija = c.sifra
where c.naziv like '%baranj%'
group by b.naziv
order by 2;

-- sada zelimo vidjeti u medimurskoj zupaniji
select b.naziv as opcina, count(a.sifra) as mjesta
from mjesta a inner join opcine b on a.opcina = b.sifra
inner join zupanije c on b.zupanija = c.sifra
where c.naziv like '%medimu%'
group by b.naziv
order by 2;

-- u splitsko dalmatinskoj
select b.naziv as opcina, count(a.sifra) as mjesta
from mjesta a inner join opcine b on a.opcina = b.sifra
inner join zupanije c on b.zupanija = c.sifra
where c.naziv like '%split%'
group by b.naziv
order by 2 desc;

-- Uprava tvtke Svastara d.o.o. je odlucila 2018
-- 5 direktora svojih dobavljaca odvesti
-- na krstarenje. Koga ce povesti?

select a.naziv, sum(c.kolicina*c.cijena) as ukupno
from Dobavljaci a inner join Primke b 
on a.sifra=b.dobavljac
inner join ArtikliNaPrimci c on b.sifra=c.primka
where b.datum between '2017-01-01' and '2017-12-31'
group by a.naziv
order by 2 desc;
-- treba paziti da ubacimo group jer inace naredba nece raditi
-- kada zelimo nesto zbrojiti ili izvaditi prosjek
-- inace bi program pokusao zbrojiti sve vrijednosti ne razdvajajuci ih prema dobavljacu

select * from ArtikliNaPrimci

select top 5 c.naziv as naziv_dobavljaca, 
sum(a. kolicina * a.cijena) as ukupna_cijena,
min(a. kolicina * a.cijena) as minimalna_cijena, 
max (a. kolicina * a.cijena) as maksimalna_cijena
from ArtikliNaPrimci a inner join Primke b
on a.primka = b.sifra
inner join dobavljaci c
on b.dobavljac = c.sifra
where b.datum between '2017-01-01' and '2017-12-31'
group by c.naziv
having min(a. kolicina * a.cijena) > 0
order by 3 desc,  2 desc;

select * from ArtikliNaPrimci

select * from primke;


-- ako zelimo vidjeti minimalno
select a.naziv, 
sum(c.kolicina*c.cijena) as ukupno,
min(c.kolicina*c.cijena) as minimalno,
max(c.kolicina*c.cijena) as maximalno
from Dobavljaci a 
inner join Primke b 
on a.sifra=b.dobavljac
inner join ArtikliNaPrimci c on b.sifra=c.primka
where b.datum between '2017-01-01' and '2017-12-31'
group by a.naziv
having min(c.kolicina*c.cijena) > 0
order by 2 desc;
-- opet koristimo naredbu cijena jer govorimo o stvarima koje smo izvukli selektom a one nisu upisane u tablice
-- sada smo dobili informaciju s kojim kupcem smo najvise radili

-- sada zelimo organizirati prvo prema koloni 3 a zatim prema 2
select a.naziv, 
sum(c.kolicina*c.cijena) as ukupno,
min(c.kolicina*c.cijena) as minimalno,
max(c.kolicina*c.cijena) as maximalno
from Dobavljaci a 
inner join Primke b 
on a.sifra=b.dobavljac
inner join ArtikliNaPrimci c on b.sifra=c.primka
where b.datum between '2017-01-01' and '2017-12-31'
group by a.naziv
having min(c.kolicina*c.cijena) > 0
order by 3 desc, 2 desc;
-- sada smo dobili info s kojim kupcem imamo najvise odradenog prema maksimalnom i minimalnom iznosu artikala na primkama

-- i jos zelimo prema istim kriterijima izbaciti prvih top 5 kupaca
select top 5  a.naziv, 
sum(c.kolicina*c.cijena) as ukupno,
min(c.kolicina*c.cijena) as minimalno,
max(c.kolicina*c.cijena) as maximalno
from Dobavljaci a 
inner join Primke b 
on a.sifra=b.dobavljac
inner join ArtikliNaPrimci c on b.sifra=c.primka
where b.datum between '2017-01-01' and '2017-12-31'
group by a.naziv
having min(c.kolicina*c.cijena) > 0
order by 3 desc, 2 desc;

-- ako zelimo povezati podatke koji nisu izravno povezane kljucevima
-- npr. Kupci i mjesto-- tj. ima u kupcima mjesto
-- zadatak : izlistajte imena i prezimena kupaca koji dolaze iz mojeg mjesta

select b. *
from Mjesta a inner join Kupci b
on a.sifra = b.mjesto
where a.naziv in ('Osijek','Punitovci') ;

-- sada zelimo vidjeti jedinstvena imena iz istog selekta
select  distinct b.ime
from Mjesta a inner join Kupci b
on a.sifra = b.mjesto
where a.naziv in ('Osijek','Punitovci') ;

- - idete svatove i planirate kupiti poklon
-- u rasponu 1000-1100 eura, koliko artikala mozete kupiti?
select * from artikli where cijena between 1000 and 1100;

-- zelimo preurediti po koloni 6 prvo najskuplje
select * from artikli where cijena between 1000 and 1100
order by 6 desc;


-- izlistati broj artikala u bazi artikli -- 52601 kom
select count(*) from artikli;

-- izlistati jedinstvene artikle iz artikle u primkama -- 52599 kom-- razlika 2-- 5299 artikala je bilo zaprimano
select distinct artikl from artiklinaprimci;

-- sada zelimo u tablici artikli maknuti sve koji nisu bili zaprimani-- u ovom slucaju mi smo ih obrisali 18.06
select * from artikli where 
sifra not in (select distinct artikl from artiklinaprimci);

-- sada moramo unijeti sebe kao kupca s mjestom u kojem zivite

select * from kupci;

insert into kupci (ime,jmbg,prezime,adresa,mjesto) values
('Tomislav','003256565898','Rogic','Gustava Krkleca 34',10000);

-- kako se pronaci u tablici kupci nakon sto se uensemo
select * from kupci where prezime = 'Rogic' and ime = 'Tomislav';

-- ispisite nazive mjesta u RH koji imaju iste nazive s pripadajucim brojem ponavljanja
select naziv, count(*) 
from  mjesta
group by naziv
having count (*) > 1
order by 2 desc;













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
from grupe a inner join clanovi b
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
