using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }

    public class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("Light is ON");
        }

        public void TurnOff()
        {
            Console.WriteLine("Light is OFF");
        }
    }

    public class Fan
    {
        public void TurnOn()
        {
            Console.WriteLine("Fan is ON");
        }

        public void TurnOff()
        {
            Console.WriteLine("Fan is OFF");
        }
    }


    public class LightOnCommand : ICommand
    {
        private readonly Light _light;

        public LightOnCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOn();
        }

        public void Undo()
        {
            _light.TurnOff();
        }
    }

    public class LightOffCommand : ICommand
    {
        private readonly Light _light;

        public LightOffCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOff();
        }

        public void Undo()
        {
            _light.TurnOn();
        }
    }

    public class FanOnCommand : ICommand
    {
        private readonly Fan _fan;

        public FanOnCommand(Fan fan)
        {
            _fan = fan;
        }

        public void Execute()
        {
            _fan.TurnOn();
        }

        public void Undo()
        {
            _fan.TurnOff();
        }
    }

    public class FanOffCommand : ICommand
    {
        private readonly Fan _fan;

        public FanOffCommand(Fan fan)
        {
            _fan = fan;
        }

        public void Execute()
        {
            _fan.TurnOff();
        }

        public void Undo()
        {
            _fan.TurnOn();
        }
    }


    public class RemoteControl
    {
        private ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void PressButton()
        {
            _command.Execute();
        }

        public void PressUndo()
        {
            _command.Undo();
        }
    }

}
