using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.CustomerFirstName+" "+musteri.CustomerLastName+" added to succesfully customer list !");
        }
        public void Delete(Musteri musteri)
        {
            Console.WriteLine(musteri.CustomerFirstName + " " + musteri.CustomerLastName + " deleted to succesfully customer list !");
        }
        public void CustomerList(List<Musteri> musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("\n----------Customer"+musteri.Id+ "----------");
                Console.WriteLine("Customer First Name = "+musteri.CustomerFirstName);
                Console.WriteLine("Customer Last Name = "+musteri.CustomerLastName);
                Console.WriteLine("Customer Age = "+musteri.CustemerAge);
                Console.WriteLine("Customer Hometown = "+musteri.CustomerHometown);
            }
        }
    }
}
