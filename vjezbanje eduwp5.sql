select * from smjerovi;

--ŠKOLSKA SINTAKSA
--1--> ovo je sifra koju generira baza
insert into smjerovi (naziv,cijena,brojsati,izvodiseod,vaucer)
values ('Web Programiranje',1599.99,225,'2024-02-07 18:00',1);

--LOŠA SINTAKSA
--2
INSERT INTO SMJEROVI VALUES ('Web Design',1200,150,null,null);

--MVP
INSERT INTO SMJEROVI (NAZIV) VALUES ('ĆŠČŽ ščćž');

select * from polaznici;

insert into polaznici (ime,prezime,email,oib)
values ('Kristina','Andric','fashionbykriss@gmail.com','12345678910');