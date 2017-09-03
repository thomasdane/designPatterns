using System;

namespace FactoryMethod
{
	public class CarFactory : ICarFactory
	{
		public ICar CreateCar(string type, string colour)
		{
			switch (type)
			{
			case "ford":
				return new Ford (colour);
			case "toyota":
				return new Toyota (colour);
			default:
				Console.WriteLine("Invalid car type");
				break;
			}

			return null;
		}
	}
}