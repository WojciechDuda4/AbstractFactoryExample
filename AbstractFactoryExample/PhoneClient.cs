using AbstractFactoryExample.Factories;
using AbstractFactoryExample.Phones;
using System;

namespace AbstractFactoryExample
{
    public class PhoneClient
    {
        IFactoryMethod _factoryMethod;

        ISmartPhone _smartPhone;

        IRegularPhone _regularPhone;

        public PhoneClient(IFactoryMethod factoryMethod)
        {
            _factoryMethod = factoryMethod;
            _smartPhone = factoryMethod.GetSmartPhone();
            _regularPhone = factoryMethod.GetRegularPhone();
        }

        public void ShowPhones()
        {
            Console.WriteLine($"Mam 2 telefony: {_smartPhone.ToString()} i {_regularPhone.ToString()}");
        }
    }
}
