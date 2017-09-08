using System;

//main difference between factory method and simple factory is that with factory method you have multiple factories. 
//not just one. 
//this allows you to have more control over the kinds of objects you create

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

		    Console.ReadKey();
		}
	}
}
