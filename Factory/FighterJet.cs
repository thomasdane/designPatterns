using System;

namespace Factory
{
    public class FighterJet : IPlane
    {
        public string Name {get; set;}

        public int Capacity { get; set; }

        public FighterJet()
        {
            Name = "Jet fighter";
            Capacity = 1;
        }

        public bool IsFull(int currentPassengers)
        {
            return Capacity > currentPassengers;
        }
    }
}
