//Kahve dükkanı için müşteri yönetimi yapan sistem
//Starbucks ve Nero firması için çalışıyoruz 
//İki firmada müşterilerini veri tabanına kaydetmek istiyor
//Starbucks müşterilerini kaydederken mutlaka mernis doğrulaması istiyor
//Nero müşterilerini kaydederken böyle birşey istemiyor
//Starbucks müşteri için her kahve alımında yıldız kazandırmak istiyor

using System;
using InterfaceAndAbstractDemo.Abstract;
using InterfaceAndAbstractDemo.Adapters;
using InterfaceAndAbstractDemo.Concrete;
using InterfaceAndAbstractDemo.Entities;

namespace InterfaceAndAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapters());
            customerManager.Save(new Customer { DateOfBirthYear = 1996, FirstName = "Merve", LastName = "AYDIN", Id = 1, NationalityId = 123 });
            Console.ReadLine();
        }
    }
}