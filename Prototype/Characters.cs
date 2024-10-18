using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{

    public interface Icharacter
    {
         public Icharacter clone();
        public void DisplayInfo();
    }
    public class Attacker : Icharacter
    {
        public string Name { get; set; }
        public int AttackPower { get; set; }

        public Attacker(string name, int attackPower)
        {
            this.Name = name;
            this.AttackPower = attackPower;
        }

        public Icharacter clone()
        {
            return new Attacker(this.Name, this.AttackPower);
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Attacker: {Name}, AttackPower: {AttackPower}");
        }


    }

    public class Defender : Icharacter
    {
        public string Name { get; set; }
        public int DefendPower { get; set; }

        public Defender(string name, int attackPower)
        {
            this.Name = name;
            this.DefendPower = attackPower;
        }

        public Icharacter clone()
        {
            return new Attacker(this.Name, this.DefendPower);
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Attacker: {Name}, AttackPower: {DefendPower}");
        }






    }


}
