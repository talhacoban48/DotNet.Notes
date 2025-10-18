create database TelefonRehberi
go
use
TelefonRehberi
go

create table Kullanici
(
	KullaniciID uniqueidentifier primary key,
	KullaniciAdi nvarchar(20) unique,
	Sifre nvarchar(20) not null
)

insert into Kullanici (KullaniciID, KullaniciAdi, Sifre) values (newid(), 'Demo', '12345')


create table Rehber
(
	ID uniqueidentifier primary key,
	isim nvarchar(30) not null,
	soyisim nvarchar(30) not null,
	TelefonNumarasi1 nvarchar(12),
	TelefonNumarasi2 nvarchar(12),
	TelefonNumarasi3 nvarchar(12),
	Email nvarchar(100),
	WebSite nvarchar(100),
	Adress nvarchar(400),
	Aciklama nvarchar(1000)
)


go

create proc spRehberKayitYeni
(
	@ID uniqueidentifier,
	@isim nvarchar(30),
	@soyisim nvarchar(30),
	@TelefonNumarasi1 nvarchar(12),
	@TelefonNumarasi2 nvarchar(12),
	@TelefonNumarasi3 nvarchar(12),
	@Email nvarchar(100),
	@WebSite nvarchar(100),
	@Adress nvarchar(400),
	@Aciklama nvarchar(1000)
)
as
begin
	insert into Rehber (ID, isim, soyisim, TelefonNumarasi1, TelefonNumarasi2, TelefonNumarasi3, Email, WebSite, Adress, Aciklama)
	values (@ID, @isim, @soyisim, @TelefonNumarasi1, @TelefonNumarasi2, @TelefonNumarasi3, @Email, @WebSite, @Adress, @Aciklama)
end


create proc spRehberKayitDuzenle
(
	@ID uniqueidentifier,
	@isim nvarchar(30),
	@soyisim nvarchar(30),
	@TelefonNumarasi1 nvarchar(12),
	@TelefonNumarasi2 nvarchar(12),
	@TelefonNumarasi3 nvarchar(12),
	@Email nvarchar(100),
	@WebSite nvarchar(100),
	@Adress nvarchar(400),
	@Aciklama nvarchar(1000)
)
as
begin
	update Rehber
	set
	isim = @isim,
	soyisim = @soyisim,
	TelefonNumarasi1 = @TelefonNumarasi1,
	TelefonNumarasi2 = @TelefonNumarasi2,
	TelefonNumarasi3 = @TelefonNumarasi3,
	Email = @Email,
	WebSite = @WebSite,
	Adress = @Adress,
	Aciklama = @Aciklama
	where 
	ID = @ID
end


create proc spRehberKayitSil
(
	@ID uniqueidentifier
)
as
begin
	delete Rehber where ID = @ID
end



create proc spRehberListeGetir
as
begin
	select * from Rehber
end


create proc spRehberIDGetir
(
	@ID uniqueidentifier
)
as
begin
	select * from Rehber where ID = @ID
end