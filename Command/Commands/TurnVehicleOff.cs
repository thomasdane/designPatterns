using System;
namespace Command
{
    public class TurnVehicleOff : ICommand
    {
        IVehicle _vehicle;

        public TurnVehicleOff(IVehicle vehicle)
        {
            _vehicle = vehicle;    
        }

        public void Execute()
        {
            _vehicle.TurnOff();
        }

        public void Undo()
        {
            _vehicle.TurnOn();
        }
    }
}
