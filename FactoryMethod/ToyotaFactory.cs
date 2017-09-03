using System;

namespace FactoryMethod
{
	public class ToyotaFactory : ICarFactory
	{
		public ICar CreateCar(string colour)
		{
			return new Toyota(colour);
		}
	}
}