using System.Collections.Generic;

namespace Observer.Manager
{
    class DeviceManager : IDeviceManager
    {
        List<Light> lights = new List<Light> { };

        public void AddLight (Light light)
        {
            lights.Add(light);
        }

        public void RemoveLight (Light light)
        {
            lights.Remove(light);
        }

        public void Update(SignalType signal)
        {
            foreach(Light light in lights)
            {
                light.Update(signal); 
            }
        }
    }
}
