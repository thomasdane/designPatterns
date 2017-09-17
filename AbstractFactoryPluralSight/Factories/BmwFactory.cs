using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPluralSight
{
    public class BmwFactory : IAutoFactory
    {
        public IAuto CreateBasicCar()
        {
            return new BmwBasic();
        }

        public IAuto CreateSportsCar()
        {
            return new BmwSports();
        }
    }
}
