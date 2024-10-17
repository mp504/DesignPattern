using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{

    public interface GUIFactory
    {
        public IButton CreateButton();
        public ICheckBox CreateCheckBox();
    }
    public class WinFactory : GUIFactory
    {
        public IButton CreateButton()
        {
            return new WinButton();
        }

        public ICheckBox CreateCheckBox()
        {
            return new WinCheckBox();
        }


    }

    public class LinuxFactory: GUIFactory
    {
        public IButton CreateButton()
        {
            return new LinuxButton();
        }
        public ICheckBox CreateCheckBox()
        {
            return new LinuxCheckBox();
        }
    }
}
