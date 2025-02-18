
public class SimpleFactory
{
    public static IAnimal CreateAnimal(int choice)
    {
        switch (choice)
        {
            case 0:
                return new Dog();
            case 1:
                return new Tiger();
            default:
                throw new ApplicationException("Invalid choice! Choose 0 for Dog or 1 for Tiger.");
        }
    }
}