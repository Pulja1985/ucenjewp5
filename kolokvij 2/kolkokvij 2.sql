use master;
go
drop database if exists kolokvij_2;
go
create database kolokvij_2;
go 
use kolokvij_2;

create table decko(
sifra int not null primary key identity(1,1),
indiferentno bit,
vesta varchar(34),
asocijalno bit not null
);

create table decko_zarucnica(
sifra int not null primary key identity(1,1),
decko int not null,
zarucnica int not null
);

create table zarucnica(
sifra int not null primary key identity(1,1),
narukvica int,
bojakose varchar(37) not null,
novcica decimal(18,9),
lipa decimal(15,8) not null,
indiferentno bit not null
);

create table cura(
sifra int not null primary key identity(1,1),
haljina varchar(33) not null,
drugiputa datetime not null,
suknja varchar(38),
narukvica int,
introvertno bit,
majica varchar(40) not null,
decko int
);

create table neprijatelj(
sifra int not null primary key identity(1,1),
majica varchar(32),
haljina varchar(43) not null,
lipa decimal(16,8),
modelnaocala varchar(49) not null,
kuna decimal(12,6) not null,
jmbag char(11),
cura int
);

create table brat(
sifra int not null primary key identity(1,1),
suknja varchar(47),
ogrlica int not null,
asocijalno bit not null,
neprijatelj int not null
);

create table prijatelj(
sifra int not null primary key identity(1,1),
modelnaocala varchar(37),
trciputa datetime not null,
ektroventno bit not null,
prviputa datetime,
svekar int not null
);

create table svekar(
sifra int not null primary key identity(1,1),
stilfrizura varchar(48),
ogrlica int not null,
asocijalno bit not null
);
alter table brat add foreign key (neprijatelj) references neprijatelj (sifra);
alter table neprijatelj add foreign key (cura) references cura (sifra); 
alter table cura add foreign key (decko) references decko(sifra);
alter table decko_zarucnica add foreign key (decko) references decko(sifra);
alter table decko_zarucnica add foreign key (zarucnica) references zarucnica(sifra);
alter table prijatelj add foreign key (svekar)references svekar(sifra);

insert into decko(indiferentno,vesta,asocijalno)values
('1','Crvena Nike','0'),
('0','Žuta Puma','1'),
('1','Crna Adidas','0')

select * from decko;

insert into zarucnica(narukvica,bojakose,novcica,lipa,indiferentno)values
(2,'Smeđa','1553.56','153.37','1'),
(2,'Crna','1258.36','128.87','0'),
(2,'Žuta','1359.48','1977.19','1')

select * from zarucnica;

insert into decko_zarucnica(decko,zarucnica)values
(1,1),(2,1),(3,1)

select * from decko_zarucnica;

insert into cura(haljina,drugiputa,suknja,narukvica,introvertno,majica,decko)values
('Crevena haljina','2023-12-01','Zelena Nike',2,'1','žuta Adidas',3),
('Roza haljina','2023-09-30','Ljubicasta Puma',4,'1','Tirkinzno zelena Umbro',3),
('Zelena haljina','2023-11-25','Roza Nike',1,'0','Dunav Plava Nike',3)

select * from cura;

INSERT INTO neprijatelj(majica,haljina,lipa,modelnaocala,kuna,jmbag,cura) VALUES
('Crvena majica','Nike žuta',1598.35,'Ray ban Aviator',4398.75,12345678912,1),
('Zelena majica','Adidas crvena',1898.45,'Ray ban Aviator',3358.74,12345678914,2),
('Plava majica','Puma zelena',1438.76,'Ray ban wayfarer',1849.67,99345678910,3)

SELECT * FROM neprijatelj;

insert INTO brat(suknja,ogrlica,asocijalno,neprijatelj)VALUES
('Zelena Nike',3,1,1),
('Crvena Puma',4,0,2),
('Ljubicasta Adidas',1,1,3)



