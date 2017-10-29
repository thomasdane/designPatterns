using System;

namespace NullObject
{
    public abstract class CarBase
    {
        public abstract void Drive();

        #region NULL

        public class NullCar : CarBase
        {
            public override void Drive() { }
        }

        static readonly NullCar nullCar = new NullCar();

        public static NullCar Null
        {
            get
            {
                return nullCar;
            }
        }
        
        #endregion
    }

    class Tesla : CarBase
    {
        public override void Drive()
        {
            Console.WriteLine("Driving a tesla");
        }
    }
}