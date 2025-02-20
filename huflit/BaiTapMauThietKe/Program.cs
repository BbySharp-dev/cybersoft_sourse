class Program
{
    static void Main()
    {
        Console.WriteLine("DEMO SINGLETON \n");

        Console.WriteLine("Tạo instance s1:");
        Singleton s1 = Singleton.Instance;

        Console.WriteLine("\nTạo instance s2:");
        Singleton s2 = Singleton.Instance;

        if (s1 == s2)
        {
            Console.WriteLine("\nCả hai đều là một đối tượng duy nhất");
        }
        else
        {
            Console.WriteLine("\nĐối tượng bị tạo nhiều lần");
        }

        Console.ReadKey();
    }
}
