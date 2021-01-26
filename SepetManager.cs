using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention

        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi: " + urun.Adi);

        }

        public void Ekle2(string urunAdi, string acikalma, double fiyat,int stokAdeti)
        {
            Console.WriteLine("Sepete Eklendi: " + urunAdi);


        }


    }
}
