select * from smjerovi;

--  filtriranje kolona
-- * sve kolone
-- naziv kolone, konstanta i izraz

-- ovo nize se zove relacija
select naziv from smjerovi;

select naziv, cijena from smjerovi;

-- ovdje nize smo selektirali, naziv, cijena i opet cijelu tablicu smjerovi
-- selektirati mozemo nekoliko puta i uvijek ce nam se kolone ponavljati
select naziv, cijena, *, naziv, 
'Osijek' as grad,2 as broj,
getdate () as datum from smjerovi;

-- dodavanje konstante- znaci svi redovi dobiju neku vrijednost , u ovom slucaju rijec Osijek
select 'Osijek' from smjerovi;
-- sada vidimo da kolona Osijek nema naziv i mozemo ga dodati kao 
select 'Osijek' as grad from smjerovi;

-- dodavanje aktuelnog datuma
select getdate() as Datum,
s.* 
from smjerovi s;

-- filtriranje redova
select * from polaznici;
-- where klauzula
-- operatori: = jednako, != razlicito
select * from polaznici where ime='Luka';
-- ova gore naredba izvaci sva imena Luka

select * from polaznici where ime!='Luka';
-- ova naredba gore selektira sva imena koja nisu Luka

-- <> >= <=
select * from polaznici where sifra<5;
-- ova naredba gore povlaci sva imena gdje je sifra manja od 5

-- logicki operatori: and, or i not
-- boolean operatori: https://i.ytimg.com/vi/7dvqfpXEjdg/maxresdefault.jpg
-- izvacenje podataka gdje je sifra veca od 6 i manja od 10
select ime, prezime from polaznici where sifra>5 and sifra<10;
-- pokazuju se samo oni podaci koji zadovoljavaju oba uvjeta >5 i <10

-- or
select * from polaznici where sifra=1 or sifra=2;

-- not
select * from polaznici where not sifra=2;

-- ostali operatori
-- like

-- svi polaznici koji u svom imenu nemaju slovo a
select * from polaznici where ime not like '%a%';

-- svi polaznici koji u imenu imaju slovo a
select * from polaznici where ime like '%a%';

-- ako nas zanimaju samo imena koja sadrze slovo a
-- svi polaznici koji u imenu imaju slovo a
select ime from polaznici where ime like '%a%';

-- ako zelimo abecedno sloziti imena koja sadrze slovo a
select ime from polaznici where ime like '%a%'
order by ime;

-- ako zelimo abecedno sloziti imena koja sadrze slovo a ali odostraga
select ime from polaznici where ime like '%a%'
order by ime desc;

-- ako zelimo abecedno sloziti imena koja sadrze slovo a ali odostraga s time da program navede samo jedno ime bez obzira sto u tablici imamo npr. dva Luke
select distinct ime from polaznici where ime like '%a%'
order by ime desc;

-- uz najmanju mogucu gresku s obzirom na podatke
-- izlistajte sve zene u grupi  , zapravo trazimo sva imena koja zavrsavaju na a
select * from polaznici where ime like '%a';


