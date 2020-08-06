using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_Polimorfisme
{
    class Jajar_Genjang : bangun_datar
    {
        public float sisi_miring;
        public float alas;
        public float tinggi;

        public override float luas()
        {
            float luas = alas * tinggi;
            Console.WriteLine("Luas Jajar Genjang : " + luas);
            return luas;
        }
        public override float keliling()
        {
            float keliling = 2 * (alas + sisi_miring);
            Console.WriteLine("Keliling Jajr Genjang  : " + keliling);
            return keliling;
        }

    }
}
