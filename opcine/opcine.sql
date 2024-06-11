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
('Vukovarsko-srijemska županija','Damir Dekanić'),
('Splitsko-dalmatinska županija','Blaženko Boban'),
('Zagreba?ka županija','Stijepan Kožić')

 select * from zupanija;

 insert into opcina(zupanija,naziv)values
 ('Vukovarsko-srijemska županija','Nuštar'),
 ('Vukovarsko-srijemska županija','Ivankovo'),
 ('Splitsko-dalmatinska županija','Baška voda'),
 ('Splitsko-dalmatinska županija','Bol'),
 ('Zagrebacka županija','Dubrava'),
 ('Zagrebacka županija','Dubravica')

 select*from opcina;

 insert into mjesto(opcina,naziv)values
 ('Nustar','Nuštar'),
 ('Nustar','Marinci'),
 ('Nustar','Cerić'),
 ('Baška voda','Baška voda'),
 ('Baška voda','Promajna'),
 ('Baška voda','Bratuš'),
 ('Dubrava','Dubrava'),
 ('Dubrava','Badinec'),
 ('Dubrava','Brezje')

 select * from mjesto;

 insert into zupan(ime,prezime)values
 ('Damir','Dekanić'),
 ('Blaženko','Boban'),
 ('Stijepan','Kožić')
 
 Select * from zupan;

 select * from mjesto where sifra=4;

 update mjesto set naziv='Krvavica' where sifra=4;

 select * from mjesto where sifra=5;

 update mjesto set naziv='Bast'where sifra =5;

 select * from mjesto where sifra =6;

 update mjesto set naziv='Topići' where sifra=6;

 select * from mjesto where sifra =7;

 update mjesto set naziv='Koritna' where sifra=7;

 select * from mjesto where sifra=8;

 update mjesto set naziv='Mostari' where sifra=8;