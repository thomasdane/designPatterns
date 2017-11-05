using System;
namespace Command
{
    public class Boat : IVehicle
    {
		private int speed;

		public void Accelerate()
		{
			speed++;
			Console.WriteLine("Boat speed is " + speed);
		}

		public void Decelerate()
		{
			speed--;
			Console.WriteLine("Boat speed is " + speed);
		}

		public void TurnOff()
		{
			Console.WriteLine("Boat is off");
		}

		public void TurnOn()
		{
			Console.WriteLine("Boat is on");
		}
    }
}
