using System;

namespace FactoryMethod
{
	public class Ford : ICar
	{
		public string Type { get; set; }
		public string Colour { get; set; } 

		public Ford(string colour)
		{
			Colour = colour;
			Type = "Ford";
		}
	}
}

