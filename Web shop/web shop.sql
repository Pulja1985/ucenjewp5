﻿use master;
GO
DROP DATABASE IF EXISTS WEBSHOP;
GO
CREATE DATABASE WEBSHOP;
GO
USE WEBSHOP;
CREATE TABLE PROIZVODI(
SIFRA INT NOT NULL PRIMARY KEY IDENTITY (1,1),
NAZIV VARCHAR(50) NOT NULL,
DATUM_NABAVE DATETIME,
CIJENA DECIMAL(18,2),
AKTIVAN BIT 
);
CREATE TABLE STAVKE(
RACUN_SIFRA INT NOT NULL,
PROIZVOD_SIFRA INT NOT NULL,
KUPAC_SIFRA INT NOT NULL,
KOLICINA INT NOT NULL,
CIJENA DECIMAL(18,2)
);
CREATE TABLE RACUNI(
SIFRA INT NOT NULL PRIMARY KEY IDENTITY(1,1),
DATUM DATETIME,
KUPAC VARCHAR(50) NOT NULL,
STATUS BIT 
);
CREATE TABLE KUPCI(
SIFRA INT NOT NULL PRIMARY KEY IDENTITY(1,1),
IME VARCHAR(50) NOT NULL,
PREZIME VARCHAR(50) NOT NULL,
ULICA VARCHAR(50),
MJESTO VARCHAR(50)
);
ALTER TABLE STAVKE ADD FOREIGN KEY(PROIZVOD_SIFRA) REFERENCES PROIZVODI(SIFRA);
ALTER TABLE STAVKE ADD FOREIGN KEY (RACUN_SIFRA) REFERENCES RACUNI(SIFRA);
ALTER TABLE STAVKE ADD FOREIGN KEY(KUPAC_SIFRA) REFERENCES KUPCI(SIFRA);

INSERT INTO PROIZVODI(NAZIV,DATUM_NABAVE,CIJENA,AKTIVAN)VALUES
('COCA_COLA','2024-05-17 09:00','2.09','1'),
('FANTA','2024-05-18 10:00','1.99','1')
SELECT * FROM PROIZVODI

INSERT INTO STAVKE(RACUN_SIFRA,PROIZVOD_SIFRA,KUPAC_SIFRA,KOLICINA,CIJENA)values
('1','1','1','12','2.09'),
('1','2','1','4','1.99'),
('2','2','2','7','1.99'),
('2','1','2','18','2.09')


INSERT INTO RACUNI(DATUM,KUPAC,STATUS)VALUES
('2024-06-01 11:20','HRVOJE PULJIĆ-ILIĆ','1'),
('2024-06-02 06:35','DOMINIK PULJIĆ-ILIĆ','1')
SELECT * FROM RACUNI

INSERT INTO KUPCI(IME,PREZIME,ULICA,MJESTO)VALUES
('HRVOJE','PULJIĆ-ILIĆ','ZVONARSKA 47','VINKOVCI'),
('DOMINIK','PULJIĆ-ILIĆ','ZVONARSKA 47','VINKOVCI')
SELECT * FROM KUPCI