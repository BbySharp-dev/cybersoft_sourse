public class DogFactory : IAnimalFactory
{
    public override IAnimal CreateAnimal()
    {
        return new Dog();
    }
}