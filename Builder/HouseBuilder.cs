using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{   
    public interface IHouseBuilder
    {
        void BuildFoundation();
        void BuildStructure();
        void BuildRooms(int numberOfRooms);
        House GetHouse();
    }


    public class HouseBuilder: IHouseBuilder
    {
        private House _house = new House();

        public void BuildFoundation() => _house.Foundation = "Concrete Foundation";

        public void BuildStructure() => _house.Structure = "Wood Frame";
        public void BuildRooms(int numberOfRooms) => _house.NumberOfRooms = numberOfRooms;
        public House GetHouse() => _house;


    }


    public class HouseDirector
    {
        private IHouseBuilder _builder;

        public HouseDirector(IHouseBuilder builder)
        {
            _builder = builder;
        }

        public void ConstructHouse(int numberOFRooms)
        {
            _builder.BuildFoundation();
            _builder.BuildStructure();
             _builder.BuildRooms(numberOFRooms);

        }

    }
}
