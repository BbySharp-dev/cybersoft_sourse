public class ComputerDirector
{
    public void Construct(IComputerBuilder builder)
    {
        builder.SetCPU();
        builder.SetRAM();
        builder.SetStorage();
        builder.SetGPU();
    }
}