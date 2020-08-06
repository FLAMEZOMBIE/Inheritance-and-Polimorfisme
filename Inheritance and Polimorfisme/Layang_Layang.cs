using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_Polimorfisme
{
    class Layang_Layang : bangun_datar
    {
        public float sisi_atas;
        public float sisi_bawah;
        public float d1;
        public float d2;

        public override float luas()
        {
            float luas = 0.5f * d1 * d2;
            Console.WriteLine("Luas Layang - Layang  : " + luas);
            return luas;
        }
        public override float keliling()
        {
            float keliling = 2 * (sisi_atas * sisi_bawah);
            Console.WriteLine("Keliling Layang - Layang : " + keliling);
            return keliling;
        }

    }
}
