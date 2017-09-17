using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPluralSight
{
    public class TeslaSports : IAuto
    {
        public void Drive()
        {
            Console.WriteLine("Drive a sports Tesla");
        }
    }
}
