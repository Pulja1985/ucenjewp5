--create database fakultet1;
--use fakultet1;
--create table ispitnirok(
--sifra int,
--predmet varchar(50),
--vrstaispita varchar(50),
--datumispita datetime,
--pristupio bit
--);
create table pristupnici(
ispitnirok datetime,
student varchar(50),
brojbodova int,
ocijena int
);