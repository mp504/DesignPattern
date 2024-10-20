using Composite;

namespace Composite
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var room1 = new Room("Living Room", 20, 15);
            var room2 = new Room("Bedroom", 15, 12);
            var room3 = new Room("Kitchen", 10, 10);

            
            var firstFloor = new Floor();
            firstFloor.Add(room1);
            firstFloor.Add(room2);

            var secondFloor = new Floor();
            secondFloor.Add(room3);

           
            var building = new Building();
            building.Add(firstFloor);
            building.Add(secondFloor);

            // Output total area
            Console.WriteLine(building);
        }
    }


}