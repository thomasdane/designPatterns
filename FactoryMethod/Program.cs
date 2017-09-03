using System;

namespace FactoryMethod
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var car = GetCar("ford", "red");
			Console.WriteLine(string.Format("You ordered a {0} {1}", car.Colour, car.Type));
		}


		public static ICar GetCar(string type, string colour)
		{
			var factory = new CarFactory();
			return factory.CreateCar (type, colour);
		}
	}
}
