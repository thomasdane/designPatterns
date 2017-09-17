namespace AbstractFactory
{
    public abstract class BasicEnemyFactory : EnemyFactory
    {
        protected Enemy CreateEnemyShip(string shipType)
        {
            var enemyShip = null;

            if (shipType == "fast")
            {
                var factory = new FastEnemyFactory();

            }

        }
    }
}
