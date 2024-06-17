use knjiznica;
select * from autor where ime like'%a';
select top 10 percent * from  autor;
select top 20 percent * from autor;
select * from autor where ime like '%marko%';
select * from autor where ime not like '%marko%';
select * from autor where ime like '%hrvoje%';
select * from autor where ime like'%a%';
select * from autor where prezime not like '%p%';
select * from autor where prezime like '%p%';
select * from autor where datumrodenja like '%1960%';
--getdate() as autor from datumrodenja;
select * from autor where ime = 'marko';
Cselect ime,prezime from autor where sifra < 10000;
select * from autor where sifra=1 or sifra =2;
select * from autor where datumrodenja <1970;
select * from izdavac;
select * from izdavac where aKTIVAN = 0;
select * from autor;
INSERT INTO autor( sifra,ime,prezime,datumrodenja) values
('4','HRVOJE','PULJI?_ILI?','1985-12-03 14:00');
select * from izdavac where aKTIVAN is  null;
update izdavac SET aktivan=null WHERE sifra = 1;
update izdavac set aktivan=null where sifra = 2;
update izdavac set aktivan=null where sifra = 3;
update izdavac set aktivan=null where sifra = 4;
update izdavac set aktivan=null where sifra = 5;
update izdavac set naziv = 'Biblioteka TWO LINE' where sifra =4;
update autor set datumrodenja='1980-03-12 14:00' where sifra=3;
insert into izdavac(sifra,naziv,aktivan)values
('6','Pulji? racing team','0');
DELETE FROM izdavac WHERE sifra='6';
delete from autor where sifra=4;
insert into autor(sifra,ime,prezime,datumrodenja)values
('5','hrvoje','pulji? ili?','1985-12-03 13:55')
select * from mjesto where postanskibroj like'31%';
update mjesto set postanskibroj='31000' where sifra=4;
insert into mjesto(sifra,naziv,postanskibroj,drzava)values
('5','Vinkovci','32100','Hrvatska')
select*from mjesto;
update mjesto set naziv= 'Zagreb zapad' where sifra=1;select * from autor;
insert into autor(sifra,ime,prezime,datumrodenja)values
('6','Matija','Puljić-Ilić','1989-04-03'),
('7','Dominik','Puljić Ilić','1992-11-21')
update autor set prezime='Puljić-Ilić'where sifra=5;
update autor set ime = 'Hrvoje' where sifra=5;
select * from autor;
update autor set ime='Duda' where sifra=15157;
update autor set prezime= 'Radić'where sifra =15157;
select * from mjesto;
select *from mjesto where naziv like 'v%';
update mjesto set naziv ='VINKOVCI' WHERE SIFRA =5;
select * from izdavac;
update izdavac set naziv= 'NIL D.O.O.' WHERE SIFRA= 396;