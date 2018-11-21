using AbstractFactoryExample.Phones;

namespace AbstractFactoryExample.Factories
{
    public interface IFactoryMethod
    {
        ISmartPhone GetSmartPhone();

        IRegularPhone GetRegularPhone();
    }
}
