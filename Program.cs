using System;

namespace Oyun
{
    class Program
    {
        static void Main(string[] args)
        {
            Oyuncu oyuncu1 = new Oyuncu();
            oyuncu1.OyuncıAdi = "AHMET";
            oyuncu1.OyuncuSoyadi = "BATMAN";
            oyuncu1.TcNo = "12345";

            Oyuncu oyuncu2 = new Oyuncu();
            oyuncu2.OyuncıAdi = "FERHAT";
            oyuncu2.OyuncuSoyadi = "SAĞLAM";
            oyuncu2.TcNo = "54321";

            Oyuncu[]oyuncular = new Oyuncu[] { oyuncu1, oyuncu2 };

            OyuncuService oyuncuManager = new OyuncuService();
            oyuncuManager.Ekle(oyuncu2);
            oyuncuManager.SatisYAP(oyuncu1);
            oyuncuManager.KampanyaEkle(oyuncu2);
            oyuncuManager.Güncelle(oyuncu1);
            oyuncuManager.Sil(oyuncu2);

        }
    }
}
