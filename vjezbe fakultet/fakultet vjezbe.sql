use master;
go
drop database if exists fakultet;
go
create database fakultet;
go
use fakultet;

create table ispitni_rok(
sifra int primary key identity(1,1),
predmet varchar(50) not null,
vrsta_ispita varchar(50) not null,
datum datetime null,
pristupio bit not null
);
create table pristupnici(
ispitni_rok int not null,
student varchar(50) not null,
broj_bodova int not null,
ocijena int not null
);
alter table pristupnici add foreign key(ispitni_rok) references ispitni_rok(sifra);