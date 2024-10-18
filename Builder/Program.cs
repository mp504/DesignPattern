

namespace Builder
{
    public class Progaram
    {


        public static void Main(string[] args)
        {

            IHouseBuilder Builder = new HouseBuilder();
            HouseDirector director = new HouseDirector(Builder);
            director.ConstructHouse(5);
            House house =Builder.GetHouse();


            Console.WriteLine(house);
        }
    }


}