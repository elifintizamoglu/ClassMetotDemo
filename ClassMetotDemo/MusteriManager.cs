using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri uye)
        {
            Console.WriteLine(uye.Id +" "+ uye.Ad +" "+ uye.Soyad+" "+ uye.HesapNo +" "+ uye.HesaptakiPara);
            Console.WriteLine("Müşteri Eklendi. \n");
        }
        public void Sil(Musteri uye)
        {
            Console.WriteLine(uye.HesapNo + " hesap numaralı müşteri silindi. \n");
        }
        public void Listele(Musteri uye)
        {
            Console.WriteLine("Id:" + uye.Id);
            Console.WriteLine("Ad:" + uye.Ad);
            Console.WriteLine("Soyad:" + uye.Soyad);
            Console.WriteLine("Hesap No:" + uye.HesapNo);
            Console.WriteLine("Hesaptaki Para:" + uye.HesaptakiPara);
            Console.WriteLine("\n");
        }
    }
}
