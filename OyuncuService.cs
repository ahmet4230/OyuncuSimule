using System;
using System.Collections.Generic;
using System.Text;

namespace Oyun
{
    class OyuncuService : Oyuncu
    {
        public void Ekle(Oyuncu oyuncu)
        {
            Console.WriteLine("oyuncu eklendi " + oyuncu.OyuncıAdi + " " + oyuncu.OyuncuSoyadi + " " + oyuncu.TcNo);
        }

        public void Güncelle(Oyuncu oyuncu)
        {
            Console.WriteLine("oyuncu güncellendi " + oyuncu.OyuncıAdi + " " + " " + oyuncu.OyuncuSoyadi);
        }

        public void KampanyaEkle(Oyuncu oyuncu)
        {
            Console.WriteLine("oyuncuya kampanya eklendi " +oyuncu.OyuncıAdi + " " + " " + oyuncu.OyuncuSoyadi);
        }

        public void SatisYAP(Oyuncu oyuncu)
        {
            Console.WriteLine("Oyuncuya satış yapıldı " + oyuncu.OyuncıAdi + " " + " " + oyuncu.OyuncuSoyadi);
        }

        public void Sil(Oyuncu oyuncu)
        {
            Console.WriteLine("oyuncu silindi " + oyuncu.OyuncıAdi + " " + " " + oyuncu.OyuncuSoyadi);
        }
    }
}
