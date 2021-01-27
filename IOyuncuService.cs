using System;
using System.Collections.Generic;
using System.Text;

namespace Oyun
{
    interface IOyuncuService 
    {
        void Güncelle();
        void Sil();
        void Ekle();
        void KampanyaEkle();
        void SatisYAP();
    }
}
