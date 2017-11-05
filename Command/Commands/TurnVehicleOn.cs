using System;
namespace Command
{
    public class TurnVehicleOn : ICommand
    {
        IVehicle _vehicle;

        public TurnVehicleOn(IVehicle vehicle)
        {
            _vehicle = vehicle;    
        }

        public void Execute()
        {
            _vehicle.TurnOn();
        }

        public void Undo()
        {
            _vehicle.TurnOff();
        }
    }
}
