using System;

namespace FactoryMethod
{
	public class FordFactory : ICarFactory
	{
		public ICar CreateCar(string colour)
		{
			return new Ford(colour);
		}
	}
}