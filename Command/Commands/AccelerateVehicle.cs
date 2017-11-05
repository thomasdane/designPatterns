using System;
namespace Command
{
    public class AccelerateVehicle : ICommand
    {
        private IVehicle _vehicle;

        public AccelerateVehicle(IVehicle vehicle){
            _vehicle = vehicle;
        }

        public void Execute()
        {
            _vehicle.Accelerate();
        }

        public void Undo()
        {
            _vehicle.Decelerate();
        }
    }
}
