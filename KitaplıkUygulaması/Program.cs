using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KitaplıkUygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplamfiyat = 0;
            string secim;
            Console.WriteLine("*******************************************************************");
            Console.WriteLine();
            Console.WriteLine("***      Tükrçe Kitaplar      ***      Yabancı Dil Kitaplar     ***");
            Console.WriteLine();
            Console.WriteLine("***  1-Çalıkuşu : Reşat Nuri ***  7-Tuna Kılavuzu : Jules Verne ***");
            Console.WriteLine();
            Console.WriteLine("***  2-Tutunamayanlar : Oğuz atay ***  8-Yabancı : Albert Camus ***");
            Console.WriteLine();
            Console.WriteLine("***  3-Huzur : Ahmed Hamdi      ***    9-Dava : Franz Kafka     ***");
            Console.WriteLine();
            Console.WriteLine("***  4-Aylak Adam : Yusuf A. ***     10-Gülün Adı : Umberto Eco ***");
            Console.WriteLine();
            Console.WriteLine("***  5-Eylül : Mehmet Rauf  ***  11-Lolita : Vladimir Nabokov   ***");
            Console.WriteLine();
            Console.WriteLine("***  6-Gece : Bilge karasu    ***     12-Şaka : Milan Kundera   ***");
            Console.WriteLine();
            Console.WriteLine("***** İŞLEMLER *****");
            Console.WriteLine();
            Console.WriteLine("1- Fiyat Sorgulama ");
            Console.WriteLine("2- Yeni Okur Kaydı");
            Console.WriteLine("3- Günün Kitabı   ");
            Console.WriteLine("4- Kitap Arşivi   ");
            Console.WriteLine("5- Kitap satın alma");
            Console.WriteLine();
            Console.Write("Yapmak istediğiniz işlemin numarası : ");
            char islem;
            islem =Convert.ToChar(Console.ReadLine());
            
            if (islem == '1') 
            {
                Console.WriteLine();
                Console.WriteLine("İşlem : Fiyatını Sorgulamak istediğiniz kitabın numarasını giriniz :  ");
                string numara;
                numara = Console.ReadLine();
                switch (numara) 
                {
                    case "1":Console.Write("Çalışkuşu : 68 TL"); break;
                    case "2": Console.Write("Tutunamayanlar : 45 TL"); break;
                    case "3": Console.Write("Huzur : 43 TL"); break;
                    case "4": Console.Write("Aylak Adam : 49 TL"); break;
                    case "5": Console.Write("Eylül : 35 TL"); break;
                    case "6": Console.Write("Gece : 35 TL"); break;

                    case "7": Console.Write("Tuna Kılavuzu : 88 TL"); break;
                    case "8": Console.Write("Yabancı : 45 TL"); break;
                    case "9": Console.Write("Dava : 13 TL"); break;
                    case "10": Console.Write("Gülün Adı : 19 TL"); break;
                    case "11": Console.Write("Lolita : 55 TL"); break;
                    case "12": Console.Write("Şaka : 25 TL"); break;


                }
            }

            if (islem =='2') 
            {
                Console.WriteLine();
                Console.WriteLine("***** Yeni Okur Kaydı *****");
                string ad, soyad, okul;
                Console.Write("Adınız : ");
                ad = Console.ReadLine();
                Console.Write("Soyadınız : ");
                soyad = Console.ReadLine();
                Console.Write("Bulunduğunuz Üniversite : ");
                okul = Console.ReadLine();

                string dosya = "C:\\Users\\Cetin\\Desktop\\Yeni Metin Belgesi.txt"; //masaüstünde metin belgesi oluşturup alınan bilgileri yazar
                StreamWriter sw = new StreamWriter(dosya);
                sw.WriteLine("adınız : "+ad);
                sw.WriteLine("soyadınız : "+soyad);
                sw.WriteLine("okulunuz : "+okul);
                sw.Close();




            }

            if (islem == '3')
            {
                Console.WriteLine();
                Console.WriteLine("Günü Kitabı :  Tutunamayanlar : Oğuz atay");

            }

            if (islem == '4')
            {
                Console.WriteLine();
                Console.WriteLine("***********************");
                Console.WriteLine();
                FileStream fs = new FileStream("‪C:\\Users\\Cetin\\Desktop\\kitaplar.txt",FileMode.Open,FileAccess.Read);
                StreamReader sd = new StreamReader(fs);
                string metin = sd.ReadLine();
                while (metin != null) 
                {
                    Console.WriteLine(metin);
                    metin = sd.ReadLine();
                }
                sd.Close();
                fs.Close();
                Console.WriteLine();
                Console.WriteLine("***********************");
                Console.WriteLine();
            }

            if (islem == '5')
            {
                for (int i = 1; i <= 100; i++) 
                {
                    Console.WriteLine();
                    Console.Write("Alacağınız kitabın numarası : ");
                    secim = Console.ReadLine();
                    if (secim == "1")
                    {
                        toplamfiyat = toplamfiyat + 68;
                    }

                    else if (secim == "2")
                    {
                        toplamfiyat = toplamfiyat + 45;
                    }
                    else if (secim == "3")
                    {
                        toplamfiyat = toplamfiyat + 43;
                    }
                    else if (secim == "4")
                    {
                        toplamfiyat = toplamfiyat + 49;
                    }
                    else if (secim == "5")
                    {
                        toplamfiyat = toplamfiyat + 35;
                    }
                    else if (secim == "6")
                    {
                        toplamfiyat = toplamfiyat + 35;
                    }

                    else if (secim == "7")
                    {
                        toplamfiyat = toplamfiyat + 88;
                    }
                    else if (secim == "8")
                    {
                        toplamfiyat = toplamfiyat + 45;
                    }
                    else if (secim == "9")
                    {
                        toplamfiyat = toplamfiyat + 13;
                    }
                    else if (secim == "10")
                    {
                        toplamfiyat = toplamfiyat + 19;
                    }
                    else if (secim == "11")
                    {
                        toplamfiyat = toplamfiyat + 55;
                    }
                    else if (secim == "12")
                    {
                        toplamfiyat = toplamfiyat + 25;
                    }
                    else
                    
                        Console.WriteLine("Böyle bir kitap yok");
                        Console.WriteLine();
                        Console.Write("Başka bir kitap istermisiniz : ");
                        string cevap = Console.ReadLine();
                        if (cevap == "h" || cevap == "H" || cevap == "HAYIR" || cevap == "hayır ")
                            break;
                    
                    
                }

                Console.WriteLine("Toplam tutar :" + toplamfiyat);
            }

        

            Console.Read();
        }
    }
}
