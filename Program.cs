





using _05.Ders;

GercekMusteri musteri1 = new GercekMusteri();
musteri1.Id = 1;
musteri1.MusteriNo = "12345";
musteri1.Adi = "Ali";
musteri1.soyadi = "Can";
musteri1.TcNo = "7563201485";

TuzelMusteri musteri2 = new TuzelMusteri();
musteri2.Id = 2;
musteri2.MusteriNo = "54321";
musteri2.SirketAdi = "Gurcan Otomotiv";
musteri2.VergiNo = "1299900000";


Musteri musteri3 = new GercekMusteri();
Musteri musteri4 = new TuzelMusteri();



CustomerManager customerManager = new CustomerManager();

customerManager.Add(musteri1);
customerManager.Add(musteri2);
customerManager.Add(musteri3);
customerManager.Add(musteri4);
