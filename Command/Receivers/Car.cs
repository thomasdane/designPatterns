using System;
//These are the receivers
namespace Command
{
    public class Car : IVehicle
    {
        private int speed;

        public void Accelerate()
        {
            speed++;
            Console.WriteLine("Car speed is " + speed);
        }

        public void Decelerate()
        {
			speed--;
			Console.WriteLine("Car speed is " + speed);
        }

        public void TurnOff()
        {
            Console.WriteLine("Car is off");
        }

        public void TurnOn()
        {
			Console.WriteLine("Car is on");
		}
    }
}
