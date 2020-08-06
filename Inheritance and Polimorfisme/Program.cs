using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_Polimorfisme
{
    class Program
    {
        static void Main(string[] args)
        {
            void quit()
            {
                System.Environment.Exit(1);
            }
            int menu()
            {
                Console.Write("=Menu=\n 1. Persegi\n 2. Persegi Panjang\n 3. Segitiga\n 4. Jajar Genjang\n 5. Trapesium\n 6. Layang - Layang\n 7. Belah Ketupat\n Pilih Menu Di atas : ");
                int pilih = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("===========");
                return pilih;
            }
            void Main()
            {
                bangun_datar Bangun_Datar = new bangun_datar();
                Bangun_Datar.luas();
                Bangun_Datar.keliling();
                int pilih = menu();
                Console.WriteLine();
                if (pilih == 1)
                {
                    persegi persegi = new persegi();
                    Console.Write("Inputkan sisi : ");
                    float input = float.Parse(Console.ReadLine());
                    persegi.sisi = input;
                    persegi.luas();
                    persegi.keliling();
                    Console.Write("\n\nContinue? D/N:");
                    string D = Console.ReadLine();
                    if ((D == "Done") | (D == "done"))
                    {
                        System.Console.Clear();
                        Main();
                    }
                    else
                    {
                        quit();
                    }
                }
                else if (pilih == 2)
                {
                    Persegi_Panjang persegi_Panjang = new Persegi_Panjang();
                    Console.Write("Inputkan panjang : ");
                    float inputp = float.Parse(Console.ReadLine());
                    Console.Write("Inputkan lebar : ");
                    float inputl = float.Parse(Console.ReadLine());
                    persegi_Panjang.panjang = inputp;
                    persegi_Panjang.panjang = inputl;
                    persegi_Panjang.luas();
                    persegi_Panjang.keliling();
                    Console.Write("\n\nContinue? D/N:");
                    string y = Console.ReadLine();
                    if ((y == "Done") | (y == "done"))
                    {
                        System.Console.Clear();
                        Main();
                    }
                    else
                    {
                        quit();
                    }
                }
                else if (pilih == 3)
                {
                    Segitiga segitiga = new Segitiga();
                    Console.Write("Inputkan alas : ");
                    float inputa = float.Parse(Console.ReadLine());
                    Console.Write("Inputkan tinggi : ");
                    float inputt = float.Parse(Console.ReadLine());
                    segitiga.alas = inputa;
                    segitiga.tinggi = inputt;
                    segitiga.luas();
                    segitiga.keliling();
                    Console.Write("\n\nContinue? D/N:");
                    string y = Console.ReadLine();
                    if ((y == "Done") | (y == "done"))
                    {
                        System.Console.Clear();
                        Main();
                    }
                    else
                    {
                        quit();
                    }
                }
                else if (pilih == 4)
                {
                    Jajar_Genjang jajar_Genjang = new Jajar_Genjang();
                    Console.Write("Inputkan sisi miring : ");
                    float inputm = float.Parse(Console.ReadLine());
                    Console.Write("Inputkan sisi alas : ");
                    float inputa = float.Parse(Console.ReadLine());
                    Console.Write("Inputkan tinggi : ");
                    float inputt = float.Parse(Console.ReadLine());
                    jajar_Genjang.sisi_miring = inputm;
                    jajar_Genjang.alas = inputa;
                    jajar_Genjang.tinggi = inputt;
                    jajar_Genjang.luas();
                    jajar_Genjang.keliling();
                    Console.Write("\n\nContinue? D/N:");
                    string y = Console.ReadLine();
                    if ((y == "Done") | (y == "done"))
                    {
                        System.Console.Clear();
                        Main();
                    }
                    else
                    {
                        quit();
                    }
                }
                else if (pilih == 5)
                {
                    Trapesium trapesium = new Trapesium();
                    Console.Write("Inputkan sisi atas : ");
                    float inputa = float.Parse(Console.ReadLine());
                    Console.Write("Inputkan tinggi : ");
                    float inputt = float.Parse(Console.ReadLine());
                    Console.Write("Inputkan sisi miring : ");
                    float inputm = float.Parse(Console.ReadLine());
                    Console.Write("Inputkan sisi bawah : ");
                    float inputb = float.Parse(Console.ReadLine());
                    trapesium.sisi_atas = inputa;
                    trapesium.tinggi = inputt;
                    trapesium.sisi_miring = inputm;
                    trapesium.sisi_bawah = inputb;
                    trapesium.luas();
                    trapesium.keliling();
                    Console.Write("\n\nContinue? D/N:");
                    string y = Console.ReadLine();
                    if ((y == "Done") | (y == "done"))
                    {
                        System.Console.Clear();
                        Main();
                    }
                    else
                    {
                        quit();
                    }
                }
                else if (pilih == 6)
                {
                    Layang_Layang layang_Layang = new Layang_Layang();
                    Console.Write("Inputkan sisi atas : ");
                    float inputa = float.Parse(Console.ReadLine());
                    Console.Write("Inputkan sisi bawah : ");
                    float inputb = float.Parse(Console.ReadLine());
                    Console.Write("Masukkan diagonal satu : ");
                    float inputd1 = float.Parse(Console.ReadLine());
                    Console.Write("Masukkan diagonal dua : ");
                    float inputd2 = float.Parse(Console.ReadLine());
                    layang_Layang.sisi_atas = inputa;
                    layang_Layang.sisi_bawah = inputb;
                    layang_Layang.d1 = inputd1;
                    layang_Layang.d2 = inputd2;
                    layang_Layang.luas();
                    layang_Layang.keliling();
                    Console.Write("\n\nContinue? D/N:");
                    string y = Console.ReadLine();
                    if ((y == "Done") | (y == "done"))
                    {
                        System.Console.Clear();
                        Main();
                    }
                    else
                    {
                        quit();
                    }
                }
                else if (pilih == 7)
                {
                    Belah_Ketupat belah_Ketupat = new Belah_Ketupat();
                    Console.Write("Inputkan sisi : ");
                    float input = float.Parse(Console.ReadLine());
                    Console.Write("Inputkan diagonal satu : ");
                    float inputd1 = float.Parse(Console.ReadLine());
                    Console.Write("Inputkan diagonal dua : ");
                    float inputd2 = float.Parse(Console.ReadLine());
                    belah_Ketupat.sisi = input;
                    belah_Ketupat.d1 = inputd1;
                    belah_Ketupat.d2 = inputd2;
                    belah_Ketupat.luas();
                    belah_Ketupat.keliling();
                    Console.Write("\n\nContinue? D/N:");
                    string y = Console.ReadLine();
                    if ((y == "Done") | (y == "done"))
                    {
                        System.Console.Clear();
                        Main();
                    }
                    else
                    {
                        quit();
                    }
                }
                else
                {
                    System.Console.Clear();
                    Console.WriteLine("Wrong Syntax");
                    Main();
                }
            }
            Main();
            Console.WriteLine();
        }
    }
}


