namespace Factory
{
    class PlaneFactory
    {
        public IPlane CreatePlane(string type)
        {
            if (type == "Fighter")
                return new FighterJet();

            if (type == "Airliner")
                return new Airliner();

            return null;
        }
    }
}
