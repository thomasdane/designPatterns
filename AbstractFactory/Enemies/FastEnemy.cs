using System;
using AbstractFactory.Factories;

namespace AbstractFactory.Enemies
{
    public class FastEnemy : Enemy
    {
        private readonly IEnemyPartsFactory _factory;

        public FastEnemy(IEnemyPartsFactory factory)
        {
            _factory = factory;
        }

        public override void CreateShip()
        {
            Console.WriteLine("Making " + base.name);

            weapon = _factory.AddWeapon();
            engine = _factory.AddEngine();

        }
    }
}
