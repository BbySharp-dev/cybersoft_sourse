using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("***Prototype Pattern Demo***\n");

        // Tạo đối tượng gốc
        BasicCar nanoBase = new Nano("Green Nano") { Price = 100000 };
        BasicCar fordBase = new Ford("Ford Yellow") { Price = 500000 };

        // Clone và thay đổi giá của Nano
        BasicCar bc1 = nanoBase.Clone();
        bc1.Price = nanoBase.Price + BasicCar.SetPrice();
        Console.WriteLine("Car is: {0}, and its price is Rs. {1}", bc1.ModelName, bc1.Price);

        // Clone và thay đổi giá của Ford
        bc1 = fordBase.Clone();
        bc1.Price = fordBase.Price + BasicCar.SetPrice();
        Console.WriteLine("Car is: {0}, and its price is Rs. {1}", bc1.ModelName, bc1.Price);

        Console.ReadLine();
    }
}