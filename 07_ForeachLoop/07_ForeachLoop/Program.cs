using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Foreach bir dizinin tüm elemanlarına işlem yapmaya yarar
            #region GRUPLANDIRMA ÖRNEĞİ - indexe göre ayır
            string[] kisiler = new string[] { "Ayşe", "Asya", "İpek", "Gökçe", "Ali", "Kerem", "Mehmet", "Murat" };
            int indexno = 0;
            Console.WriteLine("A GRUBU");
            int sayac = 0;
            foreach (string isim in kisiler)
            {
                if (sayac % 2 == 0) // 0,2,4,...
                {
                    Console.WriteLine(isim);
                }
                sayac++;
            }

            // Tek indexli isimler
            Console.WriteLine("\nB GRUBU");
            sayac = 0;
            foreach (string isim in kisiler)
            {
                if (sayac % 2 != 0) // 1,3,5,...
                {
                    Console.WriteLine(isim);
                }
                sayac++;
                #endregion

            }
        }
    }
}
