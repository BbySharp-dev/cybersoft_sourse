public class TigerFactory : IAnimalFactory
{
    public override IAnimal CreateAnimal()
    {
        return new Tiger();
    }
}