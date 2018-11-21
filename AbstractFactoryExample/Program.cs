using AbstractFactoryExample.Factories;
using System;

namespace AbstractFactoryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactoryMethod factoryMethod = new NokiaFactory();
            PhoneClient phoneClient = new PhoneClient(factoryMethod);
            phoneClient.ShowPhones();

            factoryMethod = new SamsungFactory();
            phoneClient = new PhoneClient(factoryMethod);
            phoneClient.ShowPhones();

            Console.ReadKey();
        }
    }
}
