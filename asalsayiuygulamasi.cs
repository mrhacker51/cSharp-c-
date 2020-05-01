using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asalsayiuygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            if (IsPrime(6))
            {
                Console.WriteLine("Asaldır");
            }
            else
            {
                Console.WriteLine("Asal Degildir");
            }
            Console.ReadLine();
        }


        private static bool IsPrime(int number)
        {
            bool result = true;
            for (int  i = 2;  i < number-1;  i++)
            {
                if (number%i == 0)
                {
                    result = false;
                    i = number;
                }
            }
            return result;
        }
    }
}
