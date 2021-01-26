//Müşteri takip programı

using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.FisrtName = "Merve";
            musteri1.LastName = "AYDIN";
            musteri1.City = "Trabzon";

            Musteri musteri2 = new Musteri()
            {
                Id = 2,
                FisrtName = "Emre",
                LastName = "AYDIN",
                City = "Artvin"
            };

            Musteri musteri3 = new Musteri{Id = 3, FisrtName = "Onur", LastName = "AYDIN", City = "Ankara"};


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Listing();


            Console.ReadLine();



        }
    }
}