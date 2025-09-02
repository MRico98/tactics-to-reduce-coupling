using FacadePattern.Facade;

namespace FacadePattern;

public class SmartHome
{
    public void ActivatingHome()
    {
        var facade = new SmartHomeFacade();
        facade.ActivadeHome();
    }
}