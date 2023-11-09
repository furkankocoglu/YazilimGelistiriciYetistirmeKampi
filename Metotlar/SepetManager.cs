namespace Metotlar
{
	internal class SepetManager
	{
		//naming convention
		//syntax
		public void Ekle(Urun urun)
		{
			Console.WriteLine("Tebrikler, sepete eklendi" + urun.Adi);
		}

		public void Ekle2(string urunAdi,string aciklama, double fiyat, int stokAdedi)
		{
			Console.WriteLine("Tebrikler, sepete eklendi" + urunAdi);
		}
	}
}
