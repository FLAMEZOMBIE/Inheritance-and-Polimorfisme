using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_Polimorfisme
{
    class Belah_Ketupat : bangun_datar
    {
        public float sisi;
        public float d1;
        public float d2;

        public override float luas()
        {
            float luas = 0.5f * d1 * d2;
            Console.WriteLine("Luas Belah Ketupat  : " + luas);
            return luas;
        }
        public override float keliling()
        {
            float keliling = 4 * sisi;
            Console.WriteLine("Keliling Belah Ketupat  : " + keliling);
            return keliling;
        }

    }
}
