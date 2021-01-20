//Müşteri takip programı

using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri()
            {
                Id = 1,
                FisrtName = "Merve",
                LastName = "AYDIN",
                City = "Trabzon"
            };

            Musteri musteri2 = new Musteri()
            {
                Id = 2,
                FisrtName = "Emre",
                LastName = "AYDIN",
                City = "Artvin"
            };

            Musteri musteri3 = new Musteri()
            {
                Id = 3,
                FisrtName = "Onur",
                LastName = "AYDIN",
                City = "Ankara"
            };


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Listing();


            Console.ReadLine();



        }
    }
}