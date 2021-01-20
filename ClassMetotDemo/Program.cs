using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri uye1 = new Musteri();
            uye1.Id = 235697;
            uye1.Ad = "Elif";
            uye1.Soyad = "Yılmaz";
            uye1.HesapNo = 11111;
            uye1.HesaptakiPara = 96.41;

            Musteri uye2 = new Musteri(); 
            uye2.Id = 457896;
            uye2.Ad = "Ali";
            uye2.Soyad = "Yıldırım";
            uye2.HesapNo = 22222;
            uye2.HesaptakiPara = 59;

            Musteri uye3 = new Musteri();
            uye3.Id = 129697;
            uye3.Ad = "Ayşe";
            uye3.Soyad = "Çiçek";
            uye3.HesapNo = 33333;
            uye3.HesaptakiPara = 100.45;

            Musteri[] musteriler = new Musteri[] { uye1, uye2, uye3 };

            MusteriManager musteriManager = new MusteriManager();
            
            foreach (var musteri in musteriler)
            {
                musteriManager.Ekle(musteri);
            }

            musteriManager.Sil(uye3);

            for (int i=0; i<musteriler.Length; i++)
            {
                musteriManager.Listele(musteriler[i]);
            }
        }
    }
}
