create proc KurkayitEkle
(
	@KurID uniqueidentifier,
	@ParaBirimiID uniqueidentifier,
	@ForexBuying decimal,
	@ForexSelling decimal,
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