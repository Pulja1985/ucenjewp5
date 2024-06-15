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
select * from autor where ime! = 'marko';
select ime,prezime from autor where sifra < 10000;
select * from autor where sifra=1 or sifra =2;
select * from autor where datumrodenja <1970;
select * from izdavac;
select * from izdavac where aKTIVAN = 0;
select * from autor;
INSERT INTO autor( sifra,ime,prezime,datumrodenja) values
('4','HRVOJE','PULJI?_ILI?','1985-12-03 14:00');
select * from izdavac where aKTIVAN is  null;
update izdavac SET aktivan='0' WHERE sifra = 1;
update izdavac set aktivan='0' where sifra = 2;
update izdavac set aktivan='0' where sifra = 3;
update izdavac set aktivan='0' where sifra = 4;
update izdavac set aktivan='0' where sifra = 5;
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