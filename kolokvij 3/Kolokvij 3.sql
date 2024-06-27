use master;
go
drop database if exists kolokvij3;
go
create database kolokvij3;
go
use kolokvij3

create table snasa(
sifra int  not null primary key identity(1,1),
introvertno bit,
kuna decimal(15,6) not null,
eura decimal(12,9) not null,
treciputa datetime,
ostavljena int not null
);

create table punica(
sifra int not null primary key identity(1,1),
asocijalno bit, 
kratkamajica varchar(44),
kuna decimal(13,8) not null,
vesta varchar(32),
snasa int
);

create table ostavljena(
sifra int not null primary key identity(1,1),
kuna decimal(17,5),
lipa decimal(15,6),
majica varchar(36),
modelnaocala varchar(31) Not null,
prijatelj int
);

create table prijatelj(
sifra int not null primary key identity(1,1),
kuna decimal(16,10),
haljina varchar(37),
lipa decimal(13,10),
dukserica varchar(31),
indiferentno bit not null
);

create table prijatelj_brat(
sifra int not null primary key identity(1,1),
prijatelj int not null,
brat int not null
);

create table brat(
sifra int not null primary key identity(1,1),
jmbag char(11),
ogrlica int not null,
ekstroventno bit not null
);

create table svekar(
sifra int not null primary key identity(1,1),
novcica decimal(13,8) not null,
suknja varchar(44) not null,
bojakose varchar(36),
prstena int ,
narukvica int not null,
cura int not null
);

create table cura(
sifra int not null primary key identity(1,1),
dukserica varchar(40),
maraka decimal(13,7),
drugiputa datetime,
majica varchar(49),
novcica decimal(15,8),
ogrlica int not null
);

alter table svekar add foreign key(cura) references cura(sifra);
alter table punica add foreign key(snasa) references snasa(sifra);
alter table snasa add foreign key(ostavljena) references ostavljena(sifra);
alter table ostavljena add foreign key(prijatelj) references prijatelj(sifra);
alter table prijatelj_brat add foreign key(prijatelj) references prijatelj(sifra);
alter table prijatelj_brat add foreign key(brat) references brat (sifra);

insert into snasa (introvertno,kuna,eura,treciputa,ostavljena)values
(1,150.66,1231.37,'2012-12-22',1),
(0,1330.36,2011.32,'2013-10-08',2),
(1,246.55,1956.57,'2015-07-15',3);

select * from snasa;

insert into punica(asocijalno,kratkamajica,kuna,vesta,snasa)values
('0','Nike crvena','1478.48','Crvena sa trokutima',1),
('1','Adidas zelena','1571.69','Zelena sa trokutima',2),
('0','Puma zuta','1772.33','Žuta sa trokutima',1);

select * from punica;

insert into ostavljena(kuna ,lipa,majica,modelnaocala,prijatelj) values
('1537.55','537.57','Zelena Adidas','Ray ban',1),
('2421.78','329.64','Crvena Nike','Nike',2),
('3645.65','719.92','Žuta Puma','Adidas',3);

select * from ostavljena;

insert into prijatelj(kuna,haljina,lipa,dukserica,indiferentno)values
('158.55','Večernja crna','158.98','Puma crvena',0),
('327.29','Večernja bijela','1654.23','Nike Žuta',1),
('543.87','Večernja krem','1987.88','Adidas ljubičasta',0);

select * from prijatelj;