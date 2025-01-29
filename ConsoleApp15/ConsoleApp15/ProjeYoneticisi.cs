using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class ProjeYoneticisi : Calisan
    {
        public ProjeYoneticisi(string ad, string soyad, string departman)
    : base(ad, soyad, departman) { }

        public override void Gorev()
        {
            Console.WriteLine("Proje yöneticisi olarak çalışıyorum.");
        }
    }
}
