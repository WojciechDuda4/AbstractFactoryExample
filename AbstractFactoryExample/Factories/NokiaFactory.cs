using AbstractFactoryExample.Phones;

namespace AbstractFactoryExample.Factories
{
    public class NokiaFactory : IFactoryMethod
    {
        public IRegularPhone GetRegularPhone() => new NokiaRegularPhone();

        public ISmartPhone GetSmartPhone() => new NokiaSmartPhone();
    }
}
