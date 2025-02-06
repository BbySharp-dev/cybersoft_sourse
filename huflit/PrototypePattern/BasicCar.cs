public abstract class BasicCar
{
    public string ModelName { get; set; } = "Unknown";  // Giá trị mặc định
    public int Price { get; set; }

    public static int SetPrice()
    {
        Random r = new Random();
        return r.Next(200000, 500000);
    }

    public abstract BasicCar Clone();
}