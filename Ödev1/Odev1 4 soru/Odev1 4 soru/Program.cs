using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev1_4_soru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir Cümle Yazınız: ");
            String sayiDizisi = Console.ReadLine();

            int harf = sayiDizisi.Length;
            string[] bos = sayiDizisi.Split(' ');
            int bosluksuzharf = harf - (bos.Length - 1);
        }
    }
}
