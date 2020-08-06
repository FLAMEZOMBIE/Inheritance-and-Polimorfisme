using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_Polimorfisme
{
    class persegi : bangun_datar
    {
        public float sisi;
        public override float luas()
        {
            float luas = sisi * sisi;
            Console.WriteLine("Luas Persegi : " + luas);
            return luas;
        }
        public override float keliling()
        {
            float keliling = 4 * sisi;
            Console.WriteLine("Keliling Persegi : " + keliling);
            return keliling;
        }

    }
}
