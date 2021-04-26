using System;

namespace Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Kayit kayit1 = new Kayit();
            kayit1.KisiAdı = "Selin";
            kayit1.KisiSoyadı = "Şentürk";
            kayit1.TcNo = "1000";

            Kayit kayit2 = new Kayit();
            kayit2.KisiAdı = "Ezgi";
            kayit2.KisiSoyadı = "Kıvanç";
            kayit2.TcNo = "2000";

            Kayit[] kayitlar = new Kayit[] { kayit1, kayit2 };

            foreach (Kayit kayit in kayitlar)
            {
                Console.WriteLine(kayit.KisiAdı + " : " + kayit.KisiSoyadı + " : " + kayit.TcNo);

            }

            Product product1 = new Product();
            product1.UrunAd = "Yeşil Kuşaklı Gömlek Elbise";
            product1.UrunAciklama = "Dokuma Kumaş";
            product1.UrunFiyat = "84.99";

            Product product2 = new Product();
            product2.UrunAd = "Siyah Geniş Kesim Elbise";
            product2.UrunAciklama = "Dokuma Kumaş";
            product2.UrunFiyat = "76.49";

            Product[] products = new Product[] { product1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.UrunAd + " : " + product.UrunAciklama + " : " + product.UrunFiyat);
            }

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Ürün Adı: " + products[i].UrunAd + " Ürün Açıklaması: " + products[i].UrunAciklama + " Ürün Fiyat: " + products[i].UrunFiyat);
            }
            int sayac = 0;
            while (sayac<products.Length)
            {
                Console.WriteLine("Ürün Adı: " + products[sayac].UrunAd + "Ürün Açıklaması: " + products[sayac].UrunAciklama + "Ürün Fiyat: " + products[sayac].UrunFiyat);
                sayac++;
            }




            Console.WriteLine("Hello World!");
        }

        
        class Kayit
        {
            public string KisiAdı { get; set; }
            public string KisiSoyadı { get; set; }
            public string TcNo { get; set; }
        }

        class Product
        {
            public string UrunAd { get; set; }
            public string UrunAciklama { get; set; }
            public string UrunFiyat { get; set; }
        }
    }
}
