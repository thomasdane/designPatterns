using System;
namespace Command
{
    public interface IVehicle
    {
        void TurnOn();
        void TurnOff();
        void Accelerate();
        void Decelerate();
    }
}
