using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri customer1 = new Musteri();
            customer1.Id = 1;
            customer1.CustomerFirstName = "Russell";
            customer1.CustomerLastName = "Wilson";
            customer1.CustemerAge = 33;
            customer1.CustomerHometown = "Wisconsin";

            Musteri customer2 = new Musteri();
            customer2.Id = 2;
            customer2.CustomerFirstName = "Bobby";
            customer2.CustomerLastName = "Wagner";
            customer2.CustemerAge = 30;
            customer2.CustomerHometown = "Utah State";

            Musteri customer3 = new Musteri();
            customer3.Id = 3;
            customer3.CustomerFirstName = "Tyler";
            customer3.CustomerLastName = "Lockett";
            customer3.CustemerAge = 28;
            customer3.CustomerHometown = "Kansas State";


            List<Musteri> musteriler = new List<Musteri> { customer1, customer2, customer3 };

            MusteriManager musteriManager = new MusteriManager();
            Console.WriteLine("----------Customer Creation----------");
            musteriManager.Add(customer1);
            Console.WriteLine("\n----------Customer Remove----------");
            musteriManager.Delete(customer2);
            Console.WriteLine("\n----------Customer List----------");
            musteriManager.CustomerList(musteriler);

        }
    }
}
