use knjiznica;
select * from autor;

-- select top 10 autora
select top 10 * from autor;

-- select 10 %
select top 10 percent * from autor;

select distinct ime from autor 
where ime not like '%a%'
and ime like 't%'
and ime not like '%o%'
order by ime;

select * from izdavac;

-- svim izdavacima za koje ne znamo jesu li aktivni ili ne postavite da nisu aktivni
select * from izdavac;
update izdavac set aktivan= '0' where aktivan is null;

-- unesite sebe kao autora
select * from autor;
insert into autor (sifra,ime,prezime,datumrodenja)
values (5888,'Tomislav','Rogić','1982-02-25');

select * from mjesto;
select * from mjesto where postanskibroj like '31%';

use svastara;

-- idete u svatove i zelite kupiti poklon u vrijednosti 100 do 150 eura, koliko je artikala na izboru

select * from artikli;
select * from artikli where cijena >= 100  and cijena <= 150
order by cijena;

-- ako zelimo da pokazuje cijenu od vece prema manje
select * from artikli where cijena >= 100  and cijena <= 150
order by cijena desc;

-- ako zelimo da pokaze koliko ima kucanskih aparata
-- naredba count(*) pokazuje koliko ima ukupno redova u tablici, nevezano da li neka kolona sadrzi null ili ne
select count(*) from artikli;

-- pokazuje koliko ukupno ima redova koji odgovaraju ovom kriteriju
select count(*) from artikli where cijena >= 100  and cijena <= 150;

-- pokazuje sve redove koji sadrze u imenu rijeci aparat
select * from artikli where kratkinaziv like '%aparat%';

select * from artikli where kratkinaziv like '%kucan%';

