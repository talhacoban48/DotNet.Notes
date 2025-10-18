

create table Parabirimi
(
	ParabirimiID uniqueidentifier primary key,
	CurrencyName nvarchar(40),
	Tanim nvarchar(40),
	Uyarilimit decimal
)

delete from Parabirimi where 1 = 1

insert into Parabirimi values (newid(), 'US DOLLAR', 'ABD DOLARI', 30)
insert into Parabirimi values (newid(), 'EURO', 'EURO', 35)
insert into Parabirimi values (newid(), 'POUND STERLING', 'İNGİLİZ STERLİNİ', 40)
insert into Parabirimi values (newid(), 'AZERBAIJANI NEW MANAT', 'AZERBAYCAN YENİ MANATI', 20)
insert into Parabirimi values (newid(), 'JAPENESE YEN', 'JAPON YENİ', 0)
insert into Parabirimi values (newid(), 'QATARI RIAL', 'KATAR RİYALİ', 10)
insert into Parabirimi values (newid(), 'SOUTH KOREAN WON', 'GÜNEY KORE WONU', 0)
insert into Parabirimi values (newid(), 'UNITED ARAB EMIRATES DIRHAM', 'BİRLEŞİK ARAP EMİRLİKLERİ DİRHEMİ', 0)
insert into Parabirimi values (newid(), 'IRANIAN RIAL', 'İRAN RİYALİ', 0)



select * from Parabirimi




create table Kur
(
	KurID uniqueidentifier primary key,
	ParaBirimiID uniqueidentifier,
	ForexBuying decimal(18,4),
	ForexSelling decimal(18,4),
	olusturmaTarihi datetime
)


create table KurGecmisi
(
	KurGecmisiID uniqueidentifier primary key,
	KurID uniqueidentifier,
	ParaBirimiID uniqueidentifier,
	ForexBuying decimal(18,4),
	ForexSelling decimal(18,4),
	olusturmaTarihi datetime
)



create proc KurkayitEkle
(
	@KurID uniqueidentifier,
	@ParaBirimiID uniqueidentifier,
	@ForexBuying decimal(18,4),
	@ForexSelling decimal(18,4),
	@olusturmaTarihi datetime
)
as
begin

	if((select count(*) from Kur where ParaBirimiID = @ParaBirimiID) > 0)
	begin
		insert into KurGecmisi (KurGecmisiID, KurID, ParaBirimiID, ForexBuying, ForexSelling, olusturmaTarihi) select NEWID(), @KurID,@ParaBirimiID,@ForexBuying,ForexSelling,@olusturmaTarihi from Kur where ParabirimiID = @ParaBirimiID
		update Kur set ForexBuying = @ForexBuying, ForexSelling = @ForexSelling where ParabirimiID = @ParaBirimiID
	end
	else
	begin
		insert into Kur values (@KurID, @ParaBirimiID, @ForexBuying, @ForexSelling, @olusturmaTarihi)
	end
end



delete from Kur where 1 = 1
delete from KurGecmisi where 1 = 1


select * from Kur 
select * from KurGecmisi