using System;
namespace Command
{
	public class DecelerateVehicle : ICommand
	{
		private IVehicle _vehicle;

		public DecelerateVehicle(IVehicle vehicle)
		{
			_vehicle = vehicle;
		}

		public void Execute()
		{
            _vehicle.Decelerate();
		}

        public void Undo()
        {
            _vehicle.Accelerate();
        }
    }
}
