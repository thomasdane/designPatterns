namespace AbstractFactory.Factories
{
    public interface IEnemyPartsFactory
    {
        Weapon AddWeapon();
        Engine AddEngine();
    }
}
