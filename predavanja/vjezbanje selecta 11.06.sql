select * from smjerovi;

--  filtriranje kolona
-- * sve kolone
-- naziv kolone, konstanta i izraz

-- ovo nize se zove relacija
select naziv from smjerovi;

select naziv, cijena, *, naziv from smjerovi;

-- ovdje nize smo selektirali, naziv, cijena i opet cijelu tablicu smjerovi
-- selektirati mozemo nekoliko puta i uvijek ce nam se kolone ponavljati
select naziv, cijena, *, naziv, 
'Osijek' as grad,2 as broj,
getdate () as datum from smjerovi;

-- dodavanje konstante- znaci svi redovi dobiju neku vrijednost , u ovom slucaju rijec Osijek
select 'Osijek' from smjerovi;
-- sada vidimo da kolona Osijek nema naziv i mozemo ga dodati kao 
select 'Osijek' as grad from smjerovi;

-- dodavanje aktuelnog datuma u tablicu, uvijek treba s onim sto dodajemo staviti i da stavljamo cijelu tablicu odnosno *
select *, getdate() as Datum from smjerovi s;

-- filtriranje redova -- radi se pomocu where klauzule
select * from polaznici;
-- where klauzula
-- operatori: = jednako, != razlicito
select * from polaznici where ime='Luka';
-- ova gore naredba izvaci sva imena Luka

-- razlicito
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

-- ako zelimo vidjet abecedeno
select * from polaznici where ime like '%a%'
order by ime;

-- ako zelimo unazad
select * from polaznici where ime like '%a%'
order by ime desc;



-- ako nas zanimaju samo imena koja sadrze slovo a
-- svi polaznici koji u imenu imaju slovo a
select ime from polaznici where ime like '%a%';

-- ako zelimo abecedno sloziti imena koja sadrze slovo a
select ime from polaznici where ime like '%a%'
order by ime;

-- ako zelimo vidjeti samo imena unazad ali da ne ponavlja ime nego ih prikazuje samo jednom
select distinct ime from polaznici where ime like '%a%'
order by ime desc;

-- ako zelimo abecedno sloziti imena koja sadrze slovo a ali odostraga
select ime from polaznici where ime like '%a%'
order by ime desc;

-- ako zelimo abecedno sloziti imena koja sadrze slovo a ali odostraga s time da program navede samo jedno ime bez obzira sto u tablici imamo npr. dva Luke
select distinct ime from polaznici where ime like '%a%'
order by ime desc;

-- uz najmanju mogucu gresku s obzirom na podatke
-- izlistajte sve zene u grupi  , zapravo trazimo sva imena koja zavrsavaju na a
select * from polaznici where ime like '%a';

-- izlistajte sve polaznike cije prezime pocinje slovom M, pretrativanje nije osjetljivo na velika i mala slova ali to se moze promjeniti
select * from polaznici where prezime like 'M%';


-- ostali operatori
-- in- ekvivalent jednako
select * from polaznici where sifra in(2,7,12,25);

-- ako zelimo sve ostale osim tih
select * from polaznici where not sifra in(2,7,12,25);

-- between- naredba izmedu
select * from polaznici where sifra between 2 and 8;

-- ova naredba nize ne izbacuje dobro jer ima redova s vrijednosti nula a execute naredbom ne pokazuje nista
--ovo je kriva naredba jer se na null nikad ne ide s znakom =
-- kod null se uvijek ide s dva operatora, is null ili is not null
select * from smjerovi where izvodiseod=null;
 -- pravilno se pise
 select * from smjerovi where izvodiseod is null;