//represents a method as an object
// this includes the method name, the object that owns the method, the the method params
// so it can be used at a late time, or many times
//decouples clients that execute the command from the details of the command
//Example: remote control button - sends command 'turnTVon' to the TV which executes it. 
using System;
using Command.Invokers;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            var boat = new Boat();

            //turn on

            var carOnCommand = new TurnVehicleOn(car);
            var boatOnCommand = new TurnVehicleOn(boat);

            var turnCarOn = new Invoker(carOnCommand);
            var turnBoatOn = new Invoker(boatOnCommand);

            turnCarOn.Invoke();
            turnBoatOn.Invoke();

            // accelerate

			var accelerateCarCommand = new AccelerateVehicle(car);
            var accelerateBoatCommand = new AccelerateVehicle(boat);

            var speedUpCar = new Invoker(accelerateCarCommand);
			var speedUpBoat = new Invoker(accelerateBoatCommand);

			speedUpCar.Invoke();
			speedUpBoat.Invoke();
			speedUpBoat.Invoke();
			speedUpBoat.Invoke();

            // decelerate

            speedUpCar.Undo();
            speedUpCar.Undo();
            speedUpBoat.Undo();

            //Turn off

            turnCarOn.Undo();
            turnBoatOn.Undo();

			Console.ReadKey();

        }
    }
}
