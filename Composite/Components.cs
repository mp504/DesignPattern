using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public abstract class BuildingComponent
    {
        public abstract double Area();

    }


    public class Room : BuildingComponent
    {
        public string Name { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }


        public Room(string name, double width, double length)
        {
            Name = name;
            Width = width;
            Length = length;

        }

        public override double Area()
        {
            return Width * Length;
        }

        public override string ToString()
        {
            return $"Room: {Name}, Area: {Area()} sq m";

        }



    }


    public class Floor : BuildingComponent
    {
        private readonly List<BuildingComponent> _rooms = new List<BuildingComponent>();

        public void Add(BuildingComponent room)
        { _rooms.Add(room); }

        public override double Area()
        {
            double totalArea = 0;
            foreach (var room in _rooms)
            {
                totalArea += room.Area();
            }
            return totalArea;
        }

        public override string ToString()
        {
            return $"Floor with total area: {Area()} sq m, Rooms: {string.Join(", ", _rooms)}";

        }
    }

    public class Building: BuildingComponent
    {
        private readonly List<BuildingComponent> _floors = new List<BuildingComponent>();

        public void Add(BuildingComponent floor)
        {
            _floors.Add(floor);
        }

        public override double Area()
        {
            double totalArea = 0;
            foreach(var floor in _floors)
            {
                totalArea += floor.Area();
            }
            return totalArea;
        }

        public override string ToString()
        {
            return $"Building with total area: {Area()} sq m, Floors: {string.Join(", ", _floors)}";
        }

    }
}
