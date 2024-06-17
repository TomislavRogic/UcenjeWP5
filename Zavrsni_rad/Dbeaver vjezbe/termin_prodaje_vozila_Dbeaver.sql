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