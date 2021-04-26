using System;

namespace Odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.UrunAd = "Siyah Yüksek Bel Dikişli Pantolon";
            product1.UrunAciklama = "Dokuma Kumaş";
            product1.UrunFiyat = "84.99";

            Product product2 = new Product();
            product2.UrunAd = "Siyah Yırtmaçlı Örme Pantolon";
            product2.UrunAciklama = "Örme Kumaş";
            product2.UrunFiyat = "55.24";

            Product[] products = new Product[] { product1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.UrunAd + " : " + product.UrunAciklama + " : " + product.UrunFiyat);
            }


        }

        class Product
        {
            public string UrunAd { get; set; }
            public string UrunAciklama { get; set; }
            public string UrunFiyat { get; set; }
        }
    }
}
