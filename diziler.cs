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
            //String[] students = new string[3];  // 1. Yol
            //students[0] = "China Girls";
            //students[1] = "Russian Girls";
            //students[2] = "Turkey Girls";

            string[] students = { "China Girls", "Russian Girls", "Turkey Girls" };
            foreach (var love in students)
            {
                Console.WriteLine(love);
            }

            Console.ReadLine();
        }
            }
        }
