// Client Code
using Facade;

public class Program
{
    public static void Main(string[] args)
    {
        var maintenanceFacade = new CarMaintenanceFacade();

        // Schedule individual services
        maintenanceFacade.ScheduleOilChange();
        maintenanceFacade.ScheduleBreakCheck();

        // Schedule full service
        maintenanceFacade.ScheduleFullService();
    }
}
