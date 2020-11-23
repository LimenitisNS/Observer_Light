using System;
using Observer.Manager;

namespace Observer
{
    class Light
    {
        public bool IsStateCalm { get; private set; } = true;
        public bool IsTurnedOn { get; private set; } = false;
        public bool IsAuto { get; private set; } = true;

        public void SwitchState()
        {
            IsStateCalm = !IsStateCalm;
        }

        public void SwitchMode()
        {
            if (IsStateCalm)
            {
                IsAuto = !IsAuto;
            }
        }

        public void SwitchLight()
        {
            if (IsStateCalm)
            {
                IsTurnedOn = !IsTurnedOn;
            }
        }

        public void Update(SignalType signal)
        {
            switch(signal)
            {
                case SignalType.SwitchState:
                    SwitchState();
                    return;
                case SignalType.SwitchLight:
                    SwitchLight();
                    return;
                case SignalType.SwitchMode:
                    SwitchMode();
                    return;
            }
        }
    }
}
