public class Ford : BasicCar
{
    public Ford(string model)
    {
        ModelName = model;
    }

    public override BasicCar Clone()
    {
        return (Ford)this.MemberwiseClone();
    }
}