using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public interface IButton
    {
        void render();
    }
    public interface ICheckBox
    {
        void render();
    }


    public class WinButton: IButton 
    {
        public void render()
        {
            Console.WriteLine("Rendering Windows Button");
        }
    }
    public class WinCheckBox : ICheckBox
    {
        public void render()
        {
            Console.WriteLine("Rendering Windows Checkbox");
        }

    }


    public class LinuxButton : IButton
    {
        public void render()
        {
            Console.WriteLine("Rendering linux Button");
        }
    }

    public class LinuxCheckBox : ICheckBox
    {
        public void render()
        {
            Console.WriteLine("Rendering linux Checkbox");
        }

    }
}
