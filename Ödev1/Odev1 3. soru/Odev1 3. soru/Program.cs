using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev1_3.soru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kaç Adet Kelime Girmek İstersiniz: ");
            int sayiAdeti = int.Parse(Console.ReadLine());
            String[] sayiDizisi = new String[sayiAdeti];
            for (int i = 0; i < sayiAdeti; i++)
            {
                Console.Write("Lütfen {0}. Kelimeyi Giriniz: ", i + 1);
                sayiDizisi[i] = (Console.ReadLine());
            }


            Array.Reverse(sayiDizisi);
            Console.Write("Girmiş Olduğunuz Kelimeler: ");
            for (int i = 0; i < sayiAdeti; i++)
            {
                Console.Write(sayiDizisi[i] + " ");

            }

        }
    }
}
