using System;
using System.Collections.Generic;
using C__proje1;

namespace C_proje1{
    public  class KisilerManager{
        public static List<Kisiler> kisilers = new List<Kisiler>();

        static KisilerManager(){
            kisilers.Add(new Kisiler("Emre","KESKİN","213"));
            kisilers.Add(new Kisiler("Enes","KESKİN","112"));
        }
        public KisilerManager (){
            run();
        }
        static void kisiEkle(){
            Console.Write("Kişi adı:");
            string isim = Console.ReadLine();
            Console.Write("Soy isim:");
            string soyIsim = Console.ReadLine();
            Console.Write("Numarayı giriniz:");
            string num = Console.ReadLine();
            kisilers.Add(new Kisiler(isim,soyIsim,num));
            Console.WriteLine("Kişi eklendi");
            run();
        }
        static void kisiSil(){
            Console.Write("Silinecek kişinin adı:");
            string isim = Console.ReadLine();
            Console.Write("Silinecek kişinin Soyadı:");
            string soyIsim = Console.ReadLine();
            for(int i=0;i<kisilers.Count();i++){
                
                if(isim.Equals(kisilers[i].getName) && soyIsim.Equals(kisilers[i].getSurname)){
                    Console.Write("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n):",kisilers[i].getName()+" "+kisilers[i].getSurname());
                    string secim = Console.ReadLine();
                    switch (secim){
                        case "y" or "Y":
                        kisilers.Remove(kisilers[i]);
                        Console.WriteLine("kişi silindi");
                        kisiListeGoruntule();
                        break;

                        case "n" or "N":
                        Console.WriteLine("Ana menüye dönülüyor");
                        run();
                        break;
                    }
                       
                }    
            }
            run();
        }
        static void kisiGuncelle(){
            kisiListeGoruntule();
            Console.Write("Güncellemek istediğniz kişinin adını ve soyadını giriniz");
            Console.Write("Ad:");
            string ad = Console.ReadLine();
            Console.Write("Soyad");
            string soyAd = Console.ReadLine();
            Kisiler yeniKisi;
            int listSize = kisilers.Count();
            for(int i =0;i<listSize;i++){
                if(ad.Equals(kisilers[i]) && soyAd.Equals(kisilers[i].getSurname())){
                    Console.Write("Kişinin Adı:");
                    string yeniAd = Console.ReadLine();
                    Console.Write("Kişinin Soyismi");
                    string yeniSoyisim = Console.ReadLine();
                    Console.Write("Telefon numarası giriniz");
                     string yeniTelefon=Console.ReadLine();
                    kisilers.Remove(kisilers[i]);
                    kisilers.Add(new Kisiler(yeniAd,yeniSoyisim,yeniTelefon));
                }
            
            }

        }
        static void kisiListeGoruntule(){
            foreach(var kisi in kisilers){
                Console.WriteLine("ad: {1} soyad: {2} Telefon: {0}",kisi.getName(),kisi.getSurname(),kisi.getPhoneNumber());      
            }
              run();  
        }
        static void rehberdeArama(){
            Console.WriteLine("numaraya göre aramak için: (1)");
            Console.WriteLine("Isim ve Soyisme göre arama yapmak için (2)");
            int secim = int.Parse(Console.ReadLine());
            switch(secim){
                case 1:
                string telefonNumarası = Console.ReadLine();
                foreach(var kisi in kisilers){
                    if(telefonNumarası.Equals(kisi.getPhoneNumber())) {
                        Console.WriteLine("Kişi bulundu");
                        Console.WriteLine("ad: {0}, soyad: {1} telefon{2}",kisi.getName(),kisi.getSurname(),kisi.getPhoneNumber);
                        break;
                    }
                    }
                    Console.WriteLine("Kişi bulunamadı");
                break;
                case 2:
                break;
                default:
                Console.WriteLine("yanlış şeçim");
                rehberdeArama();
                break;
            }
        }
        static void run(){
            Console.WriteLine("********** Anamenü **********");
            Console.WriteLine("Lütfen yapmak istediğniz işlemi şeçiniz");
            Console.WriteLine("*****************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
            Console.Write("Şeçim: ");
            int secim = int.Parse(Console.ReadLine());    
            switch(secim){
                case 1:
                Console.WriteLine("kişi ekleye giriliyor");
                kisiEkle();
                break;
                case 2:
                Console.WriteLine("Numara silmeye giriliyor");
                kisiSil();
                break;
                case 3:
                kisiGuncelle();
                break;
                case 4:
                Console.WriteLine("Telefon Rehberi");
                Console.WriteLine("*****************************************");
                kisiListeGoruntule();
                break;
                case 5:
                rehberdeArama();
                break;
                default:
                Console.WriteLine("Yanlış Seçim tekrar girniz");
                run();
                break;
            }

        }

        
    }
}