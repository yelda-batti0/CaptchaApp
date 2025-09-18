using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices2
{
    internal class Program
    {

       

        static void Main(string[] args)
        {
            int d1,d2,d3,d4,d5;     // Değişken Tanımlama 
            
            // "karakterler" adında 20 karakterli bir dizi oluşturma işlemi
            string[] karakterler = { "a", "A", "b", "B", "c", "C", "d", "D", "e", "E", "f", "F", "g", "G", "h", "H", "i", "I", "j", "J" };
            Random rnd = new Random(); // rnd adında random sınıfı oluşturma işlemi
            d1 = rnd.Next(0,20);
            d2 = rnd.Next(0,20);    
            d3 = rnd.Next(0,20);       // Random sayılar oluşturma kod bloğu 
            d4 = rnd.Next(0,20);
            d5 = rnd.Next(0,20);


            // Random sayıları yazdırma işlemi
            Console.WriteLine("***** Random Sayılar *****");
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine();
            Console.WriteLine();

            // Random karakterleri yazdırma işlemi
            Console.WriteLine("***** Random Karakterler *****");
            Console.Write(karakterler[d2]);
            Console.Write(",");
            Console.Write(karakterler[d4]);
            Console.WriteLine();
            Console.WriteLine();


            // Ekrana oluşturulan CAPTCHA kodunun yazdırılması
            Console.WriteLine("Girilecek Kod: " + d1 + karakterler[d2] + d3 + karakterler[d4] + d5);

            Console.Read();

        }
    }
}
