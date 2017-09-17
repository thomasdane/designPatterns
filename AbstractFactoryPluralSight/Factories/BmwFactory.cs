using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPluralSight
{
    public class BmwFactory : IAutoFactory
    {
        public IAuto CreateCar(string model)
        {
            if (model == "basic") return new BmwBasic();
            if (model == "sports") return new BmwSports();
            return null; //could use null object pattern here
        }
    }
}
