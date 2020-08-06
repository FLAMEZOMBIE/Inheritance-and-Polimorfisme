using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_Polimorfisme
{
    class Persegi_Panjang : bangun_datar
    {
        public float panjang;
        public float lebar;

        public override float luas()
        {
            float luas = panjang * lebar;
            Console.WriteLine("Luas Persegi Panjang : " + luas);
            return luas;
        }
        public override float keliling()
        {
            float keliling = 2 * panjang + 2 * lebar;
            Console.WriteLine("Keliling Persegi Panjang :" + keliling);
            return keliling;
        }


    }
}
