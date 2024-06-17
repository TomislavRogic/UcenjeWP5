-- spajanje na bazu phpadmin
# komentar

-- naredba use ne smije se kombinirati s drugim naredbama jer nece funkcionirati, mora se koristiti zasebno
use phpmyadmin;

drop database if exists termin_prodaje_vozila;

create database termin_prodaje_vozila;


use termin_prodaje_vozila;