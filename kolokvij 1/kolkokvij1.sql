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
(1,'Crna','237.72','Žuta Lotto','0'),
(0,'Plava','370.27','Ljubičasta Puma','1');

select * from sestra;

insert into zena(treciputa,hlace,kratkamajica,jmbag,bojaociju,haljina,sestra)values
('2018-12-03','Dior','Adidas','12345678910','Smeđa','Kratka crna',1),
('2019-11-04','Nike','Coca cola','12345678912','Crna','Kratka smeđa',2),
('2020-07-24','Lotto','Umbro','12345678999','Plava','Dugačka ljubičasta',3);

select * from zena;

insert into muskarac(bojaociju,hlace,modelnaocala,maraka,zena)values
('Smeđa','Big_Star','Superdry_elegance','298.15000',1),
('Crna','Levis','Nike_fasion','122.58000',2),
('Plava','Nike','Apollo','427.99000',3);

select * from muskarac;

insert into svekar(bojaociju,prstena,dukserica,lipa,eura,majica)values
('Smeđa','2','Nike plava','273.69','711.59','Kratka Adidas'),
('Crna','1','Adidas smaeđa','159.78','901.66','Žuta Nike'),
('Plava','0','Puma crna','221.33','1237.00','Bijela Puma');

select * from svekar;

insert into sestra_svekar(sestra,svekar)values
(1,1),(2,2),(3,1),(1,3),(2,3)

insert into mladic(suknja,kuna,drugiputa,asocijalno,eksroventno,dukserica,muskarac)values
('Crvena suknja',1567.77,'2023-09-03',1,0,'Ferrari crvena',1),
('Zelena suknja',1469.47,'2023-10-04',0,0,'Audi Smeđa',2),
('Žuta suknja',1137.87,'2023-07-12',1,1,'Honda Crna',3);


select * from sestra_svekar;

update cura set gustoca= 15.77;

delete from mladic where kuna > 15.78;

select kratkamajica from zena where hlace like '%ana%';

select svekar.dukserica,mladic.asocijalno,muskarac.hlace,sestra.haljina 
from svekar
join sestra_svekar on svekar.sifra=sestra_svekar.svekar
join sestra on sestra_svekar.sestra=sestra.sifra
join zena on zena.sestra=sestra.sifra
join muskarac on muskarac.zena=zena.sifra
join mladic on mladic.muskarac=muskarac.sifra
--where zena.hlace like 'D%' and sestra.haljina like '%je%' 
order by muskarac.hlace desc

select sestra.haljina,sestra.maraka 
from sestra
left join sestra_svekar on sestra.sifra=sestra_svekar.sestra
where sestra_svekar.sestra is null








