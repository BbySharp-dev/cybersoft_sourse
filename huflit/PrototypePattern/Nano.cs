public class Nano : BasicCar
{
    public Nano(string model)
    {
        ModelName = model;
    }

    // Clone() dùng phương thức MemberwiseClone() để sao chép đối tượng
    public override BasicCar Clone()
    {
        return (Nano)this.MemberwiseClone(); // Shallow Copy
    }
}