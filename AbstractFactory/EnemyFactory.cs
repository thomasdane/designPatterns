namespace AbstractFactory
{
    public abstract class EnemyFactory
    {
        protected abstract Enemy CreateEnemyShip(string shipType);

        public Enemy orderEnemyShip(string shipType)
        {
            var enemyShip = CreateEnemyShip(shipType);

            enemyShip.CreateShip();
            enemyShip.RenderShip();
            enemyShip.ShootGun();

            return enemyShip;
        }
    }
}
