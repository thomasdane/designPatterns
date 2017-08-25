namespace Factory
{
    public interface IPlane
    {
        string Name { get; set; }
        int Capacity { get; set; }
        bool IsFull(int currentPassengers);
    }
}
