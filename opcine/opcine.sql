use master;
go
drop database if exists opcine;
go
create database opcine;
go
use opcine;

create table nacelnici(
sifra int not null primary key identity(1,1),
ime varchar(50)not null,
prezime varchar(50) not null,
datum_rodenja datetime
);
insert into nacelnici(ime,prezime,datum_rodenja)values
('Hrvoje','Pulji?-Ili?','1985-12-03 13:55'),
('Matija','Pulji?-ili?','1989-04-03 14:00'),
('Dominik','Pulji?-Ili?','1992-11-21 14:45')

--select * from nacelnici where sifra=1;

--update nacelnici set datum_rodenja ='1985-12-03 13:50' where sifra=1;

--select * from nacelnici where sifra=2;

--update nacelnici set datum_rodenja= '1989-04-03 13:55' where sifra=2;