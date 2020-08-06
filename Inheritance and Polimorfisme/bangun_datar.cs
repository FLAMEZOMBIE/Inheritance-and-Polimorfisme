using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_Polimorfisme
{
    class bangun_datar
    {
        public virtual float luas()
        {
            Console.WriteLine("==Menghitung Luas Bangun Datar==");
            return 0;
        }
        public virtual float keliling()
        {
            Console.WriteLine("==Menghitung Keliling Bangun Datar==");
            return 0;
        }

    }
}
