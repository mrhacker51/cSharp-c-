using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] regions = new string[5, 3]
            {
                {"İstanbul","Ankara","İzmir" },
                {"Nigde","Mersin","Adana" },
                {"Konya","Nevşehir","Ürgüp" },
                {"Denizli","Pamukkale","Aydın" },
                {"Muş","Malatya","Ordu" },
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                Console.WriteLine("********");
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
            }

            Console.ReadLine();
        }
    }
}
