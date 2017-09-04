using System;

namespace FactoryMethod
{
	public interface ICarFactory
	{
		ICar CreateCar(string colour);
	}
}

