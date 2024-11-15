using System;

namespace TeknolojiMagazasi
{
    // Base class
    public abstract class BaseMakine
    {
        public DateTime UretimTarihi { get; private set; }
        public string SeriNumarasi { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public string IsletimSistemi { get; set; }

        public BaseMakine()
        {
            UretimTarihi = DateTime.Now; // Üretim tarihi otomatik atanıyor
        }

        public virtual void BilgileriYazdir()
        {
            Console.WriteLine($"Üretim Tarihi: {UretimTarihi}");
            Console.WriteLine($"Seri Numarası: {SeriNumarasi}");
            Console.WriteLine($"Ad: {Ad}");
            Console.WriteLine($"Açıklama: {Aciklama}");
            Console.WriteLine($"İşletim Sistemi: {IsletimSistemi}");
        }

        public abstract void UrunAdiGetir();
    }

    // Derived class for Telefon
    public class Telefon : BaseMakine
    {
        public bool TrLisansli { get; set; }

        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine($"TR Lisanslı mı?: {(TrLisansli ? "Evet" : "Hayır")}");
        }

        public override void UrunAdiGetir()
        {
            Console.WriteLine($"Telefonunuzun adı ---> {Ad}");
        }
    }

    // Derived class for Bilgisayar
    public class Bilgisayar : BaseMakine
    {
        private int usbGirisSayisi;
        public int UsbGirisSayisi
        {
            get { return usbGirisSayisi; }
            set
            {
                if (value == 2 || value == 4)
                    usbGirisSayisi = value;
                else
                {
                    Console.WriteLine("Geçersiz USB Giriş Sayısı! Varsayılan olarak -1 atanıyor.");
                    usbGirisSayisi = -1;
                }
            }
        }

        public bool Bluetooth { get; set; }

        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine($"USB Giriş Sayısı: {UsbGirisSayisi}");
            Console.WriteLine($"Bluetooth var mı?: {(Bluetooth ? "Evet" : "Hayır")}");
        }

        public override void UrunAdiGetir()
        {
            Console.WriteLine($"Bilgisayarınızın adı ---> {Ad}");
        }
    }

    // Main program
    class Program
    {
        static void Main(string[] args)
        {
            bool devam = true;

            while (devam)
            {
                Console.WriteLine("Telefon üretmek için 1, Bilgisayar üretmek için 2'ye basınız.");
                string secim = Console.ReadLine();

                if (secim == "1")
                {
                    Telefon telefon = new Telefon();
                    Console.Write("Telefon Adını Giriniz: ");
                    telefon.Ad = Console.ReadLine();

                    Console.Write("Seri Numarası Giriniz: ");
                    telefon.SeriNumarasi = Console.ReadLine();

                    Console.Write("Açıklama Giriniz: ");
                    telefon.Aciklama = Console.ReadLine();

                    Console.Write("İşletim Sistemi Giriniz: ");
                    telefon.IsletimSistemi = Console.ReadLine();

                    Console.Write("TR Lisanslı mı? (E/H): ");
                    telefon.TrLisansli = Console.ReadLine().ToUpper() == "E";

                    Console.WriteLine("Telefon başarıyla üretildi!");
                    telefon.BilgileriYazdir();
                    telefon.UrunAdiGetir();
                }
                else if (secim == "2")
                {
                    Bilgisayar bilgisayar = new Bilgisayar();
                    Console.Write("Bilgisayar Adını Giriniz: ");
                    bilgisayar.Ad = Console.ReadLine();

                    Console.Write("Seri Numarası Giriniz: ");
                    bilgisayar.SeriNumarasi = Console.ReadLine();

                    Console.Write("Açıklama Giriniz: ");
                    bilgisayar.Aciklama = Console.ReadLine();

                    Console.Write("İşletim Sistemi Giriniz: ");
                    bilgisayar.IsletimSistemi = Console.ReadLine();

                    Console.Write("USB Giriş Sayısını Giriniz (2 veya 4): ");
                    bilgisayar.UsbGirisSayisi = int.Parse(Console.ReadLine());

                    Console.Write("Bluetooth var mı? (E/H): ");
                    bilgisayar.Bluetooth = Console.ReadLine().ToUpper() == "E";

                    Console.WriteLine("Bilgisayar başarıyla üretildi!");
                    bilgisayar.BilgileriYazdir();
                    bilgisayar.UrunAdiGetir();
                }
                else
                {
                    Console.WriteLine("Geçersiz seçim yaptınız!");
                    continue;
                }

                Console.Write("Başka bir ürün üretmek ister misiniz? (E/H): ");
                devam = Console.ReadLine().ToUpper() == "E";
            }

            Console.WriteLine("İyi günler!");
        }
    }
}
