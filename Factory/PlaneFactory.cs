namespace Factory
{
    class PlaneFactory
    {
        public IPlane CreatePlane(string type)
        {
            if (type == "Fighter")
                return new FighterJet(); //You could pass more params here

            if (type == "Airliner")
                return new Airliner();

            return null;
        }
    }
}
