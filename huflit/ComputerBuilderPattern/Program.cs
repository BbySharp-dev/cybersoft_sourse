using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("*** Builder Pattern Demo ***\n");

        // Khởi tạo Director
        ComputerDirector director = new ComputerDirector();

        // Xây dựng Gaming Computer
        IComputerBuilder gamingBuilder = new GamingComputerBuilder();
        director.Construct(gamingBuilder);
        Computer gamingPC = gamingBuilder.GetComputer();
        Console.WriteLine("Gaming Computer:");
        gamingPC.ShowConfiguration();

        // Xây dựng Office Computer
        IComputerBuilder officeBuilder = new OfficeComputerBuilder();
        director.Construct(officeBuilder);
        Computer officePC = officeBuilder.GetComputer();
        Console.WriteLine("Office Computer:");
        officePC.ShowConfiguration();
    }
}