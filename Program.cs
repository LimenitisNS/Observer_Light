using System;
using Observer.Manager;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            IDeviceManager deviceManager = new DeviceManager();

            Light light1 = new Light();
            Light light2 = new Light();
            Light light3 = new Light();

            deviceManager.AddLight(light1);
            deviceManager.AddLight(light2);
            deviceManager.AddLight(light3);


            Console.WriteLine($"Light1 state {light1.IsStateCalm} Turned On {light1.IsTurnedOn} auto {light1.IsAuto}\n" +
                $"Light2 state {light2.IsStateCalm} Turned On {light2.IsTurnedOn} auto {light2.IsAuto}\n" +
                $"Light3 state {light3.IsStateCalm} Turned On {light3.IsTurnedOn} auto {light3.IsAuto}\n");

            deviceManager.Update(SignalType.SwitchLight);

            Console.WriteLine($"Light1 state {light1.IsStateCalm} Turned On {light1.IsTurnedOn} auto {light1.IsAuto}\n" +
                $"Light2 state {light2.IsStateCalm} Turned On {light2.IsTurnedOn} auto {light2.IsAuto}\n" +
                $"Light3 state {light3.IsStateCalm} Turned On {light3.IsTurnedOn} auto {light3.IsAuto}\n");

            deviceManager.Update(SignalType.SwitchState);

            Console.WriteLine($"Light1 state {light1.IsStateCalm} Turned On {light1.IsTurnedOn} auto {light1.IsAuto}\n" +
                $"Light2 state {light2.IsStateCalm} Turned On {light2.IsTurnedOn} auto {light2.IsAuto}\n" +
                $"Light3 state {light3.IsStateCalm} Turned On {light3.IsTurnedOn} auto {light3.IsAuto}\n");

            Console.ReadKey();
        }
    }
}
