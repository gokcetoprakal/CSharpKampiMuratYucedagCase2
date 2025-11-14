using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_KararYapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region IF ELSE
            /*
            Console.Write("Sayı Girin: ");
            int sayi = int.Parse(Console.ReadLine());
            if (sayi > 0) {
                Console.WriteLine("Bu sayı pozitiftir.");
            }
            else if(sayi == 0)
            {
                Console.WriteLine("Bu sayı nötrdür.");
            }
            else
            {
                Console.WriteLine("Bu sayı negatiftir.");
            }
            //mod işlemi
            if (sayi % 2 == 0) { 
            Console.WriteLine("Bu sayı çifttir.");
            }
            else
            {
                Console.WriteLine("Bu sayı tektir.");
            }*/
            #endregion

            #region ÖRDEK Mİ KAZ MI - GELİŞTİRİLMİŞ VERSİYON
            Console.WriteLine("ÖRDEK Mİ KAZ MI?");
            Console.WriteLine("*****************************");
            Console.WriteLine(" ");
            Console.WriteLine("Ördek mi Kaz mı oyunu stratejik bir matematik oyunudur.");
            Console.WriteLine("Oyunun başlangıcında oyuncuya 3 puan verilir.");
            Console.WriteLine("Oyuncu 3 tane sayı girer. Bu sayıların ortalamasından virgüllü kısım çıkarılarak ikiye bölünür ve tek mi çift mi olunduğuna bakılır.");
            Console.WriteLine("Eğer sayı çift ise oyuncu ördek, tek ise kaz almıştır.");
            Console.WriteLine("Ördek alan oyuncunun puanı 1 artar. Kaz alan oyuncunun puanı 1 azalır.");
            Console.WriteLine("Oyuncunun amacı 5 puana çıkmaktır. 5 puana çıkan oyuncu kazanır, 0 puana inen oyuncu kaybeder.");
            Console.WriteLine("Devam etmek için Enter tuşuna basın...");
            Console.ReadLine();
            Console.Clear();

            string ordek = "Ördek";
            string kaz = "Kaz";
            int x, y, z;
            int puan = 3;

                while (puan > 0 && puan < 5)
                {
                    Console.Write("Birinci sayıyı girin: ");
                    x = int.Parse(Console.ReadLine());
                    Console.WriteLine("İkinci sayıyı girin:");
                    y = int.Parse(Console.ReadLine());
                    Console.WriteLine("Üçüncü sayıyı girin:");
                    z = int.Parse(Console.ReadLine());
                    double sonuc = (x + y + z) / 3;
                    Console.WriteLine($"Sonuç:{sonuc}");
                    double sonucMod = sonuc % 2;

                    switch (sonucMod) {
                        case 0:
                            Console.WriteLine(ordek);
                            puan++;
                            break;
                        case 1:
                            Console.WriteLine(kaz);
                            puan--;
                            break;
                    }
                Console.WriteLine("Güncel puanın:" + puan);
                }
                Console.Clear();

                if (puan == 5)
                {
                    Console.WriteLine("SEN BİR ÖRDEKSİN. TEBRİKLER :)");
                }
                else
                {
                    Console.WriteLine("SEN BİR KAZSIN. ÜZGÜNÜM :(");
                }
            #endregion
        }
    }
}
