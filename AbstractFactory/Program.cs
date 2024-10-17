

namespace AbstractFactory
{
    public  class Application
    {
        private readonly IButton _button;
        private readonly ICheckBox _checkbox;

        public Application(GUIFactory factory)
        {
            _button = factory.CreateButton();
            _checkbox = factory.CreateCheckBox();
        }

        public void RenderUI()
        {
            _button.render();
            _checkbox.render();
        }
    }
    public class Program
    {
        public static void Main()
        {
            GUIFactory factory = new LinuxFactory();

            Application app = new Application(factory);
            app.RenderUI();

        }


    }
}