using Command;

class Program
{
    static void Main(string[] args)
    {
        var remote = new RemoteControl();
        var light = new Light();
        var fan = new Fan();

        var lightOn = new LightOnCommand(light);
        var lightOff = new LightOffCommand(light);
        var fanOn = new FanOnCommand(fan);
        var fanOff = new FanOffCommand(fan);

        // Turn on the light
        remote.SetCommand(lightOn);
        remote.PressButton();

        // Turn off the light
        remote.SetCommand(lightOff);
        remote.PressButton();

        // Turn on the fan
        remote.SetCommand(fanOn);
        remote.PressButton();

        // Turn off the fan
        remote.SetCommand(fanOff);
        remote.PressButton();

        // Undo last action (fan off)
        remote.PressUndo();
    }
}