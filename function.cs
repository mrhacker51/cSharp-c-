using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sayilar(20,20));
            Console.ReadLine();
        }

            static int Sayilar(int number1, int number2)
            {
              int result = number1 + number2;
              return result;
            }
        }
    }
