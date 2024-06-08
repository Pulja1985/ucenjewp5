use master;
go
drop database if exists trgovina;
go
create database trgovina;
go 
use trgovina;
create table racun(
sifra int  primary key identity(1,1) not null,
rednibroj int not null,
datum datetime,
kupac varchar(50) not null,
placeno bit not null
);
create table stavke_racuna(
racun int not null,
artikl varchar(50) not null,
cijena decimal(18,2) not null,
kolicina int not null,
popust int not null
);
alter table stavke_racuna add foreign key(racun) references racun(sifra)

--select * from racun;

insert into racun(rednibroj,datum,kupac,placeno)values
('1','2024-06-01 14:32','hrvoje_puljic_ilic',1)

--select * from stavke_racuna;

insert into stavke_racuna(racun,artikl,cijena,kolicina,popust)values
('1','coca-cola','1,99','4','9')