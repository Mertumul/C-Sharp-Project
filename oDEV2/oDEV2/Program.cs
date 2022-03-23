/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2014-2015 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........:1
**				ÖĞRENCİ ADI............:Mert Umul
**				ÖĞRENCİ NUMARASI.......:B201210049
**               DERSİN ALINDIĞI GRUP...:C
****************************************************************************/
using System;
namespace Ödev1

{
    static class Sifrekontrolu
    {
        //degiskenleri tanimladim.
        static string sifre;
        static int kucukHarfSayisi = 0;
        static int buyukHarfSayisi = 0;
        static int rakamSayisi = 0;
        static int sembolSayisi = 0;
        static int toplampuan = 0;
        //statik sifreal fonksiyonu olusturdum bu fonksiyon mainde yazdıgımız sifreyi classın icine tasıyor.
        public static void sifreal(string sifre1)
        {
            sifre = sifre1;

        }
        // statik int buyukharfsayisi fonksiyonu oluşturdum bu fonksiyon return ile buyuk harf sayisini döndürüyor.
        public static int BuyukHarfSayisi()
        {
            for (int i = 0; i < sifre.Length; i++)
            {
                if (sifre[i] >= 'A' && sifre[i] <= 'Z')
                {
                    buyukHarfSayisi++;
                }
            }
            return buyukHarfSayisi;
        }
        // statik int kucukharfsayisi fonksiyonu oluşturdum bu fonksiyon return ile kucuk harf sayisini döndürüyor.

        public static int KucukHarfSayisi()
        {
            for (int i = 0; i < sifre.Length; i++)
            {
                if (sifre[i] >= 'a' && sifre[i] <= 'z')
                {
                    kucukHarfSayisi++;
                }
            }
            return kucukHarfSayisi;
        }
        // statik int rakamsayisi fonksiyonu oluşturdum bu fonksiyon return ile rakam sayisini döndürüyor.
        public static int RakamSayisi()
        {
            for (int i = 0; i < sifre.Length; i++)
            {
                if (sifre[i] >= '0' && sifre[i] <= '9')
                {
                    rakamSayisi++;
                }
            }
            return rakamSayisi;
        }
        // statik int sembolsayisi fonksiyonu oluşturdum bu fonksiyon return ile sembol sayisini döndürüyor.
        public static int SembolSayisi()
        {
            for (int i = 0; i < sifre.Length; i++)
            {
                if (!((sifre[i] >= 'A' && sifre[i] <= 'Z') || (sifre[i] >= 'a' && sifre[i] <= 'z') || (sifre[i] >= '0' && sifre[i] <= '9')))
                {
                    sembolSayisi++;

                }

            }
            return sembolSayisi;
        }
        //void fonksiyonunda toplam puanı yazdırdım eğer puan 100 den büyükse puanı 100 e esitledim ve puana göre sifre gücünü belirlettim.
        public static void puanHesaplamaveSifreGücü() {
            
            if (buyukHarfSayisi <= 2)
                toplampuan += buyukHarfSayisi * 10;

            else if (buyukHarfSayisi > 2)
                toplampuan += 20;

            if (kucukHarfSayisi <= 2)
                toplampuan += kucukHarfSayisi * 10;

            else if (kucukHarfSayisi > 2)
                toplampuan += 20;

            if (rakamSayisi <= 2)
                toplampuan += rakamSayisi * 10;

            else if (rakamSayisi > 2)
                toplampuan += 20;
            if ((buyukHarfSayisi + kucukHarfSayisi + rakamSayisi + sembolSayisi) == 9)
                toplampuan += 10;

            toplampuan += sembolSayisi * 10;

            if (toplampuan > 100)
            {
                toplampuan = 100;
                Console.WriteLine("Sifre kabul edildi sifreniz güclü!");
            }
            else if (toplampuan >= 90 && toplampuan < 100)
                Console.WriteLine("Sifre kabul edildi sifreniz güclü!");
            else if (toplampuan >= 70 && toplampuan < 90)
                Console.WriteLine("Sifre kabul edildi!");
            else if (toplampuan < 70)
                Console.WriteLine("Sifre Kabul Edilemez!");
           Console.WriteLine("Toplam Puan={0}", toplampuan);           
        }
 
    }
    class Program
    {
        static void Main(string[] args)
        {
            //degiskenleri tanimladim.

            int buyukharfsayisi = 0;
            int kucukharfsayisi = 0;
            int rakamsayisi = 0;
            int sembolsayisi = 0;
            Console.WriteLine("                                            SIFRE OLUŞTURMA KURALLARI                                            ");
            Console.WriteLine("Sifre olusturken dikkat edilecek seyler.");
            Console.WriteLine("1.Sifreniz bosluk içeremez.");
            Console.WriteLine("2.Sifreniz 9 karakter ve üzeri olmalıdır.");
            Console.WriteLine("3.Sifrede en az bir büyük harf,bir kücük harf,bir rakam ve bir sembol bulunması zorunludur.");
            Console.WriteLine("4.Puanlama türünde 70 ve 70 in üzerinde puan alınmalıdır.");
            Console.WriteLine("  a) Her bir küçük harf 10 puan ve en fazla 20 puan alınabilir.");
            Console.WriteLine("  b) Her bir büyük harf 10 puan ve en fazla 20 puan alınabilir.");
            Console.WriteLine("  c) Her bir rakam 10 puan ve  en fazla 20 puan alınabilir.");
            Console.WriteLine("  d) Her bir sembol 10 puandır. ");
            Console.WriteLine("  e) Sifre 9 karakter ise 10 puan eklenir.");
            //sifre aldırttım.
            Console.Write("Istediginiz bir sifreyi girin:");
            string sifre = Console.ReadLine();
            //sifre karakter uzunluğunu yazdırttım.
            Console.WriteLine("Sifrenin karakter sayisi:{0}", sifre.Length);
            //burada bosluk kontrolü icin  boslukkontrolü icin degiskene 0 degerine atadım.Eger döngünün icindeki if blogu dogru ise boslukkontolü degiskenini bir arttirir böylece bosluk kontrolünü yaparız.
            int boslukkontrol = 0;
            for (int k = 0; k < sifre.Length; k++)
            {
                //eger sifrenin k'ncı elemanı bosluk ise true dönderir.
                if (char.IsWhiteSpace(sifre, k))
                    boslukkontrol++;
            }
            //yani bosluk yok ise
            if (boslukkontrol == 0)
            {
                //burada sifrenin karakter uzunlugunu kontrol ettirdim eger 9 dan buyuk ise diger adımlari yapar.
                if (sifre.Length >= 9)
                {
                    //yukarıdaki tanimladigim fonksiyonlari cagirdim.
                    Sifrekontrolu.sifreal(sifre);
                    buyukharfsayisi = Sifrekontrolu.BuyukHarfSayisi();
                    kucukharfsayisi = Sifrekontrolu.KucukHarfSayisi();
                    rakamsayisi = Sifrekontrolu.RakamSayisi();
                    sembolsayisi = Sifrekontrolu.SembolSayisi();
                    //En az birer tane buyuk harf,kucuk harf,rakam ve sembol kontrolü
                    if (kucukharfsayisi == 0 || buyukharfsayisi == 0 || rakamsayisi == 0 || sembolsayisi == 0)
                    {
                        Console.WriteLine("Sifrenizde en az birer tane buyuk harf,kucuk harf,rakam ve sembol bulunmak zorundadır lutfen sifrenizi gözden gecirin");
                    }
                    else
                    {
                        Console.WriteLine("Buyuk Harf Sayisi={0}", buyukharfsayisi);
                        Console.WriteLine("Kucuk Harf Sayisi={0}", kucukharfsayisi);
                        Console.WriteLine("Rakam Sayisi={0}", rakamsayisi);
                        Console.WriteLine("Sembol Sayisi={0}", sembolsayisi);
                        Sifrekontrolu.puanHesaplamaveSifreGücü();
                    }
                }
                else
                {
                    Console.WriteLine("Gecersiz sifre.Sifre 9 karakter ve üzeri olmalıdır.");
                }
            }
            else
                Console.WriteLine("Sifrede bosluk olamaz tekrar deneyin!!"); 
        }
    }
}
