using FlyWeight;
// Client Code
using FlyWeight;

public class Program
{
    public static void Main(string[] args)
    {
        var styleFactory = new ButtonStyleFactory();

        // Create buttons with shared styles
        Button button1 = new Button(styleFactory.GetButtonStyle("Red", "Arial", "Solid"), "Button 1");
        Button button2 = new Button(styleFactory.GetButtonStyle("Blue", "Arial", "Solid"), "Button 2");
        Button button3 = new Button(styleFactory.GetButtonStyle("Red", "Arial", "Solid"), "Button 3"); // Reuses the style

        // Render buttons
        button1.Render();
        button2.Render();
        button3.Render();
    }
}