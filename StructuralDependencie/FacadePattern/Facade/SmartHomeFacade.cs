using FacadePattern.Services;

namespace FacadePattern.Facade;

public class SmartHomeFacade
{
    public void ActivadeHome()
    {
        var arriveService = new ArriveService();
        var leaveService = new LeaveService();
        var movieMode = new MovieService();

        arriveService.ArriveHome();
        leaveService.LeaveHome();
        movieMode.MovieHome();
    }
}