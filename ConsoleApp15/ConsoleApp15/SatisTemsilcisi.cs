using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class SatisTemsilcisi : Calisan
    {

        public SatisTemsilcisi(string ad, string soyad, string departman)
       : base(ad, soyad, departman) { }

        public override void Gorev()
        {
            Console.WriteLine("Satış temsilcisi olarak çalışıyorum.");
        }
    }
}
