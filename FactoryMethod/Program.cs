using System;

namespace FactoryMethod
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var fordFactory = new FordFactory ();
			var ford = fordFactory.CreateCar("Red");
			Console.WriteLine(string.Format("You ordered a {0} {1}", ford.Colour, ford.Type));

			var toyotaFactory = new ToyotaFactory();
			var toyota = toyotaFactory.CreateCar("Blue");
			Console.WriteLine(string.Format("You ordered a {0} {1}", toyota.Colour, toyota.Type));
		}
	}
}
