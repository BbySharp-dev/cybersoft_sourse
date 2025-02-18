public class GamingComputerBuilder : IComputerBuilder
{
    private Computer _computer = new Computer();

    public void SetCPU()
    {
        _computer.CPU = "Intel i9";
    }

    public void SetRAM()
    {
        _computer.RAM = 32;
    }

    public void SetStorage()
    {
        _computer.Storage = 1000; // 1TB = 1000GB
    }

    public void SetGPU()
    {
        _computer.GPU = "NVIDIA RTX 4090";
    }

    public Computer GetComputer()
    {
        return _computer;
    }
}