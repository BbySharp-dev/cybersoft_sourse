
class Program
{
    static void Main()
    {
        Console.WriteLine("*** Factory Method Pattern Demo ***\n");

        // Tạo Factory cho Tiger
        IAnimalFactory tigerFactory = new TigerFactory();
        IAnimal aTiger = tigerFactory.CreateAnimal();
        aTiger.AboutMe();

        // Tạo Factory cho Dog
        IAnimalFactory dogFactory = new DogFactory();
        IAnimal aDog = dogFactory.CreateAnimal();
        aDog.AboutMe();

        Console.ReadKey();
    }
}