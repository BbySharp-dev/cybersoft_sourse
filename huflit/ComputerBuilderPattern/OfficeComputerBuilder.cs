public class OfficeComputerBuilder : IComputerBuilder
{
    private Computer _computer = new Computer();

    public void SetCPU()
    {
        _computer.CPU = "Intel i5";
    }

    public void SetRAM()
    {
        _computer.RAM = 16;
    }

    public void SetStorage()
    {
        _computer.Storage = 512;
    }

    public void SetGPU()
    {
        _computer.GPU = "None"; // Không có GPU
    }

    public Computer GetComputer()
    {
        return _computer;
    }
}