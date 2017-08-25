using System;

namespace Factory
{
    public class Airliner : IPlane
    {
        public string Name { get; set; }
        public int Capacity { get; set; }

        public Airliner()
        {
            Name = "Airliner";
            Capacity = 400;
        }

        public bool IsFull(int currentPassengers)
        {
            return Capacity > currentPassengers;
        }
    }
}
