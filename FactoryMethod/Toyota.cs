using System;

namespace FactoryMethod
{
	public class Toyota : ICar
	{
		public string Type { get; set; }
		public string Colour { get; set; } 

		public Toyota(string colour)
		{
			Colour = colour;
			Type = "Toyota";
		}
	}
}

