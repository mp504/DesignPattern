
namespace Prototype
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Icharacter attacker1 = new Attacker("Neymar", 99);
            Icharacter Defender1 = new Defender("Ramos", 95);


            Icharacter attacker2 = attacker1.clone();
            Icharacter Defender2 = Defender1.clone();


            attacker1.DisplayInfo();
            attacker2.DisplayInfo();

            Defender1.DisplayInfo();
            Defender2.DisplayInfo();
        }

    }

}
