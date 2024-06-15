#DROP DATABASE IF EXISTS prijavnice;
CREATE DATABASE IF NOT exists prijavnice;
drop database prijavnice;
create database prijavnice;
use prijavnice;

create table vozaci(
sifra int not null primary key auto_increment,
ime varchar(50) not null,
prezime varchar(50) not null,
oib char(11)
);
create table vozila(
sifra int not null primary key auto_increment,
marka varchar(50) not null,
model varchar(50) not null,
snaga varchar(50) not null,
pogon varchar(50) not null,
vozaci_sifra int not null
);

create table utrke(
sifra int primary key auto_increment,
datum datetime not null,
mjesto varchar(50) not null,
naziv varchar(50) not null
);

create table vozila_utrke(
vozilo_sifra int not null,
utrke_sifra int not null
);

alter table vozila_utrke add foreign key(vozilo_sifra)references vozila(sifra);
alter table vozila add foreign key(vozaci_sifra)references vozaci(sifra);
alter table vozila_utrke add foreign key(utrke_sifra)references utrke(sifra);

insert into table vozaci(ime,prezime,oib)values;
('Tomislav','Jakopec','12345678912')

insert into table vozila(marka,model,snaga,pogon,vozaci_sifra)values
('Honda','civic',300,'prednji',1)

inser into table utrke(datum,mjesto,naziv)values
('2024-06-16 10:00','Osijek','international streetrace Honda day')

insert into table vozila_utrke values