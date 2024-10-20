using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    // Subsystem Classes
    public class OilChangeService
    {
        public void ChangeOil()
        {
            Console.WriteLine("Oil changed successfully.");
        }
    }
    public class BrakeCheckService
    {
        public void CheckBrakes()
        {
            Console.WriteLine("Brakes checked successfully.");
        }
    }

    public class CarMaintenanceFacade
    {
        private readonly OilChangeService _oilChangeService;

        private readonly BrakeCheckService _brakeCheckService;

        public CarMaintenanceFacade()
        {
            _oilChangeService = new OilChangeService();
            _brakeCheckService = new BrakeCheckService();
        }
        public void ScheduleOilChange()
        {
            Console.WriteLine("Scheduling oil change...");
            _oilChangeService.ChangeOil();
        }

        public void ScheduleBreakCheck()
        {
            Console.WriteLine("Scheduling breack check...");
            _brakeCheckService.CheckBrakes();

        }


        public void ScheduleFullService()
        {
            Console.WriteLine("Scheduling full service...");
            _oilChangeService.ChangeOil();
            _brakeCheckService.CheckBrakes();
        }
    }

}
