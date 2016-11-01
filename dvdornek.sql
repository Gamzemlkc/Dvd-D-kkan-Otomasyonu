create database OdevDatabase

use OdevDatabase

create Table Kategoriler 
(
KatID int primary key identity,
KategoriAdi nvarchar(30),
KategoriAciklama nvarchar(max)
)

create table Dvdler
(
DvdID int primary key identity,
DvdAdi nvarchar(30),
DvdAciklama nvarchar(max),
DvdImajYolu nvarchar(max),
RafID int,
KategoriID int,
DurumID int
)
create table Raflar
(
RafID int primary key identity,
RafAdi nvarchar(30),
RafAciklama nvarchar(max)
)

create table DurumlariGoster
(
DurumID int primary key identity,
DurumAdi nvarchar(30)
)

create table Musteriler
(
MusteriID int primary key identity,
MusteriAdi nvarchar(30),
MusteriSoyadi nvarchar(30),
Adres nvarchar(max),
Tel nvarchar(14)
)

create table Siparisler
(
SiparisID int primary key identity,
SiparisTarihi date,
MusteriID int
)


create table SiparisDetaylar
(
SiparisIDsi int primary key identity,
SatisFiyati decimal,
Adet int,
DvdID int
)

alter table Dvdler 
add constraint fk_raf foreign key (RafID) references Raflar(RafID)

alter table Dvdler
add constraint fk_kategori foreign key (KategoriID) references Kategoriler(KatID)

alter table Dvdler
add constraint fk_durum foreign key(DurumID) references DurumlariGoster(DurumID)

alter table Siparisler
add constraint fk_musteri foreign key(MusteriID) references Musteriler(MusteriID)

alter table SiparisDetaylar
add constraint fk_dvd foreign key(DvdID) references Dvdler(DvdID)

insert into Kategoriler(KategoriAdi,KategoriAciklama)
values('Oyun', 'Oyun cdsi')

insert into Kategoriler(KategoriAdi,KategoriAciklama)
values('Müzik', 'Mzüik cdsi')
insert into Kategoriler(KategoriAdi,KategoriAciklama)
values('Film', 'Film cdsi')

select * from Kategoriler

insert into Raflar(RafAdi,RafAciklama) 
values ('Alt','En altta bulunuyor.')


insert into Raflar(RafAdi,RafAciklama) 
values ('Orta','Ortada bulunuyor.')


insert into Raflar(RafAdi,RafAciklama) 
values ('Üst','Üstte bulunuyor.')
SELECT * FROM Raflar

insert into Musteriler(MusteriAdi,MusteriSoyadi,Adres,Tel)
values ('Gamze','Malakci','asdfsdf','00000000')


insert into Musteriler(MusteriAdi,MusteriSoyadi,Adres,Tel)
values ('Gonca','gfsdg','asdfsdf','55555555')


insert into Musteriler(MusteriAdi,MusteriSoyadi,Adres,Tel)
values ('Elif','alala','asdfsdf','55656565')

insert into Musteriler(MusteriAdi,MusteriSoyadi,Adres,Tel)
values ('Ali','ERAER','asdfsdf','23565974')

SELECT * FROM Musteriler

insert into DurumlariGoster(DurumAdi)
values(1)
insert into DurumlariGoster(DurumAdi)
values(2)
insert into DurumlariGoster(DurumAdi)
values(3)
insert into DurumlariGoster(DurumAdi) values ('Yok')

delete from DurumlariGoster where DurumAdi=4

select * from DurumlariGoster

select *from Dvdler

