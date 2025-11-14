using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _08_Metodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bu programda derste işlenen metod çeşitlerinden oluşan toplam bir örnek vardır.
            #region METODLARI UYGULAMA
            Selamla();
            GirisYap("Gökçe", "Toprakal");
            SonSinav(1);
            Dersİstegi("Matematik");
            ortHesapla(45, 34, 100);
            #endregion

            #region METOD UYGULAMASI - OKUL SİSTEMİ

            #region VOID METOD -- Selamlama
            void Selamla()
            {
                Console.WriteLine("İyi günler, okul sistemine hoş geldiniz!");
            }
            #endregion

            #region DEĞER DÖNDÜRMEYEN STRING PARAMETRELİ METOD
            void GirisYap(string isim, string soyisim)
            {
                Console.WriteLine($"Merhaba {isim} {soyisim}");
            }
            #endregion
            #region DEĞER DÖNDÜRMEYEN INT PARAMETRELİ METOD
            void SonSinav(int dersno)
            {
                if (dersno == 1)
                {
                    Console.WriteLine("Matematik");
                }
                else if (dersno == 2)
                {
                    Console.WriteLine("Türkçe");
                }
                else if (dersno == 3) {
                    Console.WriteLine("Fen Bilimleri");
                }
                else if (dersno == 4)
                {
                    Console.WriteLine("Sosyal Bilgiler");
                }
                else
                {
                    Console.WriteLine("Geçerli bir kod giriniz.");
                }
            }
            #endregion
            #region DEĞER DÖNDÜREN STRING PARAMETRELİ METOD
            string Dersİstegi(string dersAdi)
            {
                string mesaj = $"{dersAdi} hakkında ne öğrenmek istersin?";
                return mesaj;
            }
            #region DEĞER DÖNDÜREN INT PARAMETRELİ METOD
            double ortHesapla(int vize, int final, int but)
            {
                if(final>=50 && final<= 100)
                {
                    double ort = vize * 0.4 + final * 0.6;
                    int ortalama = Convert.ToInt32(ort);
                    return ortalama;
                }
                else
                {
                    double ort = vize * 0.4 + but * 0.6;
                    int ortalama = Convert.ToInt32(ort);
                    return ortalama;
                }
            }
            #endregion
            #endregion
            
            #endregion
        }
    }
}
