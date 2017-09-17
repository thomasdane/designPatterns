using System;

namespace AbstractFactory
{
    public abstract class Enemy
    {
        public string name { get; set; }
        public Weapon weapon;
        public Engine engine;

        public abstract void CreateShip();

        public void RenderShip()
        {
            Console.WriteLine(name + "is on the screen");
        }

        public void ShootGun()
        {
            Console.WriteLine(name + "shoots" + weapon);
        }

        public override string ToString()
        {
            return "The " + name + "has a top speed of " + engine + "and is armed with " + weapon;
        }
    }
}
