namespace NullObject
{
    class CarRepository
    {
        public CarBase GetCarByName(string name)
        {
            if (name == "tesla")
            {
                return new Tesla();
            }

            return CarBase.Null;
        }
    }
}
