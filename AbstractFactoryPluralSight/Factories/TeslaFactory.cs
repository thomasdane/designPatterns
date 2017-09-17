using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPluralSight
{
    public class TeslaFactory : IAutoFactory
    {
        public IAuto CreateCar(string model)
        {
            if (model == "basic") return new TeslaBasic();
            if (model == "sports") return new TeslaSports();
            return null; //could use null object pattern here
        }
    }
}
