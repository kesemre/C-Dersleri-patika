using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev_1.soru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Girmek istediğiniz Sayı Adetini Giriniz: ");

            int sayiAdeti = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[sayiAdeti];
            for (int i = 0; i < sayiAdeti; i++)
            {
                Console.Write("Lütfen {0}. Sayısı Giriniz: ", i + 1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Girmiş Olduğunuz Çift Sayılar: ");
            int bolonebilenSayi = 0;
            for (int i = 0; i < sayiAdeti; i++)
            {
                if (sayiDizisi[i] % 2 == 0)
                {
                    bolonebilenSayi++;
                    Console.Write(sayiDizisi[i] + " ");
                }
            }

        }
    }
}
