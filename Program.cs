using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sesli_sessiz_ayirma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cümle Giriniz: ");
            string cumle = Console.ReadLine().ToLower();
            char[] sesliler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            char[] sessizler = { 'b', 'c', 'ç', 'd', 'f', 'g', 'ğ', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'r', 's', 'ş', 't', 'v', 'y', 'z' };
            int toplam = 0;
            foreach (char karakter in cumle)
            {
                foreach (char sesli in sesliler)
                {
                    if (karakter == sesli)
                    {
                        toplam++;
                    }
                }
            }
            foreach (char karakter in cumle)
            {
                foreach (char sessiz in sessizler)
                {
                    if (karakter == sessiz)
                    {
                        toplam++;
                    }
                }
            }
            Console.WriteLine("Cümlede {0} Tane Sesli Harf Vardır", toplam);
            Console.ReadLine();
            Console.WriteLine("Cümlede {0} Tane Sessiz Harf Vardır", toplam);
            Console.ReadLine();
        }
    }

}
