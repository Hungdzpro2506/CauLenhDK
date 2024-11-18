using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year;
            bool isNamNhuan = false;
            Console.WriteLine("nhap vao nam muon ktra :");
            year = Convert.ToInt32(Console.ReadLine());
            bool Chiahet4 = year % 4 == 0;
            if (Chiahet4)
            {
                bool Chiahet100 = year % 100 == 0;
                if (Chiahet100) 
                {
                   bool Chiahet400= year %400== 0;
                    if(Chiahet400)
                    {
                        isNamNhuan= true;
                    }
                    

                }
                else { isNamNhuan = true; }
            }
            if (isNamNhuan)
            {
                Console.WriteLine("{0} la nam nhuan", year);
            }
            else
            {
                Console.WriteLine("{0} khong phai nam nhuan", year);
            }

        }
    }
}
