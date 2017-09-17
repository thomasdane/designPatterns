using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace AbstractFactoryPluralSight
{
    public interface IAutoFactory
    {
        IAuto CreateCar(string carType);
    }
}
