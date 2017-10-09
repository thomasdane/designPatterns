using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPluralSight
{
    class Program
    {
        static void Main(string[] args)
        {

            //strategy, command, decorator. 
            //template
            //Why is it an abstract factory? 
            //Because you create a factory (AutoFactory) that creates
            //specific factories (BMWFactory)
            //This is different from simple factory:
            //where you call a method CreateCar('bmw')
            //that returns a BMW
            //Also different is factory method. 
            //Here you have car factories (fordFactory, bmwFactory)
            //That all share the CreateCar() method
            //You can pass in settings as params, like fordFactory.CreateCar(red)
            //How is factory method different from simple factory? 

            //When you need lots of parameters, what happens with simple factory? 

            //in simple factory, you only have one factory, CarFactory
            //It has a CreateCar() method, that takes the type of car as input
            // for example, carFactory.CreateCar("ford");

            var factoryA = new AutoFactory("bmw");
            var carA = factoryA.CreateCar("basic");
            var sportsCarA = factoryA.CreateCar("sports");
            carA.Drive();
            sportsCarA.Drive();

            var factoryB = new AutoFactory("tesla");
            var carB = factoryB.CreateCar("basic");
            var sportsCarB = factoryB.CreateCar("sports");
            carB.Drive();
            sportsCarB.Drive();

            Console.ReadKey();
        }
    }
}
