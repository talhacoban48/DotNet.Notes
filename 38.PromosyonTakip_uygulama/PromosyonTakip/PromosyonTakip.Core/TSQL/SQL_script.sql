create database PromosyonSepeti
go
use PromosyonSepeti

create table SistemMagaza
(
	ID int identity(1,1) primary key,
	tanim nvarchar(100),
	adres nvarchar(100),
	yetkiliKisi nvarchar(50),
	kullaniciAdi nvarchar(50) unique,
	sifre nvarchar(50)
)

insert into SistemMagaza values ('Sefaköy AVM mağaza -1', 'Sefaköy', 'Talha ÇOBAN', 't-coban17', '1')
insert into SistemMagaza values ('Sefaköy AVM mağaza -2', 'Sefaköy', 'Mehmet ÇOBAN', 'm-coban17', '1')
insert into SistemMagaza values ('Cevahir AVM mağaza', 'Şişli', 'Mehmet Şimşek', 'ses', '1')
insert into SistemMagaza values ('Trump Tower AVM mağaza', 'Şişli', 'Trump', 'turp', '1')


select * from SistemMagaza

go

create table PotansiyelMusteri
(
	ID int identity(1,1) primary key,
	tckimlik nvarchar(15),
	isim nvarchar(15),
	soyisim nvarchar(15),
	dogumtarih datetime,
	cinsiyet int,
	meslek nvarchar(50),
	Email nvarchar(100),
	EmailBildirimOnay bit,
	Telefon nvarchar(15),
	TelefonBildirimOnay bit,
	OlusturmaTarihi datetime,
	OlusturanMagaza int
)


select * from PotansiyelMusteri

create table PromosyonUrun 
(
	ID int identity(1,1) primary key,
	tanim nvarchar(100),
	aciklama nvarchar(250),
	gecerlilikTarihi datetime,
	KullanimDurum bit
)

insert into PromosyonUrun values ('%19', 'Tüm mağazalarda geçerli', '2024.03.09', 0)
insert into PromosyonUrun values ('%29', 'Tüm mağazalarda geçerli', '2024.01.22', 0)
insert into PromosyonUrun values ('%39', 'Tüm mağazalarda geçerli', '2024.02.12', 0)
insert into PromosyonUrun values ('%49', 'Tüm mağazalarda geçerli', '2024.03.06', 0)
insert into PromosyonUrun values ('%59', 'Tüm mağazalarda geçerli', '2024.01.16', 0)
insert into PromosyonUrun values ('%69', 'Tüm mağazalarda geçerli', '2024.01.18', 0)
insert into PromosyonUrun values ('%79', 'Tüm mağazalarda geçerli', '2024.02.08', 0)
insert into PromosyonUrun values ('%19', 'Tüm mağazalarda geçerli', '2024.01.09', 0)
insert into PromosyonUrun values ('%29', 'Tüm mağazalarda geçerli', '2024.01.27', 0)
insert into PromosyonUrun values ('%39', 'Tüm mağazalarda geçerli', '2024.02.28', 0)
insert into PromosyonUrun values ('%49', 'Tüm mağazalarda geçerli', '2024.02.16', 0)
insert into PromosyonUrun values ('%59', 'Tüm mağazalarda geçerli', '2024.01.16', 0)
insert into PromosyonUrun values ('%69', 'Tüm mağazalarda geçerli', '2024.01.18', 0)
insert into PromosyonUrun values ('%79', 'Tüm mağazalarda geçerli', '2024.03.25', 0)

select top 42 * from PromosyonUrun where KullanimDurum = 0 order by NEWID()


create table KatilimciPromosyon
(
	ID int identity(1,1) primary key,
	PotansiyelMusteriID int,
	PromosyonUrunID int,
	OlusturmaTarihi datetime,
	MagazaID int
)

select * from KatilimciPromosyon



