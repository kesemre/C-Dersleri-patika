using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev1_2.soru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Modu alınacak sayıyı girniz ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Kaç Adet Sayı Girmek İstersiniz: ");
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
                if (sayiDizisi[i] % m == 0 || sayiDizisi[i] == m)
                {
                    bolonebilenSayi++;
                    Console.Write(sayiDizisi[i] + " ");
                }
            }
            Console.WriteLine("Tam Bölünene sayı sayısı: " + bolonebilenSayi);
        }
    }
}
