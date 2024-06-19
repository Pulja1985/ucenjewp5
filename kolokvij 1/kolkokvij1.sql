use master;
go
drop database if exists kolokvij_1;
go 
create database kolokvij_1;
go
use kolokvij_1;
create table sestra(
sifra int not null primary key identity(1,1),
introvertno bit,
haljina varchar(31) not null,
maraka decimal(16,6),
hlace varchar(46) not null,
narukvica int not null
);

create table zena(
sifra int not null primary key identity(1,1),
treciputa datetime,
hlace varchar(46),
kratkamajica varchar(31) not null,
jmbag char(11) not null,
bojaociju varchar(39) not null,
haljina varchar(44),
sestra int not null
);

create table muskarac(
sifra int not null primary key identity(1,1),
bojaociju varchar(50) not null,
hlace varchar(30),
modelnaocala varchar(43),
maraka decimal(14,5) not null,
zena int not null
);

create table mladic(
sifra int not null primary key identity(1,1),
suknja varchar(50) not null,
kuna decimal(16,8) not null,
drugiputa datetime,
asocijalno bit,
eksroventno bit not null,
dukserica varchar(48) not null,
muskarac int not null
);

create table svekar(
sifra int not null primary key identity(1,1),
bojaociju varchar(40) not null,
prstena int,
dukserica varchar(41),
lipa decimal(13,8),
eura decimal(12,7),
majica varchar(35)
);

create table sestra_svekar(
sifra int not null primary key identity(1,1),
sestra int not null,
svekar int not null
);

create table punac(
sifra int not null primary key identity(1,1),
ogrlica int,
gustoca decimal(14,9),
hlace varchar(41) not null
);

create table cura(
sifra int not null primary key identity(1,1),
novcica decimal(16,5) not null,
gustoca decimal(18,6) not null,
lipa decimal(13,10),
ogrlica int not null,
bojakose varchar(38),
suknja varchar(36),
punac int not null
);

alter table sestra_svekar add foreign key(sestra) references sestra (sifra);
alter table sestra_svekar add foreign key(svekar) references svekar (sifra);
alter table zena add foreign key(sestra)references sestra (sifra);
alter table muskarac add foreign key (zena) references zena(sifra);
alter table mladic add foreign key (muskarac) references muskarac(sifra);
alter table cura add foreign key (punac)references punac(sifra);

insert into sestra(introvertno,haljina,maraka,hlace,narukvica) values
(1,'Bijela','200.51','Crvene adidas','0'),
(1,'Žuta','255.44','Crvene Nike','1'),
(1,'Crna','237.72','Žuta Lotto','0')

select * from sestra;

insert into zena(treciputa,hlace,kratkamajica,jmbag,bojaociju,haljina,sestra)values
('2018-12-03','Dior','Adidas','12345678910','Smeđa','Kratka crna',1),
('2019-11-04','Nike','Coca cola','12345678912','Crna','Kratka smeđa',2),
('2020-07-24','Lotto','Umbro','12345678999','Plava','Dugačka ljubičasta',3)

select * from zena;

insert into muskarac(bojaociju,hlace,modelnaocala,maraka,zena)values
('Smeđa','Big_Star','Superdry_elegance','298.15000',1),
('Crna','Levis','Nike_fasion','122.58000',2),
('Plava','Nike','Apollo','427.99000',3)

select * from muskarac;

insert into svekar(bojaociju,prstena,dukserica,lipa,eura,majica)values
('Smeđa','2','Nike plava','273.69','711.59','Kratka Adidas'),
('Crna','1','Adidas smaeđa','159.78','901.66','Žuta Nike'),
('Plava','0','Puma crna','221.33','1237.00','Bijela Puma')

select * from svekar;

insert into sestra_svekar(sestra,svekar)values
(1,1),(2,2),(3,1),(1,3),(2,3)

select * from sestra_svekar;

update cura set gustoca= 15.77;

delete from mladic where kuna > 15.78;

select kratkamajica from zena where hlace like '%ana%';

SELECT svekar.dukserica, mladic.asocijalno, muskarac.hlace
FROM svekar
JOIN sestra_svekar ON svekar.sifra = sestra_svekar.svekar
JOIN sestra ON sestra_svekar.sestra = sestra.sifra
JOIN zena ON sestra.sifra = zena.sestra
JOIN muskarac ON zena.sifra = muskarac.zena
JOIN mladic ON muskarac.sifra = mladic.muskarac
WHERE zena.hlace LIKE 'a%' AND sestra.haljina LIKE '%ba%'
ORDER BY muskarac.hlace DESC;

SELECT sestra.haljina, sestra.maraka
FROM sestra
LEFT JOIN sestra_svekar ON sestra.sifra = sestra_svekar.sestra
WHERE sestra_svekar.sestra IS NULL;

