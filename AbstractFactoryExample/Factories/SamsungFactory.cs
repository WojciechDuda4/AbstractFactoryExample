using AbstractFactoryExample.Phones;

namespace AbstractFactoryExample.Factories
{
    public class SamsungFactory : IFactoryMethod
    {
        public IRegularPhone GetRegularPhone() => new SamsungRegularPhone();

        public ISmartPhone GetSmartPhone() => new SamsungSmartPhone();
    }
}
