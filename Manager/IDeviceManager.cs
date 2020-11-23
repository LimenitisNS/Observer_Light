namespace Observer.Manager
{
    interface IDeviceManager
    {
        void AddLight(Light light);
        void RemoveLight(Light light);
        void Update(SignalType signal);
    }
}
