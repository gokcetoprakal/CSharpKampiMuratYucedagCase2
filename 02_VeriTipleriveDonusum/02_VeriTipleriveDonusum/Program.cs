using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_VeriTipleriveDonusum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Veri Tipleri
            /*int i = 0;
            double a = 2.4; // virgüllü
            string isim = "Ayşe";
            char ilkHarf = 'A'; // tek tırnakla gösterilir
            bool dogruMu = false;
            double sayi = 3.2;
            int sayiDegisim = Convert.ToInt32(sayi);//yuvarlar
            Console.WriteLine(sayiDegisim);*/
            #endregion

            #region ÖRDEK Mİ KAZ MI?
            Console.WriteLine("Bu oyunun amacı girilen 3 tane sayının ortalamasının tek veya çift olup olmadığına göre ördek veya kazı bulmaktır.");
            Console.WriteLine("");
            string ordek = "Ördek";
            string kaz = "Kaz";
            bool ordekMi;

            Console.Write("İlk sayıyı gir:");
            int x = int.Parse(Console.ReadLine());
            Console.Write("İkinci sayıyı gir:");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Üçüncü sayıyı gir:");
            int z = int.Parse(Console.ReadLine());
            double ort = (x + y + z) / 3;
            int ortInt = Convert.ToInt32(ort);
            if(ortInt %  2 == 0)
            {
                ordekMi = true;
            }
            else
            {
                ordekMi = false;
            }
            if(ordekMi == true)
            {
                Console.WriteLine(ordek);
            }
            else
            {
                Console.WriteLine(kaz);
            }
            #endregion
        }
    }
}
