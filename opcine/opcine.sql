use master;
go
drop database if exists zupanije;
go 
create database zupanije;
go
use zupanije;
create table zupanija(
sifra int not null primary key identity(1,1),
naziv varchar(50) not null,
zupan varchar(50) not null
);

create table opcina(
sifra int not null primary key identity(1,1),
zupanija varchar(50) not null,
naziv varchar(50) not null,
);

create table mjesto(
sifra int not null primary key identity(1,1),
opcina Varchar(50) not null,
naziv varchar(50)not null
);

create table zupan(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null
);
create table zupanija_opcina_mjesto_zupan(
zupanija_sifra int,
opcina_sifra int,
mjesto_sifra int,
zupan_sifra int
);

alter table  zupanija_opcina_mjesto_zupan add foreign key (zupanija_sifra) references zupanija (sifra);
alter table zupanija_opcina_mjesto_zupan add foreign key (opcina_sifra) references opcina (sifra);
alter table zupanija_opcina_mjesto_zupan add foreign key (mjesto_sifra) references mjesto(sifra);
alter table zupanija_opcina_mjesto_zupan add foreign key (zupan_sifra) references zupan(sifra);


insert into zupanija(naziv,zupan)values
('Vukovarsko-srijemska �upanija','Damir Dekani?'),
('Splitsko-dalmatinska �upanija','Bla�enko Boban'),
('Zagreba?ka �upanija','Stijepan Ko�i?')

 select * from zupanija;

 insert into opcina(zupanija,naziv)values
 ('Vukovarsko-srijemska �upanija','Nu�tar'),
 ('Vukovarsko-srijemska �upanija','Ivankovo'),
 ('Splitsko-dalmatinska �upanija','Ba�ka voda'),
 ('Splitsko-dalmatinska �upanija','Bol'),
 ('Zagrebacka �upanija','Dubrava'),
 ('Zagrebacka �upanija','Dubravica')

 select*from opcina;

 insert into mjesto(opcina,naziv)values
 ('Nustar','Nustar'),
 ('Nustar','Marinci'),
 ('Nustar','Ceri?'),
 ('Ba�ka voda','Ba�ka voda'),
 ('Ba�ka voda','Promajna'),
 ('Ba�ka voda','Bratu�'),
 ('Dubrava','Dubrava'),
 ('Dubrava','Badinec'),
 ('Dubrava','Brezje')

 select * from mjesto;

 insert into zupan(ime,prezime)values
 ('Damir','Dekani?'),
 ('Bla�enko','Boban'),
 ('Stijepan','Kozi?')
 
 Select * from zupan;