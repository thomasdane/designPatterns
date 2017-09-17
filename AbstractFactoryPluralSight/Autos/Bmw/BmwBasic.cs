using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPluralSight
{
    public class BmwBasic : IAuto
    {
        public void Drive()
        {
            Console.WriteLine("Drive a basic BMW");
        }
    }
}
