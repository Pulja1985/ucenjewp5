use master;
go
drop database if exists doktorska_ordinacija;
go
create database doktorska_ordinacija;
go
use doktorska_ordinacija;
create table doktori(
ime varchar(50),
prezime varchar(50),
zavseni_smjer varchar(50)
);
create table pacijenti(
ime varchar(50),
prezime varchar(50),
vrsta_ljecenja varchar(50)
);
create table medicinske_sestre(
ime varchar(50),
prezime varchar(50),
strucna_sprema varchar(50),
pacijent_za_kojeg_je_zaduzena varchar(50)
);