using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    public class ButtonStyle
    {
        public string Color { get; set; }
        public string Font { get; set; }
        public string Border { get; set; }


        public ButtonStyle(string color, string font, string border)
        {
            Color = color;
            Font = font;
            Border = border;
        }

        public void Display()
        {
            Console.WriteLine($"Button Style - Color: {Color}, Font: {Font}, Border: {Border}");
        }

    }

    public class ButtonStyleFactory
    {
        private readonly Dictionary<string, ButtonStyle> _styles = new Dictionary<string, ButtonStyle>();

        public ButtonStyle GetButtonStyle(string color, string font, string border)
        {
            string key = $"{color}_{font}_{border}";
            if (!_styles.ContainsKey(key))
            {
                _styles[key] = new ButtonStyle(color, font, border);
                Console.WriteLine("Creating new ButtonStyle: " + key);
            }
            return _styles[key];
        }

    }


    // Context Class
    public class Button
    {
        private readonly ButtonStyle _style;
        public string Text { get; set; }

        public Button(ButtonStyle style, string text)
        {
            _style = style;
            Text = text;
        }

        public void Render()
        {
            Console.Write("Rendering Button: " + Text + " with ");
            _style.Display();
        }
    }


}
