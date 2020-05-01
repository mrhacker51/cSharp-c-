using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringsveritipi
{
    class Program
    {
        static void Main(string[] args)
        {
            //string city = "Ankara";
            ////string city2 = "İstanbul";

            //foreach (var i in city)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();

            string cyber = "Cyber Security";
            var result = cyber.Length;
            bool result2 = cyber.EndsWith("ty");
            bool result3 = cyber.StartsWith("Cy");
            var result4 = cyber.Replace("Cyber", "Name");
            var result5 = cyber.Substring(3, 4);
            var result6 = cyber.ToLower();
            var result7 = cyber.ToUpper();
            var result8 = cyber.IndexOf("ber");
            var result9 = cyber.LastIndexOf(" ");
            var result10 = cyber.Insert(0, "Hello");
            var result11 = cyber.Remove(2, 7);


            //Console.WriteLine(result); -- Kaç Karakter'den Oluştugunu Gösterir Uzunluk -- Python'da len parametresi 
            //Console.WriteLine(result2); -- Sonunun istedigim bir degerle bitmesini istedigim parametre True veya false döndürür
            //Console.WriteLine(result3); -- Başlangıç parametresi True veya false döndürür boolean veri tipi olarak bool
            //Console.WriteLine(result4); -- Degiştirmek istedigim degerleri giriyorum replace ... (
            //Console.WriteLine(result5); -- Kacıncı index'ten baslamak istedigimi belirtiyorum ...
            //Console.WriteLine(result6); -- Hepsini Küçültür
            //Console.WriteLine(result7); -- Hepsini Büyültür
            //Console.WriteLine(result8); -- Belirledigim degerin Kaçıncı baştan itibaren index'te oldugunu gösterir'
            //Console.WriteLine(result9); -- Sondan kaçıncı index'te oldugunu görüyorum'
            //Console.WriteLine(result10); -- Eklemek istedigim deger 
            //Console.WriteLine(result11); -- Silme parametresi
            Console.ReadLine();
        }
    }
}
